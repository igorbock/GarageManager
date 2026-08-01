create sequence marca_id_seq;

create table marca(
	id bigint not null default nextval('marca_id_seq') primary key,
	nome varchar(100) not null
	-- id_empresa bigint not null,
	-- constraint fk_marca_empresa
    --     foreign key (id_empresa)
    --     references empresa(id)
    --     on delete cascade
);

--drop table marca cascade;

--------------------------------------------------------------------------------
create sequence produto_id_seq;

create table produto (
	id bigint not null default nextval('produto_id_seq') primary key,
	id_marca bigint not null,
	nome varchar(100) not null,
	constraint fk_produto_marca
        foreign key (id_marca)
        references marca(id)
        on delete cascade
);

--drop table produto cascade;
--------------------------------------------------------------------------------

create sequence produto_ordem_servico_id_seq;

create table produto_ordem_servico (
	id bigint not null default nextval('produto_ordem_servico_id_seq') primary key,
	id_produto bigint not null,
	id_ordem_servico bigint not null,
	constraint fk_produto_ordem_servico_produto
        foreign key (id_produto)
        references produto(id)
        on delete cascade,
    constraint fk_produto_ordem_servico_ordem_servico
        foreign key (id_ordem_servico)
        references ordem_servico(id)
        on delete cascade
);

--drop table produto_ordem_servico cascade;
--------------------------------------------------------------------------------
create sequence servico_id_seq;

create table servico(
	id bigint not null default nextval('servico_id_seq') primary key,
	nome varchar(100),
	valor decimal(15, 4)
);

--drop table servico cascade;
--------------------------------------------------------------------------------

create sequence servico_ordem_servico_id_seq;

create table servico_ordem_servico(
	id bigint not null default nextval('servico_ordem_servico_id_seq') primary key,
	id_servico bigint not null,
	id_ordem_servico bigint not null,
	id_funcionario bigint not null,
	valor decimal(15, 4),
	constraint fk_servico_ordem_servico_servico
        foreign key (id_servico)
        references servico(id)
        on delete cascade,
    constraint fk_servico_ordem_servico_ordem_servico
        foreign key (id_ordem_servico)
        references ordem_servico(id)
        on delete cascade,
    constraint fk_servico_ordem_servico_funcionario
        foreign key (id_funcionario)
        references funcionario(id)
        on delete cascade
);

--drop table servico_ordem_servico cascade;
--------------------------------------------------------------------------------

create sequence modelo_veiculo_id_seq;

create table modelo_veiculo(
	id bigint not null default nextval('modelo_veiculo_id_seq') primary key,
	nome varchar(100) not null,
	id_marca bigint not null,
	-- id_empresa bigint not null,

	constraint fk_modelo_marca
        foreign key (id_marca)
        references marca(id)
        on delete cascade

	-- constraint fk_modelo_empresa
    --     foreign key (id_empresa)
    --     references empresa(id)
    --     on delete cascade
);

--drop table modelo_veiculo cascade;

--------------------------------------------------------------------------------

create sequence pessoa_id_seq;

create table pessoa (
    id bigint not null default nextval('pessoa_id_seq') primary key,
    nome varchar(150) not null,
    telefone varchar(30),
    email varchar(100),
    data_cadastro timestamp not null default CURRENT_TIMESTAMP,
    id_endereco bigint not null,
	constraint fk_funcionario_endereco
        foreign key (id_endereco)
        references endereco(id)
        on delete cascade
    -- id_empresa bigint not null,

    -- constraint fk_pessoa_empresa
    --     foreign key (id_empresa)
    --     references empresa(id)
    --     on delete cascade
);

--drop table pessoa cascade;

--------------------------------------------------------------------------------

create sequence pessoa_fisica_id_seq;

