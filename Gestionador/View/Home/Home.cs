using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Gestionador.View.Pacientes;
using System.IO;
using System.Reflection;
using Gestionador.View.HistoriaClinica;

namespace Gestionador.View.Home
{
    public partial class home : Form
    {
        private Paciente_ABM PacientesABM = null;
        private HistoriaClinica_ABM hClinicaABM = null;

        public home()
        {
            InitializeComponent();
            this.CargaInicial();
        }

        private void Pacientes_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.PacientesABM = new Paciente_ABM();
            this.PacientesABM.StartPosition = FormStartPosition.CenterParent;
            this.PacientesABM.Tag = this;
            this.PacientesABM.Region = this.Region;
            this.PacientesABM.ShowDialog(this);
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
            this.BackColor = Color.FromArgb(Visual.FONDO_COMPONENTE_RED, Visual.FONDO_COMPONENTE_GREEN, Visual.FONDO_COMPONENTE_BLUE);

            this.btnPacientes.BackColor = Color.FromArgb(Visual.BOTON_COMPONENTE_RED, Visual.BOTON_COMPONENTE_GREEN, Visual.BOTON_COMPONENTE_BLUE);
            this.btnHClinica.BackColor = Color.FromArgb(Visual.BOTON_COMPONENTE_RED, Visual.BOTON_COMPONENTE_GREEN, Visual.BOTON_COMPONENTE_BLUE);
            this.btnTratamientos.BackColor = Color.FromArgb(Visual.BOTON_COMPONENTE_RED, Visual.BOTON_COMPONENTE_GREEN, Visual.BOTON_COMPONENTE_BLUE);
            this.btnProductos.BackColor = Color.FromArgb(Visual.BOTON_COMPONENTE_RED, Visual.BOTON_COMPONENTE_GREEN, Visual.BOTON_COMPONENTE_BLUE);
            this.btnMedicas.BackColor = Color.FromArgb(Visual.BOTON_COMPONENTE_RED, Visual.BOTON_COMPONENTE_GREEN, Visual.BOTON_COMPONENTE_BLUE);

            this.MaximizeBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        }

        private void btnHClinica_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.hClinicaABM = new HistoriaClinica_ABM();
            this.hClinicaABM.StartPosition = FormStartPosition.CenterParent;
            this.hClinicaABM.Tag = this;
            this.hClinicaABM.Region = this.Region;
            this.hClinicaABM.ShowDialog(this);
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
