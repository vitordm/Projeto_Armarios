using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
//Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\myFolder\myAccess2007file.accdb;Jet OLEDB:Database Password=MyDbPassword;
namespace Armarios
{
    class Conexao
    {
        //OleDbConnection _conexao;
        private string _CS;
        private string _caminho;
        private string _senha;
        public OleDbConnection _conexao;

        //public OleDbConnection OLEConexao
        //{
        //    get { return _conexao; }
        //    set { _conexao = value; }
        //}

        public string Caminho
        {
            get { return _caminho; }
            set { _caminho = value; }
        }

        public string Senha
        {
            get { return _senha; }
            set { _senha = value; }
        }

        public void setConectionString(string caminho, string senha)
        {
            //this._CS = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + caminho + ";Jet OLEDB:Database Password=" + senha + ";";
            this._CS = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + caminho + ";Jet OLEDB:Database Password=" + senha + ";";
        }

        public string getConectionString()
        {
            return this._CS;
        }


    }
}
