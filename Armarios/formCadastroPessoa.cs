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
    public partial class formCadastroPessoa : Form
    {
        private OleDbConnection conexao;
        private bool formCarregado = false;
        private bool editar = false;
        private string cod;
        public formCadastroPessoa()
        {
            InitializeComponent();
        }

        public void Carregar()
        {
            string query = "SELECT * FROM tipos ORDER BY tipo";

            try
            {
                conexao = FormPrincipal._conexao;
                OleDbCommand cmd = new OleDbCommand(query, conexao);
                conexao.Open();
                OleDbDataReader datas = cmd.ExecuteReader();
                cbTipoPessoa.Items.Clear();
                while (datas.Read())
                {
                    ComboBoxItem itens = new ComboBoxItem();
                    itens.Text = datas["tipo"].ToString();
                    itens.Value = datas["idTipo"].ToString();
                    cbTipoPessoa.Items.Add(itens);
                }
                formCarregado = true;
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

        public void EditarCadastro(string cod)
        {
            this.cod = cod;
            Carregar();
            try
            {
                string query = "SELECT * FROM pessoas WHERE idPessoa  = " + cod;
                conexao = FormPrincipal._conexao;
                btExcluir.Visible = true;

                OleDbCommand cmd = new OleDbCommand(query, conexao);

                conexao.Open();
                OleDbDataReader dados = cmd.ExecuteReader();

                dados.Read();
                tbNomePessoa.Text = dados["nomePessoa"].ToString();
                tbEmailPessoa.Text = dados["emailPessoa"].ToString();
                tbResponsavelPessoa.Text = dados["responsavel"].ToString();
                tbTelefonePessoa.Text = dados["telefonePessoa"].ToString();
                tbTurmaPessoa.Text = dados["turmaPessoa"].ToString();
                tbObs.Text = dados["obsPessoa"].ToString();

                //cbTipoPessoa.SelectedIndex = 0;

                for (int i = 0; i < cbTipoPessoa.Items.Count; i++)
                {
                    if ((cbTipoPessoa.Items[i] as ComboBoxItem).Value.ToString() == dados["idTipo"].ToString())
                    {
                        cbTipoPessoa.SelectedIndex = i;
                    }

                }

            }
            catch (Exception err)
            {
                MessageBox.Show("Erro " + err.Message);
            }
            finally
            {
                conexao.Close();
                editar = true;
                btSalvar.Text = "Editar";
                //formCarregado = true;
            }

        }

        private void formCadastroPessoa_Load(object sender, EventArgs e)
        {

            if (formCarregado != true)
            {
                Carregar();
                //formCarregado = true;
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            limpaComponents();
            this.Close();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (!editar)
            {
                try
                {
                    string nome = tbNomePessoa.Text,
                        telefones = tbTelefonePessoa.Text,
                        email = tbEmailPessoa.Text,
                        tipo = null;
                    if (cbTipoPessoa.SelectedItem != null)
                        tipo = (cbTipoPessoa.SelectedItem as ComboBoxItem).Value.ToString();
                    string turma = tbTurmaPessoa.Text,
                        responsavel = tbResponsavelPessoa.Text,
                        obs = tbObs.Text;

                    //string query = "INSERT INTO pessoas(";
                    string query = "INSERT INTO pessoas( nomePessoa, telefonePessoa, emailPessoa, idTipo, responsavel, 	turmaPessoa, obsPessoa) " +
                    " VALUES( '" + nome + "', '" + telefones + "', '" + email + "', " + tipo + ", '" + responsavel + "', '" + turma + "', '" + obs + "' )";
                    OleDbCommand cmd = new OleDbCommand(query, conexao);
                    conexao.Open();
                    cmd.ExecuteNonQuery();
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
                catch (Exception err)
                {
                    MessageBox.Show("Erro " + err.Message);
                }
                finally
                {
                    conexao.Close();
                    limpaComponents();
                }
            }
            else
            {
                //UPDATE
                string tipo = null;
                if (cbTipoPessoa.SelectedItem != null)
                    tipo = (cbTipoPessoa.SelectedItem as ComboBoxItem).Value.ToString();
                string query = " UPDATE  	pessoas SET 	nomePessoa = '" + tbNomePessoa.Text + "',  	telefonePessoa = '" + tbTelefonePessoa.Text + "',  	emailPessoa = '" + tbEmailPessoa.Text + "', " +
                 "idTipo = " + tipo + ", 	responsavel = '" + tbResponsavelPessoa.Text + "', 	turmaPessoa = '" + tbTurmaPessoa.Text + "',  	obsPessoa = '" + tbObs.Text + "'" + 
                 " WHERE idPessoa = " + cod;

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
            tbNomePessoa.Clear();
            tbEmailPessoa.Clear();
            tbObs.Clear();
            tbResponsavelPessoa.Clear();
            tbTelefonePessoa.Clear();
            tbTurmaPessoa.Clear();
            cbTipoPessoa.SelectedItem = null;
            cbTipoPessoa.Text = "Tipos";
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja realmente excluir ? ", "Exclusao", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string query = "DELETE FROM pessoas WHERE idPessoa  = " + cod;
                try
                {
                    OleDbCommand cmd = new OleDbCommand(query, conexao);
                    conexao.Open();
                    cmd.ExecuteNonQuery();
                    this.Close();
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
    }
}
