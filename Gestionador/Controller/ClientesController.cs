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
    class PacientesController
    {
        private Pacientes cli = null;
        
        public PacientesController()
        {
            this.cli = new Pacientes();
        }

        public bool GuardarPaciente(string nombre, string apellido, string dni, DateTime fechaNacimiento, string telefonoFijo, string telefonoCelular, string telefonoTrabajo, string email, string domicilio, string localidad)
        {
            if (this.cli.ExistePaciente(dni))
            {
                return (false);
            }

            this.cli.GuardarPaciente(nombre, apellido, dni, fechaNacimiento, telefonoFijo, telefonoCelular, telefonoTrabajo, email, domicilio, localidad);

            return (true);
        }

        public bool DarDeBajaPaciente(int idPaciente, string motivo)
        {
            this.cli.DarDeBajaPaciente(idPaciente, motivo);

            return (true);
        }
        
        public bool ActualizarPaciente(int idPaciente, string nombre, string apellido, string dni, DateTime fechaNacimiento, string telefonoFijo, string telefonoCelular, string telefonoTrabajo, string email, string domicilio, string localidad)
        {
            //TODO: Validar que el DNI modificado no coincida con el DNI de otro Paciente.
            //if (this.cli.ObtenerIdPacientePorDni(dni) != idPaciente)
            //{
            //    return (false);
            //}

            this.cli.ActualizarPaciente(idPaciente, nombre, apellido, dni, fechaNacimiento, telefonoFijo, telefonoCelular, telefonoTrabajo, email, domicilio, localidad);

            return (true);
        }

        public DataSet ObtenerDatosPacientePorId(int idPaciente)
        {
            return (this.cli.ObtenerDatosPacientePorId(idPaciente));
        }

        public DataSet ObtenerDatosPacientePorDni(string dni)
        {
            return (this.cli.ObtenerDatosPacientePorDni(dni));
        }

        public DataSet ObtenerTodosLosPacientesActivos()
        {
            return (this.cli.ObtenerTodosLosPacientesActivos());
        }

        public DataSet ObtenerDatosPacientePorConsulta(string nombre, string apellido, string dni)
        {
            return (this.cli.ObtenerDatosPacientePorConsulta(nombre, apellido, dni));
        }

        //public DataSet ObtenerDatosPaciente(ObtenerDatosPacienteRequest req)
        //{
        //    DataSet consulta = null;

        //    if (req != null)
        //    {
        //        Paciente Paciente = new Paciente()
        //        {
        //            Apellido = req.Apellido,
        //            Dni = req.Dni,
        //            Domicilio = req.Domicilio,
        //            Email = req.Email,
        //            FechaNacimiento = req.FechaNacimiento,
        //            IdPaciente = req.IdPaciente,
        //            Localidad = req.Localidad,
        //            Nombre = req.Nombre,
        //            TelefonoCelular = req.TelefonoCelular,
        //            TelefonoFijo = req.TelefonoFijo,
        //            TelefonoTrabajo = req.TelefonoTrabajo
        //        };

        //        consulta = this.cli.ObtenerDatosPaciente(Paciente);
        //    }

        //    return (consulta);
        //}
    }
}
