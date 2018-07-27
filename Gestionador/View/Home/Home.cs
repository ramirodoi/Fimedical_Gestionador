using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Gestionador.View.Clientes;
using System.IO;
using System.Reflection;

namespace Gestionador.View.Home
{
    public partial class home : Form
    {
        private clientes_ABM clientesABM = null;

        public home()
        {
            InitializeComponent();
            this.CargaInicial();
        }

        private void Clientes_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.clientesABM = new clientes_ABM();
            this.clientesABM.StartPosition = FormStartPosition.CenterParent;
            this.clientesABM.Tag = this;
            this.clientesABM.Region = this.Region;
            this.clientesABM.ShowDialog(this);
        }

        private void CargaInicial()
        {
            this.CargarFormatoVentana();
            this.CargarImagen();
        }

        private void CargarImagen()
        {
            this.imgLogo.Image = Image.FromFile(Visual.IMAGEN_HOME);
        }

        private void CargarFormatoVentana()
        {
            this.BackColor = Color.FromArgb(Visual.BOTON_COMPONENTE_WHITE, Visual.BOTON_COMPONENTE_WHITE, Visual.BOTON_COMPONENTE_WHITE);

            this.btnClientes.BackColor = Color.FromArgb(Visual.BOTON_COMPONENTE_RED, Visual.BOTON_COMPONENTE_GREEN, Visual.BOTON_COMPONENTE_BLUE);
            this.btnProductos.BackColor = Color.FromArgb(Visual.BOTON_COMPONENTE_RED, Visual.BOTON_COMPONENTE_GREEN, Visual.BOTON_COMPONENTE_BLUE);
            this.btnTratamientos.BackColor = Color.FromArgb(Visual.BOTON_COMPONENTE_RED, Visual.BOTON_COMPONENTE_GREEN, Visual.BOTON_COMPONENTE_BLUE);
            this.btnEmpleados.BackColor = Color.FromArgb(Visual.BOTON_COMPONENTE_RED, Visual.BOTON_COMPONENTE_GREEN, Visual.BOTON_COMPONENTE_BLUE);

            this.MaximizeBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Próximamente!");
        }

        private void btnTratamientos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Próximamente!");
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Próximamente!");
        }
    }
}
