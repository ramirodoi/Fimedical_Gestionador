using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
//using Gestionador.Model.Entities;

namespace Gestionador.Model
{
    class Pacientes
    {
        private SqlConnection connectionString = null;
        private SqlDataAdapter sqlDataAdapter = null;
        private SqlCommand cmd = null;

        public Pacientes()
        {
            this.connectionString = new SqlConnection(Queries.CONNECTION_STRING);
        }

        public DataSet ObtenerDatosPacientePorId(int idPaciente)
        {
            this.connectionString.Open();

            this.cmd = new SqlCommand(Queries.OBTENER_DATOS_Paciente_POR_ID, connectionString);
            cmd.Parameters.AddWithValue("@p1", idPaciente);
            this.sqlDataAdapter = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            this.sqlDataAdapter.Fill(ds, "Pacientes");

            this.connectionString.Close();

            return(ds);
        }

        public DataSet ObtenerDatosPacientePorDni(string dni)
        {
            this.connectionString.Open();

            this.cmd = new SqlCommand(Queries.OBTENER_ID_Paciente_POR_DNI, connectionString);
            cmd.Parameters.AddWithValue("@p1", dni);
            this.sqlDataAdapter = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            this.sqlDataAdapter.Fill(ds, "Pacientes");

            this.connectionString.Close();

            return (ds);
        }

        public int ObtenerIdPacientePorDni(string dni)
        {
            this.connectionString.Open();

            this.cmd = new SqlCommand(Queries.OBTENER_ID_Paciente_POR_DNI, connectionString);
            cmd.Parameters.AddWithValue("@p1", dni);
            this.sqlDataAdapter = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            this.sqlDataAdapter.Fill(ds, "Pacientes");

            this.connectionString.Close();

            if (ds.Tables[0] == null || ds.Tables[0].Rows.Count.Equals(0))
            {
                return (-1);
            }

            return ((int)ds.Tables[0].Rows[0][0]);
        }

        public DataSet ObtenerTodosLosPacientesActivos()
        {
            this.connectionString.Open();

            this.cmd = new SqlCommand(Queries.OBTENER_TODOS_LOS_PacienteS_ACTIVOS, connectionString);

            this.sqlDataAdapter = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            this.sqlDataAdapter.Fill(ds, "Pacientes");

            this.connectionString.Close();

            return (ds);
        }

        public DataSet ObtenerDatosPacientePorConsulta(string nombre, string apellido, string dni)
        {
            this.connectionString.Open();

            this.cmd = new SqlCommand(Queries.OBTENER_DATOS_Paciente_POR_CONSULTA, connectionString);

            #region ValidaParametros
            if (nombre.Length > 0)
            {
                cmd.Parameters.AddWithValue("@p1", nombre);
            }
            else
            {
                cmd.Parameters.AddWithValue("@p1", DBNull.Value);
            }

            if (apellido.Length > 0)
            {
                cmd.Parameters.AddWithValue("@p2", apellido);
            }
            else
            {
                cmd.Parameters.AddWithValue("@p2", DBNull.Value);
            }

            if (dni.Length > 0)
            {
                cmd.Parameters.AddWithValue("@p3", dni);
            }
            else
            {
                cmd.Parameters.AddWithValue("@p3", DBNull.Value);
            }
            #endregion ValidaParametros

            this.sqlDataAdapter = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            this.sqlDataAdapter.Fill(ds, "Pacientes");

            this.connectionString.Close();

            return (ds);
        }

        //public DataSet ObtenerDatosPaciente(Paciente Paciente)
        //{
        //    this.connectionString.Open();

        //    this.cmd = new SqlCommand(Queries.OBTENER_DATOS_Paciente_POR_FILTROS, connectionString);

        //    #region ValidaParametros
        //    if (Paciente.Nombre.Length > 0)
        //    {
        //        cmd.Parameters.AddWithValue("@p1", Paciente.Nombre);
        //    }
        //    else
        //    {
        //        cmd.Parameters.AddWithValue("@p1", DBNull.Value);
        //    }

