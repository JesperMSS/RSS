using DAL.Repositories;
using Models;
using System;
using System.Collections.Generic;

namespace BL.Controllers
{
    public class FeedController
    {
        IRepository<Feed> feedRepository;
        public FeedController()
        {
            feedRepository = new FeedRepository();
        }

        public void Createfeed(string pName, string pUrl, string pCategory, List<Episode> pEpisodes)
        {
            Feed newFeed = null;
            feedRepository.Create(newFeed);

        }


    }
}
