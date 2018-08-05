using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Gestionador.Controller;
using Gestionador.View.Common;

namespace Gestionador.View.HistoriaClinica
{
    public partial class HistoriaClinica_Consulta : Form
    {
        private PacientesController PacienteController = null;
        private HClinicaController hClinicaController = null;
        private TratamientosController tratamientosController = null;
        private MedicasController medicasController = null;
        private ProductosController productosController = null;
        private MediosPagoController mediosPagoController = null;

        public HistoriaClinica_Consulta()
        {
            InitializeComponent();
            
            this.PacienteController = new PacientesController();
            this.hClinicaController = new HClinicaController();
            this.tratamientosController = new TratamientosController();
            this.medicasController = new MedicasController();
            this.productosController = new ProductosController();
            this.mediosPagoController = new MediosPagoController();

            this.CargarFormatoVentana();
            this.CargarComboPacientes();
            this.CargarTratamientos();
            this.CargarProductos();
            
        }

        private void CargarFormatoVentana()
        {
            this.BackColor = Color.FromArgb(Visual.FONDO_COMPONENTE_RED, Visual.FONDO_COMPONENTE_GREEN, Visual.FONDO_COMPONENTE_BLUE);

            this.btnBuscar.BackColor = Color.FromArgb(Visual.BOTON_COMPONENTE_RED, Visual.BOTON_COMPONENTE_GREEN, Visual.BOTON_COMPONENTE_BLUE);
            this.btnVolver.BackColor = Color.FromArgb(Visual.BOTON_COMPONENTE_RED, Visual.BOTON_COMPONENTE_GREEN, Visual.BOTON_COMPONENTE_BLUE);

            this.MaximizeBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        }

        private void CargarTratamientos()
        {
            this.CargarComboTratamientos();
            this.CargarComboMedicas();
        }

        private void CargarProductos()
        {
            this.CargarComboProductos();
        }

        #region Carga Combos
        private void CargarComboPacientes()
        {
            DataSet pacientes = this.PacienteController.ObtenerTodosLosPacientesActivos();
            ComboboxItem item = null;

            //Item vacio.
            item = new ComboboxItem();
            item.Text = "-";
            item.Value = -1;

            cbPaciente.Items.Add(item);

            if (pacientes != null && pacientes.Tables[0] != null && pacientes.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow paciente in pacientes.Tables[0].Rows)
                {
                    item = new ComboboxItem();
                    item.Text = string.Format("{0}, {1}", paciente["apellido"].ToString(), paciente["nombre"].ToString());
                    item.Value = paciente["idPaciente"].ToString();

                    cbPaciente.Items.Add(item);
                }

                cbPaciente.SelectedIndex = 0;
            }
        }

        private void CargarComboTratamientos()
        {
            DataSet tratamientos = this.tratamientosController.ObtenerTodosLosTratamientosActivos();
            ComboboxItem item = null;

            if (tratamientos != null && tratamientos.Tables[0] != null && tratamientos.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow tratamiento in tratamientos.Tables[0].Rows)
                {
                    item = new ComboboxItem();
                    item.Text = string.Format("{0}", tratamiento["nombre"].ToString());
                    item.Value = tratamiento["idTratamiento"].ToString();

                    cbTratamiento.Items.Add(item);
                }

                cbTratamiento.SelectedIndex = 0;
            }
        }

        private void CargarComboMedicas()
        {
            DataSet medicas = this.medicasController.ObtenerTodasLasMedicasActivas();
            ComboboxItem item = null;

            if (medicas != null && medicas.Tables[0] != null && medicas.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow paciente in medicas.Tables[0].Rows)
                {
                    item = new ComboboxItem();
                    item.Text = string.Format("{0}, {1}", paciente["apellido"].ToString(), paciente["nombre"].ToString());
                    item.Value = paciente["idMedica"].ToString();

                    cbMedica.Items.Add(item);
                }

                cbMedica.SelectedIndex = 0;
            }
        }

        private void CargarComboProductos()
        {
            DataSet productos = this.productosController.ObtenerTodosLosProductosActivos();
            ComboboxItem item = null;

            if (productos != null && productos.Tables[0] != null && productos.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow producto in productos.Tables[0].Rows)
                {
                    item = new ComboboxItem();
                    item.Text = string.Format("{0}", producto["nombre"].ToString());
                    item.Value = producto["idProducto"].ToString();

                    cbProducto.Items.Add(item);
                }

                cbProducto.SelectedIndex = 0;
            }
        }
        #endregion Fin Carga Combos

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (this.PuedeGuardar())
            {
            }
            else
            {
                MessageBox.Show(Mensajes.HCLINICA_ALTA_VALIDACION_GUARDAR);
            }
        }

        private DataTable ObtenerHistoriaClinicaComoTabla()
        {
            DataTable dt = new DataTable();

            foreach (DataGridViewColumn col in dgHClinica.Columns)
            {
               dt.Columns.Add(col.Name);    
            }

            foreach (DataGridViewRow row in dgHClinica.Rows)
            {
                DataRow dRow = dt.NewRow();
                foreach(DataGridViewCell cell in row.Cells)
                {
                    dRow[cell.ColumnIndex] = cell.Value;
                }
                dt.Rows.Add(dRow);
            }

            return (dt);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            if (this.SePerderanLosCambios())
            {
                var confirmResult = MessageBox.Show(Mensajes.Paciente_Alta_VOLVER, "Alerta", MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    this.Volver();
                }
            }
            else
            {
                this.Volver();
            }
        }
        
        private void Volver()
        {
            HistoriaClinica_ABM PacientesABM = (HistoriaClinica_ABM)Tag;
            PacientesABM.StartPosition = FormStartPosition.CenterParent;
            PacientesABM.Show();
            this.Close();
        }

        private void MostrarMensajeYVolver(string mensaje)
        {
            MessageBox.Show(mensaje);
            this.Volver();
        }

        #region Validaciones
        private bool PuedeGuardar()
        {
            if (!((ComboboxItem)this.cbPaciente.SelectedItem).Text.ToString().Equals("-") && this.dgHClinica.RowCount > 0)
            {
                return (true);
            }

            return (false);
        }

        private bool SePerderanLosCambios()
        {
            if (this.dgHClinica.RowCount > 0)
            {
                return (true);
            }

            return (false);
        }
        #endregion Validaciones  
    }
}
