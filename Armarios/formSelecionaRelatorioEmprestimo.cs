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
    public partial class formSelecionaRelatorioEmprestimo : Form
    {
        OleDbConnection conexao;

        string query;

        DataTable dt = new DataTable();

        public formSelecionaRelatorioEmprestimo()
        {
            InitializeComponent();
        }

        private void configurarQuery(string ordem = "")
        {
            query = " SELECT 	armarios.idArmario as [Codigo], 	armarios.numeroArmario as [Armario], 	" +
                "pessoas.nomePessoa as [Pessoa], pessoas.turmaPessoa as [Turma],	locais.localizacao, 	armarios.dataVinculacao as [DataVinculacao] " +
                "FROM 	((armarios 		left outer join pessoas on armarios.idPessoa = pessoas.idPessoa) 		" +
                "left outer join locais on armarios.idLocal = locais.idLocal) WHERE armarios.emprestado = true ";
            if (ordem != "") query += ordem;
        }
        private void configuraTabela()
        {
            dt.Columns.Clear();
            dt.Columns.Add("Armario", typeof(string));
            dt.Columns.Add("Pessoa", typeof(string));
            dt.Columns.Add("Turma", typeof(string));
            dt.Columns.Add("Localizacao", typeof(string));
            dt.Columns.Add("DataEmprestimo", typeof(string));
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
                    int c = dados["DataVinculacao"].ToString().Count() - 8, f = 8;
                    string data = dados["DataVinculacao"].ToString().Remove(c, f);
                    dt.Rows.Add(dados["Armario"].ToString(), dados["Pessoa"].ToString(), dados["Turma"].ToString(), dados["localizacao"].ToString(), data);
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
            else if (ordem2.Checked) configurarQuery(" ORDER BY pessoas.nomePessoa");
            else if (ordem3.Checked) configurarQuery(" ORDER BY pessoas.turmaPessoa");
            else if (ordem4.Checked) configurarQuery(" ORDER BY armarios.dataVinculacao");

            if (rbRelatorio1.Checked)
            {
                ShowRelatorio relatorioEmprestimo = new ShowRelatorio();
                DataSet ds = new DataSet();
                DataTable tabela = dt;
                try
                {
                    preencherTabela();
                    ds.Tables.Add(tabela);
                    // string caminho = Application.StartupPath + "\\xmlEmprestimo.xml";
                    ds.WriteXmlSchema("xmlEmprestimo.xml");
                    RelEmprestimos relatorio = new RelEmprestimos();
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
            else if (rbRelatorio2.Checked)
            {


                try
                {
                    preencherTabela();
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.Filter = "HTML Documents (*.html)|*.html";
                    string dataAtual = (DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Year.ToString());
                    sfd.FileName = "RelatórioDeEmprestimo_" + dataAtual + ".html";
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        string conteudo = Utilitarios.DataTableToHTML(dt);
                        string html = Utilitarios.RelatorioEmHTML("Relatório de Empréstimos", conteudo);

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
            else if (rbRelatorio3.Checked)
            {


                try
                {
                    preencherTabela();
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.Filter = "Excel Documents (*xlsx)| *xlsx";
                    string dataAtual = (DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Year.ToString());
                    sfd.FileName = "RelatórioDeEmprestimo_" + dataAtual + ".xlsx";
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

        private void gBoxSeleciona_Enter(object sender, EventArgs e)
        {
            
        }

        private void formSelecionaRelatorioEmprestimo_Load(object sender, EventArgs e)
        {
            conexao = FormPrincipal._conexao;
        }
    }
}
