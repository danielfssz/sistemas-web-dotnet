create database aula6
go

use aula6
go

create table contatos (
codigo int identity(1,1) primary key,
nome varchar(100),
email varchar(100),
idade int
)

go
CREATE PROCEDURE AtualizarDados 
@codigo int,
@nome varchar(100),
@email varchar(100),
@idade int
AS
BEGIN
	SET NOCOUNT ON;

	update contatos 
	set nome=@nome,
	email=@email,
	idade=@idade
	where codigo=@codigo
			

END
GO


cREATE PROCEDURE dbo.CarregarDados
AS
    select * from contatos

go

CREATE PROCEDURE dbo.DeletarDados
(
@codigo int
)
AS
DELETE
    FROM dbo.Contatos
    WHERE  
    codigo = @codigo

	go

CREATE PROCEDURE dbo.InserirDados
(
@nome nvarchar(50),
@email nvarchar(100),
@idade int
)
AS
Insert into Contatos(nome,email,idade) values 
(@nome,@email,@idade)

go


CREATE PROCEDURE dbo.getContato
(
    @codigo int
)
AS
select * from Contatos Where codigo = @codigo

go


create table cliente ( 
id int identity (1,1),
codigo varchar(11) primary key,
nome varchar(100),
datacadastro datetime

)

go

create procedure dbo.inserirCliente (
	@nome varchar(100), 
	@codigo varchar(11), 
	@dataCadastro datetime
)
AS
INSERT INTO cliente(nome, codigo, datacadastro) VALUES(@nome, @codigo, @dataCadastro)

go


CREATE PROCEDURE dbo.atualizarCliente ( 
	@id int, 
	@nome varchar(100),
	@codigo varchar(11),
	@dataCadastro datetime
)
AS
UPDATE cliente SET nome=@nome, codigo=@codigo, dataCadastro=@dataCadastro WHERE id=@id

go


CREATE PROCEDURE dbo.deletarCliente (
	@codigo varchar(11)
)
AS
DELETE FROM cliente WHERE codigo = @codigo

go


CREATE PROCEDURE dbo.carregarClientes
AS
SELECT * FROM cliente

go


CREATE PROCEDURE dbo.getCliente
(
    @codigo varchar(11)
)
AS
SELECT * FROM cliente WHERE codigo = @codigo