        //    if (Paciente.Apellido.Length > 0)
        //    {
        //        cmd.Parameters.AddWithValue("@p2", Paciente.Apellido);
        //    }
        //    else
        //    {
        //        cmd.Parameters.AddWithValue("@p2", DBNull.Value);
        //    }

        //    if (Paciente.Dni.Length > 0)
        //    {
        //        cmd.Parameters.AddWithValue("@p3", Paciente.Dni);
        //    }
        //    else
        //    {
        //        cmd.Parameters.AddWithValue("@p3", DBNull.Value);
        //    }
        //    #endregion ValidaParametros

        //    this.sqlDataAdapter = new SqlDataAdapter(cmd);

        //    DataSet ds = new DataSet();
        //    this.sqlDataAdapter.Fill(ds, "Pacientes");

        //    this.connectionString.Close();

        //    return (ds);
        //}

        public bool ExistePaciente(string identificador)
        {
            this.connectionString.Open();

            this.cmd = new SqlCommand(Queries.EXISTE_Paciente_POR_IDENTIFICADOR, connectionString);
            cmd.Parameters.AddWithValue("@p1", identificador);
            cmd.Parameters.AddWithValue("@p2", int.Parse(identificador));
            this.sqlDataAdapter = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            this.sqlDataAdapter.Fill(ds, "Pacientes");

            this.connectionString.Close();

            if (ds != null && ds.Tables[0].Rows.Count.Equals(0))
            {
                return (false);
            }

            return (true);
        }

        public void GuardarPaciente(string nombre, string apellido, string dni, DateTime fechaNacimiento, string telefonoFijo, string telefonoCelular, string telefonoTrabajo, string email, string domicilio, string localidad)
        {
            
            this.connectionString.Open();

            this.cmd = new SqlCommand(Queries.GUARDAR_ALTA_Paciente, connectionString);

            #region ValidaParametros
            if (nombre != null && nombre.Length > 0)
            {
                cmd.Parameters.AddWithValue("@p1", nombre);
            }
            else
            {
                cmd.Parameters.AddWithValue("@p1", DBNull.Value);
            }

            if (apellido != null && apellido.Length > 0)
            {
                cmd.Parameters.AddWithValue("@p2", apellido);
            }
            else
            {
                cmd.Parameters.AddWithValue("@p2", DBNull.Value);
            }

            if (dni != null && dni.Length > 0)
            {
                cmd.Parameters.AddWithValue("@p3", dni);
            }
            else
            {
                cmd.Parameters.AddWithValue("@p3", DBNull.Value);
            }

            if (fechaNacimiento != null)
            {
                cmd.Parameters.AddWithValue("@p4", fechaNacimiento);
            }
            else
            {
                cmd.Parameters.AddWithValue("@p4", DBNull.Value);
            }

            if (telefonoFijo != null && telefonoFijo.Length > 0)
            {
                cmd.Parameters.AddWithValue("@p5", telefonoFijo);
            }
            else
            {
                cmd.Parameters.AddWithValue("@p5", DBNull.Value);
            }

            if (telefonoCelular != null && telefonoCelular.Length > 0)
            {
                cmd.Parameters.AddWithValue("@p6", telefonoCelular);
            }
            else
            {
                cmd.Parameters.AddWithValue("@p6", DBNull.Value);
            }

            if (telefonoTrabajo != null && telefonoTrabajo.Length > 0)
            {
                cmd.Parameters.AddWithValue("@p7", telefonoTrabajo);
            }
            else
            {
                cmd.Parameters.AddWithValue("@p7", DBNull.Value);
            }

            if (email != null && email.Length > 0)
            {
                cmd.Parameters.AddWithValue("@p8", email);
            }
            else
            {
                cmd.Parameters.AddWithValue("@p8", DBNull.Value);
            }

            if (domicilio != null && domicilio.Length > 0)
            {
                cmd.Parameters.AddWithValue("@p9", domicilio);
            }
            else
            {
                cmd.Parameters.AddWithValue("@p9", DBNull.Value);
            }

            if (localidad != null && localidad.Length > 0)
            {
                cmd.Parameters.AddWithValue("@p10", localidad);
            }
            else
            {
                cmd.Parameters.AddWithValue("@p10", DBNull.Value);
            }
            #endregion ValidaParametros

            this.cmd.CommandType = CommandType.Text;
            int i = cmd.ExecuteNonQuery();

            this.connectionString.Close();
        }

