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
    public partial class Clientes_Modificar_Editar : Form
    {
        private int idCliente;
        private ClientesController clienteController;

        public Clientes_Modificar_Editar(int idCliente)
        {
            InitializeComponent();
            this.idCliente = idCliente;
            this.clienteController = new ClientesController();
            this.CargarDatosCliente();
            this.CargaInicial();
        }

        private void CargaInicial()
        {
            this.BackColor = Color.FromArgb(Visual.FONDO_COMPONENTE_RED, Visual.FONDO_COMPONENTE_GREEN, Visual.FONDO_COMPONENTE_BLUE);
            this.btnGuardar.BackColor = Color.FromArgb(Visual.BOTON_COMPONENTE_RED, Visual.BOTON_COMPONENTE_GREEN, Visual.BOTON_COMPONENTE_BLUE);
            this.btnVolver.BackColor = Color.FromArgb(Visual.BOTON_COMPONENTE_RED, Visual.BOTON_COMPONENTE_GREEN, Visual.BOTON_COMPONENTE_BLUE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        }

        private void CargarDatosCliente()
        {
            DataSet ds = clienteController.ObtenerDatosClientePorId(this.idCliente);

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
            var confirmResult = MessageBox.Show(Mensajes.CLIENTES_EDITAR_VOLVER, "Alerta", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                this.Volver();
            }
        }

        private void Volver()
        {
            Clientes_Modificacion clientesModificacion = (Clientes_Modificacion)Tag;
            clientesModificacion.StartPosition = FormStartPosition.CenterParent;
            clientesModificacion.Show();
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.PuedeGuardar())
            {
                bool guardadoOk = this.clienteController.ActualizarCliente(this.idCliente, this.txtNombre.Text, this.txtApellido.Text, this.txtDni.Text, this.dpFechaNacimiento.Value, this.txtTelefonoFijo.Text, this.txtTelefonoCelular.Text, this.txtTelefonoTrabajo.Text, this.txtEmail.Text, this.txtDomicilio.Text, this.txtLocalidad.Text);

                if (guardadoOk)
                {
                    this.MostrarMensajeYVolver(Mensajes.CLIENTES_EDITAR_GUARDAR_OK);
                }
                //TODO: Validar que el DNI modificado no coincida con el DNI de otro Cliente.
                //else
                //{
                //    MessageBox.Show(Mensajes.CLIENTES_EDITAR_VALIDACION_GUARDAR_EXISTENTE);
                //}
            }
            else
            {
                MessageBox.Show(Mensajes.CLIENTES_EDITAR_VALIDACION_GUARDAR);
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