create table pessoa_fisica(
    id bigint not null default nextval('pessoa_fisica_id_seq') primary key,
    cpf varchar(11) not null unique,
    data_nascimento date not null,
	sexo varchar(30),
	estado_civil varchar(30),
	nacionalidade varchar(30),
	id_pessoa bigint,
    constraint fk_pessoa_fisica
        foreign key (id)
        references pessoa(id)
        on delete cascade,
    constraint fk_funcionario_pessoa
    	foreign key (id_pessoa)
    	references pessoa(id)
    	on delete cascade
);

--drop table pessoa_fisica cascade;

--------------------------------------------------------------------------------

create sequence pessoa_juridica_id_seq;

create table pessoa_juridica (
    id bigint not null default nextval('pessoa_juridica_id_seq') primary key,
    cnpj varchar(14) not null unique,
    inscricao_estadual varchar(20),
    nome_fantasia varchar(150),
    id_pessoa bigint,
    constraint fk_pessoa_juridica
        foreign key (id)
        references pessoa(id)
        on delete cascade,
    constraint fk_funcionario_pessoa
    	foreign key (id_pessoa)
    	references pessoa(id)
    	on delete cascade
);

--drop table pessoa_juridica cascade;

--------------------------------------------------------------------------------

create sequence funcionario_id_seq;

create table funcionario (
	id bigint not null default nextval('funcionario_id_seq') primary key,
	carga_horaria_semanal int not null,
	id_pessoa bigint,
	id_empresa bigint not null,
    constraint fk_funcionario_pessoa
    	foreign key (id_pessoa)
    	references pessoa(id)
    	on delete cascade,
	constraint fk_funcionario_empresa
    	foreign key (id_empresa)
    	references empresa(id)
    	on delete cascade
);

--drop table funcionario cascade;

--------------------------------------------------------------------------------

create sequence endereco_id_seq;

create table endereco (
	id bigint not null default nextval('endereco_id_seq') primary key,
	rua varchar(100) not null,
	numero int not null,
	cep varchar(8) not null,
	bairro varchar(50),
	id_cidade bigint not null,
	constraint fk_cidade_endereco
        foreign key (id_cidade)
        references cidade(id)
        on delete cascade
);

--drop table endereco cascade;

--------------------------------------------------------------------------------

create sequence cidade_id_seq;

create table cidade (
    id bigint not null default nextval('cidade_id_seq') primary key,
    nome varchar(150) not null,
    codigo_ibge integer not null,
    id_estado integer not null,

    constraint fk_cidade_estado
        foreign key (id_estado)
        references estado(id)
        on delete restrict,

    constraint uk_cidade_ibge unique (codigo_ibge),

    constraint uk_cidade_nome_estado unique (nome, id_estado)
);

--drop table cidade cascade;

--------------------------------------------------------------------------------

create table estado (
    id serial primary key,
    nome varchar(100) not null,
    sigla char(2) not null,
    codigo_ibge integer not null,
    constraint uk_estado_sigla unique (sigla),
    constraint uk_estado_ibge unique (codigo_ibge)
);

insert into estado (nome, sigla, codigo_ibge) values
('Acre', 'AC', 12),
('Alagoas', 'AL', 27),
('Amapá', 'AP', 16),
('Amazonas', 'AM', 13),
('Bahia', 'BA', 29),
('Ceará', 'CE', 23),
('Distrito Federal', 'DF', 53),
('Espírito Santo', 'ES', 32),
('Goiás', 'GO', 52),
('Maranhão', 'MA', 21),
('Mato Grosso', 'MT', 51),
('Mato Grosso do Sul', 'MS', 50),
('Minas Gerais', 'MG', 31),
('Pará', 'PA', 15),
('Paraíba', 'PB', 25),
('Paraná', 'PR', 41),
('Pernambuco', 'PE', 26),
('Piauí', 'PI', 22),
('Rio de Janeiro', 'RJ', 33),
('Rio Grande do Norte', 'RN', 24),
('Rio Grande do Sul', 'RS', 43),
('Rondônia', 'RO', 11),
('Roraima', 'RR', 14),
('Santa Catarina', 'SC', 42),
('São Paulo', 'SP', 35),
('Sergipe', 'SE', 28),
('Tocantins', 'TO', 17);

