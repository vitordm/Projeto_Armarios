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
    public partial class formCadastroArmario : Form
    {
        private OleDbConnection conexao;
        private bool formCarregado = false;
        private bool edicao = false;
        public formCadastroArmario()
        {
            InitializeComponent();
        }
        private string cod;

        private void Carregar()
        {
            string query = "SELECT * FROM locais order by localizacao";
            conexao = FormPrincipal._conexao;
            OleDbCommand cmd = new OleDbCommand(query, conexao);
            try
            {
                conexao.Open();
                OleDbDataReader dados = cmd.ExecuteReader();
                while (dados.Read())
                {
                    ComboBoxItem itemsCB = new ComboBoxItem();
                    itemsCB.Text = dados["localizacao"].ToString();
                    itemsCB.Value = dados["idLocal"].ToString();
                    cbLocalizacao.Items.Add(itemsCB);
                }

            }
            catch (OleDbException err)
            {
                MessageBox.Show("Erro .: " + err.Message);
            }
            finally
            {

                conexao.Close();
                formCarregado = true;
            }

            query = "SELECT * FROM situacao order by situacao";
            cmd = new OleDbCommand(query, conexao);
            try
            {
                conexao.Open();
                OleDbDataReader dados = cmd.ExecuteReader();
                while (dados.Read())
                {
                    ComboBoxItem itemsCB = new ComboBoxItem();
                    itemsCB.Text = dados["situacao"].ToString();
                    itemsCB.Value = dados["idSituacao"].ToString();
                    cbSituacao.Items.Add(itemsCB);
                }

            }
            catch (OleDbException err)
            {
                MessageBox.Show("Erro .: " + err.Message);
            }
            finally
            {

                conexao.Close();
                formCarregado = true;
            }

        }

        public void EditarCadastro(string cod)
        {
            this.cod = cod;
            Carregar();
            try
            {
                string query = "Select * from armarios where idArmario = " + cod;

                conexao = FormPrincipal._conexao;

                btExcluir.Visible = true;

                OleDbCommand cmd = new OleDbCommand(query, conexao);

                conexao.Open();
                OleDbDataReader dados = cmd.ExecuteReader();
                dados.Read();
                tbNumeroArmario.Text = dados["numeroArmario"].ToString();
                tbLColuna.Text = dados["localizacaoArmarioC"].ToString();
                tbLLinha.Text = dados["localizacaoArmarioL"].ToString();

                cbLocalizacao.SelectedIndex = 0;
                for (int i = 0; i < cbLocalizacao.Items.Count; i++)
                {
                    if ((cbLocalizacao.Items[i] as ComboBoxItem).Value.ToString() == dados["idLocal"].ToString())
                    {
                        cbLocalizacao.SelectedIndex = i;
                    }
                }

                cbSituacao.SelectedIndex = 0;
                for (int i = 0; i < cbSituacao.Items.Count; i++)
                {
                    if ((cbSituacao.Items[i] as ComboBoxItem).Value.ToString() == dados["idSituacao"].ToString())
                    {
                        cbSituacao.SelectedIndex = i;
                    }
                }


                edicao = true;
                btSalvar.Text = "Editar";


            }
            catch (OleDbException err)
            {
                MessageBox.Show("Erro .: " + err.Message);
            }
            finally
            {

                conexao.Close();
            }
        }

        private void formCadastroArmario_Load(object sender, EventArgs e)
        {
            if (formCarregado != true)
            {
                Carregar();
            }

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            limpaComponents();
            this.Close();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (!edicao)
            {
                try
                {
                    string linha = tbLLinha.Text;
                    string coluna = tbLColuna.Text;
                    string situacao = null;

                    if (cbSituacao.SelectedItem != null)
                    {
                        situacao = (cbSituacao.SelectedItem as ComboBoxItem).Value.ToString();
                    }

                    string query = "insert into armarios(numeroArmario,localizacaoArmarioL,localizacaoArmarioC,idLocal,idSituacao,emprestado)" +
                        " VALUES('" + tbNumeroArmario.Text + "','" + linha + "','" + coluna + "'," + (cbLocalizacao.SelectedItem as ComboBoxItem).Value.ToString() + ", " + situacao + ", false)";
                    try
                    {
                        if (verificarVazio() == false)
                        {
                            conexao.Open();
                            OleDbCommand cmd = new OleDbCommand(query, conexao);
                            cmd.ExecuteNonQuery();
                            //MessageBox.Show((cbLocalizacao.SelectedItem as ComboBoxItem).Value.ToString());
                            DialogResult result = MessageBox.Show("Salvo com sucesso!\nDeseja Cadastrar outro ?", "Salvo!", MessageBoxButtons.YesNo);
                            if (result == DialogResult.No)
                            {
                                this.Close();
                            }
                            else
                            {
                                limpaComponents();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Verifique itens vazios!");
                        }
                    }
                    catch (OleDbException err)
                    {
                        MessageBox.Show(err.Message);
                    }
                    finally
                    {
                        conexao.Close();
                    }

                    //MessageBox.Show(query);
                }
                catch (Exception er)
                {
                    MessageBox.Show("Erro.: " + er.Message + "\nNão se desespere! verifique se tu selecionou a Localização e/ou deixou campos vazio :(");
                }
            }
            else
            {
                //UPDATE
                string linha = tbLLinha.Text;
                string coluna = tbLColuna.Text;
                string numeroArmario = tbNumeroArmario.Text;
                string local = (cbLocalizacao.SelectedItem as ComboBoxItem).Value.ToString();
                string situacao = null;

                if (cbSituacao.SelectedItem != null)
                {
                    situacao = (cbSituacao.SelectedItem as ComboBoxItem).Value.ToString();
                }

                string query = "UPDATE armarios SET numeroArmario = '" + numeroArmario +
                    "', localizacaoArmarioL =  '" + linha + "', localizacaoArmarioC = '" + coluna + "', "
                    + " idLocal = " + local + ", idSituacao = " + situacao + " WHERE idArmario = " + cod;
                //MessageBox.Show(query);
                try
                {
                    conexao.Open();
                    OleDbCommand cmd = new OleDbCommand(query, conexao);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ok! Editado :D");
                    limpaComponents();
                    this.Close();

                    limpaComponents();
                }
                catch (OleDbException err)
                {
                    MessageBox.Show("OPA! Deu erro :( \n" + err.Message);
                }
                finally
                {
                    conexao.Close();

                }
            }
        }

        private void limpaComponents()
        {
            tbNumeroArmario.Clear();
            tbLColuna.Clear();
            tbLLinha.Clear();
            cbLocalizacao.SelectedItem = null;
        }
        private bool verificarVazio()
        {
            if (tbNumeroArmario.Text == "" || tbNumeroArmario.Text == " ")
                return true;
            /*
            if (tbLColuna.Text == "" || tbLColuna.Text == " ")
                return true;
            if (tbLLinha.Text == "" || tbLLinha.Text == " ")
                return true;
             */
            else
                return false;
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "DELETE FROM armarios WHERE idArmario = " + cod;
                DialogResult resposta = MessageBox.Show("Desejas excluir o registro : "
                    + tbNumeroArmario.Text + "?? ", "Confirmacao", MessageBoxButtons.YesNo);
                if (resposta == DialogResult.Yes)
                {
                    conexao.Open();
                    OleDbCommand cmd = new OleDbCommand(sql, conexao);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Excluido com sucesso!");
                    limpaComponents();
                    this.Close();

                    limpaComponents();
                }

            }
            catch (OleDbException err)
            {
                MessageBox.Show("Opa! Deu erro " + err.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
