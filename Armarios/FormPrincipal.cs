using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using System.Data.OleDb;

namespace Armarios
{
    public partial class FormPrincipal : Form
    {
        private string nomeUsuario;
        private int tipoUser;
        public static OleDbConnection _conexao;
        Conexao _cx;
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            tbUser.Focus();
        }

        private void changeMenuStatus()
        {
            menu1.Enabled = !menu1.Enabled;
            status1.Enabled = !status1.Enabled;
            toolStrip1.Enabled = !toolStrip1.Enabled;

        }

        private void btAcessar_Click(object sender, EventArgs e)
        {
            _cx = new Conexao();
            try
            {
                if (File.Exists("configuration.xml"))
                {
                    XmlSerializer xs = new XmlSerializer(typeof(Information));
                    FileStream read = new FileStream("configuration.xml", FileMode.Open, FileAccess.Read, FileShare.Read);
                    Information info = (Information)xs.Deserialize(read);
                    _cx.Caminho = info.CaminhoDB;
                    _cx.Senha = info.SenhaDB;
                    read.Close();

                    _cx.setConectionString(_cx.Caminho, _cx.Senha);

                    //OleDbConnection _conexao = new OleDbConnection(_cx.getConectionString());
                    _conexao = new OleDbConnection(_cx.getConectionString());

                    string _user, _senha;

                    _user = tbUser.Text;
                    _senha = Md5.GetMD5Hash(tbSenha.Text);

                    string query = "SELECT COUNT(*)  FROM usuarios WHERE loginUsuario = '" + _user + "' and senhaUsuario = '" + _senha + "' and ativoUsuario = 1 ";
                    //OleDbCommand sql = new OleDbCommand("SELECT * FROM usuarios WHERE loginUsuario = '" + _user + "' and senhaUsuario = '" + _senha + "' and ativoUsuario = 1;",_conexao);
                    OleDbCommand sql = new OleDbCommand(query, _conexao);
                    OleDbCommand cmd = sql.Clone();
                    _conexao.Open();
                    OleDbDataReader datas = sql.ExecuteReader();
                    if (datas.HasRows)
                    {
                        int teste = (int)cmd.ExecuteScalar();
                        if (teste == 1)
                        {
                            this.changeMenuStatus();
                            panel1.Visible = !panel1.Visible;
                            statusConexao.Text = "Conectado";

                            query = "SELECT * FROM usuarios WHERE loginUsuario = '" + _user + "' and senhaUsuario = '" + _senha + "' and ativoUsuario = 1";
                            cmd = new OleDbCommand(query, _conexao);
                            datas = cmd.ExecuteReader();
                            datas.Read();
                            nomeUsuario = datas["nomeUsuario"].ToString();
                            userConectado.Text = "- Bem-vindo " + nomeUsuario;
                            tipoUser = Int32.Parse(datas["tipoUsuario"].ToString());
                            if (tipoUser == 1)
                            {
                                administracaoToolStripMenuItem.Visible = true;
                            }
                        }
                        else if (teste > 1) MessageBox.Show("OPA! Falha na segurança O.O\nUsuario Duplicado!\nContate o Administrador!");
                        else MessageBox.Show("OPA! Verifique os campos!");
                    }
                    else
                    {
                        MessageBox.Show("OPA! Não encontramos registros para esse usuário!");
                    }
                    _conexao.Close();
                }
                else
                {
                    MessageBox.Show("OPA! Não encontramos o arquivo de configuração :(\nUtilize o botão 'Configurações' para configurar seu aplicativo :D");
                }
            }
            catch (OleDbException err)
            {
                MessageBox.Show(err.Message);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            //OleDbConnection _conexao = new OleDbConnection();


        }

        private void btConfig_Click(object sender, EventArgs e)
        {
            new FormConfig().ShowDialog();
        }

        private void armariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //string sql = "SELECT armarios.idArmario as [Codigo], armarios.numeroArmario as [Numero],  locais.[local] as [Local], armarios.localizacaoArmarioC as [Coluna], armarios.localizacaoArmarioL as [Linha], pessoas.nomePessoa as [Vinculo]  from ((armarios  left outer join locais on  armarios.idlocal =  locais.idlocal) left outer join pessoas on pessoas.idPessoa = armarios.idPessoa) order by armarios.numeroArmario";
            string sql = "SELECT armarios.idArmario as [Codigo], armarios.numeroArmario as [Numero],  locais.localizacao as [Localizacao], armarios.localizacaoArmarioC as [Coluna],armarios.localizacaoArmarioL as [Linha], pessoas.nomePessoa as [Vinculo], situacao.[situacao] as [situacao] FROM  ((( armarios left outer join locais on  armarios.idlocal =  locais.idlocal)	left outer join pessoas on pessoas.idPessoa = armarios.idPessoa) left outer join situacao on armarios.idSituacao = situacao.idSituacao) order by armarios.numeroArmario";
            FormLista frmListaArmarios = new FormLista();
            frmListaArmarios.MdiParent = this;
            frmListaArmarios.preencherTabela(sql, "Armarios", 1);
            frmListaArmarios.setForm(new formCadastroArmario());
            frmListaArmarios.Show();
        }

