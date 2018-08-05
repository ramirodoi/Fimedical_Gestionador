using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gestionador.Model;
using System.Data;

namespace Gestionador.Controller
{
    class MedicasController
    {
        private Medicas medicas = null;

        public MedicasController()
        {
            this.medicas = new Medicas();
        }

        public DataSet ObtenerTodasLasMedicasActivas()
        {
            return (this.medicas.ObtenerTodasLasMedicasActivas());
        }
    }
}
