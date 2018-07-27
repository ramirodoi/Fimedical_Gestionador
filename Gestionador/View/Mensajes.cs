using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gestionador.View
{
    static public class Mensajes
    {
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
    }
}
