using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Configuration;

namespace Armarios
{
    public partial class FormLista : Form
    {
        private Form form;
        //private DataTable tabelaGeral;
        public FormLista()
        {
            InitializeComponent();
        }
        private int tipo;
        private bool mostraCodigo = false;

        private string query;

        public void preencherTabela(string sql, string titulo, int tipo)
        {
            this.Text = titulo;
            this.query = sql;
            this.tipo = tipo;
            OleDbConnection conexao = FormPrincipal._conexao;
            try
            {
                OleDbCommand cmd = new OleDbCommand(sql, conexao);
                conexao.Open();
                cmd.CommandType = CommandType.Text;

                OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);

                DataTable table = new System.Data.DataTable();

                adapter.Fill(table);
                dataGridView1.DataSource = table;
                //tabelaGeral = table;

                //dataGridView1.Columns[0].Visible = false;
                if (mostraCodigo == false)
                {
                    dataGridView1.Columns[0].Visible = false;
                }
            }
            catch (OleDbException err)
            {
                MessageBox.Show("Erro .: " + err.Message);
            }
            catch (Exception err)
            {
                MessageBox.Show("Erro .: " + err.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        public void setForm(Form obj)
        {
            this.form = obj;

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(dataGridView1.Columns[0].ToString());
            //MessageBox.Show(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            //string text = dataGridView1.

            int linha_atual = int.Parse(e.RowIndex.ToString());
            //MessageBox.Show("Linha selecionada = " + linha_atual);
            string item = "";

            try
            {
                item = dataGridView1[0, linha_atual].Value.ToString();
                //MessageBox.Show("Valor selecionada = " + item);
            }
            catch (Exception err)
            {
                MessageBox.Show("Opa!");
            }

            /*
             * dataGridView1[COLUNA SELECIONADA, LINHA ATUAL] . VALOR . TO STRING()
             * int.Parse(e.RowIndex.ToString()); OBTEM A LINHA SELECIONADA
             **/

            try
            {

                Edicoes editar = new Edicoes(item, tipo);
                btRefresh_Click(sender,e);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }


        }

        private void btExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.csv)|*.csv";
            sfd.FileName = this.Text + ".csv";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                //ToCsV(dataGridView1, @"c:\export.xls");
                Utilitarios.ToCsV(dataGridView1, sfd.FileName); // Here dataGridview1 is your grid view name
                MessageBox.Show("Exportado");
            }

        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            form.ShowDialog();
            btRefresh_Click(sender, e);
        }

        private StringBuilder DataGridtoHTML(DataGridView dg)
        {
            StringBuilder strB = new StringBuilder();
            //create html & table
            strB.AppendLine("<html><head><meta charset=\"utf-8\"></head><body><center><" +
                          "table border='1' cellpadding='0' cellspacing='0'>");
            strB.AppendLine("<tr>");
            //cteate table header
            for (int i = 0; i < dg.Columns.Count; i++)
            {
                strB.AppendLine("<td align='center' valign='middle'>" +
                               dg.Columns[i].HeaderText + "</td>");
            }
            //create table body
            strB.AppendLine("<tr>");
            for (int i = 0; i < dg.Rows.Count; i++)
            {
                strB.AppendLine("<tr>");
                foreach (DataGridViewCell dgvc in dg.Rows[i].Cells)
                {
                    strB.AppendLine("<td align='center' valign='middle'>" +
                                    dgvc.Value.ToString() + "</td>");
                }
                strB.AppendLine("</tr>");

            }
            //table footer & end of html file
            strB.AppendLine("</table></center></body></html>");
            return strB;
        }

        private void btHtml_Click(object sender, EventArgs e)
        {
            /**
             * StringBuilder html = DataGridtoHTML(dataGridView1);
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "HTML Documents (*.html)|*.html";
            sfd.FileName = this.Text + ".html";

            if (sfd.ShowDialog() == DialogResult.OK)
            {

                File.WriteAllText(sfd.FileName, html.ToString());

            }*/
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "HTML Documents (*.html)|*.html";
            string dataAtual = (DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Year.ToString());
            sfd.FileName = "Relatório_"+this.Text + dataAtual + ".html";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string conteudo = Utilitarios.DataGridToHTML(dataGridView1);
                string html = Utilitarios.RelatorioEmHTML("Relatório " + this.Text, conteudo);

                File.WriteAllText(sfd.FileName, html);
                MessageBox.Show("Salvo com sucesso!");

            }

        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            preencherTabela(query, this.Text, this.tipo);
        }

        private void btDelete_Click(object sender, EventArgs er)
        {
            /**
            DeleteFromGrid delete = new DeleteFromGrid();
            int linha_atual = int.Parse(dataGridViewCurrentRow
            string item = dataGridView1[0, linha_atual].Value.ToString();
            MessageBox.Show(item);
            //delete.Codigo = item;
            //delete.deletarConteudo(tipo);
             */
        }

        private void btCodigo_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns[0].Visible = !dataGridView1.Columns[0].Visible;
            mostraCodigo = dataGridView1.Columns[0].Visible;
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            DataGridViewCellEventArgs evento = new DataGridViewCellEventArgs(dataGridView1.CurrentCell.ColumnIndex, dataGridView1.CurrentCell.RowIndex);
            dataGridView1_CellDoubleClick(sender, evento);
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btEditar_Click(sender, null);
            }
        }

        public void changeHabilitacao(bool Novo = true, bool editar = true)
        {
            this.btNovo.Enabled = Novo;
            this.btEditar.Enabled = editar;
        }
    }
}
