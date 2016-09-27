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

namespace Armarios
{
    public partial class FormConfig : Form
    {
        bool _mostarCaracteres = true;
        public FormConfig()
        {
            InitializeComponent();
        }

        private void btMostrar_Click(object sender, EventArgs e)
        {
            if (_mostarCaracteres == true)
            {
                tbSenha.PasswordChar = '*';
            }
            else
            {
                tbSenha.PasswordChar = '\0';
            }
            _mostarCaracteres = !_mostarCaracteres;
            tbSenha.Text = tbSenha.Text;
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Information info = new Information();

                info.CaminhoDB = tbCaminho.Text;
                info.SenhaDB = tbSenha.Text;
                SaveXML.SaveData(info, "configuration.xml");
                MessageBox.Show("Configuração salva com sucesso!");
                this.Close();
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void FormConfig_Load(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists("configuration.xml"))
                {
                    XmlSerializer xs = new XmlSerializer(typeof(Information));
                    FileStream read = new FileStream("configuration.xml", FileMode.Open, FileAccess.Read, FileShare.Read);
                    Information info = (Information)xs.Deserialize(read);
                    tbCaminho.Text = info.CaminhoDB;
                    tbSenha.Text = info.SenhaDB;
                    read.Close();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btCaminho_Click(object sender, EventArgs e)
        {
            OpenFileDialog BuscaArquivo = new OpenFileDialog();
            BuscaArquivo.ShowDialog();
            tbCaminho.Text = BuscaArquivo.FileName.ToString();
        }


    }
}
