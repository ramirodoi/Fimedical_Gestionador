USE Fimedical
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[HistoriaClinicaProductos]') AND type in (N'U'))
DROP TABLE [dbo].HistoriaClinicaProductos
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[HistoriaClinicaTratamientos]') AND type in (N'U'))
DROP TABLE [dbo].HistoriaClinicaTratamientos
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[HistoriaClinica]') AND type in (N'U'))
DROP TABLE [dbo].HistoriaClinica
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Medicas]') AND type in (N'U'))
DROP TABLE [dbo].[Medicas]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MediosPago]') AND type in (N'U'))
DROP TABLE [dbo].MediosPago
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Tratamientos]') AND type in (N'U'))
DROP TABLE [dbo].Tratamientos
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Productos]') AND type in (N'U'))
DROP TABLE [dbo].Productos
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Pacientes]') AND type in (N'U'))
DROP TABLE [dbo].[Pacientes]
GO

CREATE TABLE Pacientes
(
idPaciente INT identity PRIMARY KEY NOT NULL,
nombre VARCHAR(50) NULL,
apellido VARCHAR(50) NULL,
dni VARCHAR(20) NULL,
fechaNacimiento DATE NOT NULL,
telefonoFijo VARCHAR(20) NULL,
telefonoCelular VARCHAR(20) NULL,
telefonoTrabajo VARCHAR(20) NULL,
email VARCHAR(50) NULL,
domicilio VARCHAR(200) NULL,
localidad VARCHAR(100) NULL,
activo BIT NOT NULL,
descripcionBaja VARCHAR(200) NULL
)
GO

CREATE TABLE Productos
(
idProducto INT identity PRIMARY KEY NOT NULL,
nombre VARCHAR(50) NULL,
descripcion VARCHAR(200) NULL,
activo BIT NOT NULL
)
GO

CREATE TABLE Tratamientos
(
idTratamiento INT identity PRIMARY KEY NOT NULL,
nombre VARCHAR(50) NULL,
descripcion VARCHAR(200) NULL,
activo BIT NOT NULL
)
GO

CREATE TABLE MediosPago
(
idMedioPago INT identity PRIMARY KEY NOT NULL,
nombre VARCHAR(50) NULL,
activo BIT NOT NULL
)
GO

CREATE TABLE Medicas
(
idMedica INT identity PRIMARY KEY NOT NULL,
nombre VARCHAR(50) NULL,
apellido VARCHAR(50) NULL,
dni VARCHAR(20) NULL,
fechaNacimiento DATE NULL,
telefonoCelular VARCHAR(20) NULL,
email VARCHAR(50) NULL,
domicilio VARCHAR(200) NULL,
localidad VARCHAR(100) NULL,
activo BIT NOT NULL,
descripcionBaja VARCHAR(200) NULL
)
GO

CREATE TABLE HistoriaClinica
(
idHistoriaClinica INT identity PRIMARY KEY NOT NULL,
idPaciente INT FOREIGN KEY REFERENCES dbo.Pacientes(idPaciente) NOT NULL,
fecha DATETIME NOT NULL
)
GO

CREATE TABLE HistoriaClinicaTratamientos
(
idHistoriaClinicaTratamiento INT identity PRIMARY KEY NOT NULL,
idHistoriaClinica INT FOREIGN KEY REFERENCES dbo.HistoriaClinica(idHistoriaClinica) NOT NULL,
idMedica INT FOREIGN KEY REFERENCES dbo.Medicas(idMedica) NOT NULL,
idTratamiento INT FOREIGN KEY REFERENCES dbo.Tratamientos(idTratamiento) NOT NULL,
precio MONEY NOT NULL,
pago MONEY NOT NULL,
idMedioPago INT FOREIGN KEY REFERENCES dbo.MediosPago(idMedioPago) NOT NULL,
)
GO

CREATE TABLE HistoriaClinicaProductos
(
idHistoriaClinicaProducto INT identity PRIMARY KEY NOT NULL,
idHistoriaClinica INT FOREIGN KEY REFERENCES dbo.HistoriaClinica(idHistoriaClinica) NOT NULL,
idProducto INT FOREIGN KEY REFERENCES dbo.Productos(idProducto) NOT NULL,
precio MONEY NOT NULL,
pago MONEY NOT NULL,
idMedioPago INT FOREIGN KEY REFERENCES dbo.MediosPago(idMedioPago) NOT NULL,
)
GO

