USE [master]
GO

/****** Object:  Database [HSH DesaYTest]    Script Date: 18/05/2019 13:47:01 ******/
DROP DATABASE [HSH DesaYTest]
GO

/****** Object:  Database [HSH DesaYTest]    Script Date: 18/05/2019 13:47:01 ******/
CREATE DATABASE [HSH DesaYTest]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'HSH DesaYTest', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\HSH DesaYTest.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'HSH DesaYTest_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\HSH DesaYTest_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
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

ALTER DATABASE [HSH DesaYTest] SET  READ_WRITE 
GO
