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


        public List<Episode> getAllEpisodes()
        {

            XmlReader rssReader = XmlReader.Create(@"http://www.svt.se/nyheter/rss.xml");
            SyndicationFeed rssFeed = SyndicationFeed.Load(rssReader);

            List<Episode> allEpisodes = new List<Episode>();
            
            foreach(var item in rssFeed.Items)
            {
                Episode episode = new Episode(item.Title.Text);
                episode.Description = item.Summary.Text;
                allEpisodes.Add(episode);
            }
            return allEpisodes;
        }

    }
}
