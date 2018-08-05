using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Gestionador.Controller;

namespace Gestionador.View.Pacientes
{
    public partial class Paciente_Baja : Form
    {
        private PacientesController PacientesController = null;
        private Paciente_Baja_Baja PacienteBaja = null;

        public Paciente_Baja()
        {
            InitializeComponent();
            this.PacientesController = new PacientesController();
            this.CargaInicial();
        }

        private void CargaInicial()
        {
            this.CargarFormatoVentana();
        }

        private void CargarFormatoVentana()
        {
            this.BackColor = Color.FromArgb(Visual.FONDO_COMPONENTE_RED, Visual.FONDO_COMPONENTE_GREEN, Visual.FONDO_COMPONENTE_BLUE);

            this.btnConsultar.BackColor = Color.FromArgb(Visual.BOTON_COMPONENTE_RED, Visual.BOTON_COMPONENTE_GREEN, Visual.BOTON_COMPONENTE_BLUE);
            this.btnVolver.BackColor = Color.FromArgb(Visual.BOTON_COMPONENTE_RED, Visual.BOTON_COMPONENTE_GREEN, Visual.BOTON_COMPONENTE_BLUE);

            this.MaximizeBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Paciente_ABM PacientesABM = (Paciente_ABM)Tag;
            PacientesABM.StartPosition = FormStartPosition.CenterParent;
            PacientesABM.Show();
            this.Close();
        }

        private void Paciente_Baja_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fimedicalDataSet.Pacientes' table. You can move, or remove it, as needed.
            this.PacientesTableAdapter.Fill(this.fimedicalDataSet.Pacientes);
        }

        private void dgPacientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((((int)e.RowIndex) >= 0) && (((int)e.ColumnIndex) >= 0))
            {
                var cell = dgPacientes.Rows[e.RowIndex].Cells[0];

                if (cell.Value != null)
                {
                    int idPaciente = (int)cell.Value;

                    if (idPaciente > 0)
                    {
                        this.Hide();
                        this.PacienteBaja = new Paciente_Baja_Baja(idPaciente);
                        this.PacienteBaja.StartPosition = FormStartPosition.CenterParent;
                        this.PacienteBaja.Tag = this;
                        this.PacienteBaja.Region = this.Region;
                        this.PacienteBaja.ShowDialog(this);
                    }
                }
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (this.txtNombre.Text.Length > 0 || this.txtApellido.Text.Length > 0 || this.txtDni.Text.Length > 0)
            {
                BindingSource bindingSource = new BindingSource();
                //bindingSource.DataSource = this.PacientesController.ObtenerDatosPaciente(new ObtenerDatosPacienteRequest() { Nombre = this.txtNombre.Text, Apellido = this.txtApellido.Text, Dni = this.txtDni.Text }).Tables[0];
                bindingSource.DataSource = this.PacientesController.ObtenerDatosPacientePorConsulta(this.txtNombre.Text, this.txtApellido.Text, this.txtDni.Text).Tables[0];

                dgPacientes.AutoGenerateColumns = false;
                dgPacientes.DataSource = bindingSource;
            }
            else
            {
                if (this.txtNombre.Text.Length.Equals(0) && this.txtApellido.Text.Length.Equals(0) && this.txtDni.Text.Length.Equals(0))
                {
                    BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = this.PacientesController.ObtenerTodosLosPacientesActivos().Tables[0];

                    dgPacientes.AutoGenerateColumns = false;
                    dgPacientes.DataSource = bindingSource;
                }
            }
        }
    }
}
