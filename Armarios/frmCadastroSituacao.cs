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
    public partial class frmCadastroSituacao : Form
    {
        private OleDbConnection conexao;
        private bool editar = false;
        private string cod = null;

        public frmCadastroSituacao()
        {
            InitializeComponent();
        }

        public void EditarCadastro(string cod)
        {
            this.cod = cod;
            btSalvar.Text = "Editar";
            editar = true;
            btExcluir.Visible = true;
            try
            {
                this.conexao = FormPrincipal._conexao;
                string query = "SELECT * FROM situacao WHERE idSituacao = " + cod;
                OleDbCommand cmd = new OleDbCommand(query, conexao);
                conexao.Open();
                OleDbDataReader dados = cmd.ExecuteReader();
                dados.Read();
                tbSituacao.Text = dados["situacao"].ToString();
                cbHabilitado.Checked = bool.Parse(dados["habilitarEmprestimo"].ToString());
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
        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (!editar)
            {
                if ((tbSituacao.Text != null) || (tbSituacao.Text != " "))
                {
                    try
                    {
                        string hE = cbHabilitado.Checked.ToString();
                        string query = "INSERT INTO situacao(situacao,habilitarEmprestimo) VALUES ('" + tbSituacao.Text + "'," + hE + ")";
                        //INSERT INTO situacao(situacao,habilitarEmprestimo) VALUES('PRONTO',true)
                        conexao.Open();
                        OleDbCommand cmd = new OleDbCommand(query, conexao);
                        cmd.ExecuteNonQuery();
                        DialogResult result = MessageBox.Show("Salvo com sucesso!\nDeseja Cadastrar outro ?", "Salvo!", MessageBoxButtons.YesNo);
                        if (result == DialogResult.No)
                        {
                            limpaComponents();
                            this.Close();
                        }
                        else
                        {
                            limpaComponents();
                        }
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Err.: " + err.Message);
                    }
                    finally
                    {
                        conexao.Close();
                    }
                }
                else MessageBox.Show("Campos em Branco");
            }
            else
            {
                //UPDATE
                string query = " UPDATE  situacao SET situacao = '" + tbSituacao.Text + "',  habilitarEmprestimo = "
                    + cbHabilitado.Checked.ToString() + " WHERE idSituacao = " + cod;
                try
                {
                    conexao.Open();
                    OleDbCommand cmd = new OleDbCommand(query, conexao);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ok! Editado :D");
                    limpaComponents();
                    this.Close();

                }
                catch (Exception err)
                {
                    MessageBox.Show("Err.: " + err.Message);
                }
                finally
                {
                    conexao.Close();
                }
            }
        }
        private void frmCadastroSituacao_Load(object sender, EventArgs e)
        {
            this.conexao = FormPrincipal._conexao;
        }
        private void limpaComponents()
        {
            tbSituacao.Clear();
            cbHabilitado.Checked = false;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.limpaComponents();
            this.Close();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM situacao WHERE idSituacao = " + cod;

            try
            {
                DialogResult resposta = MessageBox.Show("Desejas excluir o registro : "
                  + tbSituacao.Text + "?? ", "Confirmacao", MessageBoxButtons.YesNo);
                if (resposta == DialogResult.Yes)
                {
                    conexao.Open();
                    OleDbCommand cmd = new OleDbCommand(query, conexao);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Excluido com sucesso!");
                    limpaComponents();
                    this.Close();
                }

            }
            catch (Exception err)
            {
                MessageBox.Show("Err.: " + err.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
