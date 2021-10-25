using System.Xml.Serialization;
using System.IO;
using Models;
namespace DAL
{
    public class Datamanger
    {
        public List<Feed> DerializeFiles() 
        {
            List<Feed> listofFeeds;
            XmlSerializer serializer = new XmlSerializer(typeof(List<Feed>);

            using (Stream reader = new FileStream("feeds.xml", FileMode.Open, FileAccess.Read))
            {
                listofFeeds = (List<Feeds>)serializer.Deserialze(reader);
            }

        }


    }
}