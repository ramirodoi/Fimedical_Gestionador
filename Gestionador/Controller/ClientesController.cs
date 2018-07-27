using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gestionador.Model;
using System.Data;
//using Gestionador.Controller.Entities;
//using Gestionador.Model.Entities;

namespace Gestionador.Controller
{
    class ClientesController
    {
        private Clientes cli = null;
        
        public ClientesController()
        {
            this.cli = new Clientes();
        }

        public bool GuardarCliente(string nombre, string apellido, string dni, DateTime fechaNacimiento, string telefonoFijo, string telefonoCelular, string telefonoTrabajo, string email, string domicilio, string localidad)
        {
            if (this.cli.ExisteCliente(dni))
            {
                return (false);
            }

            this.cli.GuardarCliente(nombre, apellido, dni, fechaNacimiento, telefonoFijo, telefonoCelular, telefonoTrabajo, email, domicilio, localidad);

            return (true);
        }

        public bool DarDeBajaCliente(int idCliente, string motivo)
        {
            this.cli.DarDeBajaCliente(idCliente, motivo);

            return (true);
        }
        
        public bool ActualizarCliente(int idCliente, string nombre, string apellido, string dni, DateTime fechaNacimiento, string telefonoFijo, string telefonoCelular, string telefonoTrabajo, string email, string domicilio, string localidad)
        {
            //TODO: Validar que el DNI modificado no coincida con el DNI de otro Cliente.
            //if (this.cli.ObtenerIdClientePorDni(dni) != idCliente)
            //{
            //    return (false);
            //}

            this.cli.ActualizarCliente(idCliente, nombre, apellido, dni, fechaNacimiento, telefonoFijo, telefonoCelular, telefonoTrabajo, email, domicilio, localidad);

            return (true);
        }

        public DataSet ObtenerDatosClientePorId(int idCliente)
        {
            return (this.cli.ObtenerDatosClientePorId(idCliente));
        }

        public DataSet ObtenerDatosClientePorDni(string dni)
        {
            return (this.cli.ObtenerDatosClientePorDni(dni));
        }

        public DataSet ObtenerTodosLosClientesActivos()
        {
            return (this.cli.ObtenerTodosLosClientesActivos());
        }

        public DataSet ObtenerDatosClientePorConsulta(string nombre, string apellido, string dni)
        {
            return (this.cli.ObtenerDatosClientePorConsulta(nombre, apellido, dni));
        }

        //public DataSet ObtenerDatosCliente(ObtenerDatosClienteRequest req)
        //{
        //    DataSet consulta = null;

        //    if (req != null)
        //    {
        //        Cliente cliente = new Cliente()
        //        {
        //            Apellido = req.Apellido,
        //            Dni = req.Dni,
        //            Domicilio = req.Domicilio,
        //            Email = req.Email,
        //            FechaNacimiento = req.FechaNacimiento,
        //            IdCliente = req.IdCliente,
        //            Localidad = req.Localidad,
        //            Nombre = req.Nombre,
        //            TelefonoCelular = req.TelefonoCelular,
        //            TelefonoFijo = req.TelefonoFijo,
        //            TelefonoTrabajo = req.TelefonoTrabajo
        //        };

        //        consulta = this.cli.ObtenerDatosCliente(cliente);
        //    }

        //    return (consulta);
        //}
    }
}
