using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gestionador.Model;
using System.Data;

namespace Gestionador.Controller
{
    class ProductosController
    {
        private Productos productos = null;

        public ProductosController()
        {
            this.productos = new Productos();
        }

        public DataSet ObtenerTodosLosProductosActivos()
        {
            return (this.productos.ObtenerTodosLosProductosActivos());
        }
    }
}
