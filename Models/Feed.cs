namespace Models
{
	public class Feed : Media
    {
      public string Freq { get; set; }
      public string Url { get; set; }
      public string Category { get; set; }
      public List<Episode> Episodes { get; set;}
     
     public Feed (string name, string url, string category, List<Episode> episodes)
        {
            Name = name;
            Url = url;
            Category = category;
            Episodes = episodes;

        }

           public override string mediaType()
        {
            return "Feed";
        }
      
}