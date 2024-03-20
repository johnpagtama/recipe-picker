namespace Server.Models
{
    public class Digest
    {
        public string? Label { get; set; }
        public DigestSub? Info { get; set; }
        public string? Unit { get; set; }
        public Sub[]? Sub { get; set; }
    }
}
