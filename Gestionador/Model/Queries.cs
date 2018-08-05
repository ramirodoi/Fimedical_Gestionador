using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gestionador.Model
{
    static public class Queries
    {
        static public string CONNECTION_STRING = @"Data Source=RHA-VIRTUAL\SQLEXPRESS;Initial Catalog=Fimedical;Integrated Security=True;";

        //Cliente
        static public string OBTENER_DATOS_CLIENTE_POR_ID = "SELECT nombre, apellido, dni, fechaNacimiento, telefonoFijo, telefonoCelular, telefonoTrabajo, email, domicilio, localidad FROM dbo.Clientes WHERE idCliente = @p1;";
        static public string OBTENER_ID_CLIENTE_POR_DNI = "SELECT idCliente, nombre, apellido, dni, fechaNacimiento, telefonoFijo, telefonoCelular, telefonoTrabajo, email, domicilio, localidad FROM dbo.Clientes WHERE dni = @p1;";
        static public string EXISTE_CLIENTE_POR_IDENTIFICADOR = "SELECT 1 FROM dbo.Clientes WHERE dni = @p1 OR idCliente = @p2;";
        static public string OBTENER_DATOS_CLIENTE_POR_CONSULTA = "SELECT idCliente, nombre, apellido, dni, fechaNacimiento, telefonoFijo, telefonoCelular, telefonoTrabajo, email, domicilio, localidad FROM dbo.Clientes WHERE activo = 1 AND (nombre = @p1 OR @p1 IS NULL) AND (apellido = @p2 OR @p2 IS NULL) AND (dni = @p3 OR @p3 IS NULL);";
        static public string OBTENER_TODOS_LOS_CLIENTES_ACTIVOS = "SELECT idCliente, nombre, apellido, dni, fechaNacimiento, telefonoFijo, telefonoCelular, telefonoTrabajo, email, domicilio, localidad FROM dbo.Clientes WHERE activo = 1;";
       
        static public string GUARDAR_ALTA_CLIENTE = "INSERT INTO dbo.Clientes (nombre, apellido, dni, fechaNacimiento, telefonoFijo, telefonoCelular, telefonoTrabajo, email, domicilio, localidad, activo) values(@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10, 1);";
        static public string GUARDAR_BAJA_CLIENTE = "UPDATE dbo.Clientes SET activo = 0, descripcionBaja = @p2 WHERE idCliente = @p1;";
        static public string GUARDAR_EDITAR_CLIENTE = "UPDATE dbo.Clientes SET nombre = @p1, apellido = @p2, dni = @p3, fechaNacimiento = @p4, telefonoFijo = @p5, telefonoCelular = @p6, telefonoTrabajo = @p7, email = @p8, domicilio = @p9, localidad = @p10 WHERE idCliente = @p11;";

        //Historia Clinica
        static public string GUARDAR_HISTORIA_CLINICA = "INSERT INTO dbo.HistoriaClinica (idCliente, fecha) values(@p1, @p2);";
        static public string OBTENER_ULTIMA_HISTORIA_CLINICA_POR_PACIENTE = "SELECT MAX(idHistoriaClinica) FROM dbo.HistoriaClinica WHERE idCliente = @p1;";
        static public string GUARDAR_HISTORIA_CLINICA_TRATAMIENTOS = "INSERT INTO [dbo].[HistoriaClinicaTratamientos] (idHistoriaClinica, idMedica, idTratamiento, precio, pago, idMedioPago) VALUES (@p1, @p2, @p3, @p4, @p5, @p6);";
        static public string GUARDAR_HISTORIA_CLINICA_PRODUCTOS = "INSERT INTO [dbo].[HistoriaClinicaProductos] (idHistoriaClinica, idProducto, precio, pago, idMedioPago) VALUES (@p1, @p2, @p3, @p4, @p5);";

        //Medicas
        static public string OBTENER_TODAS_LAS_MEDICAS_ACTIVAS = "SELECT idMedica, nombre, apellido, dni, fechaNacimiento, telefonoCelular, email, domicilio, localidad FROM dbo.Medicas WHERE activo = 1;";

        //Tratamientos
        static public string OBTENER_TODOS_LOS_TRATAMIENTOS_ACTIVOS = "SELECT idTratamiento, nombre, descripcion FROM dbo.Tratamientos WHERE activo = 1;";

        //Productos
        static public string OBTENER_TODOS_LOS_PRODUCTOS_ACTIVOS = "SELECT idProducto, nombre, descripcion FROM dbo.Productos WHERE activo = 1;";

        //MediosPago
        static public string OBTENER_TODOS_LOS_MEDIOS_DE_PAGO_ACTIVOS = "SELECT idMedioPago, nombre FROM dbo.MediosPago WHERE activo = 1;";
    }
}
