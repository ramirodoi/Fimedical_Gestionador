using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gestionador.Controller.Entities
{
    class ObtenerDatosClienteRequest
    {
        public int? IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Dni { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string TelefonoFijo { get; set; }
        public string TelefonoCelular { get; set; }
        public string TelefonoTrabajo { get; set; }
        public string Email { get; set; }
        public string Domicilio { get; set; }
        public string Localidad { get; set; }

        public ObtenerDatosClienteRequest()
        {
            this.IdCliente = null;
            this.Nombre = null;
            this.Apellido = null;
            this.Dni = null;
            this.FechaNacimiento = null;
            this.TelefonoFijo = null;
            this.TelefonoCelular = null;
            this.TelefonoTrabajo = null;
            this.Email = null;
            this.Domicilio = null;
            this.Localidad = null;
        }
    }
}
