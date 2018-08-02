using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Gestionador.Controller;

namespace Gestionador.View.HistoriaClinica
{
    public partial class HistoriaClinica_Alta : Form
    {
        private ClientesController clienteController = null;
        private HClinicaController hClinicaController = null;

        public HistoriaClinica_Alta()
        {
            InitializeComponent();
            
            this.clienteController = new ClientesController();
            this.hClinicaController = new HClinicaController();

            this.CargarComboPacientes();
            this.CargarComboTratamientos();
        }

        private void CargarComboPacientes()
        {
            DataSet pacientes = this.clienteController.ObtenerTodosLosClientesActivos();
            ComboboxItem item = null;

            if (pacientes != null && pacientes.Tables[0] != null && pacientes.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow paciente in pacientes.Tables[0].Rows)
                {
                    item = new ComboboxItem();
                    item.Text = string.Format("{0}, {1}", paciente["Apellido"].ToString(), paciente["Nombre"].ToString());
                    item.Value = paciente["IdCliente"].ToString();

                    comboBox1.Items.Add(item);    
                }
                
                comboBox1.SelectedIndex = 0;
            }
        }

        private void CargarComboTratamientos()
        {
            DataSet pacientes = this.clienteController.ObtenerTodosLosClientesActivos();
            ComboboxItem item = null;

            if (pacientes != null && pacientes.Tables[0] != null && pacientes.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow paciente in pacientes.Tables[0].Rows)
                {
                    item = new ComboboxItem();
                    item.Text = string.Format("{0}, {1}", paciente["Apellido"].ToString(), paciente["Nombre"].ToString());
                    item.Value = paciente["IdCliente"].ToString();

                    comboBox2.Items.Add(item);
                }

                comboBox2.SelectedIndex = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow row2 = (DataGridViewRow)this.dgHClinica.RowTemplate.Clone();
            row2.CreateCells(this.dgHClinica, ((ComboboxItem)this.comboBox2.SelectedItem).Text.ToString(), ((ComboboxItem)this.comboBox2.SelectedItem).Value.ToString(), "cell3");

            this.dgHClinica.Rows.Add(row2);
        }
    }

    public class ComboboxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
