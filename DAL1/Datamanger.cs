using System.Xml.Serialization;
using System.IO;
using System.Collections.Generic;
using System;
using Models;
namespace DAL
{
<<<<<<< Updated upstream
    public class DataManager
=======
    internal class DataManager
>>>>>>> Stashed changes
    {
        public void SerializeFiles(List<Feed> listofFeeds)
        {
            
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Feed>));
                using (FileStream reader = new FileStream("feeds.xml", FileMode.Create, FileAccess.Write))
                {
                    xmlSerializer.Serialize(reader, listofFeeds);
                }
            
        }
<<<<<<< Updated upstream
        public void DerializeFiles()
        {
            List<string> itemsInXML;
            XmlSerializer serilizer = new XmlSerializer(typeof(List<string>));
=======

        
         public void SerializeFiles(List<Feed> listofFeeds)
        {
     
            XmlSerializer serializer = new XmlSerializer(typeof(List<Feed>);
>>>>>>> Stashed changes

            using (Stream reader = new FileStream("feeds.xml", FileMode.Create, FileAccess.Write)
            {
<<<<<<< Updated upstream
               itemsInXML = (List<string>)serilizer.Deserialize(reader);
             }
=======
                serializer.Serialize(reader, listofFeeds)
            }
        }
        

>>>>>>> Stashed changes

            foreach (String item in itemsInXML)
            {
                Console.WriteLine(item);
            }
<<<<<<< Updated upstream
        }
=======
>>>>>>> Stashed changes
       


    }
    }
