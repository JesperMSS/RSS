using System;
using System.Collections.Generic;
using System.ServiceModel.Syndication;
using System.Text;
using System.Xml;

namespace DAL.Repositories
{
    class FeedRepository
    {


        public void getAllEpisodes()
        {

            XmlReader rssReader = XmlReader.Create(@"http://www.svt.se/nyheter/rss.xml");
            SyndicationFeed rssFeed = SyndicationFeed.Load(rssReader);


        }

    }
}
