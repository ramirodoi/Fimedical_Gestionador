using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Reflection;

namespace Gestionador.View
{
    static public class Visual
    {
        static public int BOTON_COMPONENTE_RED = 55;
        static public int BOTON_COMPONENTE_GREEN = 195;
        static public int BOTON_COMPONENTE_BLUE = 235;
        static public int FONDO_COMPONENTE_RED = 255;
        static public int FONDO_COMPONENTE_GREEN = 255;
        static public int FONDO_COMPONENTE_BLUE = 255;
        static private string path = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
        static public string IMAGEN_HOME = string.Format("{0}{1}", path, @"\View\Home\Images\Logo.jpg");
        static public string IMAGEN_PACIENTE_ABM = string.Format("{0}{1}", path, @"\View\Paciente\Images\Coolsculpting.jpg");
        static public string IMAGEN_HISTORIA_CLINICA_ABM = string.Format("{0}{1}", path, @"\View\HistoriaClinica\Images\VelaShape3.jpg");
    }
}
