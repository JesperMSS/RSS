namespace Models
{
    public class Episode : Media
    {
        public string Description { get; set; }

        public Episode(string name)
        {
            this.Name = name;
            string descrption = Description;
        }

        public override string mediaType()
        {
            return "Episode";
        }
            
    }

}