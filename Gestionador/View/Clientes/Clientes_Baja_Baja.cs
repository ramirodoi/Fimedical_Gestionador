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
    public partial class Clientes_Baja_Baja : Form
    {
        private int idCliente;
        private ClientesController clienteController;

        public Clientes_Baja_Baja(int idCliente)
        {
            InitializeComponent();
            this.idCliente = idCliente;
            this.clienteController = new ClientesController();
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
            var confirmResult = MessageBox.Show(Mensajes.CLIENTES_BAJA_VOLVER, "Alerta", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                this.Volver();
            }
        }

        private void Volver()
        {
            Clientes_Baja clientesModificacion = (Clientes_Baja)Tag;
            clientesModificacion.StartPosition = FormStartPosition.CenterParent;
            clientesModificacion.Show();
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.PuedeGuardar())
            {
                var confirmResult = MessageBox.Show(Mensajes.CLIENTES_BAJA_GUARDAR, "Alerta", MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    bool guardadoOk = this.clienteController.DarDeBajaCliente(this.idCliente, this.txtMotivo.Text);

                    if (guardadoOk)
                    {
                        this.MostrarMensajeYVolver(Mensajes.CLIENTES_BAJA_GUARDAR_OK);
                    }
                }
            }
            else
            {
                MessageBox.Show(Mensajes.CLIENTES_BAJA_VALIDACION_GUARDAR);
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
