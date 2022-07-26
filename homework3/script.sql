USE [master]
GO
/****** Object:  Database [KredekPizza]    Script Date: 5/15/2022 6:28:39 PM ******/
CREATE DATABASE [KredekPizza]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'KredekPizza', FILENAME = N'D:\Microsoft SQL SERVER\MSSQL15.MACIEKSQL\MSSQL\DATA\KredekPizza.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'KredekPizza_log', FILENAME = N'D:\Microsoft SQL SERVER\MSSQL15.MACIEKSQL\MSSQL\DATA\KredekPizza_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [KredekPizza] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [KredekPizza].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [KredekPizza] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [KredekPizza] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [KredekPizza] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [KredekPizza] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [KredekPizza] SET ARITHABORT OFF 
GO
ALTER DATABASE [KredekPizza] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [KredekPizza] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [KredekPizza] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [KredekPizza] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [KredekPizza] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [KredekPizza] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [KredekPizza] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [KredekPizza] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [KredekPizza] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [KredekPizza] SET  DISABLE_BROKER 
GO
ALTER DATABASE [KredekPizza] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [KredekPizza] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [KredekPizza] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [KredekPizza] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [KredekPizza] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [KredekPizza] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [KredekPizza] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [KredekPizza] SET RECOVERY FULL 
GO
ALTER DATABASE [KredekPizza] SET  MULTI_USER 
GO
ALTER DATABASE [KredekPizza] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [KredekPizza] SET DB_CHAINING OFF 
GO
ALTER DATABASE [KredekPizza] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [KredekPizza] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [KredekPizza] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [KredekPizza] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'KredekPizza', N'ON'
GO
ALTER DATABASE [KredekPizza] SET QUERY_STORE = OFF
GO
USE [KredekPizza]
GO
/****** Object:  Table [dbo].[Finance]    Script Date: 5/15/2022 6:28:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Finance](
	[FinanceID] [int] IDENTITY(1,1) NOT NULL,
	[Description] [varchar](100) NULL,
	[Sum] [float] NULL,
	[PizzaId] [int] NULL,
 CONSTRAINT [Pk_Finance] PRIMARY KEY CLUSTERED 
(
	[FinanceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 5/15/2022 6:28:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[OrderId] [int] IDENTITY(1,1) NOT NULL,
	[PizzaId] [int] NOT NULL,
	[City] [varchar](50) NOT NULL,
	[Address] [varchar](50) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[PhoneNumber] [varchar](50) NOT NULL,
	[OrderDate] [datetime] NOT NULL,
 CONSTRAINT [Pk_Orders] PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pizzas]    Script Date: 5/15/2022 6:28:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pizzas](
	[PizzaId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Price] [float] NULL,
	[Description] [varchar](500) NULL,
	[ImagePath] [varchar](1000) NULL,
 CONSTRAINT [Pk_Pizzas] PRIMARY KEY CLUSTERED 
(
	[PizzaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Finance] ON 

INSERT [dbo].[Finance] ([FinanceID], [Description], [Sum], [PizzaId]) VALUES (3, N'Income from Order', 19.99, 1)
INSERT [dbo].[Finance] ([FinanceID], [Description], [Sum], [PizzaId]) VALUES (4, N'Income from Order', 25, 5)
INSERT [dbo].[Finance] ([FinanceID], [Description], [Sum], [PizzaId]) VALUES (5, N'Income from Order', 19.99, 1)
INSERT [dbo].[Finance] ([FinanceID], [Description], [Sum], [PizzaId]) VALUES (6, N'Income from Order', 19.99, 1)
INSERT [dbo].[Finance] ([FinanceID], [Description], [Sum], [PizzaId]) VALUES (7, N'Income from Order', 19.99, 1)
INSERT [dbo].[Finance] ([FinanceID], [Description], [Sum], [PizzaId]) VALUES (8, N'Income from Order', 20.1, 9)
SET IDENTITY_INSERT [dbo].[Finance] OFF
GO
SET IDENTITY_INSERT [dbo].[Orders] ON 

INSERT [dbo].[Orders] ([OrderId], [PizzaId], [City], [Address], [Email], [PhoneNumber], [OrderDate]) VALUES (6, 1, N'Warszawa', N'Wesoła 17/4', N'jan.kowalski@gmail.com', N'123654789', CAST(N'2022-05-14T22:43:04.400' AS DateTime))
INSERT [dbo].[Orders] ([OrderId], [PizzaId], [City], [Address], [Email], [PhoneNumber], [OrderDate]) VALUES (7, 1, N'Kraków', N'stara 57/11', N'jakub.nowak@gmail.com', N'753978111', CAST(N'2022-05-14T23:04:48.727' AS DateTime))
INSERT [dbo].[Orders] ([OrderId], [PizzaId], [City], [Address], [Email], [PhoneNumber], [OrderDate]) VALUES (8, 5, N'Zielona Góra', N'nowa 31', N'adam.kowalski@gmail.com', N'876098098', CAST(N'2022-05-14T23:49:50.127' AS DateTime))
INSERT [dbo].[Orders] ([OrderId], [PizzaId], [City], [Address], [Email], [PhoneNumber], [OrderDate]) VALUES (9, 1, N'Gdańsk', N'nowa 41', N'grzegorz.orzechowski@gmail.com', N'123444333', CAST(N'2022-05-15T13:19:56.097' AS DateTime))
INSERT [dbo].[Orders] ([OrderId], [PizzaId], [City], [Address], [Email], [PhoneNumber], [OrderDate]) VALUES (10, 1, N'Jelenia Góra', N'powstańcza 4', N'nowy.czlowiek@gmail.com', N'777888999', CAST(N'2022-05-15T14:44:35.443' AS DateTime))
INSERT [dbo].[Orders] ([OrderId], [PizzaId], [City], [Address], [Email], [PhoneNumber], [OrderDate]) VALUES (11, 1, N'Kalisz', N'orzechowa 57', N'ktos.nowy@gmail.com', N'554666333', CAST(N'2022-05-15T15:26:19.513' AS DateTime))
INSERT [dbo].[Orders] ([OrderId], [PizzaId], [City], [Address], [Email], [PhoneNumber], [OrderDate]) VALUES (12, 9, N'Szczecin', N'Długa 11', N'radoslaw.majewski@gmail.com', N'888999777', CAST(N'2022-05-15T18:20:08.730' AS DateTime))
SET IDENTITY_INSERT [dbo].[Orders] OFF
GO
SET IDENTITY_INSERT [dbo].[Pizzas] ON 

INSERT [dbo].[Pizzas] ([PizzaId], [Name], [Price], [Description], [ImagePath]) VALUES (1, N'Hawajska.v2', 19.99, N'Najlepsza pizza na świecie z ananasem', N'hawajska.png')
INSERT [dbo].[Pizzas] ([PizzaId], [Name], [Price], [Description], [ImagePath]) VALUES (2, N'Pepperoni', 18.99, N'Ostra pizzka z salami', N'pepperoni.png')
INSERT [dbo].[Pizzas] ([PizzaId], [Name], [Price], [Description], [ImagePath]) VALUES (3, N'Grecka', 21.1, N'Super pizza prosto z grecji z serem feta i pomidorami', N'grecka.png')
INSERT [dbo].[Pizzas] ([PizzaId], [Name], [Price], [Description], [ImagePath]) VALUES (4, N'Capriciosa', 23.99, N'Pyszna pizza z pieczarkami', N'capriciosa.png')
INSERT [dbo].[Pizzas] ([PizzaId], [Name], [Price], [Description], [ImagePath]) VALUES (5, N'Kebab', 25, N'Ostra pizza we wschodnim klimacie', N'kebab.png')
INSERT [dbo].[Pizzas] ([PizzaId], [Name], [Price], [Description], [ImagePath]) VALUES (9, N'Margherita', 20.1, N'Klasyczna pizza', N'margherita.png')
SET IDENTITY_INSERT [dbo].[Pizzas] OFF
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [Fk_Orders_Pizzas] FOREIGN KEY([PizzaId])
REFERENCES [dbo].[Pizzas] ([PizzaId])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [Fk_Orders_Pizzas]
GO
/****** Object:  Trigger [dbo].[UpdateFinance]    Script Date: 5/15/2022 6:28:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[UpdateFinance] ON [dbo].[Orders]
FOR INSERT
AS

BEGIN	
	INSERT INTO dbo.Finance	(PizzaId, Description, Sum)
	VALUES ((SELECT PizzaId FROM inserted), 'Income from Order', (SELECT Price FROM dbo.Pizzas WHERE PizzaId = (SELECT PizzaId FROM inserted)))
END
GO
ALTER TABLE [dbo].[Orders] ENABLE TRIGGER [UpdateFinance]
GO
USE [master]
GO
ALTER DATABASE [KredekPizza] SET  READ_WRITE 
GO
