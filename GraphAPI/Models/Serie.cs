namespace GraphAPI.Models{
    public class Serie{
        public int Id { get; set; }
        public string Name{get; set;}
        public List<Platform> Platforms{get; set;}
        public DateTime ReleaseDate{get; set;}
    }
}