USE [master]
GO
/****** Object:  Database [HSH DesaYTest]    Script Date: 18/05/2019 14:12:43 ******/
CREATE DATABASE [HSH DesaYTest]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'HSH DesaYTest', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\HSH DesaYTest.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'HSH DesaYTest_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\HSH DesaYTest_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [HSH DesaYTest] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [HSH DesaYTest].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [HSH DesaYTest] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [HSH DesaYTest] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [HSH DesaYTest] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [HSH DesaYTest] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [HSH DesaYTest] SET ARITHABORT OFF 
GO
ALTER DATABASE [HSH DesaYTest] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [HSH DesaYTest] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [HSH DesaYTest] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [HSH DesaYTest] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [HSH DesaYTest] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [HSH DesaYTest] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [HSH DesaYTest] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [HSH DesaYTest] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [HSH DesaYTest] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [HSH DesaYTest] SET  DISABLE_BROKER 
GO
ALTER DATABASE [HSH DesaYTest] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [HSH DesaYTest] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [HSH DesaYTest] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [HSH DesaYTest] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [HSH DesaYTest] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [HSH DesaYTest] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [HSH DesaYTest] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [HSH DesaYTest] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [HSH DesaYTest] SET  MULTI_USER 
GO
ALTER DATABASE [HSH DesaYTest] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [HSH DesaYTest] SET DB_CHAINING OFF 
GO
ALTER DATABASE [HSH DesaYTest] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [HSH DesaYTest] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [HSH DesaYTest] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [HSH DesaYTest] SET QUERY_STORE = OFF
GO
USE [HSH DesaYTest]
GO
/****** Object:  Table [dbo].[admins]    Script Date: 18/05/2019 14:12:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[admins](
	[token] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_admins] PRIMARY KEY CLUSTERED 
(
	[token] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[fotos]    Script Date: 18/05/2019 14:12:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[fotos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idPropiedad] [int] NOT NULL,
	[foto] [image] NOT NULL,
 CONSTRAINT [PK_fotos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HotSales]    Script Date: 18/05/2019 14:12:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HotSales](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idUsuario] [nvarchar](50) NOT NULL,
	[idPropiedad] [int] NOT NULL,
	[fechaInicio] [datetime] NOT NULL,
	[fechaFin] [datetime] NOT NULL,
	[monto] [decimal](18, 0) NOT NULL,
	[semanaReservada] [int] NOT NULL,
 CONSTRAINT [PK_HotSales] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Propiedad]    Script Date: 18/05/2019 14:12:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Propiedad](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[tipo] [nvarchar](50) NOT NULL,
	[ubicaciòn] [nvarchar](50) NOT NULL,
	[habitaciones] [int] NOT NULL,
	[adminQueDioDeAltaProp] [nvarchar](10) NOT NULL,
	[fechaAlta] [date] NOT NULL,
	[adminQueDIoDeBajaProp] [nvarchar](10) NULL,
	[fechaBaja] [date] NULL,
 CONSTRAINT [PK_Propiedad] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ReservaDirecta]    Script Date: 18/05/2019 14:12:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReservaDirecta](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idUsuario] [nvarchar](50) NOT NULL,
	[idPropiedad] [int] NOT NULL,
	[semanaReservada] [int] NOT NULL,
	[fechaReservada] [datetime] NOT NULL,
	[monto] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK_ReservaDirecta] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[subasta]    Script Date: 18/05/2019 14:12:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[subasta](
	[semana_de_subasta] [int] NOT NULL,
	[fecha_inicio] [datetime] NOT NULL,
	[fecha_fin] [datetime] NOT NULL,
	[monto_inicial] [decimal](18, 0) NOT NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_propiedad_subastada] [int] NOT NULL,
 CONSTRAINT [PK_subasta] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tarjetas]    Script Date: 18/05/2019 14:12:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tarjetas](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[numero] [nvarchar](16) NOT NULL,
	[vencimiento] [date] NOT NULL,
	[codigoSeguridad] [nvarchar](3) NOT NULL,
	[idPersona] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tarjetas] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuario]    Script Date: 18/05/2019 14:12:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuario](
	[nombre] [nvarchar](max) NOT NULL,
	[apellido] [nvarchar](max) NOT NULL,
	[contraseña] [nvarchar](20) NOT NULL,
	[mail] [nvarchar](50) NOT NULL,
	[fecha nacimiento] [date] NOT NULL,
	[premium] [bit] NOT NULL,
	[token] [int] NOT NULL,
 CONSTRAINT [PK_usuario] PRIMARY KEY CLUSTERED 
(
	[mail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuarioParticipaEnSubasta]    Script Date: 18/05/2019 14:12:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuarioParticipaEnSubasta](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[monto] [decimal](18, 0) NOT NULL,
	[idPersona] [nvarchar](50) NOT NULL,
	[idSubasta] [int] NOT NULL,
 CONSTRAINT [PK_usuarioParticipaEnSubasta] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[fotos]  WITH CHECK ADD  CONSTRAINT [idPropiedad] FOREIGN KEY([idPropiedad])
REFERENCES [dbo].[Propiedad] ([id])
GO
ALTER TABLE [dbo].[fotos] CHECK CONSTRAINT [idPropiedad]
GO
ALTER TABLE [dbo].[HotSales]  WITH CHECK ADD  CONSTRAINT [FkPropiedad] FOREIGN KEY([idPropiedad])
REFERENCES [dbo].[Propiedad] ([id])
GO
ALTER TABLE [dbo].[HotSales] CHECK CONSTRAINT [FkPropiedad]
GO
ALTER TABLE [dbo].[HotSales]  WITH CHECK ADD  CONSTRAINT [FKUsuario] FOREIGN KEY([idUsuario])
REFERENCES [dbo].[usuario] ([mail])
GO
ALTER TABLE [dbo].[HotSales] CHECK CONSTRAINT [FKUsuario]
GO
ALTER TABLE [dbo].[Propiedad]  WITH CHECK ADD  CONSTRAINT [FK_adminDioDeAlta] FOREIGN KEY([adminQueDioDeAltaProp])
REFERENCES [dbo].[admins] ([token])
GO
ALTER TABLE [dbo].[Propiedad] CHECK CONSTRAINT [FK_adminDioDeAlta]
GO
ALTER TABLE [dbo].[Propiedad]  WITH CHECK ADD  CONSTRAINT [FK_adminDioDeBaja] FOREIGN KEY([adminQueDIoDeBajaProp])
REFERENCES [dbo].[admins] ([token])
GO
ALTER TABLE [dbo].[Propiedad] CHECK CONSTRAINT [FK_adminDioDeBaja]
GO
ALTER TABLE [dbo].[ReservaDirecta]  WITH CHECK ADD  CONSTRAINT [FkPropReservaDirecta] FOREIGN KEY([idPropiedad])
REFERENCES [dbo].[Propiedad] ([id])
GO
ALTER TABLE [dbo].[ReservaDirecta] CHECK CONSTRAINT [FkPropReservaDirecta]
GO
ALTER TABLE [dbo].[ReservaDirecta]  WITH CHECK ADD  CONSTRAINT [FkUsuarioReserva] FOREIGN KEY([idUsuario])
REFERENCES [dbo].[usuario] ([mail])
GO
ALTER TABLE [dbo].[ReservaDirecta] CHECK CONSTRAINT [FkUsuarioReserva]
GO
ALTER TABLE [dbo].[subasta]  WITH CHECK ADD  CONSTRAINT [fk Propiedad Subastada] FOREIGN KEY([id_propiedad_subastada])
REFERENCES [dbo].[Propiedad] ([id])
GO
ALTER TABLE [dbo].[subasta] CHECK CONSTRAINT [fk Propiedad Subastada]
GO
ALTER TABLE [dbo].[tarjetas]  WITH CHECK ADD  CONSTRAINT [FK_tarjetas_Usuario] FOREIGN KEY([idPersona])
REFERENCES [dbo].[usuario] ([mail])
GO
ALTER TABLE [dbo].[tarjetas] CHECK CONSTRAINT [FK_tarjetas_Usuario]
GO
ALTER TABLE [dbo].[usuarioParticipaEnSubasta]  WITH CHECK ADD  CONSTRAINT [FkPersona] FOREIGN KEY([idPersona])
REFERENCES [dbo].[usuario] ([mail])
GO
ALTER TABLE [dbo].[usuarioParticipaEnSubasta] CHECK CONSTRAINT [FkPersona]
GO
ALTER TABLE [dbo].[usuarioParticipaEnSubasta]  WITH CHECK ADD  CONSTRAINT [FKSubasta] FOREIGN KEY([idSubasta])
REFERENCES [dbo].[subasta] ([id])
GO
ALTER TABLE [dbo].[usuarioParticipaEnSubasta] CHECK CONSTRAINT [FKSubasta]
GO
USE [master]
GO
ALTER DATABASE [HSH DesaYTest] SET  READ_WRITE 
GO
