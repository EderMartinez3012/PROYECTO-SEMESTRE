CREATE DATABASE RestauranteCosteño

USE [RestauranteCosteño]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 25/11/2022 14:37:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[Cedula] [int] NOT NULL,
	[Nombres] [varchar](20) NOT NULL,
	[Apellidos] [varchar](20) NOT NULL,
	[Telefono] [numeric](15, 0) NOT NULL,
	[Sexo] [varchar](20) NOT NULL,
	[Menu] [varchar](20) NOT NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[Cedula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
