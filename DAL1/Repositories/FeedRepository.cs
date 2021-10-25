using System;
using System.Collections.Generic;
using System.ServiceModel.Syndication;
using System.Text;
using System.Xml;
using Models;

namespace DAL.Repositories
{
    class FeedRepository
    {


        public  getAllEpisodes()
        {

            XmlReader rssReader = XmlReader.Create(@"http://www.svt.se/nyheter/rss.xml");
            SyndicationFeed rssFeed = SyndicationFeed.Load(rssReader);

            List<Episode> allEpisodes = new List<Episode>();
            
            foreach(Episode episode in allEpisodes)
            {
                string Title = 
            }
        }

    }
}
