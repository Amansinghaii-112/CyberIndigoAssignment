USE [master]
GO

/****** Object:  Database [CyberIndigoAssignment]    Script Date: 18-Oct-20 3:42:18 PM ******/
CREATE DATABASE [CyberIndigoAssignment]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CyberIndigoAssignment', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\CyberIndigoAssignment.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CyberIndigoAssignment_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\CyberIndigoAssignment_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CyberIndigoAssignment].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [CyberIndigoAssignment] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [CyberIndigoAssignment] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [CyberIndigoAssignment] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [CyberIndigoAssignment] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [CyberIndigoAssignment] SET ARITHABORT OFF 
GO

ALTER DATABASE [CyberIndigoAssignment] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [CyberIndigoAssignment] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [CyberIndigoAssignment] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [CyberIndigoAssignment] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [CyberIndigoAssignment] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [CyberIndigoAssignment] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [CyberIndigoAssignment] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [CyberIndigoAssignment] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [CyberIndigoAssignment] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [CyberIndigoAssignment] SET  DISABLE_BROKER 
GO

ALTER DATABASE [CyberIndigoAssignment] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [CyberIndigoAssignment] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [CyberIndigoAssignment] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [CyberIndigoAssignment] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [CyberIndigoAssignment] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [CyberIndigoAssignment] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [CyberIndigoAssignment] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [CyberIndigoAssignment] SET RECOVERY FULL 
GO

ALTER DATABASE [CyberIndigoAssignment] SET  MULTI_USER 
GO

ALTER DATABASE [CyberIndigoAssignment] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [CyberIndigoAssignment] SET DB_CHAINING OFF 
GO

ALTER DATABASE [CyberIndigoAssignment] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [CyberIndigoAssignment] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [CyberIndigoAssignment] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [CyberIndigoAssignment] SET QUERY_STORE = OFF
GO

ALTER DATABASE [CyberIndigoAssignment] SET  READ_WRITE 
GO

