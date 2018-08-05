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
    public partial class Paciente_Baja_Baja : Form
    {
        private int idPaciente;
        private PacientesController PacienteController;

        public Paciente_Baja_Baja(int idPaciente)
        {
            InitializeComponent();
            this.idPaciente = idPaciente;
            this.PacienteController = new PacientesController();
            this.CargaInicial();
        }

        private void CargaInicial()
        {
            this.BackColor = Color.FromArgb(Visual.FONDO_COMPONENTE_RED, Visual.FONDO_COMPONENTE_GREEN, Visual.FONDO_COMPONENTE_BLUE);
            this.btnGuardar.BackColor = Color.FromArgb(Visual.BOTON_COMPONENTE_RED, Visual.BOTON_COMPONENTE_GREEN, Visual.BOTON_COMPONENTE_BLUE);
            this.btnVolver.BackColor = Color.FromArgb(Visual.BOTON_COMPONENTE_RED, Visual.BOTON_COMPONENTE_GREEN, Visual.BOTON_COMPONENTE_BLUE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show(Mensajes.Paciente_Baja_VOLVER, "Alerta", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                this.Volver();
            }
        }

        private void Volver()
        {
            Paciente_Baja PacientesModificacion = (Paciente_Baja)Tag;
            PacientesModificacion.StartPosition = FormStartPosition.CenterParent;
            PacientesModificacion.Show();
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.PuedeGuardar())
            {
                var confirmResult = MessageBox.Show(Mensajes.Paciente_Baja_GUARDAR, "Alerta", MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    bool guardadoOk = this.PacienteController.DarDeBajaPaciente(this.idPaciente, this.txtMotivo.Text);

                    if (guardadoOk)
                    {
                        this.MostrarMensajeYVolver(Mensajes.Paciente_Baja_GUARDAR_OK);
                    }
                }
            }
            else
            {
                MessageBox.Show(Mensajes.Paciente_Baja_VALIDACION_GUARDAR);
            }
        }

        private void MostrarMensajeYVolver(string mensaje)
        {
            MessageBox.Show(mensaje);
            this.Volver();
        }

        private bool PuedeGuardar()
        {
            if (this.txtMotivo.Text.Length > 0)
            {
                return (true);
            }

            return (false);
        }
    }
}
