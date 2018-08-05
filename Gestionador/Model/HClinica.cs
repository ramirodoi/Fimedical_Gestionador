using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Gestionador.Model
{
    class HClinica
    {
        private SqlConnection connectionString = null;
        private SqlDataAdapter sqlDataAdapter = null;
        private SqlCommand cmd = null;

        public HClinica()
        {
            this.connectionString = new SqlConnection(Queries.CONNECTION_STRING);
        }

        public void GuardarHistoriaClinicaParaPaciente(int idPaciente, DateTime fecha)
        {
            this.connectionString.Open();

            this.cmd = new SqlCommand(Queries.GUARDAR_HISTORIA_CLINICA, connectionString);

            cmd.Parameters.AddWithValue("@p1", idPaciente);
            cmd.Parameters.AddWithValue("@p2", fecha);

            this.cmd.CommandType = CommandType.Text;
            int i = cmd.ExecuteNonQuery();

            this.connectionString.Close();
        }

        public int ObtenerUltimaHistoriaClinica(int idPaciente)
        {
            this.connectionString.Open();

            this.cmd = new SqlCommand(Queries.OBTENER_ULTIMA_HISTORIA_CLINICA_POR_PACIENTE, connectionString);
            cmd.Parameters.AddWithValue("@p1", idPaciente);
            this.sqlDataAdapter = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            this.sqlDataAdapter.Fill(ds, "HistoriaClinica");

            this.connectionString.Close();

            if (ds != null && ds.Tables != null && ds.Tables[0].Rows.Count > 0)
            {
                return (int.Parse(ds.Tables[0].Rows[0][0].ToString()));
            }

            return (-1);
        }

        public void GuardarHistoriaClinicaTratamiento(int idHistoriaClinica, EnumerableRowCollection TratamientosList)
        {
            this.connectionString.Open();

            foreach (DataRow tratamiento in TratamientosList)
            {
                this.cmd = new SqlCommand(Queries.GUARDAR_HISTORIA_CLINICA_TRATAMIENTOS, connectionString);

                cmd.Parameters.AddWithValue("@p1", idHistoriaClinica);
                cmd.Parameters.AddWithValue("@p2", int.Parse(tratamiento["idMedica"].ToString()));
                cmd.Parameters.AddWithValue("@p3", int.Parse(tratamiento["idNombre"].ToString()));
                cmd.Parameters.AddWithValue("@p4", int.Parse(tratamiento["precio"].ToString()));
                cmd.Parameters.AddWithValue("@p5", int.Parse(tratamiento["pago"].ToString()));
                cmd.Parameters.AddWithValue("@p6", int.Parse(tratamiento["idMedioPago"].ToString()));

                this.cmd.CommandType = CommandType.Text;
                int i = cmd.ExecuteNonQuery();
            }

            this.connectionString.Close();
        }

        public void GuardarHistoriaClinicaProductos(int idHistoriaClinica, EnumerableRowCollection ProductosList)
        {
            this.connectionString.Open();

            foreach (DataRow producto in ProductosList)
            {
                this.cmd = new SqlCommand(Queries.GUARDAR_HISTORIA_CLINICA_PRODUCTOS, connectionString);

                cmd.Parameters.AddWithValue("@p1", idHistoriaClinica);
                cmd.Parameters.AddWithValue("@p2", int.Parse(producto["idNombre"].ToString()));
                cmd.Parameters.AddWithValue("@p3", int.Parse(producto["precio"].ToString()));
                cmd.Parameters.AddWithValue("@p4", int.Parse(producto["pago"].ToString()));
                cmd.Parameters.AddWithValue("@p5", int.Parse(producto["idMedioPago"].ToString()));

                this.cmd.CommandType = CommandType.Text;
                int i = cmd.ExecuteNonQuery();
            }

            this.connectionString.Close();
        }
    }
}
