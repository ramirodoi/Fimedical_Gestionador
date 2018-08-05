using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gestionador.View.HistoriaClinica
{
    public partial class HistoriaClinica_ABM : Form
    {
        private HistoriaClinica_Alta hClinicaAlta = null;

        public HistoriaClinica_ABM()
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
            //this.imgCool.Image = Image.FromFile(Visual.IMAGEN_ABM);
        }

        private void CargarFormatoVentana()
        {
            this.BackColor = Color.FromArgb(Visual.FONDO_COMPONENTE_RED, Visual.FONDO_COMPONENTE_GREEN, Visual.FONDO_COMPONENTE_BLUE);

            this.btnAlta.BackColor = Color.FromArgb(Visual.BOTON_COMPONENTE_RED, Visual.BOTON_COMPONENTE_GREEN, Visual.BOTON_COMPONENTE_BLUE);
            //this.btnBaja.BackColor = Color.FromArgb(Visual.BOTON_COMPONENTE_RED, Visual.BOTON_COMPONENTE_GREEN, Visual.BOTON_COMPONENTE_BLUE);
            //this.btnModificacion.BackColor = Color.FromArgb(Visual.BOTON_COMPONENTE_RED, Visual.BOTON_COMPONENTE_GREEN, Visual.BOTON_COMPONENTE_BLUE);
            this.btnVolver.BackColor = Color.FromArgb(Visual.BOTON_COMPONENTE_RED, Visual.BOTON_COMPONENTE_GREEN, Visual.BOTON_COMPONENTE_BLUE);

            this.MaximizeBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.hClinicaAlta = new HistoriaClinica_Alta();
            this.hClinicaAlta.StartPosition = FormStartPosition.CenterParent;
            this.hClinicaAlta.Tag = this;
            this.hClinicaAlta.Region = this.Region;
            this.hClinicaAlta.ShowDialog(this);
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
