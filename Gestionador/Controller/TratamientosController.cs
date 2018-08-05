using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gestionador.Model;
using System.Data;

namespace Gestionador.Controller
{
    class TratamientosController
    {
        private Tratamientos tratamientos = null;

        public TratamientosController()
        {
            this.tratamientos = new Tratamientos();
        }

        public DataSet ObtenerTodosLosTratamientosActivos()
        {
            return (this.tratamientos.ObtenerTodosLosTratamientosActivos());
        }
    }
}
