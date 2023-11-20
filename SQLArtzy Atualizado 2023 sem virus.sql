create database Artzy

use artzy

drop table art
select * from art

drop table anotacoes
select * from anotacoes

drop table tarefa
select * from tarefa

drop table assinart
drop table contart
drop table venda

create table anotacoes
(
    id_anotacao INT PRIMARY KEY IDENTITY(1,1),
    id_usuario_anotacao INT NOT NULL,
    titulo_anotacao NVARCHAR(255),
	bloco_anotacao NVARCHAR(MAX),

    constraint FK_id_usuario_anotacao foreign key (id_usuario_anotacao) references art (id_artista)
)


create table tarefa
(
   id_tarefa INT PRIMARY KEY IDENTITY,
    status_tarefa VARCHAR(50),
    id_usuario_tarefa INT,
    ordem_tarefa INT,
    nome_tarefa VARCHAR(255)
    CONSTRAINT FK_id_usuario_tarefa FOREIGN KEY (id_usuario_tarefa) REFERENCES art (id_artista)
)


create table art
(
	id_artista int not null identity primary key,
	nome_artista varchar(50) not null,
	sobrenome_artista varchar (50) not null,
	user_artista varchar(50) not null unique ,
	senha_artista varchar(20) not null,
	fotoP_artista varbinary (max) not null ,
	email_artista varchar (100) not null,
	prof_artista varchar (100) not null,
	data_artista smalldatetime not null default getdate(),
	status_artista varchar(20) not null default 'ATIVO' 
)


drop table cliente
create table cliente
(
	id_cliente int not null identity primary key,
	nome_cliente varchar(50) not null ,
	login_cliente varchar(10) not null ,
	senha_cliente varchar(50) not null ,
	user_cliente varchar(10) not null unique ,
	data_cliente smalldatetime not null default getdate(),
	status_cliente varchar(20) not null default 'ATIVO' 
)
select * from cliente

drop table assinart
create table assinart
(
	id_assinart  int  not null  identity  primary key,
	tipo_assinart  varchar(10)  not null  ,
	beneficio_assinart  varchar(200)  not null  ,
	valor_assinart  decimal(10,2)  not null  ,
	status_assinart  varchar(20)  not null  default 'ATIVO'  
)
select * from assinart

--create table assicli
--(
--	id_assicli  int  not null  identity  primary key,
--	tipo_assicli  varchar(10)  not null ,
--	beneficio_assicli  varchar(200)  not null ,
--	valor_assicli  decimal(10,2)  not null ,
--	obs_assicli  varchar(200)  null ,
--	status_assicli  varchar(20)  not null  default 'ATIVO'
--)
--select * from assicli

drop table tipopgto
create table tipopgto
(
	id_pgto int not null identity primary key,
	tipo_pgto varchar(50) not null ,
	valor_pgto decimal(10,2) not null ,
	status_pgto varchar(200) not null default 'ATIVO' 
)
select * from tipopgto


drop table venda
create table venda
(
	id_venda int not null identity primary key,
	id_contrato_venda int not null,
	id_artista_venda int not null,
	id_pgto_venda int not null,
	data_venda smalldatetime not null default getdate(),
	qtde_venda int not null,
	status_venda varchar(200)	not null	default 'ATIVO',

 constraint FK_id_contrato_venda foreign key (id_contrato_venda) references contart (id_contart),
 constraint FK_id_artista_venda foreign key (id_artista_venda) references art (id_artista),
 constraint FK_id_pgto_venda foreign key (id_pgto_venda) references tipopgto (id_pgto)
)

select * from venda

--drop table contcli
--create table contcli
--(
--	id_contcli int not null identity primary key,
--	id_assinatura_contcli int not null ,
--	id_cliente_contcli int not null ,
--	valor_contcli decimal(10,2) not null ,
--	data_contcli smalldatetime not null default getdate(),
--	tipo_contcli varchar(10) not null ,
--	obs_contcli varchar(200) null ,
--	status_contcli varchar(20) not null  default 'ATIVO',

--constraint FK_id_assinatura_contcli foreign key (id_assinatura_contcli) references assicli (id_assicli),
--constraint FK_id_cliente_contcli foreign key (id_cliente_contcli) references cliente (id_cliente)
--)
--select * from contcli

drop table contart
create table contart
(
	id_contart int not null identity primary key,
	id_assiantura_contart int not null  ,
	id_cliente_contart int not null  ,
	valor_contart decimal(10,2) not null  ,
	data_contart smalldatetime not null  default getdate(),
	tipo_contart varchar(10) not null  ,
	status_contar varchar(20) not null default 'ATIVO', 
    
    constraint FK_id_assiantura_contart foreign key (id_assiantura_contart) references assinart (id_assinart),
    constraint FK_id_cliente_contart foreign key (id_cliente_contart) references art (id_artista)
)
select * from contart