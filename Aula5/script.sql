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

