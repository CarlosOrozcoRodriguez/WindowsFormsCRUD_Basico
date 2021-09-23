USE [master]
GO
/****** Object:  Database [WinformContacts]    Script Date: 23/09/2021 9:37:59 ******/
CREATE DATABASE [WinformContacts]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'WinformContacts', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\WinformContacts.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'WinformContacts_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\WinformContacts_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [WinformContacts] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [WinformContacts].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [WinformContacts] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [WinformContacts] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [WinformContacts] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [WinformContacts] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [WinformContacts] SET ARITHABORT OFF 
GO
ALTER DATABASE [WinformContacts] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [WinformContacts] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [WinformContacts] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [WinformContacts] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [WinformContacts] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [WinformContacts] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [WinformContacts] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [WinformContacts] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [WinformContacts] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [WinformContacts] SET  DISABLE_BROKER 
GO
ALTER DATABASE [WinformContacts] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [WinformContacts] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [WinformContacts] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [WinformContacts] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [WinformContacts] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [WinformContacts] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [WinformContacts] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [WinformContacts] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [WinformContacts] SET  MULTI_USER 
GO
ALTER DATABASE [WinformContacts] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [WinformContacts] SET DB_CHAINING OFF 
GO
ALTER DATABASE [WinformContacts] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [WinformContacts] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [WinformContacts] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [WinformContacts] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [WinformContacts] SET QUERY_STORE = OFF
GO
USE [WinformContacts]
GO
/****** Object:  Table [dbo].[Contacts]    Script Date: 23/09/2021 9:37:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contacts](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Apellido] [nvarchar](50) NOT NULL,
	[Telefono] [nvarchar](20) NULL,
	[Direccion] [nvarchar](100) NULL,
 CONSTRAINT [PK_Contacts] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [WinformContacts] SET  READ_WRITE 
GO


--USE [WinformContacts]
--GO
--SET IDENTITY_INSERT [dbo].[Contacts] ON 
--GO
--INSERT [dbo].[Contacts] ([Id], [Nombre], [Apellido], [Telefono], [Direccion]) VALUES (1, N'Federico', N'Pelaez', N'555123123', N'Calle Falsa')
--GO
--INSERT [dbo].[Contacts] ([Id], [Nombre], [Apellido], [Telefono], [Direccion]) VALUES (2, N'Jorge', N'Vazquez', N'7777', N'Freeea')
--GO
--INSERT [dbo].[Contacts] ([Id], [Nombre], [Apellido], [Telefono], [Direccion]) VALUES (3, N'Gordon', N'Freeman', N'555ASD', N'Blaack Mesa s/n')
--GO
--INSERT [dbo].[Contacts] ([Id], [Nombre], [Apellido], [Telefono], [Direccion]) VALUES (9, N'Pablo', N'Piloto', N'12313123', N'Paredes')
--GO
--INSERT [dbo].[Contacts] ([Id], [Nombre], [Apellido], [Telefono], [Direccion]) VALUES (10, N'Pericoso', N'Palotes', N'324912313', N'Popurri')
--GO
--INSERT [dbo].[Contacts] ([Id], [Nombre], [Apellido], [Telefono], [Direccion]) VALUES (11, N'Fulgencioso', N'Matrinez', N'9123123', N'Fulgencia Cia')
--GO
--INSERT [dbo].[Contacts] ([Id], [Nombre], [Apellido], [Telefono], [Direccion]) VALUES (12, N'Fulgencio', N'Matrinez', N'9123123', N'FulgenciaCia')
--GO
--INSERT [dbo].[Contacts] ([Id], [Nombre], [Apellido], [Telefono], [Direccion]) VALUES (14, N'Periquin', N'Palotes', N'84644664', N'Popurri')
--GO
--SET IDENTITY_INSERT [dbo].[Contacts] OFF
--GO
