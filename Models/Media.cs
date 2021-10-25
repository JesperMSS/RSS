namespace Models 
    public abstract class Media{
        public string Name { get; set }

        public Media(string name)
    {
        Name = name;
    }


    public virtual string mediaType() {
        return "Media";
    }

    }