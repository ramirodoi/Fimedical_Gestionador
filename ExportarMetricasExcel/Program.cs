using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Excel = Microsoft.Office.Interop.Excel;


namespace ExportarMetricasExcel
{
    class Program
    {
        private static string CONNECTION_STRING = @"Data Source=RHA-VIRTUAL\SQLEXPRESS;Initial Catalog=Fimedical;Integrated Security=True;";
        private static string QUERY_EXPORTAR_PacienteS = "SELECT * FROM dbo.Pacientes";

        private static SqlConnection cnn;
        private static SqlDataAdapter dscmd;
        private static string sql;
        private static DataSet ds;

        private static Excel.Application xlApp;
        private static Excel.Workbook xlWorkBook;
        private static Excel.Worksheet xlWorkSheet;
        private static string path;
        
        static void Main(string[] args)
        {
            CrearExcel();

            CrearPaginaPrincipal();
            ExportarTablaPacientes();

            CerrarYGuardarExcel();
        }

        /// <summary>
        /// Crea la pagina principal del Excel.
        /// </summary>
        private static void CrearPaginaPrincipal()
        {
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            xlWorkSheet.Cells[1, 1] = "Página Principal";
            
            xlWorkSheet.Cells[2, 1] = "Fecha de Proceso";
            xlWorkSheet.Cells[2, 2] = string.Format("{0} {1}", DateTime.Now.ToLongDateString(), DateTime.Now.ToLongTimeString());
        }

        private static void CrearExcel()
        {
            xlApp = new Microsoft.Office.Interop.Excel.Application();
            xlWorkBook = xlApp.Workbooks.Add(System.Reflection.Missing.Value);
        }

        private static void CerrarYGuardarExcel()
        {
            path = string.Format("c:\\Exportacion_{0}_{1}", DateTime.Now.ToShortDateString().Replace("/", ""), DateTime.Now.ToLongTimeString().Replace(":", ""));

            xlWorkBook.SaveAs(path, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing,
                                false, false, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange,
                                Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

            xlWorkBook.Close();
        }

        private static void ExportarTablaPacientes()
        {
            cnn = new SqlConnection(CONNECTION_STRING);
            cnn.Open();

            sql = QUERY_EXPORTAR_PacienteS;
            dscmd = new SqlDataAdapter(sql, cnn);
            ds = new DataSet();
            dscmd.Fill(ds);

            if (ds != null && ds.Tables[0] != null && ds.Tables[0].Rows.Count > 0)
            {
                Excel.Worksheet addedSheet = xlWorkBook.Worksheets.Add(Type.Missing, xlWorkBook.Worksheets[1], Type.Missing, Type.Missing);
               
                addedSheet = CargarExcel(ds.Tables[0], addedSheet.Index);
            }
            
            cnn.Close();
        }

        private static Excel.Worksheet CargarExcel(DataTable miTabla, int index)
        {
            Excel.Worksheet xlWorkSheet = null;

            if (miTabla != null && miTabla.Rows.Count > 0)
            {
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(index);

                for (int i = 1; i < miTabla.Columns.Count + 1; i++)
                {
                    xlWorkSheet.Cells[1, i] = miTabla.Columns[i - 1].ColumnName;
                }

                for (int j = 0; j < miTabla.Rows.Count; j++)
                {
                    for (int k = 0; k < miTabla.Columns.Count; k++)
                    {
                        xlWorkSheet.Cells[j + 2, k + 1] = miTabla.Rows[j].ItemArray[k].ToString();
                    }
                }
            }

            return (xlWorkSheet);
        }
    }
}
