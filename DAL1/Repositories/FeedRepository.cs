using System;
using System.Collections.Generic;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Models;

namespace DAL.Repositories
{
   public class FeedRepository : IFeedRepositroy<Feed>
    {
        DataManager dataManager;
        List<Feed> listOfFeeds;

        public FeedRepository()
        {
            dataManager = new DataManager();
            listOfFeeds = new List<Feed>();
            listOfFeeds = GetAll();
        }
        public void Create(Feed podcast)
        {
            listOfFeeds.Add(podcast);
            SaveChanges();
        }

        public void Delete(int i)
        {
            listOfFeeds.RemoveAt(i);
            SaveChanges();
        }

        public List<Feed> GetAll()
        {
            return dataManager.DerializeFiles();
        }

        public Task<List<Episode>> getEpisodes(string url)
        {
            throw new NotImplementedException();
        }

        public int GetIndexOfCategory(string name)
        {
            throw new NotImplementedException();
        }

        public int GetIndexOfName(string name)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
             dataManager.SerializeFiles(listOfFeeds);
        }

        public void Update(int i, Feed newMedia)
        {
            if(i >= 0)
            {
                listOfFeeds[i] = newMedia;
            }
            SaveChanges();
        }
        public List<Episode> getAllEpisodes()
        {

            XmlReader rssReader = XmlReader.Create(@"http://www.svt.se/nyheter/rss.xml");
            SyndicationFeed rssFeed = SyndicationFeed.Load(rssReader);

            List<Episode> allEpisodes = new List<Episode>();

            foreach (var item in rssFeed.Items)
            {
                Episode episode = new Episode(item.Title.Text);
                episode.Description = item.Summary.Text;
                allEpisodes.Add(episode);
            }
            return allEpisodes;
        }
    }
}
