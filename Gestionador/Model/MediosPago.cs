using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Gestionador.Model
{
    class MediosPago
    {
        private SqlConnection connectionString = null;
        private SqlDataAdapter sqlDataAdapter = null;
        private SqlCommand cmd = null;

        public MediosPago()
        {
            this.connectionString = new SqlConnection(Queries.CONNECTION_STRING);
        }

        public DataSet ObtenerTodosLosMediosPagoActivos()
        {
            this.connectionString.Open();

            this.cmd = new SqlCommand(Queries.OBTENER_TODOS_LOS_MEDIOS_DE_PAGO_ACTIVOS, connectionString);

            this.sqlDataAdapter = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            this.sqlDataAdapter.Fill(ds, "MediosPago");

            this.connectionString.Close();

            return (ds);
        }
    }
}
