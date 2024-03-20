namespace Server.Models
{
    public class RootObject
    {
        public int From { get; set; }
        public int To { get; set; }
        public int Count { get; set; }
        public LinkNext? _Links { get; set; }
        public Hit[]? Hits { get; set; }
    }
}
