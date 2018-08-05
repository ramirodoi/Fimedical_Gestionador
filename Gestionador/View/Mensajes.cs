using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gestionador.View
{
    static public class Mensajes
    {
        //Clientes
        static public string CLIENTES_ALTA_VALIDACION_GUARDAR = "Debe completar el nombre, apellido, DNI, fecha de nacimiento y teléfono celular para poder guardar.";
        static public string CLIENTES_ALTA_GUARDAR_OK = "Se guardó el Cliente correctamente.";
        static public string CLIENTES_ALTA_VALIDACION_GUARDAR_EXISTENTE = "El Cliente ya existe.";
        static public string CLIENTES_ALTA_VOLVER = "¿Está seguro que desea volver? Se perderán los cambios realizados.";

        static public string CLIENTES_BAJA_VALIDACION_GUARDAR = "Debe completar el motivo para poder guardar.";
        static public string CLIENTES_BAJA_GUARDAR_OK = "Se dio de baja el Cliente correctamente.";
        static public string CLIENTES_BAJA_GUARDAR = "¿Está seguro que desea dar de baja al Cliente? (Esta acción no podrá deshacerse).";
        static public string CLIENTES_BAJA_VOLVER = "¿Está seguro que desea volver? Se perderán los cambios realizados.";

        static public string CLIENTES_EDITAR_VALIDACION_GUARDAR = "Debe completar el nombre, apellido, DNI, fecha de nacimiento y teléfono celular para poder guardar.";
        static public string CLIENTES_EDITAR_GUARDAR_OK = "Se guardó el Cliente correctamente.";
        static public string CLIENTES_EDITAR_VALIDACION_GUARDAR_EXISTENTE = "Ya existe un Cliente con ese DNI.";
        static public string CLIENTES_EDITAR_VOLVER = "¿Está seguro que desea volver? Se perderán los cambios realizados.";

        //Historia Clinica
        static public string HCLINICA_ALTA_GUARDAR_OK = "Se guardó la Historia Clínica correctamente.";
        static public string HCLINICA_ALTA_VALIDACION_GUARDAR = "Debe seleccionar un Paciente o agregar algún Tratamiento y/o Producto a la lista para poder guardar la Historia Clínica.";
        static public string HCLINICA_ALTA_VALIDACION_AGREGAR_TRATAMIENTO = "Debe completar toda la información del Tratamiento para poder agregarlo.";
        static public string HCLINICA_ALTA_VALIDACION_AGREGAR_PRODUCTO = "Debe completar toda la información del Producto para poder agregarlo.";
        static public string HCLINICA_ALTA_VALIDACION_AGREGAR_TRATAMIENTO_PRECIO = "El precio del Tratamiento debe ser numérico.";
        static public string HCLINICA_ALTA_VALIDACION_AGREGAR_TRATAMIENTO_PAGO = "El pago del Tratamiento debe ser numérico.";
        static public string HCLINICA_ALTA_VALIDACION_AGREGAR_PRODUCTO_PRECIO = "El precio del Producto debe ser numérico.";
        static public string HCLINICA_ALTA_VALIDACION_AGREGAR_PRODUCTO_PAGO = "El pago del Producto debe ser numérico.";
    }
}
