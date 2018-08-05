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
    public partial class HistoriaClinica_Alta : Form
    {
        private ClientesController clienteController = null;
        private HClinicaController hClinicaController = null;
        private TratamientosController tratamientosController = null;
        private MedicasController medicasController = null;
        private ProductosController productosController = null;
        private MediosPagoController mediosPagoController = null;

        public HistoriaClinica_Alta()
        {
            InitializeComponent();
            
            this.clienteController = new ClientesController();
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

            this.btnAgregarTratamiento.BackColor = Color.FromArgb(Visual.BOTON_COMPONENTE_RED, Visual.BOTON_COMPONENTE_GREEN, Visual.BOTON_COMPONENTE_BLUE);
            this.btnAgregarProducto.BackColor = Color.FromArgb(Visual.BOTON_COMPONENTE_RED, Visual.BOTON_COMPONENTE_GREEN, Visual.BOTON_COMPONENTE_BLUE);
            this.btnGuardar.BackColor = Color.FromArgb(Visual.BOTON_COMPONENTE_RED, Visual.BOTON_COMPONENTE_GREEN, Visual.BOTON_COMPONENTE_BLUE);
            this.btnVolver.BackColor = Color.FromArgb(Visual.BOTON_COMPONENTE_RED, Visual.BOTON_COMPONENTE_GREEN, Visual.BOTON_COMPONENTE_BLUE);

            this.MaximizeBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        }

        private void CargarTratamientos()
        {
            this.CargarComboTratamientos();
            this.CargarComboMedicas();
            this.CargarComboMediosPagoTratamientos();
        }

        private void CargarProductos()
        {
            this.CargarComboProductos();
            this.CargarComboMediosPagoProductos();
        }

        #region Carga Combos
        private void CargarComboPacientes()
        {
            DataSet pacientes = this.clienteController.ObtenerTodosLosClientesActivos();
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
                    item.Value = paciente["idCliente"].ToString();

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

        private void CargarComboMediosPagoTratamientos()
        {
            DataSet medios = this.mediosPagoController.ObtenerTodosLosMediosPagoActivos();
            ComboboxItem item = null;

            //Item vacio.
            item = new ComboboxItem();
            item.Text = "-";
            item.Value = -1;

            cbMedioPagoTratamiento.Items.Add(item);

            if (medios != null && medios.Tables[0] != null && medios.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow medio in medios.Tables[0].Rows)
                {
                    item = new ComboboxItem();
                    item.Text = string.Format("{0}", medio["nombre"].ToString());
                    item.Value = medio["idMedioPago"].ToString();

                    cbMedioPagoTratamiento.Items.Add(item);
                }

                cbMedioPagoTratamiento.SelectedIndex = 0;
            }
        }

        private void CargarComboMediosPagoProductos()
        {
            DataSet medios = this.mediosPagoController.ObtenerTodosLosMediosPagoActivos();
            ComboboxItem item = null;

            //Item vacio.
            item = new ComboboxItem();
            item.Text = "-";
            item.Value = -1;

            cbMedioPagoProducto.Items.Add(item);

            if (medios != null && medios.Tables[0] != null && medios.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow medio in medios.Tables[0].Rows)
                {
                    item = new ComboboxItem();
                    item.Text = string.Format("{0}", medio["nombre"].ToString());
                    item.Value = medio["idMedioPago"].ToString();

                    cbMedioPagoProducto.Items.Add(item);
                }

                cbMedioPagoProducto.SelectedIndex = 0;
            }
        }
        #endregion Fin Carga Combos

        private void btnAgregarTratamiento_Click(object sender, EventArgs e)
        {
            if (this.PuedeAgregarTratamiento())
            {
                DataGridViewRow tratamiento = (DataGridViewRow)this.dgHClinica.RowTemplate.Clone();
                //tratamiento.CreateCells(this.dgHClinica, "Tratamiento", ((ComboboxItem)this.cbTratamiento.SelectedItem).Text.ToString(), this.dpFechaTratamiento.Text.ToString(), ((ComboboxItem)this.cbMedica.SelectedItem).Text.ToString(), this.txtPrecioTratamiento.Text.ToString(), this.txtPagoTratamiento.Text.ToString(), this.cbMedioPagoTratamiento.Text.ToString());
                tratamiento.CreateCells(this.dgHClinica, "Tratamiento", ((ComboboxItem)this.cbTratamiento.SelectedItem).Value.ToString(), ((ComboboxItem)this.cbTratamiento.SelectedItem).Text.ToString(), DateTime.Now.ToShortDateString(), ((ComboboxItem)this.cbMedica.SelectedItem).Value.ToString(), ((ComboboxItem)this.cbMedica.SelectedItem).Text.ToString(), this.txtPrecioTratamiento.Text.ToString(), this.txtPagoTratamiento.Text.ToString(), ((ComboboxItem)this.cbMedioPagoTratamiento.SelectedItem).Value.ToString(), ((ComboboxItem)this.cbMedioPagoTratamiento.SelectedItem).Text.ToString());

                this.dgHClinica.Rows.Add(tratamiento);

                this.LimpiarTratamiento();
            }
            else
            {
                MessageBox.Show(Mensajes.HCLINICA_ALTA_VALIDACION_AGREGAR_TRATAMIENTO);
            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (this.PuedeAgregarProducto())
            {
                DataGridViewRow producto = (DataGridViewRow)this.dgHClinica.RowTemplate.Clone();
                //producto.CreateCells(this.dgHClinica, "Producto", ((ComboboxItem)this.cbProducto.SelectedItem).Text.ToString(), this.dpFechaProducto.Text.ToString(), "-", this.txtPrecioProducto.Text.ToString(), this.txtPagoProducto.Text.ToString(), this.cbMedioPagoProducto.Text.ToString());
                producto.CreateCells(this.dgHClinica, "Producto", ((ComboboxItem)this.cbProducto.SelectedItem).Value.ToString(), ((ComboboxItem)this.cbProducto.SelectedItem).Text.ToString(), DateTime.Now.ToShortDateString(), "-1", "-", this.txtPrecioProducto.Text.ToString(), this.txtPagoProducto.Text.ToString(), ((ComboboxItem)this.cbMedioPagoProducto.SelectedItem).Value.ToString(), ((ComboboxItem)this.cbMedioPagoProducto.SelectedItem).Text.ToString());

                this.dgHClinica.Rows.Add(producto);

                this.LimpiarProducto();
            }
            else
            {
                MessageBox.Show(Mensajes.HCLINICA_ALTA_VALIDACION_AGREGAR_PRODUCTO);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.PuedeGuardar())
            {
                this.hClinicaController.GuardarHistoriaClinica(int.Parse(((ComboboxItem)this.cbPaciente.SelectedItem).Value.ToString()), this.ObtenerHistoriaClinicaComoTabla());

                this.MostrarMensajeYVolver(Mensajes.HCLINICA_ALTA_GUARDAR_OK);
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
                var confirmResult = MessageBox.Show(Mensajes.CLIENTES_ALTA_VOLVER, "Alerta", MessageBoxButtons.YesNo);

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

        private void LimpiarTratamiento()
        {
            this.cbTratamiento.SelectedIndex = 0;
            this.cbMedica.SelectedIndex = 0;
            this.txtPrecioTratamiento.Text = string.Empty;
            this.txtPagoTratamiento.Text = string.Empty;
            this.cbMedioPagoTratamiento.SelectedIndex = 0;
        }

        private void LimpiarProducto()
        {
            this.cbProducto.SelectedIndex = 0;
            this.txtPrecioProducto.Text = string.Empty;
            this.txtPagoProducto.Text = string.Empty;
            this.cbMedioPagoProducto.SelectedIndex = 0;
        }

        private void Volver()
        {
            HistoriaClinica_ABM clientesABM = (HistoriaClinica_ABM)Tag;
            clientesABM.StartPosition = FormStartPosition.CenterParent;
            clientesABM.Show();
            this.Close();
        }

        private void MostrarMensajeYVolver(string mensaje)
        {
            MessageBox.Show(mensaje);
            this.Volver();
        }

        #region Validaciones
        private bool PuedeAgregarTratamiento()
        {
            if (this.txtPrecioTratamiento.Text.Length > 0 && this.txtPagoTratamiento.Text.Length > 0 && !((ComboboxItem)this.cbMedioPagoTratamiento.SelectedItem).Text.ToString().Equals("-"))
            {
                return (true);
            }

            return (false);
        }

        private bool PuedeAgregarProducto()
        {
            if (this.txtPrecioProducto.Text.Length > 0 && this.txtPagoProducto.Text.Length > 0 && !((ComboboxItem)this.cbMedioPagoProducto.SelectedItem).Text.ToString().Equals("-"))
            {
                return (true);
            }

            return (false);
        }

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

        private void txtPrecioTratamiento_TextChanged(object sender, EventArgs e)
        {
            if (this.txtPrecioTratamiento.Text.Length > 0)
            {
                int number = 0;

                if (int.TryParse(this.txtPrecioTratamiento.Text.Trim(), out number))
                {
                }
                else
                {
                    MessageBox.Show(Mensajes.HCLINICA_ALTA_VALIDACION_AGREGAR_TRATAMIENTO_PRECIO);
                    this.txtPrecioTratamiento.Text = this.txtPrecioTratamiento.Text.Substring(0, this.txtPrecioTratamiento.Text.Length - 1);
                }
            }
        }

        private void txtPagoTratamiento_TextChanged(object sender, EventArgs e)
        {
            if (this.txtPagoTratamiento.Text.Length > 0)
            {
                int number = 0;

                if (int.TryParse(this.txtPagoTratamiento.Text.Trim(), out number))
                {
                }
                else
                {
                    MessageBox.Show(Mensajes.HCLINICA_ALTA_VALIDACION_AGREGAR_TRATAMIENTO_PAGO);
                    this.txtPagoTratamiento.Text = this.txtPagoTratamiento.Text.Substring(0, this.txtPagoTratamiento.Text.Length - 1);
                }
            }
        }

        private void txtPrecioProducto_TextChanged(object sender, EventArgs e)
        {
            if (this.txtPrecioProducto.Text.Length > 0)
            {
                int number = 0;

                if (int.TryParse(this.txtPrecioProducto.Text.Trim(), out number))
                {
                }
                else
                {
                    MessageBox.Show(Mensajes.HCLINICA_ALTA_VALIDACION_AGREGAR_PRODUCTO_PRECIO);
                    this.txtPrecioProducto.Text = this.txtPrecioProducto.Text.Substring(0, this.txtPrecioProducto.Text.Length - 1);
                }
            }
        }

        private void txtPagoProducto_TextChanged(object sender, EventArgs e)
        {
            if (this.txtPagoProducto.Text.Length > 0)
            {
                int number = 0;

                if (int.TryParse(this.txtPagoProducto.Text.Trim(), out number))
                {
                }
                else
                {
                    MessageBox.Show(Mensajes.HCLINICA_ALTA_VALIDACION_AGREGAR_PRODUCTO_PAGO);
                    this.txtPagoProducto.Text = this.txtPagoProducto.Text.Substring(0, this.txtPagoProducto.Text.Length - 1);
                }
            }
        }
        #endregion Validaciones  
    }
}
