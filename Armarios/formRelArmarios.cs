using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using System.Configuration;

namespace Armarios
{
    public partial class formRelArmarios : Form
    {
        OleDbConnection conexao;

        string query;

        DataTable dt = new DataTable();

        public formRelArmarios()
        {
            InitializeComponent();
        }

        //ARRUMAR AQUI
        private void configurarQuery(string ordem = "")
        {
            query = " SELECT armarios.idArmario as [Codigo], armarios.numeroArmario as [Armario], locais.localizacao as [Localizacao], " +
                    " situacao.situacao as [Situacao] FROM 	((armarios left outer join locais on armarios.idLocal = locais.idLocal)  " +
                    " left outer join situacao on armarios.idSituacao = situacao.idSituacao) ";
            if (ordem != "") query += ordem;
        }
        private void configuraTabela()
        {
            dt.Columns.Clear();
            dt.Columns.Add("Código", typeof(string));
            dt.Columns.Add("Armário", typeof(string));
            dt.Columns.Add("Localização", typeof(string));
            dt.Columns.Add("Situação", typeof(string));
        }
        private void preencherTabela()
        {
            dt.Clear();
            configuraTabela();
            try
            {
                OleDbCommand cmd = new OleDbCommand(query, conexao);
                conexao.Open();
                OleDbDataReader dados = cmd.ExecuteReader();
                // int i = 0;
                while (dados.Read())
                {
                    dt.Rows.Add(dados["Codigo"].ToString(), dados["Armario"].ToString(), dados["Localizacao"].ToString(), dados["Situacao"].ToString());
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Erro " + err.Message);
            }
            finally
            {
                conexao.Close();
            }


        }

        private void btGerar_Click(object sender, EventArgs e)
        {
            if (ordem1.Checked) configurarQuery(" ORDER BY armarios.numeroArmario ");
            else if (ordem2.Checked) configurarQuery(" ORDER BY locais.localizacao");
            else if (ordem3.Checked) configurarQuery(" ORDER BY situacao.situacao");

            if (rel1.Checked)
            {

                ShowRelatorio relatorioEmprestimo = new ShowRelatorio();
                DataSet ds = new DataSet("DataSetArmarios");
                DataTable tabela = dt;
                try
                {
                    preencherTabela();
                    tabela.TableName = "Armarios";
                    ds.Tables.Add(tabela);
                    // string caminho = Application.StartupPath + "\\xmlEmprestimo.xml";
                    ds.WriteXmlSchema("xmlArmarios.xml");
                    RelArmarios relatorio = new RelArmarios();
                    relatorio.SetDataSource(ds);
                    relatorioEmprestimo.setDataSourceRelatorio(relatorio);
                    //this.Close();
                    relatorioEmprestimo.Show();
                    //MessageBox.Show("Relatório Gerado!");



                }
                catch (Exception err)
                {
                    MessageBox.Show("Erro " + err.Message);
                }
                finally
                {
                    ds.Tables.Clear();
                    conexao.Close();
                }

            }
            else if (rel2.Checked)
            {
                try
                {
                    preencherTabela();
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.Filter = "HTML Documents (*.html)|*.html";
                    string dataAtual = (DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Year.ToString());
                    sfd.FileName = "RelatórioDeArmarios_" + dataAtual + ".html";
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        string conteudo = Utilitarios.DataTableToHTML(dt);
                        string html = Utilitarios.RelatorioEmHTML("Relatório de Armários", conteudo);

                        File.WriteAllText(sfd.FileName, html);
                        MessageBox.Show("Salvo com sucesso!");
                        this.Close();

                    }

                }
                catch (Exception err)
                {
                    MessageBox.Show("Erro " + err.Message);
                }
                finally
                {
                    conexao.Close();
                }
            }
            else if (rel3.Checked)
            {
                try
                {

                    preencherTabela();
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.Filter = "Excel Documents (*xlsx)| *xlsx";
                    string dataAtual = (DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Year.ToString());
                    sfd.FileName = "RelatórioDeArmarios_" + dataAtual + ".xlsx";
                    //string filePath = System.IO.Path.GetTempPath() + DateTime.Now.Ticks.ToString() + ".xlsm";
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        Utilitarios.DataTableToExcel(dt, sfd.FileName);
                        MessageBox.Show("Salvo com sucesso!");
                        this.Close();
                    }

                }
                catch (Exception err)
                {
                    MessageBox.Show("Erro " + err.Message);
                }
                finally
                {
                    conexao.Close();
                }
            }

        }

        private void formRelArmarios_Load(object sender, EventArgs e)
        {
            conexao = FormPrincipal._conexao;
        }
    }
}
