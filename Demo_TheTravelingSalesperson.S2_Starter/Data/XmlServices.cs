using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Demo_TheTravelingSalesperson
{
    class XmlServices
    {
        private string _dataFilePath;

        public Salesperson ReadSalespersonFromDataFile()
        {
            Salesperson salesperson = new Salesperson();

            // initialize filestream object for reading
            StreamReader sReader = new StreamReader(_dataFilePath);

            // initialize an XML serializer object
            XmlSerializer deserializer = new XmlSerializer(typeof(Salesperson));

            using (sReader)
            {
                object xmlObject = deserializer.Deserialize(sReader);
                Console.WriteLine(xmlObject);
                salesperson = (Salesperson)xmlObject;
            }

            return salesperson;
        }

        public void WriteSalespersonToDataFile(Salesperson salesperson)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Salesperson), new XmlRootAttribute("Salesperson"));

            StreamWriter sWriter = new StreamWriter(_dataFilePath);

            using (sWriter)
            {
                serializer.Serialize(sWriter, salesperson);
            }
        }

        public XmlServices(string dataFilePath)
        {

        }
    }
}
