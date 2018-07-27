﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Gestionador.Controller;

namespace Gestionador.View.Clientes
{
    public partial class Clientes_Baja : Form
    {
        private ClientesController clientesController = null;
        private Clientes_Baja_Baja clienteBaja = null;

        public Clientes_Baja()
        {
            InitializeComponent();
            this.clientesController = new ClientesController();
            this.CargaInicial();
        }

        private void CargaInicial()
        {
            this.CargarFormatoVentana();
        }

        private void CargarFormatoVentana()
        {
            this.BackColor = Color.FromArgb(Visual.BOTON_COMPONENTE_WHITE, Visual.BOTON_COMPONENTE_WHITE, Visual.BOTON_COMPONENTE_WHITE);

            this.btnConsultar.BackColor = Color.FromArgb(Visual.BOTON_COMPONENTE_RED, Visual.BOTON_COMPONENTE_GREEN, Visual.BOTON_COMPONENTE_BLUE);
            this.btnVolver.BackColor = Color.FromArgb(Visual.BOTON_COMPONENTE_RED, Visual.BOTON_COMPONENTE_GREEN, Visual.BOTON_COMPONENTE_BLUE);

            this.MaximizeBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            clientes_ABM clientesABM = (clientes_ABM)Tag;
            clientesABM.StartPosition = FormStartPosition.CenterParent;
            clientesABM.Show();
            this.Close();
        }

        private void Clientes_Baja_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fimedicalDataSet.Clientes' table. You can move, or remove it, as needed.
            this.clientesTableAdapter.Fill(this.fimedicalDataSet.Clientes);
        }

        private void dgClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((((int)e.RowIndex) >= 0) && (((int)e.ColumnIndex) >= 0))
            {
                var cell = dgClientes.Rows[e.RowIndex].Cells[0];

                if (cell.Value != null)
                {
                    int idCliente = (int)cell.Value;

                    if (idCliente > 0)
                    {
                        this.Hide();
                        this.clienteBaja = new Clientes_Baja_Baja(idCliente);
                        this.clienteBaja.StartPosition = FormStartPosition.CenterParent;
                        this.clienteBaja.Tag = this;
                        this.clienteBaja.Region = this.Region;
                        this.clienteBaja.ShowDialog(this);
                    }
                }
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (this.txtNombre.Text.Length > 0 || this.txtApellido.Text.Length > 0 || this.txtDni.Text.Length > 0)
            {
                BindingSource bindingSource = new BindingSource();
                //bindingSource.DataSource = this.clientesController.ObtenerDatosCliente(new ObtenerDatosClienteRequest() { Nombre = this.txtNombre.Text, Apellido = this.txtApellido.Text, Dni = this.txtDni.Text }).Tables[0];
                bindingSource.DataSource = this.clientesController.ObtenerDatosClientePorConsulta(this.txtNombre.Text, this.txtApellido.Text, this.txtDni.Text).Tables[0];

                dgClientes.AutoGenerateColumns = false;
                dgClientes.DataSource = bindingSource;
            }
            else
            {
                if (this.txtNombre.Text.Length.Equals(0) && this.txtApellido.Text.Length.Equals(0) && this.txtDni.Text.Length.Equals(0))
                {
                    BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = this.clientesController.ObtenerTodosLosClientesActivos().Tables[0];

                    dgClientes.AutoGenerateColumns = false;
                    dgClientes.DataSource = bindingSource;
                }
            }
        }
    }
}