create database Artzy

use artzy


create table art
(
	id_artista int not null identity primary key,
	nome_artista varchar(50) not null,
	user_artista varchar(10) not null unique ,
	senha_artista varchar(50) not null,
	login_artista varchar(10) not null,
	email_artista varchar (100) not null,
	prof_artista varchar (50) not null,
	nasc_artista date not null,
	data_artista smalldatetime not null default getdate(),
	cpf_artista char(14) not null,
	obs_artista varchar(200) null,
	status_artista varchar(20) not null default 'ATIVO' 
)

select * from art

create table cliente
(
	id_cliente int not null identity primary key,
	nome_cliente varchar(50) not null ,
	login_cliente varchar(10) not null ,
	senha_cliente varchar(50) not null ,
	user_cliente varchar(10) not null unique ,
	nasc_cliente date not null ,
	data_cliente smalldatetime not null default getdate(),
	telefone1_cliente varchar(16) not null ,
	telefone2_cliente varchar(16) null ,
	obs_cliente varchar(200) null ,
	status_cliente varchar(20) not null default 'ATIVO' 
)
select * from cliente


create table prod
(
	id_produto int not null identity primary key,
	nome_Produto varchar(30) not null ,
	data_Produto smalldatetime not null default getdate(),
	qtde_Produto int not null ,
	valor_Produto decimal(10,2) not null ,
	obs_Produto varchar(200) null ,
	status_Produto varchar(20) not null default 'ATIVO' 
)
select * from prod

create table assinart
(
	id_assinart  int  not null  identity  primary key,
	tipo_assinart  varchar(10)  not null  ,
	beneficio_assinart  varchar(200)  not null  ,
	valor_assinart  decimal(10,2)  not null  ,
	obs_assinart  varchar(200)  null  ,
	status_assinart  varchar(20)  not null  default 'ATIVO'  
)
select * from assinart

create table assicli
(
	id_assicli  int  not null  identity  primary key,
	tipo_assicli  varchar(10)  not null ,
	beneficio_assicli  varchar(200)  not null ,
	valor_assicli  decimal(10,2)  not null ,
	obs_assicli  varchar(200)  null ,
	status_assicli  varchar(20)  not null  default 'ATIVO'
)
select * from assicli

create table tipopgto
(
	id_pgto int not null identity primary key,
	tipo_pgto varchar(50) not null ,
	valor_pgto decimal(10,2) not null ,
	obs_pgto varchar(20) null ,  
	status_pgto varchar(200) not null default 'ATIVO' 
)
select * from tipopgto

create table venda
(
	id_venda int not null identity primary key,
	id_produto_venda int not null,
	id_artista_venda int not null,
	id_pgto_venda int not null,
	data_venda smalldatetime not null default getdate(),
	valor_venda	decimal(10,2) not null,
	qtde_venda int not null,
	obs_venda varchar(20) null,
	status_venda varchar(200)	not null	default 'ATIVO',

 constraint FK_id_produto_venda foreign key (id_produto_venda) references prod (id_produto),
 constraint FK_id_artista_venda foreign key (id_artista_venda) references art (id_artista),
 constraint FK_id_pgto_venda foreign key (id_pgto_venda) references tipopgto (id_pgto)
)

select * from venda

create table contcli
(
	id_contcli int not null identity primary key,
	id_assinatura_contcli int not null ,
	id_cliente_contcli int not null ,
	valor_contcli decimal(10,2) not null ,
	data_contcli smalldatetime not null default getdate(),
	tipo_contcli varchar(10) not null ,
	obs_contcli varchar(200) null ,
	status_contcli varchar(20) not null  default 'ATIVO',

constraint FK_id_assinatura_contcli foreign key (id_assinatura_contcli) references assicli (id_assicli),
constraint FK_id_cliente_contcli foreign key (id_cliente_contcli) references cliente (id_cliente)
)
select * from contcli

create table contart
(
	id_contart int not null identity primary key,
	id_assiantura_contart int not null  ,
	id_cliente_contart int not null  ,
	valor_contart decimal(10,2) not null  ,
	data_contart smalldatetime not null  default getdate(),
	tipo_contart varchar(10) not null  ,
	obs_contart varchar(200) null  ,
	status_contar varchar(20) not null default 'ATIVO', 
    
    constraint FK_id_assiantura_contart foreign key (id_assiantura_contart) references assinart (id_assinart),
    constraint FK_id_cliente_contart foreign key (id_cliente_contart) references cliente (id_cliente)
)
select * from contart