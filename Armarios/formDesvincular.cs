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

namespace Armarios
{
    public partial class formDesvincular : Form
    {
        string Codigo;
        OleDbConnection conexao;
        public formDesvincular()
        {
            InitializeComponent();
        }

        public void Desvincular(string codigo)
        {
            this.Codigo = codigo;
            string query = "SELECT 	armarios.idArmario as [Codigo], 	armarios.numeroArmario as [Armario], 	" +
                "pessoas.nomePessoa as [Pessoa], pessoas.turmaPessoa as [Turma],	locais.localizacao, 	armarios.dataVinculacao as [DataVinculacao] " +
                "FROM 	((armarios 		left outer join pessoas on armarios.idPessoa = pessoas.idPessoa) 		" +
                "left outer join locais on armarios.idLocal = locais.idLocal) WHERE armarios.idArmario = " + codigo;
            //"SELECT * FROM armarios WHERE idArmario = " + codigo;
            conexao = FormPrincipal._conexao;

            try
            {
                OleDbCommand cmd = new OleDbCommand(query, conexao);
                conexao.Open();
                OleDbDataReader dados = cmd.ExecuteReader();
                dados.Read();

                tbArmario.Text = dados["Armario"].ToString();
                tbLocal.Text = dados["localizacao"].ToString();
                tbPessoa.Text = dados["Pessoa"].ToString();
                tbTurma.Text = dados["Turma"].ToString();
                lbData.Text = "Data da vínculação: " + Utilitarios.RemoveZeroString(dados["DataVinculacao"].ToString());


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

        private void limpaComponents()
        {

            tbArmario.Clear();
            tbLocal.Clear();
            tbPessoa.Clear();
            tbTurma.Clear();
            lbData.Text = "...";
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            limpaComponents();
            this.Close();
        }

        private void btDesvincular_Click(object sender, EventArgs e)
        {
            string update = "UPDATE armarios SET idPessoa = null, dataVinculacao = null, emprestado = false WHERE idArmario = " + Codigo;

            DialogResult resposta = MessageBox.Show("Deseja realmente Desvíncular ?", "Confirmacao", MessageBoxButtons.YesNo);
            if (resposta == DialogResult.Yes)
            {
                try
                {
                    conexao.Open();
                    OleDbCommand cmd = new OleDbCommand(update, conexao);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Desvínculado");
                    limpaComponents();
                    this.Close();
                }
                catch (Exception err)
                {
                    MessageBox.Show("Erro.: "+err.Message);
                }
                finally
                {
                    conexao.Close();
                }
            }
        }
    }
}
