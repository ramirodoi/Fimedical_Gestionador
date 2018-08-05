using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Gestionador.Model;
using Gestionador.Controller;

namespace Gestionador.View.Pacientes
{
    public partial class Pacientes_Modificar_Editar : Form
    {
        private int idPaciente;
        private PacientesController PacienteController;

        public Pacientes_Modificar_Editar(int idPaciente)
        {
            InitializeComponent();
            this.idPaciente = idPaciente;
            this.PacienteController = new PacientesController();
            this.CargarDatosPaciente();
            this.CargaInicial();
        }

        private void CargaInicial()
        {
            this.BackColor = Color.FromArgb(Visual.FONDO_COMPONENTE_RED, Visual.FONDO_COMPONENTE_GREEN, Visual.FONDO_COMPONENTE_BLUE);
            this.btnGuardar.BackColor = Color.FromArgb(Visual.BOTON_COMPONENTE_RED, Visual.BOTON_COMPONENTE_GREEN, Visual.BOTON_COMPONENTE_BLUE);
            this.btnVolver.BackColor = Color.FromArgb(Visual.BOTON_COMPONENTE_RED, Visual.BOTON_COMPONENTE_GREEN, Visual.BOTON_COMPONENTE_BLUE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        }

        private void CargarDatosPaciente()
        {
            DataSet ds = PacienteController.ObtenerDatosPacientePorId(this.idPaciente);

            if(ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];

                if (dr != null)
                {
                    this.txtNombre.Text = dr["nombre"].ToString();
                    this.txtApellido.Text = dr["apellido"].ToString();
                    this.txtDni.Text = dr["dni"].ToString();
                    this.dpFechaNacimiento.Value = DateTime.Parse(dr["fechaNacimiento"].ToString());
                    this.txtTelefonoFijo.Text = dr["telefonoFijo"].ToString();
                    this.txtTelefonoCelular.Text = dr["telefonoCelular"].ToString();
                    this.txtTelefonoTrabajo.Text = dr["telefonoTrabajo"].ToString();
                    this.txtEmail.Text = dr["email"].ToString();
                    this.txtDomicilio.Text = dr["domicilio"].ToString();
                    this.txtLocalidad.Text = dr["localidad"].ToString();
                }
            }
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show(Mensajes.PacienteS_EDITAR_VOLVER, "Alerta", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                this.Volver();
            }
        }

        private void Volver()
        {
            Paciente_Modificacion PacientesModificacion = (Paciente_Modificacion)Tag;
            PacientesModificacion.StartPosition = FormStartPosition.CenterParent;
            PacientesModificacion.Show();
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.PuedeGuardar())
            {
                bool guardadoOk = this.PacienteController.ActualizarPaciente(this.idPaciente, this.txtNombre.Text, this.txtApellido.Text, this.txtDni.Text, this.dpFechaNacimiento.Value, this.txtTelefonoFijo.Text, this.txtTelefonoCelular.Text, this.txtTelefonoTrabajo.Text, this.txtEmail.Text, this.txtDomicilio.Text, this.txtLocalidad.Text);

                if (guardadoOk)
                {
                    this.MostrarMensajeYVolver(Mensajes.PacienteS_EDITAR_GUARDAR_OK);
                }
                //TODO: Validar que el DNI modificado no coincida con el DNI de otro Paciente.
                //else
                //{
                //    MessageBox.Show(Mensajes.PacienteS_EDITAR_VALIDACION_GUARDAR_EXISTENTE);
                //}
            }
            else
            {
                MessageBox.Show(Mensajes.PacienteS_EDITAR_VALIDACION_GUARDAR);
            }
        }

        private void MostrarMensajeYVolver(string mensaje)
        {
            MessageBox.Show(mensaje);
            this.Volver();
        }

        private bool PuedeGuardar()
        {
            if (this.txtNombre.Text.Length > 0 && this.txtApellido.Text.Length > 0 && this.txtDni.Text.Length > 0 && this.txtTelefonoCelular.Text.Length > 0)
            {
                return (true);
            }

            return (false);
        }
    }
}
