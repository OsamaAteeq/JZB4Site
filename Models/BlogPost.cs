namespace GameStudioSite.Models
{
    public class BlogPost
    {
        public string Title { get; set; } = "";
        public string Slug { get; set; } = "";
        public string Excerpt { get; set; } = "";

        public string ContentHtml { get; set; } = "";
        public string FeaturedImageUrl { get; set; } = "";
        public DateTime PublishedDate { get; set; }

        public string ImageAltText { get; set; } = "";
    }
}