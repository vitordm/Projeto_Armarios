using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;
using System.Data;
using System.Windows.Forms;
using System.IO;


namespace Armarios
{
    public static class Utilitarios
    {
        public static void DataTableToExcel(this DataTable Tbl, string ExcelFilePath = null)
        {
            try
            {
                if (Tbl == null || Tbl.Columns.Count == 0)
                    throw new Exception("ExportToExcel: Null or empty input table!\n");

                // load excel, and create a new workbook
                Excel.Application excelApp = new Excel.Application();
                excelApp.Workbooks.Add();

                // single worksheet
                Excel._Worksheet workSheet = excelApp.ActiveSheet;

                // column headings
                for (int i = 0; i < Tbl.Columns.Count; i++)
                {
                    workSheet.Cells[1, (i + 1)] = Tbl.Columns[i].ColumnName;
                }

                // rows
                for (int i = 0; i < Tbl.Rows.Count; i++)
                {
                    // to do: format datetime values before printing
                    for (int j = 0; j < Tbl.Columns.Count; j++)
                    {
                        workSheet.Cells[(i + 2), (j + 1)] = Tbl.Rows[i][j];
                    }
                }

                // check fielpath
                if (ExcelFilePath != null && ExcelFilePath != "")
                {
                    try
                    {
                        workSheet.SaveAs(ExcelFilePath);
                        excelApp.Quit();
                        //MessageBox.Show("Excel file saved!");
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("ExportToExcel: Excel file could not be saved! Check filepath.\n"
                            + ex.Message);
                    }
                }
                else    // no filepath is given
                {
                    excelApp.Visible = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("ExportToExcel: \n" + ex.Message);
            }
        }
        public static string RelatorioEmHTML(string titulo, string conteudo = null)
        {
            string dataAtual = (DateTime.Now.Day.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString());
            string cabecalho = "<!DOCTYPEhtml><html><head><title>" + titulo + "</title><style type=\"text/css\">html,body,div,span,applet,object,iframe,h1,h2,h3,h4,h5,h6,p,blockquote,pre,a,abbr,acronym,address,big,cite,code,del,dfn,em,img,ins,kbd,q,s,samp,small,strike,strong,sub,sup,tt,var,b,u,i,center,dl,dt,dd,ol,ul,li,fieldset,form,label,legend,table,caption,tbody,tfoot,thead,tr,th,td,article,aside,canvas,details,embed,figure,figcaption,footer,header,hgroup,menu,nav,output,ruby,section,summary,time,mark,audio,video{margin:0;padding:0;border:0;font-size:100%;font:inherit;vertical-align:baseline;}/*HTML5display-roleresetforolderbrowsers*/article,aside,details,figcaption,figure,footer,header,hgroup,menu,nav,section{display:block;}body{line-height:1.5;}ol,ul{list-style:none;}blockquote,q{quotes:none;}blockquote:before,blockquote:after,q:before,q:after{content:'';content:none;}table{border-collapse:collapse;border-spacing:0;}/*FIMDORESET*/body{width:19.7cm;height:21.0cm;font-family:Arial,Verdana;font-size:14px;}#geral{width:100%}thead{display:table-header-group;font-size:18px;text-align:center;font-weight:bold;}tfoot{display:table-footer-group;font-size:12px;}tfoottrtd{padding-top:10px;} #tabelaGeral{border:none; width:100%;} #tabelaConteudo{width:100%; border: 1px solid black} #tabelaConteudo tr{border: 1px solid black} #tabelaConteudo td{border: 1px solid black; text-align:center;}</style><meta charset=\"UTF-8\"/></head>";
            string content = "<body><div id=\"geral\"><table id=\"tabelaGeral\"><thead><tr><th style=\"width:100%\">"
            + titulo + "<br/>Sistema Armários</th></tr></thead><tfoot><tr><td style=\"width:100%\">Data:" + dataAtual + "</td></tr></tfoot>" +
            "<tbody><tr><td style=\"text-align:justify;width:100%\">" + conteudo + "</td></tr></tbody></table></div></body></html>";
            StringBuilder html = new StringBuilder();
            html.AppendLine(cabecalho);
            html.AppendLine(content);
            return html.ToString();
        }
        public static string DataTableToHTML(DataTable dt)
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("<table id=\"tabelaConteudo\">");

            // headers.
            sb.Append("<tr>");

            foreach (DataColumn dc in dt.Columns)
            {
                sb.AppendFormat("<td style=\"font-weight: bold;\">{0}</td>", dc.ColumnName);
            }

            sb.AppendLine("</tr>");

            // data rows
            foreach (DataRow dr in dt.Rows)
            {
                sb.Append("<tr>");

                foreach (DataColumn dc in dt.Columns)
                {
                    string cellValue = dr[dc] != null ? dr[dc].ToString() : "";
                    sb.AppendFormat("<td>{0}</td>", cellValue);
                }

                sb.AppendLine("</tr>");
            }

            sb.AppendLine("</table>");
            return sb.ToString();
        }
        public static string DataGridToHTML(DataGridView dt)
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("<table id=\"tabelaConteudo\">");

            // headers.
            sb.Append("<tr>");

            //foreach (DataColumn dc in dt.Columns)
            //{
            //    sb.AppendFormat("<td style=\"font-weight: bold;\">{0}</td>", dc.ColumnName);
            //}
            int countColum = dt.ColumnCount;
            for (int i = 0; i < countColum; i++)
            {
                sb.AppendFormat("<td style=\"font-weight: bold;\">{0}</td>", dt.Columns[i].Name);
            }

            sb.AppendLine("</tr>");

            // data rows
            /*
            foreach (DataRow dr in dt.Rows)
            {
                sb.Append("<tr>");

                foreach (DataColumn dc in dt.Columns)
                {
                    string cellValue = dr[dc] != null ? dr[dc].ToString() : "";
                    sb.AppendFormat("<td>{0}</td>", cellValue);
                }

                sb.AppendLine("</tr>");
            }
            */
            int rowCount = dt.RowCount;
            for (int i = 0; i < rowCount; i++)
            {
                sb.Append("<tr>");
                foreach (DataGridViewCell dgvc in dt.Rows[i].Cells)
                {
                    sb.AppendLine("<td>" +dgvc.Value.ToString() + "</td>");
                }
                sb.AppendLine("</tr>");

            }
            sb.AppendLine("</table>");
            return sb.ToString();
        }
        public static void ToCsV(DataGridView dGV, string filename)
        {
            string stOutput = "";
            // Export titles:
            string sHeaders = "";

            for (int j = 0; j < dGV.Columns.Count; j++)
                sHeaders = sHeaders.ToString() + Convert.ToString(dGV.Columns[j].HeaderText) + ";";
            stOutput += sHeaders + "\r\n";
            // Export data.
            for (int i = 0; i < dGV.RowCount - 1; i++)
            {
                string stLine = "";
                for (int j = 0; j < dGV.Rows[i].Cells.Count; j++)
                    stLine = stLine.ToString() + Convert.ToString(dGV.Rows[i].Cells[j].Value) + ";";
                stOutput += stLine + "\r\n";
            }
            Encoding utf16 = Encoding.GetEncoding(1254);
            byte[] output = utf16.GetBytes(stOutput);
            FileStream fs = new FileStream(filename, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(output, 0, output.Length); //write the encoded file
            bw.Flush();
            bw.Close();
            fs.Close();
        }
        public static string RemoveZeroString(string ToRemove)
        {
            int c = ToRemove.Count() - 8, f = 8;
            string Removed = ToRemove.Remove(c, f);
            return Removed;
        }
    }
}
