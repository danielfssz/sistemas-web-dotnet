create database prova
go
Use prova
go


Create table Cliente
(
	Id int identity(1,1) primary key,
	Nome varchar(100),
	Email varchar(100),
	Cpf char(18),
	Rg char(14),
	Dt_Nascimento datetime,
	Logradouro varchar(100),
	Cep varchar(12),
	Cidade varchar(100),
	Bairro varchar(100)
)