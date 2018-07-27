using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Gestionador.View.Home;

namespace Gestionador.View.Clientes
{
    public partial class clientes_ABM : Form
    {
        private Clientes_Alta clientesAlta = null;
        private Clientes_Baja clientesBaja = null;
        private Clientes_Modificacion clientesModificacion = null;

        public clientes_ABM()
        {
            InitializeComponent();
            this.CargaInicial();
        }

        private void CargaInicial()
        {
            this.CargarFormatoVentana();
            this.CargarImagen();
        }

        private void CargarImagen()
        {
            this.imgCool.Image = Image.FromFile(Visual.IMAGEN_ABM);
        }

        private void CargarFormatoVentana()
        {
            this.BackColor = Color.FromArgb(Visual.BOTON_COMPONENTE_WHITE, Visual.BOTON_COMPONENTE_WHITE, Visual.BOTON_COMPONENTE_WHITE);

            this.btnAlta.BackColor = Color.FromArgb(Visual.BOTON_COMPONENTE_RED, Visual.BOTON_COMPONENTE_GREEN, Visual.BOTON_COMPONENTE_BLUE);
            this.btnBaja.BackColor = Color.FromArgb(Visual.BOTON_COMPONENTE_RED, Visual.BOTON_COMPONENTE_GREEN, Visual.BOTON_COMPONENTE_BLUE);
            this.btnModificacion.BackColor = Color.FromArgb(Visual.BOTON_COMPONENTE_RED, Visual.BOTON_COMPONENTE_GREEN, Visual.BOTON_COMPONENTE_BLUE);
            this.btnVolver.BackColor = Color.FromArgb(Visual.BOTON_COMPONENTE_RED, Visual.BOTON_COMPONENTE_GREEN, Visual.BOTON_COMPONENTE_BLUE);

            this.MaximizeBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.clientesAlta = new Clientes_Alta();
            this.clientesAlta.StartPosition = FormStartPosition.CenterParent;
            this.clientesAlta.Tag = this;
            this.clientesAlta.Region = this.Region;
            this.clientesAlta.ShowDialog(this);
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Próximamente!");
            this.Hide();
            this.clientesBaja = new Clientes_Baja();
            this.clientesBaja.StartPosition = FormStartPosition.CenterParent;
            this.clientesBaja.Tag = this;
            this.clientesBaja.Region = this.Region;
            this.clientesBaja.ShowDialog(this);
        }

        private void btnModificacion_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.clientesModificacion = new Clientes_Modificacion();
            this.clientesModificacion.StartPosition = FormStartPosition.CenterParent;
            this.clientesModificacion.Tag = this;
            this.clientesModificacion.Region = this.Region;
            this.clientesModificacion.ShowDialog(this);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Home.home home = (Home.home)Tag;
            home.StartPosition = FormStartPosition.CenterParent;
            home.Region = this.Region;
            home.Show();
            this.Close();
        }
    }
}
