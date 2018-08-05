using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gestionador.Model;
using System.Data;

namespace Gestionador.Controller
{
    class MediosPagoController
    {
        private MediosPago medios = null;

        public MediosPagoController()
        {
            this.medios = new MediosPago();
        }

        public DataSet ObtenerTodosLosMediosPagoActivos()
        {
            return (this.medios.ObtenerTodosLosMediosPagoActivos());
        }
    }
}
