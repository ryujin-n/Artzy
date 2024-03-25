create database Artzy

use artzy


create table usuario
(
	id_usuario int not null auto_increment primary key,
	nome_usuario varchar(50) not null,
	login_usuario varchar(50) null unique ,
	senha_usuario varchar(20) not null,
	fotoP_usuario varchar(200) null default 'fotopadrao.png',
	banner_usuario varchar(200) null default 'bannerpadrao.png',
	premium_usuario varchar(200) null default 'OFF',
	email_usuario varchar (100) not null unique,
	area_usuario varchar (100) not null,
	data_usuario timestamp not null,
	status_usuario varchar(20) not null default 'ATIVO'
)
select * from usuario
drop table usuario

drop table assinatura

create table assinatura
(
	id_assinatura  int  not null  auto_increment  primary key,
	tipo_assinatura  varchar(10)  not null  ,
	beneficio_assinatura  varchar(200)  not null  ,
	valor_assinatura  decimal(10,2)  not null  ,
	status_assinatura  varchar(20)  not null  default 'ATIVO'  
)
select * from assinatura

drop table tipopgto

create table tipopgto
(
	id_pgto int not null auto_increment primary key,
	tipo_pgto varchar(50) not null ,
	valor_pgto decimal(10,2) not null ,
	status_pgto varchar(200) not null default 'ATIVO' 
)
select * from tipopgto


drop table venda
create table venda
(
	id_venda int not null auto_increment primary key,
	id_contrato_venda int not null,
	id_pgto_venda int not null,
	id_produto_venda int not null,
    id_usuario_venda int not null,
    data_venda timestamp not null,
	qtde_venda int not null,
	status_venda varchar(200) not null default 'ATIVO',

 constraint FK_id_contrato_venda foreign key (id_contrato_venda) references contrato (id_contrato),
 constraint FK_id_usuario_venda foreign key (id_usuario_venda) references usuario (id_usuario),
 constraint FK_id_pgto_venda foreign key (id_pgto_venda) references tipopgto (id_pgto),
 constraint FK_id_produto_venda foreign key (id_produto_venda) references produto (id_produto)
)

select * from venda

drop table contrato
create table contrato
(
	id_contrato int not null auto_increment primary key,
	id_assinatura_contrato int not null  ,
	id_cliente_contrato int not null  ,
	valor_contrato decimal(10,2) not null  ,
	data_contrato timestamp not null  default,
	tipo_contrato varchar(10) not null  ,
	status_contrato varchar(20) not null default 'ATIVO', 
    
    constraint FK_id_assiantura_contrato foreign key (id_assinatura_contrato) references assinatura (id_assinatura),
    constraint FK_id_cliente_contrato foreign key (id_cliente_contrato) references art (id_usuario)
)
select * from contrato

 create table produto
    (
    id_produto	int	not null auto_increment	primary key,
    nome_Produto varchar(30) not null,
	data_Produto timestamp not null,
	qtde_Produto int not null,
	valor_Produto decimal(10,2)	not null,
	obs_Produto varchar(200) null,
	status_Produto varchar(20) not null	default 'ATIVO'
    )
	select * from produto