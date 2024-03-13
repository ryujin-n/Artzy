create database Artzy

use artzy


create table tarefa
(
   id_tarefa INT PRIMARY KEY IDENTITY,
    status_tarefa VARCHAR(50),
    id_usuario_tarefa INT,
    ordem_tarefa INT,
    nome_tarefa VARCHAR(255)
    CONSTRAINT FK_id_usuario_tarefa FOREIGN KEY (id_usuario_tarefa) REFERENCES art (id_usuario)
)


create table usuario
(
	id_usuario int not null identity primary key,
	nome_usuario varchar(50) not null,
	sobrenome_usuario varchar (50) not null,
	login_usuario varchar(50) not null unique ,
	senha_usuario varchar(20) not null,
	fotoP_usuario varbinary (max) not null ,
	email_usuario varchar (100) not null,
	prof_usuario varchar (100) not null,
	data_usuario smalldatetime not null default getdate(),
	status_usuario varchar(20) not null default 'ATIVO' 
)


drop table assinatura

create table assinatura
(
	id_assinatura  int  not null  identity  primary key,
	tipo_assinatura  varchar(10)  not null  ,
	beneficio_assinatura  varchar(200)  not null  ,
	valor_assinatura  decimal(10,2)  not null  ,
	status_assinatura  varchar(20)  not null  default 'ATIVO'  
)
select * from assinatura

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
	id_vendedor_venda int not null,
	id_comprador_venda int not null,
	id_pgto_venda int not null,
	data_venda smalldatetime not null default getdate(),
	qtde_venda int not null,
	status_venda varchar(200)	not null	default 'ATIVO',

 constraint FK_id_contrato_venda foreign key (id_contrato_venda) references contart (id_contart),
 constraint FK_id_usuario_venda foreign key (id_usuario_venda) references art (id_usuario),
 constraint FK_id_pgto_venda foreign key (id_pgto_venda) references tipopgto (id_pgto)
)

select * from venda

drop table contart
create table contrato
(
	id_contart int not null identity primary key,
	id_assiantura_contart int not null  ,
	id_cliente_contart int not null  ,
	valor_contart decimal(10,2) not null  ,
	data_contart smalldatetime not null  default getdate(),
	tipo_contart varchar(10) not null  ,
	status_contar varchar(20) not null default 'ATIVO', 
    
    constraint FK_id_assiantura_contart foreign key (id_assiantura_contart) references assinatura (id_assinatura),
    constraint FK_id_cliente_contart foreign key (id_cliente_contart) references art (id_usuario)
)
select * from contrato