using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Armarios
{
    public partial class ShowRelatorio : Form
    {
        public ShowRelatorio()
        {
            InitializeComponent();
        }

        public void setDataSourceRelatorio(RelEmprestimos relatorio)
        {
            CrystalRelatorio.ReportSource = relatorio;
        }
        public void setDataSourceRelatorio(RelArmarios relatorio)
        {
            CrystalRelatorio.ReportSource = relatorio;
        }

        private void ShowRelatorio_FormClosed(object sender, FormClosedEventArgs e)
        {
            CrystalRelatorio.ReportSource = null;
        }

        public void limpaRelatorio()
        {
            CrystalRelatorio.ReportSource = null;
        }
    }
}
