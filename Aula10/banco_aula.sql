create database Aula
go

USE [Aula]
GO

/****** Object:  Table [dbo].[Clientes]    Script Date: 17/05/2019 19:27:16 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Clientes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [nvarchar](100) NOT NULL,
	[Email] [nvarchar](100) NOT NULL,
	[IdConsultor] [int] NOT NULL,
 CONSTRAINT [PK_dbo.Clientes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Clientes]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Clientes_dbo.Consultores_IdConsultor] FOREIGN KEY([IdConsultor])
REFERENCES [dbo].[Consultores] ([Id])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[Clientes] CHECK CONSTRAINT [FK_dbo.Clientes_dbo.Consultores_IdConsultor]
GO
USE [Aula]
GO

/****** Object:  Table [dbo].[Consultores]    Script Date: 17/05/2019 19:28:28 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Consultores](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_dbo.Consultores] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
USE [Aula]
GO

/****** Object:  Table [dbo].[Telefones]    Script Date: 17/05/2019 19:28:50 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Telefones](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DDD] [int] NOT NULL,
	[Numero] [nvarchar](max) NULL,
	[Tipo] [int] NOT NULL,
	[Cliente_Id] [int] NULL,
 CONSTRAINT [PK_dbo.Telefones] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

ALTER TABLE [dbo].[Telefones]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Telefones_dbo.Clientes_Cliente_Id] FOREIGN KEY([Cliente_Id])
REFERENCES [dbo].[Clientes] ([Id])
GO

ALTER TABLE [dbo].[Telefones] CHECK CONSTRAINT [FK_dbo.Telefones_dbo.Clientes_Cliente_Id]
GO





