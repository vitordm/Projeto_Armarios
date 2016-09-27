using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armarios
{
    /*
     * CLASSE POG
     */
    class Edicoes
    {
        private string _codigo;

        public Edicoes(string cod, int e)
        {
            Codigo = cod;
            editar(e);

        }

        public string Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        private void editar(int edicao)
        {
            if (_codigo == null)
            {
                throw new Exception("Erro, codigo inválido");
            }
            else
            {
                switch (edicao)
                {
                    case 0:
                        return;
                        break;
                    case 1:
                        //Armários
                        formCadastroArmario frmEditarArmario = new formCadastroArmario();
                        frmEditarArmario.EditarCadastro(Codigo);
                        frmEditarArmario.ShowDialog();
                        break;
                    case 2:
                        //Pessoas
                        formCadastroPessoa frmPessoa = new formCadastroPessoa();
                        frmPessoa.EditarCadastro(Codigo);
                        frmPessoa.ShowDialog();
                        break;
                    case 3:
                        //TIPOS
                        formCadastroTipos frmTipo = new formCadastroTipos();
                        frmTipo.EditarCadastro(Codigo);
                        frmTipo.ShowDialog();
                        break;
                    case 4:
                        //LOCAIS
                        formCadastroLocais frmLocal = new formCadastroLocais();
                        frmLocal.EditarCadastro(Codigo);
                        frmLocal.ShowDialog();
                        break;
                    case 5:
                        //SITUAÇÃO
                        frmCadastroSituacao frmSituacao = new frmCadastroSituacao();
                        frmSituacao.EditarCadastro(Codigo);
                        frmSituacao.ShowDialog();
                        break;
                    case 6:
                        formDesvincular frmDesvinculo = new formDesvincular();
                        frmDesvinculo.Desvincular(Codigo);
                        frmDesvinculo.ShowDialog();
                        break;
                }
            }
        }
    }
}
