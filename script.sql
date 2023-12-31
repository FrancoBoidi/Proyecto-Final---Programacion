USE [master]
GO
/****** Object:  Database [DB_BasePruebas]    Script Date: 03/07/2023 18:59:08 ******/
CREATE DATABASE [DB_BasePruebas]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DB_BasePruebas', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\DB_BasePruebas.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DB_BasePruebas_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\DB_BasePruebas_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [DB_BasePruebas] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DB_BasePruebas].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DB_BasePruebas] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DB_BasePruebas] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DB_BasePruebas] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DB_BasePruebas] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DB_BasePruebas] SET ARITHABORT OFF 
GO
ALTER DATABASE [DB_BasePruebas] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [DB_BasePruebas] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DB_BasePruebas] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DB_BasePruebas] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DB_BasePruebas] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DB_BasePruebas] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DB_BasePruebas] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DB_BasePruebas] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DB_BasePruebas] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DB_BasePruebas] SET  ENABLE_BROKER 
GO
ALTER DATABASE [DB_BasePruebas] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DB_BasePruebas] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DB_BasePruebas] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DB_BasePruebas] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DB_BasePruebas] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DB_BasePruebas] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DB_BasePruebas] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DB_BasePruebas] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DB_BasePruebas] SET  MULTI_USER 
GO
ALTER DATABASE [DB_BasePruebas] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DB_BasePruebas] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DB_BasePruebas] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DB_BasePruebas] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DB_BasePruebas] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DB_BasePruebas] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [DB_BasePruebas] SET QUERY_STORE = ON
GO
ALTER DATABASE [DB_BasePruebas] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [DB_BasePruebas]
GO
/****** Object:  Schema [SCH_GENERAL]    Script Date: 03/07/2023 18:59:09 ******/
CREATE SCHEMA [SCH_GENERAL]
GO
/****** Object:  UserDefinedTableType [dbo].[Detalle]    Script Date: 03/07/2023 18:59:09 ******/
CREATE TYPE [dbo].[Detalle] AS TABLE(
	[id] [int] NOT NULL,
	[Descripcion] [text] NULL,
	[HorasEstimadas] [int] NULL,
	[CostoEstimado] [numeric](18, 2) NULL,
	[HorasReales] [int] NULL,
	[CostoReal] [numeric](18, 2) NULL,
	[FechaFinal] [date] NULL,
	[Estado] [int] NULL,
	PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (IGNORE_DUP_KEY = OFF)
)
GO
/****** Object:  Table [dbo].[Empleado]    Script Date: 03/07/2023 18:59:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleado](
	[legajo] [int] IDENTITY(1,1) NOT NULL,
	[fecha_ingreso] [date] NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[apellido] [nvarchar](50) NOT NULL,
	[celular] [nvarchar](50) NOT NULL,
	[email] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Empleado] PRIMARY KEY CLUSTERED 
(
	[legajo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Funcion]    Script Date: 03/07/2023 18:59:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Funcion](
	[id_funcion] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Funcion] PRIMARY KEY CLUSTERED 
(
	[id_funcion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[observacion]    Script Date: 03/07/2023 18:59:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[observacion](
	[id_observacion] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [date] NOT NULL,
	[observacion] [text] NOT NULL,
	[legajo_FK] [int] NOT NULL,
 CONSTRAINT [PK_observaciones] PRIMARY KEY CLUSTERED 
(
	[id_observacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Propietario]    Script Date: 03/07/2023 18:59:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Propietario](
	[id_propietario] [int] IDENTITY(1,1) NOT NULL,
	[razon_social] [nvarchar](150) NOT NULL,
	[telefono] [nvarchar](50) NOT NULL,
	[email] [nvarchar](100) NOT NULL,
	[cuit] [bigint] NOT NULL,
	[persona_contacto] [nvarchar](250) NOT NULL,
 CONSTRAINT [PK_Propietario] PRIMARY KEY CLUSTERED 
(
	[id_propietario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proyecto]    Script Date: 03/07/2023 18:59:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proyecto](
	[id_proyecto] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](150) NOT NULL,
	[monto_estimado] [numeric](18, 2) NOT NULL,
	[tiempo_estimado] [int] NOT NULL,
	[id_propietario_FK] [int] NOT NULL,
	[legajo_FK] [int] NOT NULL,
 CONSTRAINT [PK_Proyecto] PRIMARY KEY CLUSTERED 
(
	[id_proyecto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tarea]    Script Date: 03/07/2023 18:59:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tarea](
	[id_proyecto] [int] NOT NULL,
	[nro_tarea] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [text] NOT NULL,
	[horas_estimadas] [int] NOT NULL,
	[costo_estimado] [numeric](18, 2) NOT NULL,
	[horas_reales] [int] NULL,
	[costo_real] [numeric](18, 2) NULL,
	[fecha_final] [date] NULL,
	[estado] [int] NULL,
 CONSTRAINT [PK_Tarea] PRIMARY KEY CLUSTERED 
(
	[id_proyecto] ASC,
	[nro_tarea] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Trabaja]    Script Date: 03/07/2023 18:59:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Trabaja](
	[legajo] [int] NOT NULL,
	[id_proyecto] [int] NOT NULL,
	[id_tarea] [int] NOT NULL,
	[id_funcion_fk] [int] NOT NULL,
 CONSTRAINT [PK_Trabaja] PRIMARY KEY CLUSTERED 
(
	[legajo] ASC,
	[id_proyecto] ASC,
	[id_tarea] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UK_Trabaja] UNIQUE NONCLUSTERED 
(
	[legajo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[observacion]  WITH CHECK ADD  CONSTRAINT [FK_observacion_Empleado] FOREIGN KEY([legajo_FK])
REFERENCES [dbo].[Empleado] ([legajo])
GO
ALTER TABLE [dbo].[observacion] CHECK CONSTRAINT [FK_observacion_Empleado]
GO
ALTER TABLE [dbo].[Proyecto]  WITH CHECK ADD  CONSTRAINT [FK_Proyecto_Empleado] FOREIGN KEY([legajo_FK])
REFERENCES [dbo].[Empleado] ([legajo])
GO
ALTER TABLE [dbo].[Proyecto] CHECK CONSTRAINT [FK_Proyecto_Empleado]
GO
ALTER TABLE [dbo].[Proyecto]  WITH CHECK ADD  CONSTRAINT [FK_Proyecto_Propietario] FOREIGN KEY([id_propietario_FK])
REFERENCES [dbo].[Propietario] ([id_propietario])
GO
ALTER TABLE [dbo].[Proyecto] CHECK CONSTRAINT [FK_Proyecto_Propietario]
GO
ALTER TABLE [dbo].[Tarea]  WITH CHECK ADD  CONSTRAINT [FK_Tarea_Proyecto] FOREIGN KEY([id_proyecto])
REFERENCES [dbo].[Proyecto] ([id_proyecto])
GO
ALTER TABLE [dbo].[Tarea] CHECK CONSTRAINT [FK_Tarea_Proyecto]
GO
ALTER TABLE [dbo].[Trabaja]  WITH CHECK ADD  CONSTRAINT [FK_Trabaja_Empleado] FOREIGN KEY([legajo])
REFERENCES [dbo].[Empleado] ([legajo])
GO
ALTER TABLE [dbo].[Trabaja] CHECK CONSTRAINT [FK_Trabaja_Empleado]
GO
ALTER TABLE [dbo].[Trabaja]  WITH CHECK ADD  CONSTRAINT [FK_Trabaja_Funcion] FOREIGN KEY([id_funcion_fk])
REFERENCES [dbo].[Funcion] ([id_funcion])
GO
ALTER TABLE [dbo].[Trabaja] CHECK CONSTRAINT [FK_Trabaja_Funcion]
GO
/****** Object:  StoredProcedure [dbo].[SP_Empleado_Agregar]    Script Date: 03/07/2023 18:59:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_Empleado_Agregar]
 
 (@fecha_ingreso date
 , @nombre nvarchar(50)
 ,@apellido nvarchar(50)
 ,@celular nvarchar(50)
 ,@email nvarchar(50)
  )
as
begin  

INSERT INTO [dbo].[Empleado]
           ([fecha_ingreso]
           ,[nombre]
           ,[apellido]
           ,[celular]
           ,[email])
     VALUES
           (@fecha_ingreso
           ,@nombre
           ,@apellido
           ,@celular
           ,@email)

SELECT SCOPE_IDENTITY()

end

GO
/****** Object:  StoredProcedure [dbo].[SP_Empleado_CargarCombo]    Script Date: 03/07/2023 18:59:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[SP_Empleado_CargarCombo]
as 

begin

SELECT [legajo]
      ,[nombre]

  FROM [dbo].[Empleado]	



end

GO
/****** Object:  StoredProcedure [dbo].[SP_Empleado_Eliminar]    Script Date: 03/07/2023 18:59:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SP_Empleado_Eliminar]

(@legajo int)
as
begin  

DELETE
  FROM [dbo].[Empleado]	where legajo = @legajo
	
	select 1

end

GO
/****** Object:  StoredProcedure [dbo].[SP_Empleado_Index]    Script Date: 03/07/2023 18:59:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[SP_Empleado_Index]

as
begin  

SELECT [legajo]
      ,[fecha_ingreso]
      ,[nombre]
      ,[apellido]
      ,[celular]
      ,[email]
  FROM [dbo].[Empleado]	

end
GO
/****** Object:  StoredProcedure [dbo].[SP_Empleado_Modificar]    Script Date: 03/07/2023 18:59:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_Empleado_Modificar]
 
 (@legajo int
 ,@fecha_ingreso date
 , @nombre nvarchar(50)
 ,@apellido nvarchar(50)
 ,@celular nvarchar(50)
 ,@email nvarchar(50)
  )
as
begin  

UPDATE [dbo].[Empleado]
   SET [fecha_ingreso] = @fecha_ingreso
      ,[nombre] = @nombre
      ,[apellido] = @apellido
      ,[celular] = @celular
      ,[email] = @email
 WHERE legajo = @legajo

select 1


end

GO
/****** Object:  StoredProcedure [dbo].[SP_Empleado_Seleccionar]    Script Date: 03/07/2023 18:59:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_Empleado_Seleccionar]

(@legajo int)
as
begin  

SELECT [legajo]
      ,[fecha_ingreso]
      ,[nombre]
      ,[apellido]
      ,[celular]
      ,[email]
  FROM [dbo].[Empleado]	where legajo = @legajo

end

GO
/****** Object:  StoredProcedure [dbo].[SP_Funcion_Agregar]    Script Date: 03/07/2023 18:59:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SP_Funcion_Agregar]

(@descripcion nvarchar(50))
as 
begin 

INSERT INTO [dbo].[Funcion]
           ([descripcion])
     VALUES
           (@descripcion)
	SELECT SCOPE_IDENTITY()

end
GO
/****** Object:  StoredProcedure [dbo].[SP_Funcion_Eliminar]    Script Date: 03/07/2023 18:59:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_Funcion_Eliminar]

(@id_funcion int)

as 
begin

DELETE FROM [dbo].[Funcion]
      WHERE id_funcion = @id_funcion

	  select 1

end 

GO
/****** Object:  StoredProcedure [dbo].[SP_Funcion_Index]    Script Date: 03/07/2023 18:59:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[SP_Funcion_Index]

as 
begin 

SELECT [id_funcion]
      ,[descripcion]
  FROM [dbo].[Funcion]


end

GO
/****** Object:  StoredProcedure [dbo].[SP_Funcion_Modificar]    Script Date: 03/07/2023 18:59:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_Funcion_Modificar]

(@id_funcion int
,@descripcion nvarchar(50))
as 
begin 

UPDATE [dbo].[Funcion]
   SET [descripcion] = @descripcion
 WHERE id_funcion = @id_funcion
	select 1

end

GO
/****** Object:  StoredProcedure [dbo].[SP_Funcion_Seleccionar]    Script Date: 03/07/2023 18:59:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[SP_Funcion_Seleccionar]

(
	@id_funcion int
)

as 

begin

SELECT [id_funcion]
      ,[descripcion]
  FROM [dbo].[Funcion] where id_funcion = @id_funcion

end
GO
/****** Object:  StoredProcedure [dbo].[SP_Observacion_Agregar]    Script Date: 03/07/2023 18:59:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SP_Observacion_Agregar]

(
	
    @fecha date
    ,@observacion text
    ,@legajo_FK int

)

as

begin

INSERT INTO [dbo].[observacion]
           (
           [fecha]
           ,[observacion]
           ,[legajo_FK])
     VALUES
           (
			@fecha
           ,@observacion
           ,@legajo_FK)

	SELECT SCOPE_IDENTITY()
end
GO
/****** Object:  StoredProcedure [dbo].[SP_Observacion_Eliminar]    Script Date: 03/07/2023 18:59:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE procedure [dbo].[SP_Observacion_Eliminar]

 (@id_observacion int)
 as

 begin

 DELETE FROM [dbo].[observacion]
      WHERE id_observacion = @id_observacion

select 1

 end
GO
/****** Object:  StoredProcedure [dbo].[SP_Observacion_Index]    Script Date: 03/07/2023 18:59:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[SP_Observacion_Index]

as 

begin

SELECT [id_observacion]
      ,[fecha]
      ,[observacion]
      ,[legajo_FK]
  FROM [dbo].[observacion]

end
GO
/****** Object:  StoredProcedure [dbo].[SP_Observacion_Modificar]    Script Date: 03/07/2023 18:59:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SP_Observacion_Modificar]

(
	
	@id_observacion int
    ,@fecha date
    ,@observacion text
    ,@legajo_FK int

)

as

begin

UPDATE [dbo].[observacion]
   SET [fecha] = @fecha
      ,[observacion] = @observacion
      ,[legajo_FK] = @legajo_FK
 WHERE id_observacion = @id_observacion

 select 1

 end
GO
/****** Object:  StoredProcedure [dbo].[SP_Observacion_Seleccionar]    Script Date: 03/07/2023 18:59:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SP_Observacion_Seleccionar]

( @id_observacion int)

as

begin

SELECT [id_observacion]
      ,[fecha]
      ,[observacion]
      ,[legajo_FK]
  FROM [dbo].[observacion] where id_observacion = @id_observacion



end
GO
/****** Object:  StoredProcedure [dbo].[SP_Propietario_Agregar]    Script Date: 03/07/2023 18:59:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SP_Propietario_Agregar]
(
@razon_social nvarchar(150)
,@telefono nvarchar(50)
,@email nvarchar(100)
,@cuit bigint
,@persona_contacto  nvarchar(250)
)


as 
begin

INSERT INTO [dbo].[Propietario]
           ([razon_social]
           ,[telefono]
           ,[email]
           ,[cuit]
           ,[persona_contacto])
     VALUES
           (@razon_social
           ,@telefono
           ,@email
           ,@cuit
           ,@persona_contacto)

SELECT SCOPE_IDENTITY()

end
GO
/****** Object:  StoredProcedure [dbo].[SP_Propietario_CargarCombo]    Script Date: 03/07/2023 18:59:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[SP_Propietario_CargarCombo]

as 

begin

SELECT [id_propietario]
      ,[razon_social]

	  FROM [dbo].[Propietario]

end 

GO
/****** Object:  StoredProcedure [dbo].[SP_Propietario_Eliminar]    Script Date: 03/07/2023 18:59:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SP_Propietario_Eliminar]
(
@id_propietario int
)
as 
begin

DELETE FROM [dbo].[Propietario]
      WHERE id_propietario = @id_propietario

	  select 1
end
GO
/****** Object:  StoredProcedure [dbo].[SP_Propietario_Index]    Script Date: 03/07/2023 18:59:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[SP_Propietario_Index]

as 
begin

SELECT [id_propietario]
      ,[razon_social]
      ,[telefono]
      ,[email]
      ,[cuit]
      ,[persona_contacto]
  FROM [dbo].[Propietario]

end

GO
/****** Object:  StoredProcedure [dbo].[SP_Propietario_Modificar]    Script Date: 03/07/2023 18:59:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SP_Propietario_Modificar]
(
@id_propietario int
,@razon_social nvarchar(150)
,@telefono nvarchar(50)
,@email nvarchar(100)
,@cuit bigint
,@persona_contacto  nvarchar(250)
)


as 
begin

UPDATE [dbo].[Propietario]
   SET [razon_social] = @razon_social
      ,[telefono] = @telefono
      ,[email] = @email
      ,[cuit] = @cuit
      ,[persona_contacto] = @persona_contacto
 WHERE id_propietario = @id_propietario

 select 1
end

GO
/****** Object:  StoredProcedure [dbo].[SP_Propietario_Seleccionar]    Script Date: 03/07/2023 18:59:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_Propietario_Seleccionar]
(
@id_propietario int
)
as 
begin

SELECT [id_propietario]
      ,[razon_social]
      ,[telefono]
      ,[email]
      ,[cuit]
      ,[persona_contacto]
  FROM [dbo].[Propietario] where id_propietario = @id_propietario

end
GO
/****** Object:  StoredProcedure [dbo].[SP_Proyecto_Agregar]    Script Date: 03/07/2023 18:59:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[SP_Proyecto_Agregar] 



 (@nombre nvarchar(150)
	,@monto_estimado numeric(18,2)
	,@tiempo_estimado int
	,@id_propietario_FK int
	,@legajo_FK int)

as

begin

declare @id_proyecto int

INSERT INTO [dbo].[Proyecto]
           ([nombre]
           ,[monto_estimado]
           ,[tiempo_estimado]
           ,[id_propietario_FK]
           ,[legajo_FK])
     VALUES
           (@nombre
           ,@monto_estimado
           ,@tiempo_estimado
           ,@id_propietario_FK
           ,@legajo_FK)

	SELECT SCOPE_IDENTITY()
	

	end
GO
/****** Object:  StoredProcedure [dbo].[SP_Proyecto_CargarCombo]    Script Date: 03/07/2023 18:59:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[SP_Proyecto_CargarCombo] 

as 
begin

SELECT [id_proyecto]
      ,[nombre]
     
  FROM [dbo].[Proyecto]

  end
GO
/****** Object:  StoredProcedure [dbo].[SP_Proyecto_Eliminar]    Script Date: 03/07/2023 18:59:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[SP_Proyecto_Eliminar]

(@id_proyecto int)

as 

begin

DELETE FROM [dbo].[Proyecto]
      WHERE id_proyecto = @id_proyecto

	  select 1

end
GO
/****** Object:  StoredProcedure [dbo].[SP_Proyecto_Index]    Script Date: 03/07/2023 18:59:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[SP_Proyecto_Index]

as 
begin 

SELECT [id_proyecto]
      ,[nombre]
      ,[monto_estimado]
      ,[tiempo_estimado]
      ,[id_propietario_FK]
      ,[legajo_FK]
  FROM [dbo].[Proyecto]

end
GO
/****** Object:  StoredProcedure [dbo].[SP_Proyecto_Modificar]    Script Date: 03/07/2023 18:59:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[SP_Proyecto_Modificar]

(@id_proyecto int 
,@nombre nvarchar(150)
	,@monto_estimado numeric(18,2)
	,@tiempo_estimado int
	,@id_propietario_FK int
	,@legajo_FK int)

as
begin

UPDATE [dbo].[Proyecto]
   SET [nombre] = @nombre
      ,[monto_estimado] = @monto_estimado
      ,[tiempo_estimado] = @tiempo_estimado
      ,[id_propietario_FK] = @id_propietario_FK
      ,[legajo_FK] = @legajo_FK
 WHERE id_proyecto = @id_proyecto

 select 1

 end
GO
/****** Object:  StoredProcedure [dbo].[SP_Proyecto_Seleccionar]    Script Date: 03/07/2023 18:59:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[SP_Proyecto_Seleccionar]

(@id_proyecto int)

as 

begin

SELECT [id_proyecto]
      ,[nombre]
      ,[monto_estimado]
      ,[tiempo_estimado]
      ,[id_propietario_FK]
      ,[legajo_FK]
  FROM [dbo].[Proyecto] where id_proyecto = @id_proyecto

  end
GO
/****** Object:  StoredProcedure [dbo].[SP_Tarea_Agregar]    Script Date: 03/07/2023 18:59:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[SP_Tarea_Agregar]

(
@id_proyecto int
,@descripcion text
,@horas_estimadas int
,@costo_estimado numeric(18,2)
,@horas_reales int
,@costo_real numeric(18,2)
,@fecha_final date
,@estado int )

as 
begin

INSERT INTO [dbo].[Tarea]
           ([id_proyecto]
           ,[descripcion]
           ,[horas_estimadas]
           ,[costo_estimado]
           ,[horas_reales]
           ,[costo_real]
           ,[fecha_final]
           ,[estado])
     VALUES
           (@id_proyecto	
           ,@descripcion
           ,@horas_estimadas
           ,@costo_estimado
           ,@horas_reales
           ,@costo_real
           ,@fecha_final
           ,@estado)

	SELECT SCOPE_IDENTITY()

end

GO
/****** Object:  StoredProcedure [dbo].[SP_Tarea_Eliminar]    Script Date: 03/07/2023 18:59:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[SP_Tarea_Eliminar]

(@nro_tarea int)

as
begin

DELETE FROM [dbo].[Tarea]
      WHERE nro_tarea = @nro_tarea

	  select 1

end
GO
/****** Object:  StoredProcedure [dbo].[SP_Tarea_Index]    Script Date: 03/07/2023 18:59:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[SP_Tarea_Index]

@id int
as


begin

SET NOCOUNT ON;

IF EXISTS (SELECT 1 FROM Tarea WHERE id_proyecto = @id)

BEGIN


SELECT [id_proyecto]
      ,[nro_tarea]
      ,[descripcion]
      ,[horas_estimadas]
      ,[costo_estimado]
      ,[horas_reales]
      ,[costo_real]
      ,[fecha_final]
      ,[estado]
  FROM [dbo].[Tarea] where id_proyecto = @id

  END
  
  end
GO
/****** Object:  StoredProcedure [dbo].[SP_Tarea_Modificar]    Script Date: 03/07/2023 18:59:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[SP_Tarea_Modificar]

(
@nro_tarea int,
@id_proyecto int
,@descripcion text
,@horas_estimadas int
,@costo_estimado numeric(18,2)
,@horas_reales int
,@costo_real numeric(18,2)
,@fecha_final date
,@estado int )

as 
begin

UPDATE [dbo].[Tarea]
   SET [id_proyecto] = @id_proyecto
      ,[descripcion] = @descripcion
      ,[horas_estimadas] = @horas_estimadas
      ,[costo_estimado] = @costo_estimado
      ,[horas_reales] = @horas_reales
      ,[costo_real] = @costo_real
      ,[fecha_final] = @fecha_final
      ,[estado] = @estado
 WHERE nro_tarea = @nro_tarea

 select 1

 end
GO
/****** Object:  StoredProcedure [dbo].[SP_Tarea_Seleccionar]    Script Date: 03/07/2023 18:59:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[SP_Tarea_Seleccionar]

(@nro_tarea int)

as 
begin

SELECT [id_proyecto]
      ,[nro_tarea]
      ,[descripcion]
      ,[horas_estimadas]
      ,[costo_estimado]
      ,[horas_reales]
      ,[costo_real]
      ,[fecha_final]
      ,[estado]
  FROM [dbo].[Tarea] where nro_tarea = @nro_tarea

  end
GO
USE [master]
GO
ALTER DATABASE [DB_BasePruebas] SET  READ_WRITE 
GO
