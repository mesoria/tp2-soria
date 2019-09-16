use master
go
drop database CATALOGO_DB
go
create database CATALOGO_DB
go
use CATALOGO_DB
go

/****** Object:  Table [dbo].[MARCAS]    Script Date: 08/09/2019 10:32:05 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET DATEFORMAT 'DMY'
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MARCAS](
	[Id]		  [int] IDENTITY(1,1) NOT NULL,
	[Nombre]	  [varchar](30) NOT NULL,
	[Slogan] [varchar](50) NOT NULL,
 CONSTRAINT [PK_MARCAS] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
USE [CATALOGO_DB]
GO

/****** Object:  Table [dbo].[CATEGORIAS]    Script Date: 08/09/2019 10:32:14 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CATEGORIAS](
	[Id]		  [int] IDENTITY(1,1) NOT NULL,
	[Nombre]	  [varchar](30) NOT NULL,
 CONSTRAINT [PK_CATEGORIAS] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
USE [CATALOGO_DB]
GO

/****** Object:  Table [dbo].[ARTICULOS]    Script Date: 08/09/2019 10:32:24 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ARTICULOS](
	[Id]		  [int] IDENTITY(1,1) NOT NULL,
	[Codigo]	  [varchar](50) NOT NULL,
	[Nombre]	  [varchar](50) NOT NULL,
	[Descripcion] [varchar](150) NOT NULL,
	[IdMarca]	  [int] not NULL FOREIGN KEY REFERENCES MARCAS(ID),
	[IdCategoria] [int] not NULL FOREIGN KEY REFERENCES CATEGORIAS(ID),
	[Imagen]	  [varchar](150) NULL,
	[Precio]	  [float] NOT NULL CHECK(Precio >= 0),
 CONSTRAINT [PK_ARTICULOS] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO


insert into MARCAS values ('Samsung','Do What You Can’t'), ('Apple', 'Think Different'), ('Sony','make.believe'), ('Huawei','Make it Possible'), ('Motorola','Hello Moto')
insert into CATEGORIAS values ('Celulares'),('Televisores'), ('Media'), ('Audio')
insert into ARTICULOS values ('S01', 'Galaxy S10', 'Una canoa cara', 1, 1, '', 69.99),
('M03', 'Moto G Play 7ma Gen', 'Ya siete de estos?', 5, 1, '', 15699),
('S99', 'Play 4', 'Ya no se cuantas versiones hay', 3, 3, '', 35000),
('S56', 'Bravia 55', 'Alta tele', 3, 2, '', 49500),
('A23', 'Apple TV', 'lindo loro', 2, 2, '', 7850)