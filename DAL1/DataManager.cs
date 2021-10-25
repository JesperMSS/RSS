using System.Xml.Serialization;
using System.IO;
using System.Collections.Generic;
using System;
using Models;
namespace DAL
{
    public class DataManager
    {
        public void SerializeFiles(List<Feed> listofFeeds)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Feed>));
            using (FileStream reader = new FileStream("feeds.xml", FileMode.Create, FileAccess.Write))
            {
                xmlSerializer.Serialize(reader, listofFeeds);
            }
        }
            public void DerializeFiles()
            {
                List<string> itemsInXML;
                XmlSerializer serilizer = new XmlSerializer(typeof(List<string>));

                using (Stream reader = new FileStream("feeds.xml", FileMode.Open, FileAccess.Read))
                {
                    itemsInXML = (List<string>)serilizer.Deserialize(reader);
                }

                foreach (String item in itemsInXML)
                {
                    Console.WriteLine(item);
                }
            }
    }
}
