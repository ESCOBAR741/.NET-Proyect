USE [master]
GO
/****** Object:  Database [DBSeguimientoGastos]    Script Date: 21-05-2023 0:38:30 ******/
CREATE DATABASE [DBSeguimientoGastos]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DBSeguimientoGastos', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\DBSeguimientoGastos.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DBSeguimientoGastos_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\DBSeguimientoGastos_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [DBSeguimientoGastos] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DBSeguimientoGastos].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DBSeguimientoGastos] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DBSeguimientoGastos] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DBSeguimientoGastos] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DBSeguimientoGastos] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DBSeguimientoGastos] SET ARITHABORT OFF 
GO
ALTER DATABASE [DBSeguimientoGastos] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [DBSeguimientoGastos] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DBSeguimientoGastos] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DBSeguimientoGastos] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DBSeguimientoGastos] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DBSeguimientoGastos] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DBSeguimientoGastos] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DBSeguimientoGastos] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DBSeguimientoGastos] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DBSeguimientoGastos] SET  ENABLE_BROKER 
GO
ALTER DATABASE [DBSeguimientoGastos] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DBSeguimientoGastos] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DBSeguimientoGastos] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DBSeguimientoGastos] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DBSeguimientoGastos] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DBSeguimientoGastos] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DBSeguimientoGastos] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DBSeguimientoGastos] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DBSeguimientoGastos] SET  MULTI_USER 
GO
ALTER DATABASE [DBSeguimientoGastos] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DBSeguimientoGastos] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DBSeguimientoGastos] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DBSeguimientoGastos] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DBSeguimientoGastos] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DBSeguimientoGastos] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [DBSeguimientoGastos] SET QUERY_STORE = ON
GO
ALTER DATABASE [DBSeguimientoGastos] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [DBSeguimientoGastos]
GO
/****** Object:  Table [dbo].[Departamentos]    Script Date: 21-05-2023 0:38:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Departamentos](
	[idDepto] [tinyint] IDENTITY(1,1) NOT NULL,
	[nombreDepto] [varchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idDepto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Gastos]    Script Date: 21-05-2023 0:38:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Gastos](
	[idGasto] [int] IDENTITY(1,1) NOT NULL,
	[tipoGasto] [varchar](30) NOT NULL,
	[detalle] [varchar](30) NOT NULL,
	[descripcion] [varchar](100) NULL,
	[monto] [int] NOT NULL,
	[fechaGasto] [datetime] NULL,
	[idUsuario] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idGasto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 21-05-2023 0:38:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[idUsuario] [int] IDENTITY(1,1) NOT NULL,
	[nombres] [varchar](100) NOT NULL,
	[apellidos] [varchar](100) NOT NULL,
	[run] [varchar](10) NOT NULL,
	[usuario] [varchar](30) NOT NULL,
	[contraseña] [varchar](30) NOT NULL,
	[idDepto] [tinyint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Departamentos] ON 

INSERT [dbo].[Departamentos] ([idDepto], [nombreDepto]) VALUES (1, N'finanzas')
INSERT [dbo].[Departamentos] ([idDepto], [nombreDepto]) VALUES (2, N'informatica')
INSERT [dbo].[Departamentos] ([idDepto], [nombreDepto]) VALUES (4, N'mantencion')
INSERT [dbo].[Departamentos] ([idDepto], [nombreDepto]) VALUES (3, N'rrhh')
SET IDENTITY_INSERT [dbo].[Departamentos] OFF
GO
SET IDENTITY_INSERT [dbo].[Gastos] ON 

INSERT [dbo].[Gastos] ([idGasto], [tipoGasto], [detalle], [descripcion], [monto], [fechaGasto], [idUsuario]) VALUES (1, N'alimentacion', N'ida trabajo', N'', 10000, NULL, 1)
INSERT [dbo].[Gastos] ([idGasto], [tipoGasto], [detalle], [descripcion], [monto], [fechaGasto], [idUsuario]) VALUES (2, N'alimentacion', N'regreso trabajo', N'', 4000, NULL, 2)
INSERT [dbo].[Gastos] ([idGasto], [tipoGasto], [detalle], [descripcion], [monto], [fechaGasto], [idUsuario]) VALUES (3, N'alimentacion', N'otros', N'', 30000, NULL, 1)
INSERT [dbo].[Gastos] ([idGasto], [tipoGasto], [detalle], [descripcion], [monto], [fechaGasto], [idUsuario]) VALUES (4, N'alimentacion', N'otros', N'comer', 1000, NULL, 4)
INSERT [dbo].[Gastos] ([idGasto], [tipoGasto], [detalle], [descripcion], [monto], [fechaGasto], [idUsuario]) VALUES (6, N'otros', N'otros', N'Hardware', 300000, NULL, 6)
INSERT [dbo].[Gastos] ([idGasto], [tipoGasto], [detalle], [descripcion], [monto], [fechaGasto], [idUsuario]) VALUES (8, N'alimentacion', N'ida trabajo', N'bus', 1111, NULL, 4)
INSERT [dbo].[Gastos] ([idGasto], [tipoGasto], [detalle], [descripcion], [monto], [fechaGasto], [idUsuario]) VALUES (9, N'articulos', N'otros', N'lolazo', 10000, NULL, 4)
INSERT [dbo].[Gastos] ([idGasto], [tipoGasto], [detalle], [descripcion], [monto], [fechaGasto], [idUsuario]) VALUES (10, N'alimentacion', N'ida trabajo', N'', 344445, NULL, 3)
INSERT [dbo].[Gastos] ([idGasto], [tipoGasto], [detalle], [descripcion], [monto], [fechaGasto], [idUsuario]) VALUES (11, N'otros', N'otros', N'', 1000, NULL, 4)
SET IDENTITY_INSERT [dbo].[Gastos] OFF
GO
SET IDENTITY_INSERT [dbo].[Usuarios] ON 

INSERT [dbo].[Usuarios] ([idUsuario], [nombres], [apellidos], [run], [usuario], [contraseña], [idDepto]) VALUES (1, N'Carlos', N'Chepillo', N'10010999-3', N'cchepillo', N'1234', 2)
INSERT [dbo].[Usuarios] ([idUsuario], [nombres], [apellidos], [run], [usuario], [contraseña], [idDepto]) VALUES (2, N'Cristian Daniel', N'Rojas Alvarez', N'10200300-4', N'crojas', N'12345', 3)
INSERT [dbo].[Usuarios] ([idUsuario], [nombres], [apellidos], [run], [usuario], [contraseña], [idDepto]) VALUES (3, N'Raul Javier', N'Acevedo Cancino', N'12500600-4', N'racevedo', N'123456', 1)
INSERT [dbo].[Usuarios] ([idUsuario], [nombres], [apellidos], [run], [usuario], [contraseña], [idDepto]) VALUES (4, N'Nicolas', N'Fuentes', N'21389045-K', N'nfuentes', N'1234', 4)
INSERT [dbo].[Usuarios] ([idUsuario], [nombres], [apellidos], [run], [usuario], [contraseña], [idDepto]) VALUES (6, N'Denilson', N'Escobar', N'27238651-K', N'Escobar', N'1234', 2)
INSERT [dbo].[Usuarios] ([idUsuario], [nombres], [apellidos], [run], [usuario], [contraseña], [idDepto]) VALUES (7, N'Rafael', N'Cubillos', N'12300600-3', N'rcubillos', N'12345', 2)
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Departam__776B810DAB487DC4]    Script Date: 21-05-2023 0:38:30 ******/
ALTER TABLE [dbo].[Departamentos] ADD UNIQUE NONCLUSTERED 
(
	[nombreDepto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Usuarios__7675D77ABA64D9C1]    Script Date: 21-05-2023 0:38:30 ******/
ALTER TABLE [dbo].[Usuarios] ADD UNIQUE NONCLUSTERED 
(
	[apellidos] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Usuarios__822604A246AFEFA3]    Script Date: 21-05-2023 0:38:30 ******/
ALTER TABLE [dbo].[Usuarios] ADD UNIQUE NONCLUSTERED 
(
	[nombres] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Usuarios__9AFF8FC6ED89A5A6]    Script Date: 21-05-2023 0:38:30 ******/
ALTER TABLE [dbo].[Usuarios] ADD UNIQUE NONCLUSTERED 
(
	[usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Usuarios__C2B74E6C0C9325EA]    Script Date: 21-05-2023 0:38:30 ******/
ALTER TABLE [dbo].[Usuarios] ADD UNIQUE NONCLUSTERED 
(
	[run] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Gastos] ADD  DEFAULT (getdate()) FOR [fechaGasto]
GO
ALTER TABLE [dbo].[Gastos]  WITH NOCHECK ADD  CONSTRAINT [FK_Gastos_Usuarios_idUsuario] FOREIGN KEY([idUsuario])
REFERENCES [dbo].[Usuarios] ([idUsuario])
GO
ALTER TABLE [dbo].[Gastos] CHECK CONSTRAINT [FK_Gastos_Usuarios_idUsuario]
GO
ALTER TABLE [dbo].[Usuarios]  WITH NOCHECK ADD  CONSTRAINT [FK_Usuarios_Departamentos_idDepto] FOREIGN KEY([idDepto])
REFERENCES [dbo].[Departamentos] ([idDepto])
GO
ALTER TABLE [dbo].[Usuarios] CHECK CONSTRAINT [FK_Usuarios_Departamentos_idDepto]
GO
USE [master]
GO
ALTER DATABASE [DBSeguimientoGastos] SET  READ_WRITE 
GO
