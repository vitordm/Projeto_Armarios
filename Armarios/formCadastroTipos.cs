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
    public partial class formCadastroTipos : Form
    {
        private OleDbConnection conexao;
        private bool editar = false;
        private string cod = null;
        public formCadastroTipos()
        {
            InitializeComponent();
        }
        public void EditarCadastro(string cod)
        {
            this.cod = cod;
            this.conexao = FormPrincipal._conexao;
            string query = "SELECT * FROM tipos WHERE idTipo = " + cod;
            this.editar = true;
            btSalvar.Text = "Editar";
            try
            {
                btExcluir.Visible = true;
                OleDbCommand cmd = new OleDbCommand(query, conexao);
                conexao.Open();
                OleDbDataReader dados = cmd.ExecuteReader();
                dados.Read();
                tbTipo.Text = dados["tipo"].ToString();
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
                try
                {
                    if (tbTipo.Text != null || tbTipo.Text != " ")
                    {
                        string query = "INSERT INTO tipos(tipo) VALUES ('" + tbTipo.Text + "')";
                        conexao.Open();
                        OleDbCommand cmd = new OleDbCommand(query, conexao);
                        cmd.ExecuteNonQuery();
                        //MessageBox.Show((cbLocalizacao.SelectedItem as ComboBoxItem).Value.ToString());
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
                    else
                    {
                        MessageBox.Show("Compo Vazio!");
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
            else
            {
                //UPDATE
                string query = "UPDATE tipos SET tipo = '" + tbTipo.Text + "' WHERE idTipo = " + cod;
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
        private void formCadastroTipos_Load(object sender, EventArgs e)
        {
            this.conexao = FormPrincipal._conexao;
        }
        private void limpaComponents()
        {
            tbTipo.Clear();
        }
        private void btCancelar_Click(object sender, EventArgs e)
        {
            limpaComponents();
            this.Close();
        }
        private void btExcluir_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM tipos WHERE idTipo = " + cod;
            try
            {
                DialogResult resposta = MessageBox.Show("Desejas excluir o registro : "
                  + tbTipo.Text + "?? ", "Confirmacao", MessageBoxButtons.YesNo);
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
