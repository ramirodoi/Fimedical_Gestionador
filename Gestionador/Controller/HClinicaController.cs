using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gestionador.Model;
using System.Data;

namespace Gestionador.Controller
{
    class HClinicaController
    {
        private Pacientes cli = null;
        private HClinica hcli = null;

        public HClinicaController()
        {
            this.hcli = new HClinica();
            this.cli = new Pacientes();
        }

        public void GuardarHistoriaClinica(int idPaciente, DataTable grilla)
        {
            if (idPaciente > 0 && (grilla != null && grilla.Rows.Count > 0))
            {
                this.hcli.GuardarHistoriaClinicaParaPaciente(idPaciente, DateTime.Now);
                int idHistoriaClinica = this.hcli.ObtenerUltimaHistoriaClinica(idPaciente);

                if (idHistoriaClinica > 0)
                {
                    var TratamientosList = grilla.AsEnumerable().Where(x => x["Tipo"].Equals("Tratamiento"));
                    var ProductosList = grilla.AsEnumerable().Where(x => x["Tipo"].Equals("Producto"));

                    this.hcli.GuardarHistoriaClinicaTratamiento(idHistoriaClinica, TratamientosList);
                    this.hcli.GuardarHistoriaClinicaProductos(idHistoriaClinica, ProductosList);
                }
            }
        }
    }
}
