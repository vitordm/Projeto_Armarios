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
    public partial class formCadastrarVinculo : Form
    {
        OleDbConnection conexao;
        public formCadastrarVinculo()
        {
            InitializeComponent();
        }

        private void formCadastrarVinculo_Load(object sender, EventArgs e)
        {
            conexao = FormPrincipal._conexao;
        }

        private void preencherTabela(DataGridView dataGridView1, string sql)
        {
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

                //dataGridView1.Columns[0].Visible = false;

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

        private void btFindPessoa_Click(object sender, EventArgs e)
        {
            string pessoa;
            if (tbPessoa.Text != "") pessoa = tbPessoa.Text;
            else pessoa = "%";

            string sql = " SELECT  	pessoas.idPessoa as [Codigo], 	pessoas.nomePessoa as [Nome], 	pessoas.turmaPessoa as [Turma], tipos.tipo as [Tipo] " +
            " FROM  (pessoas   left outer join tipos on pessoas.idTipo = tipos.idTipo) " +
            "WHERE pessoas.nomePessoa like '" + pessoa + "%' OR pessoas.nomePessoa = '" + pessoa + "'  OR pessoas.nomePessoa like '%" + pessoa + "' OR pessoas.nomePessoa like '%" + pessoa + "%' order by pessoas.nomePessoa";
            preencherTabela(dataGridPessoa, sql);
            dataGridPessoa.Columns[0].Width = 50;
            dataGridPessoa.Columns[1].Width = 150;
            dataGridPessoa.Columns[2].Width = 80;
            dataGridPessoa.Columns[3].Width = 80;
            //}
            //else MessageBox.Show("Campo vazio!");
        }

        private void tbPessoa_KeyUp(object sender, KeyEventArgs e)
        {
            /*if (e.KeyCode == Keys.Enter)
            {
                btFindPessoa_Click(sender, null);
            }*/
        }

        private void tbPessoa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btFindPessoa_Click(sender, null);
            }
        }

        private void tbArmario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btFindArmario_Click(sender, null);
            }
        }

        private void btFindArmario_Click(object sender, EventArgs e)
        {
            string armario;
            if (tbArmario.Text != "")
            {
                armario = tbArmario.Text;
            }
            else
            {
                armario = "%";
            }

            string query = "SELECT armarios.idArmario as [Codigo], armarios.numeroArmario as [Numero], armarios.emprestado as [Emprestado], situacao.habilitarEmprestimo as [Habilitado], locais.localizacao as [Localizacao], situacao.situacao as [Situacao] " +
                " FROM ((  armarios  left outer join  locais on armarios.idLocal = locais.idLocal ) left outer join situacao on armarios.idSituacao = situacao.idSituacao) " +
                " WHERE armarios.numeroArmario like '%" + armario + "' or armarios.numeroArmario like '" + armario + "%' or armarios.numeroArmario like '%" + armario + "%' or armarios.numeroArmario = '" + armario + "' ORDER BY armarios.numeroArmario;";
            preencherTabela(dataGridArmario, query);
            dataGridArmario.Columns[0].Width = 50;
            dataGridArmario.Columns[1].Width = 70;
            dataGridArmario.Columns[2].Width = 75;
            dataGridArmario.Columns[3].Width = 70;
            dataGridArmario.Columns[4].Width = 70;
            dataGridArmario.Columns[5].Width = 70;
        }

        private void btNovaPessoa_Click(object sender, EventArgs e)
        {
            new formCadastroPessoa().ShowDialog();
        }

        private void btNovoArmario_Click(object sender, EventArgs e)
        {
            new formCadastroArmario().ShowDialog();
        }

        private void limpaComponets()
        {
            tbPessoa.Clear();
            tbArmario.Clear();
            progressBar1.Value = 0;
            dataGridArmario.Columns.Clear();
            dataGridPessoa.Columns.Clear();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            limpaComponets();
            this.Close();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            string pessoa = null;
            string armario = null;
            DataGridViewCellEventArgs evento;
            try
            {
                evento = new DataGridViewCellEventArgs(dataGridPessoa.CurrentCell.ColumnIndex, dataGridPessoa.CurrentCell.RowIndex);
                pessoa = getCodigoByDataGridView(evento, dataGridPessoa);
                //MessageBox.Show(pessoa);
                progressBar1.Value += 15;
                statusProgress.Text = "Resgatando dados da Pessoa";

            }
            catch (Exception erro)
            {
                MessageBox.Show("Selecione uma Pessoa para Vincular!"); 
                return;
            }

            statusProgress.Text = null;

            try
            {
                evento = new DataGridViewCellEventArgs(dataGridArmario.CurrentCell.ColumnIndex, dataGridArmario.CurrentCell.RowIndex);
                armario = getCodigoByDataGridView(evento, dataGridArmario);
                //MessageBox.Show(armario);
                progressBar1.Value += 15;
                statusProgress.Text = "Resgatando dados do armário";
            }
            catch (Exception erro)
            {
                MessageBox.Show("Selecione um Armário para Vincular!");
                return;
            }
            statusProgress.Text = null;

            string query = 
                "SELECT  	armarios.idArmario as [Codigo], 	armarios.numeroArmario as [Armario], " +
                "armarios.emprestado as [Emprestado], 	situacao.situacao as [Situacao], 	" +
                "situacao.habilitarEmprestimo as [Habilitado], 	pessoas.nomePessoa as [Pessoa] " + 
                "FROM 	( 	(armarios left outer join situacao on armarios.idSituacao = situacao.idSituacao) 	" +
                " left outer join pessoas on armarios.idPessoa = pessoas.idPessoa 	) WHERE idArmario = " + armario;
            string numeroArmario, situacao, p;
            bool emprestado, habilitado;
            try
            {
                OleDbCommand cmd = new OleDbCommand(query, conexao);

                conexao.Open();
                OleDbDataReader dados = cmd.ExecuteReader();
                dados.Read();
                numeroArmario = dados["Armario"].ToString();
                situacao = dados["Situacao"].ToString();
                p = dados["Pessoa"].ToString();
                emprestado = bool.Parse(dados["Emprestado"].ToString());
                habilitado = bool.Parse(dados["Habilitado"].ToString());

                this.conexao.Close();

                //MessageBox.Show("Armario.: " + numeroArmario + "\nSituacao.: " + situacao + "\nPessoa: "+p+
                //    "\nEmprestado "+emprestado.ToString() + "\nHabilitado: "+habilitado.ToString());

                if (emprestado == true)
                {
                    MessageBox.Show("Armário já está vinculado a pessoa.: " + p);
                    progressBar1.Value = 0;

                }
                else
                {
                    if (habilitado == false)
                    {
                        MessageBox.Show("A situação do Armário encontra-se indispónivel para vínculo\nSitucao.: " + situacao);
                        progressBar1.Value = 0;
                    }
                    else
                    {
                        //MessageBox.Show("vou emprestar!"); 
                        System.Threading.Thread.Sleep(1000);

                        //DateTime time = new DateTime();
                        string dataAtual = (DateTime.Now.Day.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString());
                        string SQL = " UPDATE  	armarios  SET  	idPessoa =" + pessoa + ", "
                        + "dataVinculacao = '" + dataAtual + "' , 	emprestado = TRUE WHERE idArmario = " + armario;
                        progressBar1.Value += 70;
                        //MessageBox.Show(dataAtual);
                        try
                        {
                            conexao.Open();
                            cmd = new OleDbCommand(SQL, conexao);
                            cmd.ExecuteNonQuery();
                            DialogResult result = MessageBox.Show("Salvo com sucesso!\nDeseja Vincular outro ?", "Vinculado!", MessageBoxButtons.YesNo);
                            if (result == DialogResult.No)
                            {
                                this.Close();
                            }
                            else
                            {
                                limpaComponets();
                            }
                        }
                        catch (OleDbException err)
                        {
                            MessageBox.Show("OPA! Deu erro :( \n" + err.Message);
                        }
                        finally
                        {
                            limpaComponets();
                            conexao.Close();

                        }
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Erro : " + err.Message);
                progressBar1.Value = 0;
            }
            finally
            {
                
                conexao.Close();
            }

        }
        private string getCodigoByDataGridView(DataGridViewCellEventArgs e, DataGridView grid)
        {

            int linha_atual = int.Parse(e.RowIndex.ToString());
            //MessageBox.Show("Linha selecionada = " + linha_atual);
            string item = "";

            try
            {
                item = grid[0, linha_atual].Value.ToString();
                //MessageBox.Show("Valor selecionada = " + item);
            }
            catch (Exception err)
            {
                MessageBox.Show("Opa!");
            }
            return item;

        }

    }
}
