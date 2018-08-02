using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gestionador.Model;
using System.Data;

namespace Gestionador.Controller
{
    class HClinicaController
    {
        private Clientes cli = null;
        private HClinica hcli = null;

        public HClinicaController()
        {
            this.hcli = new HClinica();
            this.cli = new Clientes();
        }

        //public bool GuardarHistoriaClinica()
        //{
        //    if (this.cli.ExisteCliente(dni))
        //    {
        //        return (false);
        //    }

        //    this.hcli.GuardarCliente(nombre, apellido, dni, fechaNacimiento, telefonoFijo, telefonoCelular, telefonoTrabajo, email, domicilio, localidad);

        //    return (true);
        //}
    }
}