        public void ActualizarPaciente(int idPaciente, string nombre, string apellido, string dni, DateTime fechaNacimiento, string telefonoFijo, string telefonoCelular, string telefonoTrabajo, string email, string domicilio, string localidad)
        {
            this.connectionString.Open();

            this.cmd = new SqlCommand(Queries.GUARDAR_EDITAR_Paciente, connectionString);

            #region ValidaParametros
            if (idPaciente > 0)
            {
                cmd.Parameters.AddWithValue("@p11", idPaciente);
            }
            else
            {
                cmd.Parameters.AddWithValue("@p11", DBNull.Value);
            }

            if (nombre != null && nombre.Length > 0)
            {
                cmd.Parameters.AddWithValue("@p1", nombre);
            }
            else
            {
                cmd.Parameters.AddWithValue("@p1", DBNull.Value);
            }

            if (apellido != null && apellido.Length > 0)
            {
                cmd.Parameters.AddWithValue("@p2", apellido);
            }
            else
            {
                cmd.Parameters.AddWithValue("@p2", DBNull.Value);
            }

            if (dni != null && dni.Length > 0)
            {
                cmd.Parameters.AddWithValue("@p3", dni);
            }
            else
            {
                cmd.Parameters.AddWithValue("@p3", DBNull.Value);
            }

            if (fechaNacimiento != null)
            {
                cmd.Parameters.AddWithValue("@p4", fechaNacimiento);
            }
            else
            {
                cmd.Parameters.AddWithValue("@p4", DBNull.Value);
            }

            if (telefonoFijo != null && telefonoFijo.Length > 0)
            {
                cmd.Parameters.AddWithValue("@p5", telefonoFijo);
            }
            else
            {
                cmd.Parameters.AddWithValue("@p5", DBNull.Value);
            }

            if (telefonoCelular != null && telefonoCelular.Length > 0)
            {
                cmd.Parameters.AddWithValue("@p6", telefonoCelular);
            }
            else
            {
                cmd.Parameters.AddWithValue("@p6", DBNull.Value);
            }

            if (telefonoTrabajo != null && telefonoTrabajo.Length > 0)
            {
                cmd.Parameters.AddWithValue("@p7", telefonoTrabajo);
            }
            else
            {
                cmd.Parameters.AddWithValue("@p7", DBNull.Value);
            }

            if (email != null && email.Length > 0)
            {
                cmd.Parameters.AddWithValue("@p8", email);
            }
            else
            {
                cmd.Parameters.AddWithValue("@p8", DBNull.Value);
            }

            if (domicilio != null && domicilio.Length > 0)
            {
                cmd.Parameters.AddWithValue("@p9", domicilio);
            }
            else
            {
                cmd.Parameters.AddWithValue("@p9", DBNull.Value);
            }

            if (localidad != null && localidad.Length > 0)
            {
                cmd.Parameters.AddWithValue("@p10", localidad);
            }
            else
            {
                cmd.Parameters.AddWithValue("@p10", DBNull.Value);
            }
            #endregion ValidaParametros

            this.cmd.CommandType = CommandType.Text;
            int i = cmd.ExecuteNonQuery();

            this.connectionString.Close();
        }

        public void DarDeBajaPaciente(int idPaciente, string motivo)
        {
            this.connectionString.Open();

            this.cmd = new SqlCommand(Queries.GUARDAR_BAJA_Paciente, connectionString);

            #region ValidaParametros
            if (idPaciente > 0)
            {
                cmd.Parameters.AddWithValue("@p1", idPaciente);
            }
            else
            {
                cmd.Parameters.AddWithValue("@p1", DBNull.Value);
            }

            if (motivo != null && motivo.Length > 0)
            {
                cmd.Parameters.AddWithValue("@p2", motivo);
            }
            else
            {
                cmd.Parameters.AddWithValue("@p2", DBNull.Value);
            }
            #endregion ValidaParametros

            this.cmd.CommandType = CommandType.Text;
            int i = cmd.ExecuteNonQuery();

            this.connectionString.Close();
        }
    }
}
