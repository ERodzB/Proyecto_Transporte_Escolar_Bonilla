USE [master]
GO
/****** Object:  Database [Transporte_Bonilla]    Script Date: 2019-08-04 3:05:08 PM ******/
CREATE DATABASE [Transporte_Bonilla]
 CONTAINMENT = NONE
/*ON  PRIMARY 
( NAME = N'Transporte_Bonilla', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Transporte_Bonilla.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
LOG ON 
( NAME = N'Transporte_Bonilla_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Transporte_Bonilla_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO*/
ALTER DATABASE [Transporte_Bonilla] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Transporte_Bonilla].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Transporte_Bonilla] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Transporte_Bonilla] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Transporte_Bonilla] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Transporte_Bonilla] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Transporte_Bonilla] SET ARITHABORT OFF 
GO
ALTER DATABASE [Transporte_Bonilla] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Transporte_Bonilla] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Transporte_Bonilla] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Transporte_Bonilla] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Transporte_Bonilla] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Transporte_Bonilla] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Transporte_Bonilla] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Transporte_Bonilla] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Transporte_Bonilla] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Transporte_Bonilla] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Transporte_Bonilla] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Transporte_Bonilla] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Transporte_Bonilla] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Transporte_Bonilla] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Transporte_Bonilla] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Transporte_Bonilla] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Transporte_Bonilla] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Transporte_Bonilla] SET RECOVERY FULL 
GO
ALTER DATABASE [Transporte_Bonilla] SET  MULTI_USER 
GO
ALTER DATABASE [Transporte_Bonilla] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Transporte_Bonilla] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Transporte_Bonilla] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Transporte_Bonilla] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Transporte_Bonilla] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Transporte_Bonilla', N'ON'
GO
ALTER DATABASE [Transporte_Bonilla] SET QUERY_STORE = OFF
GO
USE [Transporte_Bonilla]
GO
/****** Object:  Table [dbo].[Acceso]    Script Date: 2019-08-04 3:05:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Acceso](
	[Codigo_Acceso] [int] NOT NULL,
	[Tipo_Acceso] [varchar](100) NOT NULL,
	[Descripcion_Acceso] [varchar](200) NULL,
 CONSTRAINT [PK_Acceso] PRIMARY KEY CLUSTERED 
(
	[Codigo_Acceso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categoria]    Script Date: 2019-08-04 3:05:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categoria](
	[Codigo_Categoria] [varchar](50) NOT NULL,
	[Nombre_Categoria] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Categoria] PRIMARY KEY CLUSTERED 
(
	[Codigo_Categoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 2019-08-04 3:05:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[Codigo_Cliente] [varchar](50) NOT NULL,
	[Nombre_Cliente] [varchar](100) NOT NULL,
	[Direccion_Cliente] [varchar](200) NOT NULL,
	[Telefono_Cliente] [varchar](20) NOT NULL,
	[Correo_Cliente] [varchar](100) NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[Codigo_Cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Contratos]    Script Date: 2019-08-04 3:05:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contratos](
	[Codigo_Contrato] [varchar](50) NOT NULL,
	[Cliente_Contrato] [varchar](50) NOT NULL,
	[Tipo_Contrato] [int] NOT NULL,
	[Monto Mensual] [money] NULL,
	[Cuotas_Mensuales] [int] NULL,
	[Servicio] [varchar](50) NULL,
	[Anticipo] [money] NULL,
	[Fecha_Inicio_Contrato] [date] NOT NULL,
	[Monto_Contrato] [money] NOT NULL,
	[Fecha_Vencimiento] [date] NOT NULL,
	[Estado_Contrato] [int] NOT NULL,
	[Cod_Documento] [varchar](50) NOT NULL,
	[Tipo_Pago] [int] NOT NULL,
 CONSTRAINT [PK_Contratos] PRIMARY KEY CLUSTERED 
(
	[Codigo_Contrato] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Documentos]    Script Date: 2019-08-04 3:05:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Documentos](
	[Codigo_Documento] [varchar](50) NOT NULL,
	[Nombre_Documento] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Documentos] PRIMARY KEY CLUSTERED 
(
	[Codigo_Documento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Documentos_Relacion]    Script Date: 2019-08-04 3:05:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Documentos_Relacion](
	[Codigo_Documento] [varchar](50) NOT NULL,
	[Identidad_Empleado] [varchar](50) NOT NULL,
	[Estado_Documento] [int] NOT NULL,
	[Documento] [varchar](200) NOT NULL,
	[Fecha_Emision] [date] NOT NULL,
	[Fecha_Vencimiento] [date] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleado]    Script Date: 2019-08-04 3:05:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleado](
	[Identidad_Empleado] [varchar](50) NOT NULL,
	[Nombre_Empleado] [varchar](100) NOT NULL,
	[Fecha_Nacimiento] [date] NOT NULL,
	[Genero] [int] NOT NULL,
	[Telefono] [varchar](20) NOT NULL,
	[Correo] [varchar](100) NULL,
	[Direccion] [varchar](200) NOT NULL,
	[Puesto_Empleado] [int] NOT NULL,
	[Salario] [money] NOT NULL,
	[Licencia] [varchar](50) NULL,
	[Fecha_Vencimiento_Licencia] [date] NULL,
	[Tipo_Licencia] [int] NULL,
 CONSTRAINT [PK_Empleado] PRIMARY KEY CLUSTERED 
(
	[Identidad_Empleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Estado]    Script Date: 2019-08-04 3:05:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estado](
	[Codigo_Estado] [int] NOT NULL,
	[Codigo_Categoria] [varchar](50) NOT NULL,
	[Nombre_Estado] [varchar](100) NOT NULL,
	[Descripcion_Estado] [varchar](200) NULL,
 CONSTRAINT [PK_Estado] PRIMARY KEY CLUSTERED 
(
	[Codigo_Estado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Eventos]    Script Date: 2019-08-04 3:05:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Eventos](
	[CodEvento] [varchar](50) NOT NULL,
	[TipoEvento] [int] NOT NULL,
	[FechaEvento] [date] NOT NULL,
	[Dato1] [varchar](100) NULL,
	[Dato2] [varchar](100) NULL,
	[Dato3] [varchar](100) NULL,
	[Dato4] [varchar](100) NULL,
	[Dato5] [varchar](100) NULL,
	[Dato6] [varchar](100) NULL,
 CONSTRAINT [PK_Eventos] PRIMARY KEY CLUSTERED 
(
	[CodEvento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Genero]    Script Date: 2019-08-04 3:05:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Genero](
	[CodGenero] [int] NOT NULL,
	[Genero] [varchar](50) NOT NULL,
	[Descripcion_Genero] [varchar](200) NOT NULL,
 CONSTRAINT [PK_Genero] PRIMARY KEY CLUSTERED 
(
	[CodGenero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mantenimientos]    Script Date: 2019-08-04 3:05:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mantenimientos](
	[Codigo_Mantenimiento] [int] NOT NULL,
	[Tipo_Mantenimiento] [int] NOT NULL,
	[Fecha_Mantenimiento] [date] NOT NULL,
	[Codigo_Vehiculo] [varchar](50) NOT NULL,
	[Costo_Mantenimiento] [money] NOT NULL,
 CONSTRAINT [PK_Mantenimientos] PRIMARY KEY CLUSTERED 
(
	[Codigo_Mantenimiento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Perfiles]    Script Date: 2019-08-04 3:05:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Perfiles](
	[Codigo_Perfil] [int] NOT NULL,
	[Nivel_Acceso] [int] NOT NULL,
	[Nombre_Perfil] [varchar](100) NOT NULL,
	[Descripcion_Perfil] [varchar](200) NULL,
 CONSTRAINT [PK_Perfiles] PRIMARY KEY CLUSTERED 
(
	[Codigo_Perfil] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Puesto]    Script Date: 2019-08-04 3:05:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Puesto](
	[Codigo_Puesto] [int] NOT NULL,
	[Nombre_Puesto] [varchar](100) NOT NULL,
	[Descripcion_Puesto] [varchar](200) NULL,
 CONSTRAINT [PK_Puesto] PRIMARY KEY CLUSTERED 
(
	[Codigo_Puesto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Recibos]    Script Date: 2019-08-04 3:05:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Recibos](
	[Num_Recibo] [int] NOT NULL,
	[Numero_de_Cuota] [int] NULL,
	[Codigo_Contrato] [varchar](50) NOT NULL,
	[Codigo_Documento] [varchar](50) NOT NULL,
	[Fecha_Recibo] [date] NOT NULL,
	[Monto] [money] NOT NULL,
	[Numero_CAI] [varchar](50) NOT NULL,
	[Descripcion de Recibo] [varchar](200) NULL,
 CONSTRAINT [PK_Recibos] PRIMARY KEY CLUSTERED 
(
	[Num_Recibo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rutas]    Script Date: 2019-08-04 3:05:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rutas](
	[Codigo_Ruta] [varchar](50) NOT NULL,
	[Nombre_Ruta] [varchar](100) NOT NULL,
	[Descripcion_Ruta] [varchar](200) NULL,
	[Tipo_Ruta] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Rutas] PRIMARY KEY CLUSTERED 
(
	[Codigo_Ruta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rutas_Contratos]    Script Date: 2019-08-04 3:05:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rutas_Contratos](
	[Codigo_Ruta] [varchar](50) NOT NULL,
	[Codigo_Contrato] [varchar](50) NOT NULL,
	[Parada_Contrato] [varchar](100) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tipo_Mantenimientos]    Script Date: 2019-08-04 3:05:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipo_Mantenimientos](
	[Codigo_Tipo_Mantenimiento] [int] NOT NULL,
	[Nombre_Mantenimiento] [varchar](100) NOT NULL,
	[Descripcion_Mantenimiento] [varchar](200) NULL,
 CONSTRAINT [PK_Tipo_Mantenimientos] PRIMARY KEY CLUSTERED 
(
	[Codigo_Tipo_Mantenimiento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tipo_Pago]    Script Date: 2019-08-04 3:05:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipo_Pago](
	[TipoPago] [int] NOT NULL,
	[NombrePago] [varchar](100) NOT NULL,
	[DescripcionPago] [varchar](200) NOT NULL,
 CONSTRAINT [PK_Tipo_Pago] PRIMARY KEY CLUSTERED 
(
	[TipoPago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tipo_Ruta]    Script Date: 2019-08-04 3:05:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipo_Ruta](
	[Tipo_Ruta] [varchar](50) NOT NULL,
	[Descripcion_Tipo_Ruta] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Tipo_Ruta] PRIMARY KEY CLUSTERED 
(
	[Tipo_Ruta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoContrato]    Script Date: 2019-08-04 3:05:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoContrato](
	[Cod_Contrato] [int] NOT NULL,
	[Tipo_Contrato] [varchar](100) NOT NULL,
	[Descripcion_Contrato] [varchar](200) NULL,
 CONSTRAINT [PK_TipoContrato] PRIMARY KEY CLUSTERED 
(
	[Cod_Contrato] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoEvento]    Script Date: 2019-08-04 3:05:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoEvento](
	[CodTipoEvento] [int] NOT NULL,
	[TipoEvento] [varchar](50) NOT NULL,
 CONSTRAINT [PK_TipoEvento] PRIMARY KEY CLUSTERED 
(
	[CodTipoEvento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoGasolina]    Script Date: 2019-08-04 3:05:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoGasolina](
	[CodGasolina] [int] NOT NULL,
	[NombreGasolina] [varchar](50) NOT NULL,
	[DescripcionGasolina] [varchar](200) NULL,
 CONSTRAINT [PK_TipoGasolina] PRIMARY KEY CLUSTERED 
(
	[CodGasolina] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoLicencia]    Script Date: 2019-08-04 3:05:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoLicencia](
	[CodTipoLicencia] [int] NOT NULL,
	[TipoLicencia] [varchar](50) NOT NULL,
 CONSTRAINT [PK_TipoLicencia] PRIMARY KEY CLUSTERED 
(
	[CodTipoLicencia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoServicio]    Script Date: 2019-08-04 3:05:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoServicio](
	[TipoServicio] [varchar](50) NOT NULL,
	[Descripcion] [varchar](100) NOT NULL,
 CONSTRAINT [PK_TipoServicio] PRIMARY KEY CLUSTERED 
(
	[TipoServicio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoTransmision]    Script Date: 2019-08-04 3:05:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoTransmision](
	[CodTransmision] [int] NOT NULL,
	[NombreTransmision] [varchar](50) NOT NULL,
	[DescripcionTransmision] [varchar](200) NULL,
 CONSTRAINT [PK_TipoTransmision] PRIMARY KEY CLUSTERED 
(
	[CodTransmision] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoVehiculo]    Script Date: 2019-08-04 3:05:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoVehiculo](
	[CodVehiculo] [int] NOT NULL,
	[Tipo_Vehiculo] [varchar](50) NOT NULL,
	[Descripcion_Tipo_Vehiculo] [varchar](200) NULL,
 CONSTRAINT [PK_TipoVehiculo] PRIMARY KEY CLUSTERED 
(
	[CodVehiculo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 2019-08-04 3:05:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[Codigo_Empleado] [varchar](50) NOT NULL,
	[Nombre_Usuario] [varchar](100) NOT NULL,
	[Contrasena_Usuario] [varchar](100) NOT NULL,
	[Perfil_Acceso] [int] NOT NULL,
	[Estado_Usuario] [int] NOT NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[Nombre_Usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vehiculos]    Script Date: 2019-08-04 3:05:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vehiculos](
	[Codigo_Vehiculo] [varchar](50) NOT NULL,
	[Tipo_Vehiculo] [int] NOT NULL,
	[Anio_Vehiculo] [int] NOT NULL,
	[Marca_Vehiculo] [varchar](100) NOT NULL,
	[Modelo_Vehiculo] [varchar](100) NOT NULL,
	[Capacidad_Vehiculo] [int] NOT NULL,
	[Transmision_Vehiculo] [int] NOT NULL,
	[Combustible_Vehiculo] [int] NOT NULL,
	[Color_Vehiculo] [varchar](100) NOT NULL,
	[Anio_Adquisicion] [int] NOT NULL,
	[Estado_Vehiculo] [int] NOT NULL,
	[Emision_Permiso] [date] NOT NULL,
	[Vencimiento_Permiso] [date] NOT NULL,
	[Responsable_Vehiculo] [varchar](50) NULL,
	[Matricula_Anterior_Vehiculo] [varchar](50) NULL,
 CONSTRAINT [PK_Vehiculos] PRIMARY KEY CLUSTERED 
(
	[Codigo_Vehiculo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vehiculos_Rutas]    Script Date: 2019-08-04 3:05:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vehiculos_Rutas](
	[Codigo_Ruta] [varchar](50) NOT NULL,
	[Codigo_Vehiculo] [varchar](50) NOT NULL,
	[Horario_Salida] [time](7) NOT NULL,
	[Horario_Entrada] [time](7) NOT NULL,
	[Cantidad_Pasajeros_Actuales] [int] NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Acceso] ADD  CONSTRAINT [DF_Acceso_Descripcion_Acceso]  DEFAULT ('Sin Especificar') FOR [Descripcion_Acceso]
GO
ALTER TABLE [dbo].[Cliente] ADD  CONSTRAINT [DF_Cliente_Correo_Cliente]  DEFAULT ('Sin Especificar') FOR [Correo_Cliente]
GO
ALTER TABLE [dbo].[Contratos] ADD  CONSTRAINT [DF_Contratos_Monto Mensual]  DEFAULT ((0)) FOR [Monto Mensual]
GO
ALTER TABLE [dbo].[Contratos] ADD  CONSTRAINT [DF_Contratos_Meses Pagados]  DEFAULT ((0)) FOR [Cuotas_Mensuales]
GO
ALTER TABLE [dbo].[Contratos] ADD  CONSTRAINT [DF_Contratos_Anticipo]  DEFAULT ((0)) FOR [Anticipo]
GO
ALTER TABLE [dbo].[Empleado] ADD  CONSTRAINT [DF_Empleado_Correo]  DEFAULT ('Sin Especificar') FOR [Correo]
GO
ALTER TABLE [dbo].[Estado] ADD  CONSTRAINT [DF_Estado_Descripcion_Estado]  DEFAULT ('Sin Especificar') FOR [Descripcion_Estado]
GO
ALTER TABLE [dbo].[Perfiles] ADD  CONSTRAINT [DF_Perfiles_Descripcion_Perfil]  DEFAULT ('Sin Especificar') FOR [Descripcion_Perfil]
GO
ALTER TABLE [dbo].[Puesto] ADD  CONSTRAINT [DF_Puesto_Descripcion_Puesto]  DEFAULT ('Sin Especificar') FOR [Descripcion_Puesto]
GO
ALTER TABLE [dbo].[Rutas] ADD  CONSTRAINT [DF_Rutas_Descripcion_Ruta]  DEFAULT ('Sin Especificar') FOR [Descripcion_Ruta]
GO
ALTER TABLE [dbo].[Tipo_Mantenimientos] ADD  CONSTRAINT [DF_Tipo_Mantenimientos_Descripcion_Mantenimiento]  DEFAULT ('Sin Especificar') FOR [Descripcion_Mantenimiento]
GO
ALTER TABLE [dbo].[TipoContrato] ADD  CONSTRAINT [DF_TipoContrato_Descripcion_Contrato]  DEFAULT ('Sin Especificar') FOR [Descripcion_Contrato]
GO
ALTER TABLE [dbo].[Contratos]  WITH CHECK ADD  CONSTRAINT [FK_Cod_Documento] FOREIGN KEY([Cod_Documento])
REFERENCES [dbo].[Documentos] ([Codigo_Documento])
GO
ALTER TABLE [dbo].[Contratos] CHECK CONSTRAINT [FK_Cod_Documento]
GO
ALTER TABLE [dbo].[Contratos]  WITH CHECK ADD  CONSTRAINT [FK_Contratos_Cliente] FOREIGN KEY([Cliente_Contrato])
REFERENCES [dbo].[Cliente] ([Codigo_Cliente])
GO
ALTER TABLE [dbo].[Contratos] CHECK CONSTRAINT [FK_Contratos_Cliente]
GO
ALTER TABLE [dbo].[Contratos]  WITH CHECK ADD  CONSTRAINT [FK_Contratos_Estado] FOREIGN KEY([Estado_Contrato])
REFERENCES [dbo].[Estado] ([Codigo_Estado])
GO
ALTER TABLE [dbo].[Contratos] CHECK CONSTRAINT [FK_Contratos_Estado]
GO
ALTER TABLE [dbo].[Contratos]  WITH CHECK ADD  CONSTRAINT [FK_Contratos_Tipo_Pago] FOREIGN KEY([Tipo_Pago])
REFERENCES [dbo].[Tipo_Pago] ([TipoPago])
GO
ALTER TABLE [dbo].[Contratos] CHECK CONSTRAINT [FK_Contratos_Tipo_Pago]
GO
ALTER TABLE [dbo].[Contratos]  WITH CHECK ADD  CONSTRAINT [FK_Contratos_TipoContrato] FOREIGN KEY([Tipo_Contrato])
REFERENCES [dbo].[TipoContrato] ([Cod_Contrato])
GO
ALTER TABLE [dbo].[Contratos] CHECK CONSTRAINT [FK_Contratos_TipoContrato]
GO
ALTER TABLE [dbo].[Contratos]  WITH CHECK ADD  CONSTRAINT [FK_Contratos_TipoServicio] FOREIGN KEY([Servicio])
REFERENCES [dbo].[TipoServicio] ([TipoServicio])
GO
ALTER TABLE [dbo].[Contratos] CHECK CONSTRAINT [FK_Contratos_TipoServicio]
GO
ALTER TABLE [dbo].[Documentos_Relacion]  WITH CHECK ADD  CONSTRAINT [FK_Documentos_Relacion_Documentos] FOREIGN KEY([Codigo_Documento])
REFERENCES [dbo].[Documentos] ([Codigo_Documento])
GO
ALTER TABLE [dbo].[Documentos_Relacion] CHECK CONSTRAINT [FK_Documentos_Relacion_Documentos]
GO
ALTER TABLE [dbo].[Documentos_Relacion]  WITH CHECK ADD  CONSTRAINT [FK_Documentos_Relacion_Empleado] FOREIGN KEY([Identidad_Empleado])
REFERENCES [dbo].[Empleado] ([Identidad_Empleado])
GO
ALTER TABLE [dbo].[Documentos_Relacion] CHECK CONSTRAINT [FK_Documentos_Relacion_Empleado]
GO
ALTER TABLE [dbo].[Documentos_Relacion]  WITH CHECK ADD  CONSTRAINT [FK_Documentos_Relacion_Estado] FOREIGN KEY([Estado_Documento])
REFERENCES [dbo].[Estado] ([Codigo_Estado])
GO
ALTER TABLE [dbo].[Documentos_Relacion] CHECK CONSTRAINT [FK_Documentos_Relacion_Estado]
GO
ALTER TABLE [dbo].[Empleado]  WITH CHECK ADD  CONSTRAINT [FK_Empleado_Genero] FOREIGN KEY([Genero])
REFERENCES [dbo].[Genero] ([CodGenero])
GO
ALTER TABLE [dbo].[Empleado] CHECK CONSTRAINT [FK_Empleado_Genero]
GO
ALTER TABLE [dbo].[Empleado]  WITH CHECK ADD  CONSTRAINT [FK_Empleado_Puesto] FOREIGN KEY([Puesto_Empleado])
REFERENCES [dbo].[Puesto] ([Codigo_Puesto])
GO
ALTER TABLE [dbo].[Empleado] CHECK CONSTRAINT [FK_Empleado_Puesto]
GO
ALTER TABLE [dbo].[Empleado]  WITH CHECK ADD  CONSTRAINT [FK_Empleado_Licencia] FOREIGN KEY([Tipo_Licencia])
REFERENCES [dbo].[TipoLicencia] ([CodTipoLicencia])
GO
ALTER TABLE [dbo].[Empleado] CHECK CONSTRAINT [FK_Empleado_Licencia]
GO
ALTER TABLE [dbo].[Estado]  WITH CHECK ADD  CONSTRAINT [FK_Estado_Categoria] FOREIGN KEY([Codigo_Categoria])
REFERENCES [dbo].[Categoria] ([Codigo_Categoria])
GO
ALTER TABLE [dbo].[Estado] CHECK CONSTRAINT [FK_Estado_Categoria]
GO
ALTER TABLE [dbo].[Eventos]  WITH CHECK ADD  CONSTRAINT [FK_Eventos_TipoEvento] FOREIGN KEY([TipoEvento])
REFERENCES [dbo].[TipoEvento] ([CodTipoEvento])
GO
ALTER TABLE [dbo].[Eventos] CHECK CONSTRAINT [FK_Eventos_TipoEvento]
GO
ALTER TABLE [dbo].[Mantenimientos]  WITH CHECK ADD  CONSTRAINT [FK_Mantenimientos_Tipo_Mantenimientos] FOREIGN KEY([Tipo_Mantenimiento])
REFERENCES [dbo].[Tipo_Mantenimientos] ([Codigo_Tipo_Mantenimiento])
GO
ALTER TABLE [dbo].[Mantenimientos] CHECK CONSTRAINT [FK_Mantenimientos_Tipo_Mantenimientos]
GO
ALTER TABLE [dbo].[Mantenimientos]  WITH CHECK ADD  CONSTRAINT [FK_Mantenimientos_Vehiculos] FOREIGN KEY([Codigo_Vehiculo])
REFERENCES [dbo].[Vehiculos] ([Codigo_Vehiculo])
GO
ALTER TABLE [dbo].[Mantenimientos] CHECK CONSTRAINT [FK_Mantenimientos_Vehiculos]
GO
ALTER TABLE [dbo].[Perfiles]  WITH CHECK ADD  CONSTRAINT [FK_Perfiles_Acceso] FOREIGN KEY([Nivel_Acceso])
REFERENCES [dbo].[Acceso] ([Codigo_Acceso])
GO
ALTER TABLE [dbo].[Perfiles] CHECK CONSTRAINT [FK_Perfiles_Acceso]
GO
ALTER TABLE [dbo].[Recibos]  WITH CHECK ADD  CONSTRAINT [FK_Codigo_Contrato] FOREIGN KEY([Codigo_Contrato])
REFERENCES [dbo].[Contratos] ([Codigo_Contrato])
GO
ALTER TABLE [dbo].[Recibos] CHECK CONSTRAINT [FK_Codigo_Contrato]
GO
ALTER TABLE [dbo].[Recibos]  WITH CHECK ADD  CONSTRAINT [FK_Codigo_Documento] FOREIGN KEY([Codigo_Documento])
REFERENCES [dbo].[Documentos] ([Codigo_Documento])
GO
ALTER TABLE [dbo].[Recibos] CHECK CONSTRAINT [FK_Codigo_Documento]
GO
ALTER TABLE [dbo].[Rutas]  WITH CHECK ADD  CONSTRAINT [FK_Rutas_Tipo_Ruta] FOREIGN KEY([Tipo_Ruta])
REFERENCES [dbo].[Tipo_Ruta] ([Tipo_Ruta])
GO
ALTER TABLE [dbo].[Rutas] CHECK CONSTRAINT [FK_Rutas_Tipo_Ruta]
GO
ALTER TABLE [dbo].[Rutas_Contratos]  WITH CHECK ADD  CONSTRAINT [FK_Rutas_Contratos_Contratos] FOREIGN KEY([Codigo_Contrato])
REFERENCES [dbo].[Contratos] ([Codigo_Contrato])
GO
ALTER TABLE [dbo].[Rutas_Contratos] CHECK CONSTRAINT [FK_Rutas_Contratos_Contratos]
GO
ALTER TABLE [dbo].[Rutas_Contratos]  WITH CHECK ADD  CONSTRAINT [FK_Rutas_Contratos_Rutas] FOREIGN KEY([Codigo_Ruta])
REFERENCES [dbo].[Rutas] ([Codigo_Ruta])
GO
ALTER TABLE [dbo].[Rutas_Contratos] CHECK CONSTRAINT [FK_Rutas_Contratos_Rutas]
GO
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD  CONSTRAINT [FK_Usuarios_Empleado] FOREIGN KEY([Codigo_Empleado])
REFERENCES [dbo].[Empleado] ([Identidad_Empleado])
GO
ALTER TABLE [dbo].[Usuarios] CHECK CONSTRAINT [FK_Usuarios_Empleado]
GO
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD  CONSTRAINT [FK_Usuarios_Perfiles] FOREIGN KEY([Perfil_Acceso])
REFERENCES [dbo].[Perfiles] ([Codigo_Perfil])
GO
ALTER TABLE [dbo].[Usuarios] CHECK CONSTRAINT [FK_Usuarios_Perfiles]
GO

ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD  CONSTRAINT [FK_Usuarios_Estado] FOREIGN KEY([Estado_Usuario])
REFERENCES [dbo].[Estado] ([Codigo_Estado])
GO
ALTER TABLE [dbo].[Usuarios] CHECK CONSTRAINT [FK_Usuarios_Estado]
GO

ALTER TABLE [dbo].[Vehiculos]  WITH CHECK ADD  CONSTRAINT [FK_Vehiculos_Empleado] FOREIGN KEY([Responsable_Vehiculo])
REFERENCES [dbo].[Empleado] ([Identidad_Empleado])
GO
ALTER TABLE [dbo].[Vehiculos] CHECK CONSTRAINT [FK_Vehiculos_Empleado]
GO
ALTER TABLE [dbo].[Vehiculos]  WITH CHECK ADD  CONSTRAINT [FK_Vehiculos_Estado] FOREIGN KEY([Estado_Vehiculo])
REFERENCES [dbo].[Estado] ([Codigo_Estado])
GO
ALTER TABLE [dbo].[Vehiculos] CHECK CONSTRAINT [FK_Vehiculos_Estado]
GO
ALTER TABLE [dbo].[Vehiculos]  WITH CHECK ADD  CONSTRAINT [FK_Vehiculos_TipoGasolina] FOREIGN KEY([Combustible_Vehiculo])
REFERENCES [dbo].[TipoGasolina] ([CodGasolina])
GO
ALTER TABLE [dbo].[Vehiculos] CHECK CONSTRAINT [FK_Vehiculos_TipoGasolina]
GO
ALTER TABLE [dbo].[Vehiculos]  WITH CHECK ADD  CONSTRAINT [FK_Vehiculos_TipoTransmision] FOREIGN KEY([Transmision_Vehiculo])
REFERENCES [dbo].[TipoTransmision] ([CodTransmision])
GO
ALTER TABLE [dbo].[Vehiculos] CHECK CONSTRAINT [FK_Vehiculos_TipoTransmision]
GO
ALTER TABLE [dbo].[Vehiculos]  WITH CHECK ADD  CONSTRAINT [FK_Vehiculos_TipoVehiculo] FOREIGN KEY([Tipo_Vehiculo])
REFERENCES [dbo].[TipoVehiculo] ([CodVehiculo])
GO
ALTER TABLE [dbo].[Vehiculos] CHECK CONSTRAINT [FK_Vehiculos_TipoVehiculo]
GO
ALTER TABLE [dbo].[Vehiculos_Rutas]  WITH CHECK ADD  CONSTRAINT [FK_Vehiculos_Rutas_Rutas] FOREIGN KEY([Codigo_Ruta])
REFERENCES [dbo].[Rutas] ([Codigo_Ruta])
GO
ALTER TABLE [dbo].[Vehiculos_Rutas] CHECK CONSTRAINT [FK_Vehiculos_Rutas_Rutas]
GO
ALTER TABLE [dbo].[Vehiculos_Rutas]  WITH CHECK ADD  CONSTRAINT [FK_Vehiculos_Rutas_Vehiculos] FOREIGN KEY([Codigo_Vehiculo])
REFERENCES [dbo].[Vehiculos] ([Codigo_Vehiculo])
GO
ALTER TABLE [dbo].[Vehiculos_Rutas] CHECK CONSTRAINT [FK_Vehiculos_Rutas_Vehiculos]
GO
USE [master]
GO
ALTER DATABASE [Transporte_Bonilla] SET  READ_WRITE 
GO
