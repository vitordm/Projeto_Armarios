using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace Armarios
{
    public class SaveXML
    {
        public static void SaveData(Object obj, string filename)
        {
            XmlSerializer sr = new XmlSerializer(obj.GetType());
            TextWriter write = new StreamWriter(filename);
            sr.Serialize(write, obj);
            write.Close();
        }
    }
}
