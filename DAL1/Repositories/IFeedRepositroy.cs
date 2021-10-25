using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    interface IFeedRepositroy<T> : IRepository<T> where T : Feed
    {
        Task<List<Episode>> getEpisodes(string url);
        int GetIndexOfCategory(string name);
    }

}
