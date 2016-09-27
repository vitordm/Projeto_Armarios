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
    public partial class formCadastroLocais : Form
    {
        private OleDbConnection conexao;
        private bool editar = false;
        private string cod = null;

        public formCadastroLocais()
        {
            InitializeComponent();
        }

        private void formCadastroLocais_Load(object sender, EventArgs e)
        {
            this.conexao = FormPrincipal._conexao;
        }
        public void EditarCadastro(string cod)
        {
            this.cod = cod;
            this.conexao = FormPrincipal._conexao;
            string query = "SELECT * FROM locais WHERE idLocal = " + cod;
            this.editar = true;
            btSalvar.Text = "Editar";
            try
            {
                btExcluir.Visible = true;
                OleDbCommand cmd = new OleDbCommand(query, conexao);
                conexao.Open();
                OleDbDataReader dados = cmd.ExecuteReader();
                dados.Read();
                tbLocal.Text = dados["localizacao"].ToString();
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
        private void btCancelar_Click(object sender, EventArgs e)
        {
            limpaComponents();
            this.Close();
        }
        private void limpaComponents()
        {
            tbLocal.Clear();
        }
        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (!editar)
            {
                if ((tbLocal.Text != null) || (tbLocal.Text != " "))
                {
                    try
                    {
                        string query = "INSERT INTO locais(localizacao) VALUES ('" + tbLocal.Text + "')";
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
                else MessageBox.Show("Opa! Campo está vazio!");
            }
            else
            {
                //UPDATE
                string query = "UPDATE locais SET localizacao = '" + tbLocal.Text + "' WHERE idLocal = " + cod;
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

        private void btExcluir_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM locais WHERE idLocal = " + cod;
            try
            {
                DialogResult resposta = MessageBox.Show("Desejas excluir o registro : "
                  + tbLocal.Text + "?? ", "Confirmacao", MessageBoxButtons.YesNo);
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
