-- =============================================================================
-- GarageManager - Schema SQLite
-- Convertido de sqlGM.sql (Postgres) para SQLite
-- =============================================================================
-- SQLite NÃO possui SEQUENCE / GENERATOR (CREATE SEQUENCE).
-- Ele usa INTEGER PRIMARY KEY AUTOINCREMENT que internamente controla
-- a tabela sqlite_sequence. Não use nextval(), use AUTOINCREMENT.
-- Para GUID/UUID, use TEXT com gen_random_uuid() na app (C# Guid.NewGuid()).
-- Habilite FKs: PRAGMA foreign_keys = ON;
-- =============================================================================

PRAGMA foreign_keys = ON;
PRAGMA journal_mode = WAL;

-- Para recriação limpa (descomente se necessário, na ordem reversa por FK)
-- PRAGMA foreign_keys = OFF;
-- DROP VIEW IF EXISTS vw_estoque_critico;
-- DROP VIEW IF EXISTS vw_estoque_zerado;
-- DROP VIEW IF EXISTS vw_estoque_atual;
-- DROP VIEW IF EXISTS vw_kardex;
-- DROP TABLE IF EXISTS auditoria;
-- DROP TABLE IF EXISTS usuario;
-- DROP TABLE IF EXISTS pessoa_empresa;
-- DROP TABLE IF EXISTS ordem_servico_expressa_empresa;
-- DROP TABLE IF EXISTS ordem_servico_empresa;
-- DROP TABLE IF EXISTS servico_ordem_servico;
-- DROP TABLE IF EXISTS produto_ordem_servico;
-- DROP TABLE IF EXISTS movimento_estoque;
-- DROP TABLE IF EXISTS compra_item;
-- DROP TABLE IF EXISTS compra;
-- DROP TABLE IF EXISTS ordem_servico;
-- DROP TABLE IF EXISTS ordem_servico_expressa;
-- DROP TABLE IF EXISTS servico;
-- DROP TABLE IF EXISTS produto;
-- DROP TABLE IF EXISTS modelo_veiculo;
-- DROP TABLE IF EXISTS marca;
-- DROP TABLE IF EXISTS funcionario;
-- DROP TABLE IF EXISTS pessoa;
-- DROP TABLE IF EXISTS endereco;
-- DROP TABLE IF EXISTS cidade;
-- DROP TABLE IF EXISTS estado;
-- DROP TABLE IF EXISTS empresa;
-- PRAGMA foreign_keys = ON;

-- =============================================================================
-- 1. Estado / Cidade / Endereco (base geográfica)
-- =============================================================================

CREATE TABLE IF NOT EXISTS estado (
    id          INTEGER PRIMARY KEY AUTOINCREMENT,
    nome        TEXT NOT NULL,
    sigla       TEXT NOT NULL CHECK(length(sigla) = 2),
    codigo_ibge INTEGER NOT NULL,
    CONSTRAINT uk_estado_sigla UNIQUE (sigla),
    CONSTRAINT uk_estado_ibge  UNIQUE (codigo_ibge)
);

CREATE TABLE IF NOT EXISTS cidade (
    id          INTEGER PRIMARY KEY AUTOINCREMENT,
    nome        TEXT NOT NULL,
    codigo_ibge INTEGER NOT NULL,
    id_estado   INTEGER NOT NULL,
    CONSTRAINT fk_cidade_estado FOREIGN KEY (id_estado) REFERENCES estado(id) ON DELETE RESTRICT,
    CONSTRAINT uk_cidade_ibge        UNIQUE (codigo_ibge),
    CONSTRAINT uk_cidade_nome_estado UNIQUE (nome, id_estado)
);

CREATE TABLE IF NOT EXISTS endereco (
    id          INTEGER PRIMARY KEY AUTOINCREMENT,
    rua         TEXT NOT NULL,
    numero      INTEGER NOT NULL,
    cep         TEXT NOT NULL CHECK(length(cep) = 8),
    bairro      TEXT,
    id_cidade   INTEGER NOT NULL,
    CONSTRAINT fk_endereco_cidade FOREIGN KEY (id_cidade) REFERENCES cidade(id) ON DELETE CASCADE
);

-- =============================================================================
-- 2. Empresa (multi-empresa / matriz-filial)
-- =============================================================================

CREATE TABLE IF NOT EXISTS empresa (
    id                  INTEGER PRIMARY KEY AUTOINCREMENT,
    nome                TEXT NOT NULL,
    razao_social        TEXT NOT NULL,
    cnpj                TEXT NOT NULL CHECK(length(cnpj) = 14),
    guid_empresa        TEXT NOT NULL, -- UUID em TEXT (Guid.NewGuid().ToString())
    endereco            TEXT,
    cidade              TEXT,
    uf                  TEXT CHECK(length(uf) = 2),
    id_empresa_matriz   INTEGER,
    CONSTRAINT fk_empresa_matriz FOREIGN KEY (id_empresa_matriz) REFERENCES empresa(id) ON DELETE SET NULL,
    CONSTRAINT uk_empresa_cnpj UNIQUE (cnpj),
    CONSTRAINT uk_empresa_guid UNIQUE (guid_empresa)
);

-- =============================================================================
-- 3. Pessoa (unificada: CPF ou CNPJ, sem TPT pessoa_fisica/juridica)
-- CORRECAO: id_endereco era NOT NULL + CASCADE (apagar endereco apagava pessoa).
-- Agora é NULL + SET NULL. Adicionado documento unico com tipo.
-- =============================================================================

CREATE TABLE IF NOT EXISTS pessoa (
    id              INTEGER PRIMARY KEY AUTOINCREMENT,
    nome            TEXT NOT NULL,
    telefone        TEXT,
    email           TEXT,
    documento       TEXT, -- CPF (11) ou CNPJ (14) - sem mascara
    tipo_documento  TEXT CHECK(tipo_documento IN ('CPF', 'CNPJ')),
    data_cadastro   TEXT NOT NULL DEFAULT (strftime('%Y-%m-%dT%H:%M:%fZ', 'now')),
    id_endereco     INTEGER, -- NULL para cliente avulso sem endereco completo
    CONSTRAINT fk_pessoa_endereco FOREIGN KEY (id_endereco) REFERENCES endereco(id) ON DELETE SET NULL,
    CONSTRAINT uk_pessoa_documento UNIQUE (documento),
    CONSTRAINT ck_pessoa_documento CHECK(
        documento IS NULL OR
        (tipo_documento = 'CPF'  AND length(documento) = 11) OR
        (tipo_documento = 'CNPJ' AND length(documento) = 14)
    )
);

-- =============================================================================
-- 4. Funcionario (vincula pessoa + empresa)
-- CORRECAO: id_pessoa era nullable. Agora NOT NULL implícito lógico, FK com RESTRICT.
-- =============================================================================

CREATE TABLE IF NOT EXISTS funcionario (
    id                      INTEGER PRIMARY KEY AUTOINCREMENT,
    carga_horaria_semanal   INTEGER NOT NULL CHECK(carga_horaria_semanal > 0),
    id_pessoa               INTEGER NOT NULL,
    id_empresa              INTEGER NOT NULL,
    CONSTRAINT fk_funcionario_pessoa  FOREIGN KEY (id_pessoa)  REFERENCES pessoa(id)  ON DELETE CASCADE,
    CONSTRAINT fk_funcionario_empresa FOREIGN KEY (id_empresa) REFERENCES empresa(id) ON DELETE CASCADE,
    CONSTRAINT uk_funcionario_pessoa UNIQUE (id_pessoa)
);

-- =============================================================================
-- 5. Marca / ModeloVeiculo / Produto (peca)
-- CORRECAO: marca agora com id_empresa para multi-empresa (era comentado).
-- =============================================================================

CREATE TABLE IF NOT EXISTS marca (
    id          INTEGER PRIMARY KEY AUTOINCREMENT,
    nome        TEXT NOT NULL,
    id_empresa  INTEGER NOT NULL,
    CONSTRAINT fk_marca_empresa FOREIGN KEY (id_empresa) REFERENCES empresa(id) ON DELETE CASCADE,
    CONSTRAINT uk_marca_nome_empresa UNIQUE (nome, id_empresa)
);

CREATE TABLE IF NOT EXISTS modelo_veiculo (
    id          INTEGER PRIMARY KEY AUTOINCREMENT,
    nome        TEXT NOT NULL,
    id_marca    INTEGER NOT NULL,
    CONSTRAINT fk_modelo_marca FOREIGN KEY (id_marca) REFERENCES marca(id) ON DELETE CASCADE,
    CONSTRAINT uk_modelo_nome_marca UNIQUE (nome, id_marca)
);

CREATE TABLE IF NOT EXISTS produto (
    id              INTEGER PRIMARY KEY AUTOINCREMENT,
    id_marca        INTEGER NOT NULL,
    nome            TEXT NOT NULL,
    preco_venda     NUMERIC NOT NULL DEFAULT 0 CHECK(preco_venda >= 0),
    estoque_minimo  INTEGER NOT NULL DEFAULT 5 CHECK(estoque_minimo >= 0),
    CONSTRAINT fk_produto_marca FOREIGN KEY (id_marca) REFERENCES marca(id) ON DELETE CASCADE,
    CONSTRAINT uk_produto_nome_marca UNIQUE (nome, id_marca)
);

-- =============================================================================
-- 6. Servico (catalogo de servicos da oficina)
-- =============================================================================

CREATE TABLE IF NOT EXISTS servico (
    id      INTEGER PRIMARY KEY AUTOINCREMENT,
    nome    TEXT,
    valor   NUMERIC NOT NULL DEFAULT 0 CHECK(valor >= 0)
);

-- =============================================================================
-- 7. Ordem de Servico Expressa (fluxo rapido, campos soltos - mantida)
-- =============================================================================

CREATE TABLE IF NOT EXISTS ordem_servico_expressa (
    id                  INTEGER PRIMARY KEY AUTOINCREMENT,
    data_inicio         TEXT NOT NULL, -- ISO8601 DATE
    data_fim            TEXT NOT NULL,
    hora_inicio         TEXT NOT NULL, -- HH:MM
    hora_fim            TEXT,
    placa               TEXT CHECK(length(placa) = 7),
    kilometragem        INTEGER CHECK(kilometragem > 0),
    veiculo             TEXT,
    cor                 TEXT,
    ano                 INTEGER CHECK(ano BETWEEN 1886 AND 2100),
    nome_cliente        TEXT,
    telefone            TEXT,
    descricao           TEXT,
    valor_total         NUMERIC CHECK(valor_total >= 0),
    mecanico            TEXT,
    servico_realizado   TEXT
);

-- =============================================================================
-- 8. Ordem de Servico (principal - normalizada)
-- CORRECOES:
-- - id_cliente -> pessoa(id) NOT NULL
-- - id_modelo  -> modelo_veiculo(id) NOT NULL
-- - Adicionado id_funcionario (mecanico responsavel) -> funcionario(id) NULL
-- - id_ordem_expressa com ON DELETE SET NULL (nao CASCADE, para nao apagar OS)
-- - kilometragem NOT NULL mantido, ano com check compativel SQLite
-- - id_empresa removido daqui: use tabela N:N ordem_servico_empresa
-- =============================================================================

CREATE TABLE IF NOT EXISTS ordem_servico (
    id                  INTEGER PRIMARY KEY AUTOINCREMENT,
    data_inicio         TEXT NOT NULL, -- DATE ISO8601
    data_fim            TEXT,
    hora_inicio         TEXT NOT NULL, -- TIME HH:MM
    hora_fim            TEXT,
    placa               TEXT NOT NULL CHECK(length(placa) = 7),
    cor                 TEXT,
    ano                 INTEGER CHECK(ano BETWEEN 1886 AND 2100),
    kilometragem        INTEGER NOT NULL CHECK(kilometragem > 0),
    descricao           TEXT,
    lavacao             INTEGER NOT NULL DEFAULT 0 CHECK(lavacao IN (0,1)),
    id_cliente          INTEGER NOT NULL,
    id_modelo           INTEGER NOT NULL,
    id_funcionario      INTEGER, -- mecanico responsavel (NULL = nao atribuido)
    id_ordem_expressa   INTEGER,
    CONSTRAINT fk_ordem_servico_cliente     FOREIGN KEY (id_cliente)        REFERENCES pessoa(id)          ON DELETE RESTRICT,
    CONSTRAINT fk_ordem_servico_modelo      FOREIGN KEY (id_modelo)         REFERENCES modelo_veiculo(id)  ON DELETE RESTRICT,
    CONSTRAINT fk_ordem_servico_funcionario FOREIGN KEY (id_funcionario)    REFERENCES funcionario(id)     ON DELETE SET NULL,
    CONSTRAINT fk_ordem_servico_expressa    FOREIGN KEY (id_ordem_expressa) REFERENCES ordem_servico_expressa(id) ON DELETE SET NULL
);

CREATE INDEX IF NOT EXISTS idx_ordem_servico_placa         ON ordem_servico(placa);
CREATE INDEX IF NOT EXISTS idx_ordem_servico_id_cliente    ON ordem_servico(id_cliente);
CREATE INDEX IF NOT EXISTS idx_ordem_servico_id_modelo     ON ordem_servico(id_modelo);

-- =============================================================================
-- 9. Tabelas N:N
-- =============================================================================

CREATE TABLE IF NOT EXISTS produto_ordem_servico (
    id                  INTEGER PRIMARY KEY AUTOINCREMENT,
    id_produto          INTEGER NOT NULL,
    id_ordem_servico    INTEGER NOT NULL,
    quantidade          INTEGER NOT NULL DEFAULT 1 CHECK(quantidade > 0),
    valor_unitario      NUMERIC,
    CONSTRAINT fk_prod_os_produto FOREIGN KEY (id_produto)       REFERENCES produto(id)       ON DELETE CASCADE,
    CONSTRAINT fk_prod_os_os       FOREIGN KEY (id_ordem_servico) REFERENCES ordem_servico(id) ON DELETE CASCADE,
    CONSTRAINT uk_prod_os UNIQUE (id_produto, id_ordem_servico)
);

CREATE TABLE IF NOT EXISTS servico_ordem_servico (
    id                  INTEGER PRIMARY KEY AUTOINCREMENT,
    id_servico          INTEGER NOT NULL,
    id_ordem_servico    INTEGER NOT NULL,
    id_funcionario      INTEGER NOT NULL,
    valor               NUMERIC CHECK(valor >= 0),
    CONSTRAINT fk_serv_os_servico     FOREIGN KEY (id_servico)       REFERENCES servico(id)       ON DELETE CASCADE,
    CONSTRAINT fk_serv_os_os          FOREIGN KEY (id_ordem_servico) REFERENCES ordem_servico(id) ON DELETE CASCADE,
    CONSTRAINT fk_serv_os_funcionario FOREIGN KEY (id_funcionario)   REFERENCES funcionario(id)   ON DELETE CASCADE
);

-- =============================================================================
-- 10. Estoque: Compra (entrada) + Movimento unificado + Triggers + Views
-- =============================================================================

CREATE TABLE IF NOT EXISTS compra (
    id              INTEGER PRIMARY KEY AUTOINCREMENT,
    data            TEXT NOT NULL DEFAULT (strftime('%Y-%m-%dT%H:%M:%fZ', 'now')),
    id_fornecedor   INTEGER, -- pessoa (CNPJ), NULL = avulso
    id_empresa      INTEGER NOT NULL,
    total           NUMERIC NOT NULL DEFAULT 0 CHECK(total >= 0),
    status          TEXT NOT NULL DEFAULT 'ABERTA' CHECK(status IN ('ABERTA','FECHADA','CANCELADA')),
    observacao      TEXT,
    CONSTRAINT fk_compra_fornecedor FOREIGN KEY (id_fornecedor) REFERENCES pessoa(id) ON DELETE SET NULL,
    CONSTRAINT fk_compra_empresa    FOREIGN KEY (id_empresa)    REFERENCES empresa(id) ON DELETE CASCADE
);
CREATE INDEX IF NOT EXISTS idx_compra_empresa ON compra(id_empresa);
CREATE INDEX IF NOT EXISTS idx_compra_fornecedor ON compra(id_fornecedor);

CREATE TABLE IF NOT EXISTS compra_item (
    id              INTEGER PRIMARY KEY AUTOINCREMENT,
    id_compra       INTEGER NOT NULL,
    id_produto      INTEGER NOT NULL,
    quantidade      INTEGER NOT NULL CHECK(quantidade > 0),
    custo_unitario  NUMERIC NOT NULL CHECK(custo_unitario >= 0),
    CONSTRAINT fk_compra_item_compra  FOREIGN KEY (id_compra)  REFERENCES compra(id)  ON DELETE CASCADE,
    CONSTRAINT fk_compra_item_produto FOREIGN KEY (id_produto) REFERENCES produto(id) ON DELETE RESTRICT,
    CONSTRAINT uk_compra_item UNIQUE (id_compra, id_produto)
);
CREATE INDEX IF NOT EXISTS idx_compra_item_compra  ON compra_item(id_compra);
CREATE INDEX IF NOT EXISTS idx_compra_item_produto ON compra_item(id_produto);

-- Kardex unificado: unica fonte para saldo. ENTRADA via compra FECHADA, SAIDA via produto_ordem_servico
CREATE TABLE IF NOT EXISTS movimento_estoque (
    id              INTEGER PRIMARY KEY AUTOINCREMENT,
    data            TEXT NOT NULL DEFAULT (strftime('%Y-%m-%dT%H:%M:%fZ', 'now')),
    id_produto      INTEGER NOT NULL,
    id_empresa      INTEGER NOT NULL,
    tipo            TEXT NOT NULL CHECK(tipo IN ('ENTRADA','SAIDA')),
    quantidade      INTEGER NOT NULL CHECK(quantidade > 0),
    custo_unitario  NUMERIC, -- copia de compra_item.custo_unitario em ENTRADA; NULL em SAIDA
    origem          TEXT NOT NULL CHECK(origem IN ('COMPRA','ORDEM_SERVICO','AJUSTE')),
    id_origem       INTEGER, -- id_compra ou id_ordem_servico (produto_ordem_servico.id)
    observacao      TEXT,
    CONSTRAINT fk_mov_produto FOREIGN KEY (id_produto) REFERENCES produto(id) ON DELETE RESTRICT,
    CONSTRAINT fk_mov_empresa FOREIGN KEY (id_empresa) REFERENCES empresa(id) ON DELETE CASCADE
);
CREATE INDEX IF NOT EXISTS idx_mov_prod_emp ON movimento_estoque(id_produto, id_empresa);
CREATE INDEX IF NOT EXISTS idx_mov_origem   ON movimento_estoque(origem, id_origem);
CREATE INDEX IF NOT EXISTS idx_mov_data     ON movimento_estoque(data);

-- Bloqueia estoque negativo (decisao 3)
CREATE TRIGGER IF NOT EXISTS trg_mov_bloqueia_negativo
BEFORE INSERT ON movimento_estoque
WHEN NEW.tipo = 'SAIDA'
BEGIN
    SELECT CASE
        WHEN (
            SELECT COALESCE(SUM(CASE WHEN tipo='ENTRADA' THEN quantidade ELSE -quantidade END), 0)
            FROM movimento_estoque
            WHERE id_produto = NEW.id_produto AND id_empresa = NEW.id_empresa
        ) < NEW.quantidade
        THEN RAISE(ABORT, 'Estoque insuficiente para baixa')
    END;
END;

-- Entrada: ao inserir item de compra ja FECHADA, gera movimento ENTRADA
CREATE TRIGGER IF NOT EXISTS trg_compra_item_entrada
AFTER INSERT ON compra_item
WHEN (SELECT status FROM compra WHERE id = NEW.id_compra) = 'FECHADA'
BEGIN
    INSERT INTO movimento_estoque(id_produto, id_empresa, tipo, quantidade, custo_unitario, origem, id_origem)
    SELECT NEW.id_produto, c.id_empresa, 'ENTRADA', NEW.quantidade, NEW.custo_unitario, 'COMPRA', NEW.id_compra
    FROM compra c WHERE c.id = NEW.id_compra;
END;

-- Entrada: ao fechar compra (ABERTA -> FECHADA), gera movimentos para todos os itens
CREATE TRIGGER IF NOT EXISTS trg_compra_fecha_entrada
AFTER UPDATE OF status ON compra
WHEN NEW.status = 'FECHADA' AND OLD.status != 'FECHADA'
BEGIN
    INSERT INTO movimento_estoque(id_produto, id_empresa, tipo, quantidade, custo_unitario, origem, id_origem)
    SELECT ci.id_produto, NEW.id_empresa, 'ENTRADA', ci.quantidade, ci.custo_unitario, 'COMPRA', NEW.id
    FROM compra_item ci WHERE ci.id_compra = NEW.id;
END;

-- Saida: consumo em O.S. (unico caso de saida, sem venda avulsa)
CREATE TRIGGER IF NOT EXISTS trg_prod_os_saida
AFTER INSERT ON produto_ordem_servico
BEGIN
    INSERT INTO movimento_estoque(id_produto, id_empresa, tipo, quantidade, origem, id_origem)
    SELECT NEW.id_produto,
           COALESCE((SELECT id_empresa FROM ordem_servico_empresa WHERE id_ordem_servico = NEW.id_ordem_servico ORDER BY id_empresa LIMIT 1),
                    (SELECT id FROM empresa ORDER BY id LIMIT 1)),
           'SAIDA', NEW.quantidade, 'ORDEM_SERVICO', NEW.id;
END;

-- Estorno: ao cancelar compra FECHADA, gera SAIDA de estorno (se tinha gerado ENTRADA)
CREATE TRIGGER IF NOT EXISTS trg_compra_cancela_estorno
AFTER UPDATE OF status ON compra
WHEN NEW.status = 'CANCELADA' AND OLD.status = 'FECHADA'
BEGIN
    INSERT INTO movimento_estoque(id_produto, id_empresa, tipo, quantidade, origem, id_origem, observacao)
    SELECT ci.id_produto, NEW.id_empresa, 'SAIDA', ci.quantidade, 'AJUSTE', NEW.id, 'Estorno compra cancelada #' || NEW.id
    FROM compra_item ci WHERE ci.id_compra = NEW.id;
END;

-- Views de consulta
CREATE VIEW IF NOT EXISTS vw_kardex AS
SELECT me.id, me.data, me.tipo, me.quantidade, me.custo_unitario, me.origem, me.id_origem, me.observacao,
       p.nome AS produto, m.nome AS marca, e.nome AS empresa, me.id_produto, me.id_empresa
FROM movimento_estoque me
JOIN produto p ON p.id = me.id_produto
JOIN marca m ON m.id = p.id_marca
JOIN empresa e ON e.id = me.id_empresa
ORDER BY me.data DESC, me.id DESC;

CREATE VIEW IF NOT EXISTS vw_estoque_atual AS
SELECT p.id AS id_produto, p.nome AS produto, m.nome AS marca,
       p.preco_venda, p.estoque_minimo,
       e.id AS id_empresa, e.nome AS empresa,
       COALESCE(SUM(CASE WHEN me.tipo='ENTRADA' THEN me.quantidade ELSE -me.quantidade END), 0) AS saldo
FROM produto p
JOIN marca m ON m.id = p.id_marca
CROSS JOIN empresa e
LEFT JOIN movimento_estoque me ON me.id_produto = p.id AND me.id_empresa = e.id
GROUP BY p.id, e.id;

CREATE VIEW IF NOT EXISTS vw_estoque_critico AS
SELECT * FROM vw_estoque_atual WHERE saldo <= estoque_minimo;

CREATE VIEW IF NOT EXISTS vw_estoque_zerado AS
SELECT * FROM vw_estoque_atual WHERE saldo = 0;

-- =============================================================================
-- 11. Vinculos multi-empresa (N:N)
-- =============================================================================

CREATE TABLE IF NOT EXISTS ordem_servico_empresa (
    id                  INTEGER PRIMARY KEY AUTOINCREMENT,
    id_ordem_servico    INTEGER NOT NULL,
    id_empresa          INTEGER NOT NULL,
    CONSTRAINT fk_ose_os      FOREIGN KEY (id_ordem_servico) REFERENCES ordem_servico(id) ON DELETE CASCADE,
    CONSTRAINT fk_ose_empresa FOREIGN KEY (id_empresa)       REFERENCES empresa(id)       ON DELETE CASCADE,
    CONSTRAINT uq_ose UNIQUE (id_ordem_servico, id_empresa)
);

CREATE TABLE IF NOT EXISTS ordem_servico_expressa_empresa (
    id                          INTEGER PRIMARY KEY AUTOINCREMENT,
    id_ordem_servico_expressa   INTEGER NOT NULL,
    id_empresa                  INTEGER NOT NULL,
    CONSTRAINT fk_osee_os      FOREIGN KEY (id_ordem_servico_expressa) REFERENCES ordem_servico_expressa(id) ON DELETE CASCADE,
    CONSTRAINT fk_osee_empresa FOREIGN KEY (id_empresa)                REFERENCES empresa(id)                ON DELETE CASCADE,
    CONSTRAINT uq_osee UNIQUE (id_ordem_servico_expressa, id_empresa)
);

CREATE TABLE IF NOT EXISTS pessoa_empresa (
    id          INTEGER PRIMARY KEY AUTOINCREMENT,
    id_pessoa   INTEGER NOT NULL,
    id_empresa  INTEGER NOT NULL,
    CONSTRAINT fk_pe_pessoa  FOREIGN KEY (id_pessoa)  REFERENCES pessoa(id)  ON DELETE CASCADE,
    CONSTRAINT fk_pe_empresa FOREIGN KEY (id_empresa) REFERENCES empresa(id) ON DELETE CASCADE,
    CONSTRAINT uq_pe UNIQUE (id_pessoa, id_empresa)
);

-- =============================================================================
-- 12. Usuario / Auditoria
-- =============================================================================

CREATE TABLE IF NOT EXISTS usuario (
    id              INTEGER PRIMARY KEY AUTOINCREMENT,
    hash            TEXT NOT NULL,
    inativo         INTEGER DEFAULT 0 CHECK(inativo IN (0,1)),
    id_colaborador  INTEGER NOT NULL,
    CONSTRAINT fk_usuario_colaborador FOREIGN KEY (id_colaborador) REFERENCES funcionario(id) ON DELETE RESTRICT
);

CREATE TABLE IF NOT EXISTS auditoria (
    id          INTEGER PRIMARY KEY AUTOINCREMENT,
    metodo      TEXT NOT NULL CHECK(metodo IN ('INSERT','UPDATE','DELETE')),
    tabela      TEXT NOT NULL,
    id_registro INTEGER NOT NULL,
    antigo      TEXT,
    novo        TEXT,
    id_usuario  INTEGER NOT NULL,
    id_empresa  INTEGER,
    data_hora   TEXT NOT NULL DEFAULT (strftime('%Y-%m-%dT%H:%M:%fZ', 'now')),
    CONSTRAINT fk_auditoria_usuario FOREIGN KEY (id_usuario) REFERENCES usuario(id) ON DELETE RESTRICT,
    CONSTRAINT fk_auditoria_empresa FOREIGN KEY (id_empresa) REFERENCES empresa(id) ON DELETE SET NULL
);
CREATE INDEX IF NOT EXISTS idx_auditoria_tabela_registro ON auditoria(tabela, id_registro);
CREATE INDEX IF NOT EXISTS idx_auditoria_empresa_data ON auditoria(id_empresa, data_hora DESC);
CREATE INDEX IF NOT EXISTS idx_auditoria_usuario ON auditoria(id_usuario);

CREATE VIEW IF NOT EXISTS vw_auditoria_detalhada AS
SELECT a.id, a.metodo, a.tabela, a.id_registro, a.antigo, a.novo, a.id_usuario, a.id_empresa, a.data_hora,
       p.nome AS usuario_nome, e.nome AS empresa_nome, f.id AS id_funcionario
FROM auditoria a
JOIN usuario u ON u.id = a.id_usuario
JOIN funcionario f ON f.id = u.id_colaborador
JOIN pessoa p ON p.id = f.id_pessoa
LEFT JOIN empresa e ON e.id = a.id_empresa;

-- =============================================================================
-- 13. Dados iniciais
-- =============================================================================

-- Seed mínimo para auditoria sem login (Sessao fallback id=1) + usuário ADM (senha 12345)
INSERT OR IGNORE INTO empresa(id, nome, razao_social, cnpj, guid_empresa) VALUES (1, 'Matriz', 'Matriz LTDA', '00000000000191', lower(hex(randomblob(16))));
INSERT OR IGNORE INTO pessoa(id, nome) VALUES (1, 'Admin');
INSERT OR IGNORE INTO pessoa(id, nome) VALUES (2, 'ADM');
INSERT OR IGNORE INTO funcionario(id, id_pessoa, id_empresa, carga_horaria_semanal) VALUES (1, 1, 1, 44);
INSERT OR IGNORE INTO funcionario(id, id_pessoa, id_empresa, carga_horaria_semanal) VALUES (2, 2, 1, 44);
INSERT OR IGNORE INTO usuario(id, hash, id_colaborador) VALUES (1, 'seed', 1);
INSERT OR IGNORE INTO usuario(id, hash, id_colaborador) VALUES (2, '$2a$11$dj0II0wGaiSSyPGJVczPr.iBRbA7CuQ4fBRsrTBg9n3jGiCKCvgae', 2);

INSERT OR IGNORE INTO estado (id, nome, sigla, codigo_ibge) VALUES
(1, 'Acre', 'AC', 12),
(2, 'Alagoas', 'AL', 27),
(3, 'Amapá', 'AP', 16),
(4, 'Amazonas', 'AM', 13),
(5, 'Bahia', 'BA', 29),
(6, 'Ceará', 'CE', 23),
(7, 'Distrito Federal', 'DF', 53),
(8, 'Espírito Santo', 'ES', 32),
(9, 'Goiás', 'GO', 52),
(10, 'Maranhão', 'MA', 21),
(11, 'Mato Grosso', 'MT', 51),
(12, 'Mato Grosso do Sul', 'MS', 50),
(13, 'Minas Gerais', 'MG', 31),
(14, 'Pará', 'PA', 15),
(15, 'Paraíba', 'PB', 25),
(16, 'Paraná', 'PR', 41),
(17, 'Pernambuco', 'PE', 26),
(18, 'Piauí', 'PI', 22),
(19, 'Rio de Janeiro', 'RJ', 33),
(20, 'Rio Grande do Norte', 'RN', 24),
(21, 'Rio Grande do Sul', 'RS', 43),
(22, 'Rondônia', 'RO', 11),
(23, 'Roraima', 'RR', 14),
(24, 'Santa Catarina', 'SC', 42),
(25, 'São Paulo', 'SP', 35),
(26, 'Sergipe', 'SE', 28),
(27, 'Tocantins', 'TO', 17);
