using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armarios
{
    public class Information
    {
        private string caminhoDB, senhaDB;

        public string CaminhoDB
        {
            get { return caminhoDB; }
            set { caminhoDB = value; }
        }

        public string SenhaDB
        {
            get { return senhaDB; }
            set { senhaDB = value; }
        }
    }
}
