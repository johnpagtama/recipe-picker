namespace Server.Models
{
    public class DigestSub
    {
        public string? Tag { get; set; }
        public string? SchemaOrgTag { get; set; }
        public float Total { get; set; }
        public bool HasRDI { get; set; }
        public float Daily { get; set; }
    }
}
