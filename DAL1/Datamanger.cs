using System.Xml.Serialization;
using System.IO;
using System.Collections.Generic;
using System;
namespace DAL
{
    public class Datamanger
    {

        static void Main(string[] args) { 
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


        public static void DerializeFiles()
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
