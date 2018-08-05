USE Fimedical
GO

DELETE FROM [Fimedical].[dbo].[HistoriaClinicaTratamientos];
GO
DELETE FROM [Fimedical].[dbo].[HistoriaClinicaProductos];
GO
DELETE FROM [Fimedical].[dbo].[HistoriaClinica];
GO
DELETE FROM [Fimedical].[dbo].[Medicas];
GO
DELETE FROM [Fimedical].[dbo].[MediosPago];
GO
DELETE FROM [Fimedical].[dbo].[Tratamientos];
GO
DELETE FROM [Fimedical].[dbo].[Productos];
GO
DELETE FROM [Fimedical].[dbo].[Pacientes];
GO

DBCC CHECKIDENT ('[Fimedical].[dbo].[HistoriaClinicaTratamientos]', RESEED, 0);
GO
DBCC CHECKIDENT ('[Fimedical].[dbo].[HistoriaClinicaProductos]', RESEED, 0);
GO
DBCC CHECKIDENT ('[Fimedical].[dbo].[HistoriaClinica]', RESEED, 0);
GO
DBCC CHECKIDENT ('[Fimedical].[dbo].[Medicas]', RESEED, 0);
GO
DBCC CHECKIDENT ('[Fimedical].[dbo].[MediosPago]', RESEED, 0);
GO
DBCC CHECKIDENT ('[Fimedical].[dbo].[Tratamientos]', RESEED, 0);
GO
DBCC CHECKIDENT ('[Fimedical].[dbo].[Productos]', RESEED, 0);
GO
DBCC CHECKIDENT ('[Fimedical].[dbo].[Pacientes]', RESEED, 0);
GO
   
INSERT INTO [Fimedical].[dbo].[Pacientes]
(nombre, apellido, dni, fechaNacimiento, telefonoFijo, telefonoCelular, telefonoTrabajo, email, domicilio, localidad, activo, descripcionBaja)
VALUES
('Juana', 'Blanco', '11222333', '19500513', '4321-4875', '15-5412-6987', NULL, 'jblanco@gmail.com', 'Cerrito 400 3ºB', 'CABA', 1, NULL);

INSERT INTO [Fimedical].[dbo].[Pacientes]
(nombre, apellido, dni, fechaNacimiento, telefonoFijo, telefonoCelular, telefonoTrabajo, email, domicilio, localidad, activo, descripcionBaja)
VALUES
('Lucia', 'Luchetti', '35487521', '19920110', NULL, '1559761576', NULL, 'lucialuchetti@gmail.com', 'Santa Fe 4235 4ºD', 'CABA', 1, NULL);

INSERT INTO [Fimedical].[dbo].[Pacientes]
(nombre, apellido, dni, fechaNacimiento, telefonoFijo, telefonoCelular, telefonoTrabajo, email, domicilio, localidad, activo, descripcionBaja)
VALUES
('Susana', 'Gomez', '10578123', '19510910', NULL, '1545671892', NULL, 'susigomez@hotmail.com', 'Vicente Lopez 112 11F', 'CABA', 1, NULL);  

INSERT INTO [Fimedical].[dbo].[Pacientes]
(nombre, apellido, dni, fechaNacimiento, telefonoFijo, telefonoCelular, telefonoTrabajo, email, domicilio, localidad, activo, descripcionBaja)
VALUES
('Florencia', 'Limia', '14978345', '19730910', '4681-2893', '1557463791', '51269642 interno 12', 'flimia@fibertel.com.ar', 'Olleros 3526 3-A', 'CABA', 1, NULL);  

INSERT INTO [Fimedical].[dbo].[Pacientes]
(nombre, apellido, dni, fechaNacimiento, telefonoFijo, telefonoCelular, telefonoTrabajo, email, domicilio, localidad, activo, descripcionBaja)
VALUES
('Raul', 'Perez', '20684159', '19800919', NULL, '1511224879', '35970164 int. 1004', 'raulperez1980@yahoo.com.ar', 'Guemes 140', 'Ramos Mejia', 1, NULL);

