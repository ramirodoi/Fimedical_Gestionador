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

        public HistoriaClinica_Consulta()
        {
            InitializeComponent();
            
            this.PacienteController = new PacientesController();
            this.hClinicaController = new HClinicaController();
            this.tratamientosController = new TratamientosController();
            this.medicasController = new MedicasController();
            this.productosController = new ProductosController();

            this.CargarFormatoVentana();
            this.CargarFormateDatePicker();

            this.CargarComboPacientes();
            this.CargarComboMedicas();
            this.CargarComboTratamientos();
            this.CargarComboProductos();
            
        }

        /// <summary>
        /// Carga incial del datetimepicker fecha de nacimiento vacio.
        /// </summary>
        private void CargarFormateDatePicker()
        {
            dpFecha.Format = DateTimePickerFormat.Custom;
            dpFecha.CustomFormat = " ";
        }

        /// <summary>
        /// Formatea el datetimepicker fecha de nacimiento cuando se carga.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dpFechaTratamiento_ValueChanged(object sender, EventArgs e)
        {
            dpFecha.CustomFormat = "dd/MM/yyyy";
        }

        private void CargarFormatoVentana()
        {
            this.BackColor = Color.FromArgb(Visual.FONDO_COMPONENTE_RED, Visual.FONDO_COMPONENTE_GREEN, Visual.FONDO_COMPONENTE_BLUE);

            this.btnConsultar.BackColor = Color.FromArgb(Visual.BOTON_COMPONENTE_RED, Visual.BOTON_COMPONENTE_GREEN, Visual.BOTON_COMPONENTE_BLUE);
            this.btnVolver.BackColor = Color.FromArgb(Visual.BOTON_COMPONENTE_RED, Visual.BOTON_COMPONENTE_GREEN, Visual.BOTON_COMPONENTE_BLUE);

            this.MaximizeBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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

        private void CargarComboMedicas()
        {
            DataSet medicas = this.medicasController.ObtenerTodasLasMedicasActivas();
            ComboboxItem item = null;

            //Item vacio.
            item = new ComboboxItem();
            item.Text = "-";
            item.Value = -1;
            cbMedica.Items.Add(item);

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

        private void CargarComboTratamientos()
        {
            DataSet tratamientos = this.tratamientosController.ObtenerTodosLosTratamientosActivos();
            ComboboxItem item = null;

            //Item vacio.
            item = new ComboboxItem();
            item.Text = "-";
            item.Value = -1;
            cbTratamiento.Items.Add(item);

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

        private void CargarComboProductos()
        {
            DataSet productos = this.productosController.ObtenerTodosLosProductosActivos();
            ComboboxItem item = null;

            //Item vacio.
            item = new ComboboxItem();
            item.Text = "-";
            item.Value = -1;
            cbProducto.Items.Add(item);

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

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (int.Parse(((ComboboxItem)this.cbPaciente.SelectedItem).Value.ToString()) > 0)
            {
                DateTime? fecha = null;

                if (this.dpFecha.CustomFormat != " ")
                {
                    fecha = this.dpFecha.Value;
                }

                if (int.Parse(((ComboboxItem)this.cbMedica.SelectedItem).Value.ToString()) > 0 || int.Parse(((ComboboxItem)this.cbTratamiento.SelectedItem).Value.ToString()) > 0 || int.Parse(((ComboboxItem)this.cbProducto.SelectedItem).Value.ToString()) > 0)
                {
                    DataSet ds = this.hClinicaController.ObtenerHistoriaClinicaPorConsulta(int.Parse(((ComboboxItem)this.cbPaciente.SelectedItem).Value.ToString()), int.Parse(((ComboboxItem)this.cbMedica.SelectedItem).Value.ToString()), int.Parse(((ComboboxItem)this.cbTratamiento.SelectedItem).Value.ToString()), int.Parse(((ComboboxItem)this.cbProducto.SelectedItem).Value.ToString()), fecha);

                    if (ds != null && ds.Tables[0] != null && ds.Tables[0].Rows.Count > 0)
                    {
                        BindingSource bindingSource = new BindingSource();

                        bindingSource.DataSource = ds.Tables[0];

                        dgHClinica.AutoGenerateColumns = false;
                        dgHClinica.DataSource = bindingSource;
                    }
                }
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Volver();
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
    }
}
