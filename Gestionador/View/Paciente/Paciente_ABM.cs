using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Gestionador.View.Home;

namespace Gestionador.View.Pacientes
{
    public partial class Paciente_ABM : Form
    {
        private Paciente_Alta PacientesAlta = null;
        private Paciente_Baja PacientesBaja = null;
        private Paciente_Modificacion PacientesModificacion = null;

        public Paciente_ABM()
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
            this.imgCool.Image = Image.FromFile(Visual.IMAGEN_PACIENTE_ABM);
            this.imgCool.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void CargarFormatoVentana()
        {
            this.BackColor = Color.FromArgb(Visual.FONDO_COMPONENTE_RED, Visual.FONDO_COMPONENTE_RED, Visual.FONDO_COMPONENTE_RED);

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
            this.PacientesAlta = new Paciente_Alta();
            this.PacientesAlta.StartPosition = FormStartPosition.CenterParent;
            this.PacientesAlta.Tag = this;
            this.PacientesAlta.Region = this.Region;
            this.PacientesAlta.ShowDialog(this);
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Próximamente!");
            this.Hide();
            this.PacientesBaja = new Paciente_Baja();
            this.PacientesBaja.StartPosition = FormStartPosition.CenterParent;
            this.PacientesBaja.Tag = this;
            this.PacientesBaja.Region = this.Region;
            this.PacientesBaja.ShowDialog(this);
        }

        private void btnModificacion_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.PacientesModificacion = new Paciente_Modificacion();
            this.PacientesModificacion.StartPosition = FormStartPosition.CenterParent;
            this.PacientesModificacion.Tag = this;
            this.PacientesModificacion.Region = this.Region;
            this.PacientesModificacion.ShowDialog(this);
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