INSERT INTO [Fimedical].[dbo].[Productos]
(nombre, descripcion, activo)
VALUES
('Producto 1', 'Descipción Producto 1', 1);

INSERT INTO [Fimedical].[dbo].[Productos]
(nombre, descripcion, activo)
VALUES
('Producto 2', 'Descipción Producto 2', 1);

INSERT INTO [Fimedical].[dbo].[Productos]
(nombre, descripcion, activo)
VALUES
('Producto 3', 'Descipción Producto 3', 1);
GO

INSERT INTO [Fimedical].[dbo].[Tratamientos]
(nombre, descripcion, activo)
VALUES
('Tratamiento 1', 'Descipción Tratamiento 1', 1);

INSERT INTO [Fimedical].[dbo].[Tratamientos]
(nombre, descripcion, activo)
VALUES
('Tratamiento 2', 'Descipción Tratamiento 2', 1);

INSERT INTO [Fimedical].[dbo].[Tratamientos]
(nombre, descripcion, activo)
VALUES
('Tratamiento 3', 'Descipción Tratamiento 3', 1);

INSERT INTO [Fimedical].[dbo].[MediosPago]
(nombre, activo)
VALUES
('Efectivo', 1);

INSERT INTO [Fimedical].[dbo].[MediosPago]
(nombre, activo)
VALUES
('Tarjeta de Débito', 1);

INSERT INTO [Fimedical].[dbo].[MediosPago]
(nombre, activo)
VALUES
('Tarjeta de Crédito', 1);

INSERT INTO [Fimedical].[dbo].[MediosPago]
(nombre, activo)
VALUES
('Cuenta Corriente', 1);
   
INSERT INTO [Fimedical].[dbo].[Medicas]
(nombre, apellido, dni, fechaNacimiento, telefonoCelular, email, domicilio, localidad, activo, descripcionBaja)
VALUES
('Lorena', 'Medica 1', '00111222', '20180101', '15-1111-2222', 'lorena@fimedical.com', 'Madero 1', 'Vicente Lopez', 1, NULL);

INSERT INTO [Fimedical].[dbo].[Medicas]
(nombre, apellido, dni, fechaNacimiento, telefonoCelular, email, domicilio, localidad, activo, descripcionBaja)
VALUES
('Ana', 'Medica 2', '00333444', '20180202', '15-3333-4444', 'ana@fimedical.com', 'Madero 2', 'Vicente Lopez', 1, NULL);

INSERT INTO [Fimedical].[dbo].[Medicas]
(nombre, apellido, dni, fechaNacimiento, telefonoCelular, email, domicilio, localidad, activo, descripcionBaja)
VALUES
('Cecilia', 'Medica 3', '00555666', '20180303', '15-5555-6666', 'cecilia@fimedical.com', 'Madero 3', 'Vicente Lopez', 1, NULL);
   
INSERT INTO [Fimedical].[dbo].[HistoriaClinica]
(idPaciente, fecha)
VALUES
(2, GETDATE());
   
INSERT INTO [Fimedical].[dbo].[HistoriaClinicaTratamientos]
(idHistoriaClinica, idMedica, idTratamiento, precio, pago, idMedioPago)
VALUES
(1, 1, 1, 100, 100, 1);

INSERT INTO [Fimedical].[dbo].[HistoriaClinicaTratamientos]
(idHistoriaClinica, idMedica, idTratamiento, precio, pago, idMedioPago)
VALUES
(1, 1, 1, 100, 100, 2);

INSERT INTO [Fimedical].[dbo].[HistoriaClinicaTratamientos]
(idHistoriaClinica, idMedica, idTratamiento, precio, pago, idMedioPago)
VALUES
(1, 1, 2, 200, 200, 3);
