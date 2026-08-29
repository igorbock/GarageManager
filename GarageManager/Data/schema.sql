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
-- DROP TABLE IF EXISTS auditoria;
-- DROP TABLE IF EXISTS usuario;
-- DROP TABLE IF EXISTS pessoa_empresa;
-- DROP TABLE IF EXISTS ordem_servico_expressa_empresa;
-- DROP TABLE IF EXISTS ordem_servico_empresa;
-- DROP TABLE IF EXISTS servico_ordem_servico;
-- DROP TABLE IF EXISTS produto_ordem_servico;
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
    id          INTEGER PRIMARY KEY AUTOINCREMENT,
    id_marca    INTEGER NOT NULL,
    nome        TEXT NOT NULL,
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
    ano                 INTEGER CHECK(ano BETWEEN 1886 AND cast(strftime('%Y','now') AS INTEGER)),
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
    ano                 INTEGER CHECK(ano BETWEEN 1886 AND cast(strftime('%Y','now') AS INTEGER)),
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
-- 10. Vinculos multi-empresa (N:N)
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
-- 11. Usuario / Auditoria
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
    data_hora   TEXT NOT NULL DEFAULT (strftime('%Y-%m-%dT%H:%M:%fZ', 'now')),
    CONSTRAINT fk_auditoria_usuario FOREIGN KEY (id_usuario) REFERENCES usuario(id) ON DELETE RESTRICT
);

-- =============================================================================
-- 12. Dados iniciais
-- =============================================================================

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
