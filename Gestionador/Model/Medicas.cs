using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Gestionador.Model
{
    class Medicas
    {
        private SqlConnection connectionString = null;
        private SqlDataAdapter sqlDataAdapter = null;
        private SqlCommand cmd = null;

        public Medicas()
        {
            this.connectionString = new SqlConnection(Queries.CONNECTION_STRING);
        }

        public DataSet ObtenerTodasLasMedicasActivas()
        {
            this.connectionString.Open();

            this.cmd = new SqlCommand(Queries.OBTENER_TODAS_LAS_MEDICAS_ACTIVAS, connectionString);

            this.sqlDataAdapter = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            this.sqlDataAdapter.Fill(ds, "Medicas");

            this.connectionString.Close();

            return (ds);
        }
    }
}
