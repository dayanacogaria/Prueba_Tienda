USE [master]
GO
/****** Object:  Database [Tienda]    Script Date: 13/04/2021 6:32:38 p. m. ******/
CREATE DATABASE [Tienda]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Tienda', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Tienda.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Tienda_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Tienda_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Tienda] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Tienda].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Tienda] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Tienda] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Tienda] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Tienda] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Tienda] SET ARITHABORT OFF 
GO
ALTER DATABASE [Tienda] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Tienda] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Tienda] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Tienda] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Tienda] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Tienda] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Tienda] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Tienda] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Tienda] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Tienda] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Tienda] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Tienda] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Tienda] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Tienda] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Tienda] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Tienda] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Tienda] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Tienda] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Tienda] SET  MULTI_USER 
GO
ALTER DATABASE [Tienda] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Tienda] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Tienda] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Tienda] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Tienda] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Tienda] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Tienda] SET QUERY_STORE = OFF
GO
USE [Tienda]
GO
/****** Object:  Table [dbo].[categoria]    Script Date: 13/04/2021 6:32:38 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[categoria](
	[id_categoria] [int] IDENTITY(1,1) NOT NULL,
	[categoria] [varchar](255) NULL,
	[id_sublinea] [int] NULL,
 CONSTRAINT [PK_categoria] PRIMARY KEY CLUSTERED 
(
	[id_categoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Linea]    Script Date: 13/04/2021 6:32:38 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Linea](
	[id_linea] [int] IDENTITY(1,1) NOT NULL,
	[linea] [varchar](255) NULL,
 CONSTRAINT [PK_Linea] PRIMARY KEY CLUSTERED 
(
	[id_linea] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 13/04/2021 6:32:38 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[id_producto] [int] IDENTITY(1,1) NOT NULL,
	[producto] [varchar](255) NULL,
	[id_categoria] [int] NULL,
 CONSTRAINT [PK_Producto] PRIMARY KEY CLUSTERED 
(
	[id_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sublinea]    Script Date: 13/04/2021 6:32:38 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sublinea](
	[id_sublinea] [int] IDENTITY(1,1) NOT NULL,
	[sublinea] [varchar](255) NULL,
	[id_linea] [int] NULL,
 CONSTRAINT [PK_sublinea] PRIMARY KEY CLUSTERED 
(
	[id_sublinea] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[categoria] ON 
GO
INSERT [dbo].[categoria] ([id_categoria], [categoria], [id_sublinea]) VALUES (1, N'Disney', 2)
GO
INSERT [dbo].[categoria] ([id_categoria], [categoria], [id_sublinea]) VALUES (2, N'Fantasia', 2)
GO
SET IDENTITY_INSERT [dbo].[categoria] OFF
GO
SET IDENTITY_INSERT [dbo].[Linea] ON 
GO
INSERT [dbo].[Linea] ([id_linea], [linea]) VALUES (1, N'Vestuario')
GO
INSERT [dbo].[Linea] ([id_linea], [linea]) VALUES (3, N'Calzado')
GO
SET IDENTITY_INSERT [dbo].[Linea] OFF
GO
SET IDENTITY_INSERT [dbo].[Producto] ON 
GO
INSERT [dbo].[Producto] ([id_producto], [producto], [id_categoria]) VALUES (1, N'Camisa', 1)
GO
INSERT [dbo].[Producto] ([id_producto], [producto], [id_categoria]) VALUES (2, N'pantalon', 1)
GO
SET IDENTITY_INSERT [dbo].[Producto] OFF
GO
SET IDENTITY_INSERT [dbo].[sublinea] ON 
GO
INSERT [dbo].[sublinea] ([id_sublinea], [sublinea], [id_linea]) VALUES (2, N'Dama', 1)
GO
INSERT [dbo].[sublinea] ([id_sublinea], [sublinea], [id_linea]) VALUES (3, N'Ropa Infantil', 1)
GO
SET IDENTITY_INSERT [dbo].[sublinea] OFF
GO
/****** Object:  StoredProcedure [dbo].[crudcategoria]    Script Date: 13/04/2021 6:32:38 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[crudcategoria]
	
	@id int = null , @tipo int =null, @categoria varchar(255) = null, @idsublinea int = null
AS
BEGIN
	if @tipo = 1 
	begin 

INSERT INTO [dbo].[categoria]
           ([categoria]
           ,[id_sublinea])
     VALUES
           (@categoria,@idsublinea)
	end 
		if @tipo = 2
	begin 

	
UPDATE [dbo].[categoria]
   SET [categoria] = @categoria
      ,[id_sublinea] = @idsublinea
 WHERE id_categoria = @id
	end 
		if @tipo = 3
	begin 

	 DELETE FROM  [dbo].[categoria] WHERE id_categoria = @id
	end 
	if @tipo = 4
	begin 
	
SELECT c.id_categoria,c.categoria,s.id_sublinea,s.sublinea
  FROM [Tienda].[dbo].[sublinea] s  inner join categoria c on s.id_sublinea = c.id_sublinea

	end 
END
GO
/****** Object:  StoredProcedure [dbo].[crudlinea]    Script Date: 13/04/2021 6:32:38 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[crudlinea]
	
	@id int = null , @tipo int =null, @linea varchar(255) = null
AS
BEGIN
	if @tipo = 1 
	begin 

	INSERT INTO [dbo].[Linea]
           ([linea])
     VALUES
           (@linea)
	end 
		if @tipo = 2
	begin 

	
UPDATE [dbo].[Linea]
   SET [linea] = @linea
 WHERE id_linea = @id
	end 
		if @tipo = 3
	begin 

	 DELETE FROM  [dbo].[Linea] WHERE id_linea = @id
	end 
	if @tipo = 4
	begin 
	SELECT id_linea, linea FROM [dbo].[Linea]
	end 
END
GO
/****** Object:  StoredProcedure [dbo].[crudsublinea]    Script Date: 13/04/2021 6:32:38 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[crudsublinea]
	
	@id int = null , @tipo int =null, @sublinea varchar(255) = null, @idlinea int = null
AS
BEGIN
	if @tipo = 1 
	begin 

	INSERT INTO [dbo].[sublinea]
           ([sublinea]
           ,[id_linea])
     VALUES
           (@sublinea,@idlinea)
	end 
		if @tipo = 2
	begin 

	
UPDATE [dbo].[sublinea]
   SET [sublinea] = @sublinea
      ,[id_linea] = @idlinea
 WHERE id_sublinea = @id
	end 
		if @tipo = 3
	begin 

	 DELETE FROM  [dbo].[sublinea] WHERE id_sublinea = @id
	end 
	if @tipo = 4
	begin 
	
  SELECT s.id_sublinea,s.sublinea,l.id_linea,l.linea
  FROM [Tienda].[dbo].[sublinea] s inner join Linea l on s.id_linea = l.id_linea 
	end 
END
GO
USE [master]
GO
ALTER DATABASE [Tienda] SET  READ_WRITE 
GO
