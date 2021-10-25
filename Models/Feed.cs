using System.Collections.Generic;
namespace Models
{
    public class Feed : Media
    {
        public string Freq { get; set; }
        public string Url { get; set; }
        public string Category { get; set; }
        public List<Episode> Episodes { get; set; }

        public Feed(string pName, string pUrl, string pCategory, List<Episode> pEpisodes) : base()
        {
            Name = pName;
            Url = pUrl;
            Category = pCategory;
            Episodes = pEpisodes;

        }

        public override string mediaType()
        {
            return "Feed";
        }

    }
}