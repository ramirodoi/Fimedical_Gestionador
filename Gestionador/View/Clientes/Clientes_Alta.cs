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

namespace Gestionador.View.Clientes
{
    public partial class Clientes_Alta : Form
    {
        private ClientesController clientesController = null;

        public Clientes_Alta()
        {
            InitializeComponent();
            this.CargaInicial();
            this.clientesController = new ClientesController();
        }

        private void CargaInicial()
        {
            this.CargarFormatoVentana();
            this.CargarFormateDatePicker();
        }

        /// <summary>
        /// Carga incial del datetimepicker fecha de nacimiento vacio.
        /// </summary>
        private void CargarFormateDatePicker()
        {
            dpFechaNacimiento.Format = DateTimePickerFormat.Custom;
            dpFechaNacimiento.CustomFormat = " ";
        }

        /// <summary>
        /// Formatea el datetimepicker fecha de nacimiento cuando se carga.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dpFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {
            dpFechaNacimiento.CustomFormat = "dd/MM/yyyy";
        }

        private void CargarFormatoVentana()
        {
            this.BackColor = Color.FromArgb(Visual.FONDO_COMPONENTE_RED, Visual.FONDO_COMPONENTE_GREEN, Visual.FONDO_COMPONENTE_BLUE);

            this.btnGuardar.BackColor = Color.FromArgb(Visual.BOTON_COMPONENTE_RED, Visual.BOTON_COMPONENTE_GREEN, Visual.BOTON_COMPONENTE_BLUE);
            this.btnVolver.BackColor = Color.FromArgb(Visual.BOTON_COMPONENTE_RED, Visual.BOTON_COMPONENTE_GREEN, Visual.BOTON_COMPONENTE_BLUE);

            this.MaximizeBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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

        private void Volver()
        {
            Clientes_ABM clientesABM = (Clientes_ABM)Tag;
            clientesABM.StartPosition = FormStartPosition.CenterParent;
            clientesABM.Show();
            this.Close();
        }

        private void MostrarMensajeYVolver(string mensaje)
        {
            MessageBox.Show(mensaje);
            this.Volver();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.PuedeGuardar())
            {
                bool guardadoOk = this.clientesController.GuardarCliente(this.txtNombre.Text, this.txtApellido.Text, this.txtDni.Text, this.dpFechaNacimiento.Value, this.txtTelefonoFijo.Text, this.txtTelefonoCelular.Text, this.txtTelefonoTrabajo.Text, this.txtEmail.Text, this.txtDomicilio.Text, this.txtLocalidad.Text);

                if (guardadoOk)
                {
                    this.MostrarMensajeYVolver(Mensajes.CLIENTES_ALTA_GUARDAR_OK);
                }
                else
                {
                    MessageBox.Show(Mensajes.CLIENTES_ALTA_VALIDACION_GUARDAR_EXISTENTE);
                }
            }
            else
            {
                MessageBox.Show(Mensajes.CLIENTES_ALTA_VALIDACION_GUARDAR);
            }
        }

        private bool PuedeGuardar()
        {
            if (this.txtNombre.Text.Length > 0 && this.txtApellido.Text.Length > 0 && this.txtDni.Text.Length > 0 && this.dpFechaNacimiento.Value != null && this.txtTelefonoCelular.Text.Length > 0)
            {
                return(true);
            }

            return(false);
        }

        private bool SePerderanLosCambios()
        {
            if (this.txtNombre.Text.Length > 0 || this.txtApellido.Text.Length > 0 || this.txtDni.Text.Length > 0 || this.dpFechaNacimiento.CustomFormat != " " || this.txtTelefonoCelular.Text.Length > 0)
            {
                return (true);
            }

            return (false);
        }
    }
}
