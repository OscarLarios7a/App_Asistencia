USE [master]
GO
/****** Object:  Database [AppAsistencia]    Script Date: 17/10/2020 10:55:19 p.m. ******/
CREATE DATABASE [AppAsistencia]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'AppAsistencia', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\AppAsistencia.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'AppAsistencia_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\AppAsistencia_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [AppAsistencia] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [AppAsistencia].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [AppAsistencia] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [AppAsistencia] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [AppAsistencia] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [AppAsistencia] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [AppAsistencia] SET ARITHABORT OFF 
GO
ALTER DATABASE [AppAsistencia] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [AppAsistencia] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [AppAsistencia] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [AppAsistencia] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [AppAsistencia] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [AppAsistencia] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [AppAsistencia] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [AppAsistencia] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [AppAsistencia] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [AppAsistencia] SET  DISABLE_BROKER 
GO
ALTER DATABASE [AppAsistencia] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [AppAsistencia] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [AppAsistencia] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [AppAsistencia] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [AppAsistencia] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [AppAsistencia] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [AppAsistencia] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [AppAsistencia] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [AppAsistencia] SET  MULTI_USER 
GO
ALTER DATABASE [AppAsistencia] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [AppAsistencia] SET DB_CHAINING OFF 
GO
ALTER DATABASE [AppAsistencia] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [AppAsistencia] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [AppAsistencia] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [AppAsistencia] SET QUERY_STORE = OFF
GO
USE [AppAsistencia]
GO
/****** Object:  Table [dbo].[Cargo]    Script Date: 17/10/2020 10:55:20 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cargo](
	[Id_cargo] [int] IDENTITY(1,1) NOT NULL,
	[Cargo] [varchar](max) NULL,
	[SueldoPorHora] [numeric](18, 2) NULL,
 CONSTRAINT [PK_Cargo] PRIMARY KEY CLUSTERED 
(
	[Id_cargo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Personal]    Script Date: 17/10/2020 10:55:20 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personal](
	[Id_personal] [int] IDENTITY(1,1) NOT NULL,
	[Nombres] [varchar](max) NULL,
	[Identificacion] [varchar](max) NULL,
	[Pais] [varchar](max) NULL,
	[Id_cargo] [int] NULL,
	[SueldoPorHora] [numeric](18, 2) NULL,
	[Estado] [varchar](max) NULL,
	[codigo] [varchar](max) NULL,
 CONSTRAINT [PK_Personal] PRIMARY KEY CLUSTERED 
(
	[Id_personal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Personal]  WITH CHECK ADD  CONSTRAINT [FK_Personal_Cargo] FOREIGN KEY([Id_cargo])
REFERENCES [dbo].[Cargo] ([Id_cargo])
GO
ALTER TABLE [dbo].[Personal] CHECK CONSTRAINT [FK_Personal_Cargo]
GO
/****** Object:  StoredProcedure [dbo].[editarPersonal]    Script Date: 17/10/2020 10:55:20 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[editarPersonal]
@Id_personal int,
@Nombres as varchar(max),
@Identificacion varchar(max),
@Pais varchar(max),
@Id_cargo int,
@Sueldo_por_hora numeric(18,2)
as
if Exists(Select Identificacion from Personal where Identificacion=@Identificacion and Id_personal <>@Id_personal)
Raiserror('Ya existe un registro con esta Identificacion',16,1)
else
Update Personal set
Nombres=@Nombres ,Identificacion=@Identificacion,Pais=@Pais,Id_cargo =@Id_cargo ,SueldoPorHora =@Sueldo_por_hora 
where Id_personal=@Id_personal
GO
/****** Object:  StoredProcedure [dbo].[InsertarPersonal]    Script Date: 17/10/2020 10:55:20 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[InsertarPersonal]
@Nombres varchar(max),
@Identificacion varchar(max),
@Pais varchar(max),
@Id_cargo int,
@SueldoPorHora numeric(18,2)
as
declare @Estado varchar(max)
declare @codigo varchar(max)
declare @Id_personal int
set @Estado='ACTIVO'
set @codigo='-'
if Exists(select Identificacion from Personal where Identificacion=@Identificacion)
Raiserror('Ya existe un registro con esta Identificacion',16,1)
else
Insert into Personal 
values(@Nombres ,
@Identificacion,
@Pais ,
@Id_cargo ,
@SueldoPorHora ,
@Estado ,
@codigo )
Select @Id_personal=scope_identity()
Update Personal set codigo = @Id_personal
GO
/****** Object:  StoredProcedure [dbo].[mostrarPersonal]    Script Date: 17/10/2020 10:55:20 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[mostrarPersonal]
@Desde int,
@Hasta int
as
Set Nocount On;
Select 
Id_personal,Nombres,Identificacion,SueldoPorHora,Cargo,Id_cargo,Estado,codigo
from
(Select Id_personal ,Nombres,Identificacion,Personal.SueldoPorHora,Cargo.Cargo,Personal.Id_cargo,Estado,codigo,
Row_Number() Over(Order by Id_personal) 'Numero_de_fila'
from Personal
inner join Cargo on Cargo.Id_cargo=Personal.Id_cargo ) as Paginado
Where (Paginado.Numero_de_fila >=@Desde) and (Paginado.Numero_de_fila<=@Hasta)
GO
USE [master]
GO
ALTER DATABASE [AppAsistencia] SET  READ_WRITE 
GO
/**Se crea el proceso para la eliminacion  de datos de la tabla de Personal**/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc eliminarPersonal
@IdPersonal int
as
Update Personal set Estado= 'Eliminado'
where Id_personal=@IdPersonal
GO
USE [master]
GO
ALTER DATABASE [AppAsistencia] SET  READ_WRITE 
GO
/**Proceso para la Busqueda de datos en la tabla de personal sea nombre o identificacion**/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc BuscarPersonal
@Desde int,
@Hasta int,
@Buscador varchar(50)
as
Set Nocount On;
Select 
Id_personal,Nombres,Identificacion,SueldoPorHora,Cargo,Id_cargo,Estado,codigo
from
(Select Id_personal ,Nombres,Identificacion,Personal.SueldoPorHora,Cargo.Cargo,Personal.Id_cargo,Estado,codigo,
Row_Number() Over(Order by Id_personal) 'Numero_de_fila'
from Personal
inner join Cargo on Cargo.Id_cargo=Personal.Id_cargo ) as Paginado
Where (Paginado.Numero_de_fila >=@Desde) and (Paginado.Numero_de_fila<=@Hasta)
and (Nombres + Identificacion Like '%' + @Buscador + '%')
GO
USE [master]
GO
ALTER DATABASE [AppAsistencia] SET  READ_WRITE 
GO