        private void locaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sql = "SELECT locais.idLocal as [Codigo], locais.localizacao as [Localizacao] from locais";
            FormLista frmListaLocais = new FormLista();
            frmListaLocais.MdiParent = this;
            frmListaLocais.preencherTabela(sql, "Locais", 4);
            frmListaLocais.setForm(new formCadastroLocais());
            frmListaLocais.Show();
        }

        private void pessoasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //string query = "SELECT pessoas.idPessoa as [Codigo], pessoas.nomePessoa as [Nome], pessoas.turmaPessoa as [Turma], tipos.tipo as [Tipo] FROM (pessoas left outer join tipos on pessoas.idTipo = tipos.idTipo)";
            string query = "SELECT pessoas.idPessoa as [Codigo], pessoas.nomePessoa as [Nome], pessoas.turmaPessoa as [Turma], pessoas.telefonePessoa as [Telefone], pessoas.emailPessoa as [E-mail], tipos.tipo as [Tipo] FROM (pessoas left outer join tipos on pessoas.idTipo = tipos.idTipo) ORDER BY pessoas.nomePessoa";
            FormLista frmPessoas = new FormLista();
            frmPessoas.MdiParent = this;
            frmPessoas.preencherTabela(query, "Pessoas", 2);
            frmPessoas.setForm(new formCadastroPessoa());
            frmPessoas.Show();
        }



        private void tiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string query = "SELECT tipos.idTipo as [Codigo], tipos.tipo as [Tipos] from tipos";
            FormLista frmTipo = new FormLista();
            frmTipo.MdiParent = this;
            frmTipo.preencherTabela(query, "Tipos", 3);
            frmTipo.setForm(new formCadastroTipos());
            frmTipo.Show();

        }

        private void bancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FormConfig frmConfigBD = new FormConfig();

        }

        private void situaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string query = "SELECT situacao.idSituacao as [Codigo], situacao.situacao as [Situação], situacao.habilitarEmprestimo as [PodeEmprestar] FROM situacao order by situacao.situacao";
            FormLista frmListaSituacao = new FormLista();
            frmListaSituacao.MdiParent = this;
            frmListaSituacao.preencherTabela(query, "Situacao", 5);
            frmListaSituacao.setForm(new frmCadastroSituacao());
            frmListaSituacao.Show();
        }

        private void vincularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCadastrarVinculo frmVinculo = new formCadastrarVinculo();
            frmVinculo.ShowDialog();
        }

        private void vinculosCadastradosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string query = " SELECT 	armarios.idArmario as [Codigo], 	armarios.numeroArmario as [Armario], 	" +
            "pessoas.nomePessoa as [Pessoa], pessoas.turmaPessoa as [Turma],	locais.localizacao, 	armarios.dataVinculacao as [DataVinculacao] " +
            "FROM 	((armarios 		left outer join pessoas on armarios.idPessoa = pessoas.idPessoa) 		" +
            "left outer join locais on armarios.idLocal = locais.idLocal) WHERE armarios.emprestado = true";
            FormLista frmLista = new FormLista();
            frmLista.MdiParent = this;
            frmLista.preencherTabela(query, "Vínculos", 6);
            frmLista.setForm(new formCadastrarVinculo());
            frmLista.Show();

        }

        private void emprestimosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formSelecionaRelatorioEmprestimo relEmprestimo = new formSelecionaRelatorioEmprestimo();
            relEmprestimo.ShowDialog();
        }

        private void armáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formRelArmarios frmRelArmarios = new formRelArmarios();
            frmRelArmarios.ShowDialog();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sobre frmSobre = new Sobre();
            frmSobre.ShowDialog();
        }

        private void novoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void armáriosLivresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sql = " SELECT  armarios.idArmario as [Codigo],  armarios.numeroArmario as [Numero],  locais.localizacao as [Localizacao], situacao.situacao as [Situacao], situacao.habilitarEmprestimo as [Habilitado], armarios.emprestado as [Livre] FROM   ( 	( 		armarios left outer join locais on  armarios.idlocal =  locais.idlocal 	) 	left outer join situacao on armarios.idSituacao = situacao.idSituacao )  WHERE armarios.emprestado = false and situacao.habilitarEmprestimo = true order by armarios.numeroArmario";
            FormLista frmArmariosLivres = new FormLista();
            frmArmariosLivres.MdiParent = this;
            frmArmariosLivres.preencherTabela(sql, "Armário Livres Para Empréstimo", 0);
            frmArmariosLivres.changeHabilitacao(false, false);
            frmArmariosLivres.Show();

        }

        private void backupDoBDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String localBackup = @"%USERPROFILE%\Documents\SistemaArmarioBackups";
            string caminhoBackup = Environment.ExpandEnvironmentVariables(localBackup);
            //MessageBox.Show(caminhoBackup);
            if (!System.IO.Directory.Exists(caminhoBackup))
            {
                System.IO.Directory.CreateDirectory(caminhoBackup);
            }

            string[] value;
            value = _cx.Caminho.Split('\\');
            int contagem = value.Length;
            //MessageBox.Show(value[contagem - 1]);

            string destino = System.IO.Path.Combine(caminhoBackup,"BACKUP_"+System.DateTime.Now.ToString("ddMMyyyyHHmmss")+value[contagem - 1]);

            System.IO.File.Copy(_cx.Caminho, destino, true);

            MessageBox.Show("REALIZAMOS O BACKUP DA BASE DE DADOS!\nVerifique na Pasta dos Documentos > SistemaArmarioBackups");
        }

        private void desvincularTodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Deseja realmente Desvíncular TODOS os ARMÁRIOS?", "Confirmacao", MessageBoxButtons.YesNo);
            if (resposta == DialogResult.Yes)
            {
                string query = "UPDATE armarios SET emprestado = FALSE, idPessoa = null;";
                try
                {
                    _conexao.Open();
                    OleDbCommand cmd = new OleDbCommand(query, _conexao);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Todos os armários foram desvínculados");
                }
                catch (Exception err)
                {
                    MessageBox.Show("Erro.: " + err.Message);
                }
                finally
                {
                    _conexao.Close();
                }
            }
        }
    }
}