--drop table estado cascade;

--------------------------------------------------------------------------------

create sequence ordem_servico_id_seq;

create table ordem_servico(
	id bigint not null default nextval('ordem_servico_id_seq') primary key,
	data_inicio date not null,
	data_fim date,
	hora_inicio time not null,
	hora_fim time,
	placa varchar(7) not null,
	cor varchar(30),
	ano int check (ano between 1886 and extract(year from current_date)),
	kilometragem bigint check(kilometragem > 0) not null,
	descricao text,

	id_cliente bigint not null,
	id_modelo bigint not null,
	-- id_mecanico bigint not null,
	-- id_empresa bigint not null,
	id_ordem_expressa bigint,

	lavacao bool default false,

	constraint fk_ordem_servico_cliente
        foreign key (id_cliente)
        references pessoa(id)
        on delete cascade,

	constraint fk_ordem_servico_modelo
        foreign key (id_modelo)
        references modelo_veiculo(id)
        on delete cascade,

	--constraint fk_ordem_servico_mecanico
    --    foreign key (id_mecanico)
    --    references pessoa(id)
    --    on delete cascade,
        
    constraint fk_ordem_servico_expressa
        foreign key (id_ordem_expressa)
        references ordem_servico_expressa(id)
        on delete cascade

	-- constraint fk_ordem_servico_empresa
    --     foreign key (id_empresa)
    --     references empresa(id)
    --     on delete cascade
);

--drop table ordem_servico cascade;

--------------------------------------------------------------------------------

create sequence ordem_servico_expressa_id_seq;

create table ordem_servico_expressa (
	id bigint not null default nextval('ordem_servico_expressa_id_seq') primary key,
	data_inicio date not null,
	data_fim date not null,
	hora_inicio time not null,
	hora_fim time,
	placa varchar(7),
	kilometragem bigint,
	veiculo varchar(100),
	cor varchar(30),
	ano int,
	nome_cliente varchar(100),
	telefone varchar(100),
	descricao text
);

--drop table ordem_servico_expressa cascade;

--------------------------------------------------------------------------------

create sequence empresa_id_seq;
--drop sequence empresa_id_seq;

create table empresa (
    id bigint not null default nextval('empresa_id_seq') primary key,
    nome varchar(100) not null,
    razao_social varchar(100) not null,
    cnpj varchar(14) not null,
    guid_empresa uuid not null,
    endereco varchar(200),
    cidade varchar(30),
    uf varchar(2),
    id_empresa_matriz bigint,
    constraint fk_empresa_matriz
        foreign key (id_empresa_matriz)
        references empresa(id)
);

--drop table empresa cascade;

--------------------------------------------------------------------------------

create sequence ordem_servico_empresa_id_seq;

create table ordem_servico_empresa (
	id bigint not null default nextval('ordem_servico_empresa_id_seq') primary key,
	id_ordem_servico bigint not null,
	id_empresa bigint not null,
	constraint fk_ordem_servico_empresa_os
        foreign key (id_ordem_servico)
        references ordem_servico(id),
    constraint fk_ordem_servico_empresa_empresa
        foreign key (id_empresa)
        references empresa(id),
    constraint uq_ordem_servico_empresa
        unique (id_ordem_servico, id_empresa)
);

--drop table ordem_servico_empresa;

--------------------------------------------------------------------------------

create sequence ordem_servico_expressa_empresa_id_seq;

create table ordem_servico_expressa_empresa (
	id bigint not null default nextval('ordem_servico_expressa_empresa_id_seq') primary key,
	id_ordem_servico_expressa bigint not null,
	id_empresa bigint not null,
	constraint fk_ordem_servico_expressa_empresa_os
        foreign key (id_ordem_servico_expressa)
        references ordem_servico_expressa(id),
    constraint fk_ordem_servico_expressa_empresa_empresa
        foreign key (id_empresa)
        references empresa(id),
    constraint uq_ordem_servico_expressa_empresa
        unique (id_ordem_servico_expressa, id_empresa)
);

