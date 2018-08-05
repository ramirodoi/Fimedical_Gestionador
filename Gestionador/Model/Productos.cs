using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Gestionador.Model
{
    class Productos
    {
        private SqlConnection connectionString = null;
        private SqlDataAdapter sqlDataAdapter = null;
        private SqlCommand cmd = null;

        public Productos()
        {
            this.connectionString = new SqlConnection(Queries.CONNECTION_STRING);
        }

        public DataSet ObtenerTodosLosProductosActivos()
        {
            this.connectionString.Open();

            this.cmd = new SqlCommand(Queries.OBTENER_TODOS_LOS_PRODUCTOS_ACTIVOS, connectionString);

            this.sqlDataAdapter = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            this.sqlDataAdapter.Fill(ds, "Productos");

            this.connectionString.Close();

            return (ds);
        }
    }
}
