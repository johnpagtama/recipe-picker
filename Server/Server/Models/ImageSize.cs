namespace Server.Models
{
    public class ImageSize
    {
        public ImageSizeInfo? Thumbnail { get; set; }
        public ImageSizeInfo? Small { get; set; }
        public ImageSizeInfo? Regular { get; set; }
        public ImageSizeInfo? Large { get; set; }
    }
}
