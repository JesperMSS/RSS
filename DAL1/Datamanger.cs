using System.Xml.Serialization;
using System.IO;
using Models;
using System.Collections.Generic;
using System;
namespace DAL
{
    public class Datamanger
    {

        public Datamanger()
        {
            DerializeFiles();
        }


        /*
         public List<Feed> DerializeFiles()
        {
            List<Feed> listofFeeds;
            XmlSerializer serializer = new XmlSerializer(typeof(List<Feed>);

            using (Stream reader = new FileStream("feeds.xml", FileMode.Open, FileAccess.Read))
            {
                listofFeeds = (List<Feeds>)serializer.Deserialze(reader);
            }
        }
        */
        
        
        public void DerializeFiles()
        {
            List<string> itemsInXML;
            XmlSerializer serilizer = new XmlSerializer(typeof(List<string>));

            using (Stream reader = new FileStream("feeds.xml", FileMode.Open, FileAccess.Read))
            {
                itemsInXML = (List<string>)serilizer.Deserialize(reader);
            }

            Console.Write(itemsInXML);
        }
    }
}