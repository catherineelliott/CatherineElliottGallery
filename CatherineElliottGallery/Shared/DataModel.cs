namespace CatherineElliottGallery.Shared
{
    public class DataModel
    {
       public List<ArtType> types { get; set; }
    }

    public class ArtType
    {
        public string name { get; set; }
        public string title { get; set; }

        public List<Image> images { get; set; }
    }

    public class Image
    {
        public string fileName { get; set; }
        public string title { get; set; }

        public string description { get; set; }

        public string? date { get; set; }
    }
}