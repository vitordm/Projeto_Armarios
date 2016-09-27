using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Armarios
{
    /**
     * POG PARA DELETAR!
     **/

    class DeleteFromGrid
    {
        private string _codigo;
        private string query;
        private OleDbConnection conexao;

        public string Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        public void deletarConteudo(int tipo)
        {
            switch (tipo)
            {
                case 1:
                    //armarios
                    query = "DELETE FROM armarios WHERE idArmario = " + _codigo;
                    break;
            }

            try
            {
                conexao.Open();
                OleDbCommand cmd = new OleDbCommand(query, conexao);
                cmd.ExecuteNonQuery();
                //MessageBox.Show((cbLocalizacao.SelectedItem as ComboBoxItem).Value.ToString());


            }
            catch (Exception err)
            {
                throw err;
            }
            finally
            {
                conexao.Close();
            }

        }
    }
}