--drop table ordem_servico_expressa_empresa;

--------------------------------------------------------------------------------

create sequence pessoa_empresa_id_seq;
--drop sequence pessoa_empresa_id_seq;

create table pessoa_empresa (
	id bigint not null default nextval('pessoa_empresa_id_seq') primary key,
	id_pessoa bigint not null,
	id_empresa bigint not null,
	constraint fk_pessoa_empresa_pessoa
        foreign key (id_pessoa)
        references pessoa(id),
    constraint fk_pessoa_empresa_empresa
        foreign key (id_empresa)
        references empresa(id),
    constraint uq_pessoa_empresa
        unique (id_pessoa, id_empresa)
);

--drop table pessoa_empresa cascade;

--------------------------------------------------------------------------------

create sequence pessoa_fisica_empresa_id_seq;
--drop sequence pessoa_fisica_empresa_id_seq;

create table pessoa_fisica_empresa (
	id bigint not null default nextval('pessoa_fisica_empresa_id_seq') primary key,
	id_pessoa_fisica bigint not null,
	id_empresa bigint not null,
	constraint fk_pessoa_fisica_empresa_pessoa
        foreign key (id_pessoa_fisica)
        references pessoa_fisica(id),
    constraint fk_pessoa_fisica_empresa_empresa
        foreign key (id_empresa)
        references empresa(id),
    constraint uq_pessoa_fisica_empresa
        unique (id_pessoa_fisica, id_empresa)
);

--drop table pessoa_fisica_empresa cascade;

--------------------------------------------------------------------------------

create sequence pessoa_juridica_empresa_id_seq;
--drop sequence pessoa_juridica_empresa_id_seq;

create table pessoa_juridica_empresa (
	id bigint not null default nextval('pessoa_juridica_empresa_id_seq') primary key,
	id_pessoa_juridica bigint not null,
	id_empresa bigint not null,
	constraint fk_pessoa_juridica_empresa_pessoa
        foreign key (id_pessoa_juridica)
        references pessoa_juridica(id),
    constraint fk_pessoa_juridica_empresa_empresa
        foreign key (id_empresa)
        references empresa(id),
    constraint uq_pessoa_juridica_empresa
        unique (id_pessoa_juridica, id_empresa)
);

--drop table pessoa_juridica_empresa cascade;

--------------------------------------------------------------------------------

create sequence usuario_id_seq;
--drop sequence usuario_id_seq;

create table usuario (
	id bigint not null default nextval('usuario_id_seq') primary key,
	hash text not null,
	inativo boolean,
	id_colaborador bigint not null,
	constraint fk_usuario_colaborador
        foreign key (id_colaborador)
        references funcionario(id)
);

--drop table usuario cascade;

--------------------------------------------------------------------------------

create sequence auditoria_id_seq;
--drop sequence auditoria_id_seq;

create table auditoria (
	id bigint not null default nextval('auditoria_id_seq') primary key,
	metodo varchar(6) not null,
	tabela varchar(50) not null,
	id_registro bigint not null,
	antigo text,
	novo text,
	id_usuario bigint not null,
	constraint fk_auditoria_usuario
        foreign key (id_usuario)
        references usuario(id)
);

--drop table auditoria cascade;

--------------------------------------------------------------------------------

create sequence usuario_empresa_id_seq;
--drop sequence usuario_empresa_id_seq;

create table usuario_empresa (
	id bigint not null default nextval('usuario_empresa_id_seq') primary key,
	id_usuario bigint not null,
	id_empresa bigint not null,
	constraint fk_usuario_empresa_usuario
        foreign key (id_usuario)
        references usuario(id),
    constraint fk_usuario_empresa_empresa
        foreign key (id_empresa)
        references empresa(id),
    constraint uq_usuario_empresa
        unique (id_usuario, id_empresa)
);

--drop table usuario_empresa cascade;

--------------------------------------------------------------------------------
