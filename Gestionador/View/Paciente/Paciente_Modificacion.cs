using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Gestionador.Controller;
//using Gestionador.Controller.Entities;

namespace Gestionador.View.Pacientes
{
    public partial class Paciente_Modificacion : Form
    {
        private PacientesController PacientesController = null;
        private Pacientes_Modificar_Editar PacienteEditar = null;

        public Paciente_Modificacion()
        {
            InitializeComponent();
            this.PacientesController = new PacientesController();
            this.CargaInicial();
        }

        private void CargaInicial()
        {
            this.BackColor = Color.FromArgb(Visual.FONDO_COMPONENTE_RED, Visual.FONDO_COMPONENTE_GREEN, Visual.FONDO_COMPONENTE_BLUE);
            this.btnConsultar.BackColor = Color.FromArgb(Visual.BOTON_COMPONENTE_RED, Visual.BOTON_COMPONENTE_GREEN, Visual.BOTON_COMPONENTE_BLUE);
            this.btnVolver.BackColor = Color.FromArgb(Visual.BOTON_COMPONENTE_RED, Visual.BOTON_COMPONENTE_GREEN, Visual.BOTON_COMPONENTE_BLUE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            Paciente_ABM PacientesABM = (Paciente_ABM)Tag;
            PacientesABM.StartPosition = FormStartPosition.CenterParent;
            PacientesABM.Show();
            this.Close();
        }

        private void Paciente_Modificacion_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fimedicalDataSet.Paciente' table. You can move, or remove it, as needed.
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
                        this.PacienteEditar = new Pacientes_Modificar_Editar(idPaciente);
                        this.PacienteEditar.StartPosition = FormStartPosition.CenterParent;
                        this.PacienteEditar.Tag = this;
                        this.PacienteEditar.Region = this.Region;
                        this.PacienteEditar.ShowDialog(this);
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
