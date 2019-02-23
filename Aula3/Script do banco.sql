create database aula
go
use aula
go

create table login (id int identity(1,10),
login varchar(30),
nome varchar(30),
senha varchar(128))

insert into login select 'eneves','elienai','123'
insert into login select 'jose','jose','123'
insert into login select 'maria','maria','123'
insert into login select 'carlos','carlos','123'

go

Create proc pr_ins_login
@login varchar(30),
@nome varchar(30),
@senha varchar(128)

AS

INSERT INTO LOGIN (login, nome, senha)
values (@login, @nome, @senha)

select @@IDENTITY
