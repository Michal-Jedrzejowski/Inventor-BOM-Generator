using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;
using ListGenerator2000.Models;
using System.Xml.Linq;

namespace ListGenerator2000.Services
{
    class InventorXMLService
    {
        private XmlSerializer _serializer = new XmlSerializer(typeof(List<InventorPart>));
        private List<InventorPart> _inventorParts = new List<InventorPart>();

        public void SaveToXML(List<InventorPart> inventorParts, string filename)
        {
            filename = Properties.Settings.Default["ListFileLocation"] + "\\"+ filename + ".xml";
            //filename += @"\Lista.xml";

            TextWriter writer = new StreamWriter(filename);
            _serializer.Serialize(writer, inventorParts);
            writer.Dispose();

        }

        public void ChangeXMLValue(InventorPart inventorPart, string filename)
        {
            filename = Properties.Settings.Default["ListFileLocation"] + "\\" + filename + ".xml";
            XDocument xmlDocument = XDocument.Load(filename);

            XElement ipart = (from inventorParts in xmlDocument.Descendants("InventorPart")
                            where inventorParts.Element("PartNumber").Value == inventorPart.PartNumber
                            select inventorParts).FirstOrDefault();

            ipart.Element("Comments").Value = inventorPart.Comments;
            ipart.Element("State").Value = inventorPart.State;

            try
            {
                if (inventorPart.UpdateCounter == Int32.Parse(ipart.Element("UpdateCounter").Value))
                {
                    inventorPart.Update();
                    ipart.Element("UpdateCounter").Value = inventorPart.UpdateCounter.ToString();

                }
            }
            catch
            {
                ipart.Add(new XElement("UpdateCounter", inventorPart.UpdateCounter.ToString()));
            }
            

            xmlDocument.Save(filename);
        }

        public List<InventorPart> ReadFromXML(string filename)
        {
            _inventorParts.Clear();
            if (File.Exists(filename))
            {
                //FileStream fileStream = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                Stream fileStream = new FileStream(filename, FileMode.Open);
                System.Xml.XmlReader reader = new System.Xml.XmlTextReader(fileStream);
                _serializer = new XmlSerializer(typeof(List<InventorPart>));
                

                using (fileStream)
                {
                    if (_serializer.CanDeserialize(reader))
                        _inventorParts = (List<InventorPart>)_serializer.Deserialize(reader);
                }
                reader.Close();
            }

            
            return _inventorParts;

        }

    }
}
