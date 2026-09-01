namespace GameStudioSite.Models
{
    public class BlogPost
    {
        public string Title { get; set; } = "";
        public string Slug { get; set; } = "";
        public string ExcerptHtml { get; set; } = "";
        public string FeaturedImageUrl { get; set; } = "";
        public DateTime PublishedDate { get; set; }
    }

    public static class BlogPostSeedData
    {
        public static List<BlogPost> All => new()
        {
            new BlogPost
            {
                Title = "Esports World Cup 2024 Schedule Revealed",
                Slug = "esports-world-cup-2024-schedule-revealed-gamings-grand-event-in-saudi-arabia",
                ExcerptHtml = "The official schedule for the Esports World Cup 2024 has been unveiled, setting the stage for an epic showdown in Riyadh with a record-breaking $60 million prize pool.",
                FeaturedImageUrl = "/images/blog-esports-world-cup.jpg",
                PublishedDate = new DateTime(2024, 5, 1)
            },
            new BlogPost
            {
                Title = "Unity and Mazda Collaborate to Revolutionize In-Vehicle Experiences",
                Slug = "unity-and-mazda-collaborate-to-revolutionize-in-vehicle-experiences",
                ExcerptHtml = "Unity Japan and Mazda Motor Corporation have announced a groundbreaking partnership aimed at transforming in-vehicle Human-Machine Interfaces.",
                FeaturedImageUrl = "/images/blog-unity-mazda.jpg",
                PublishedDate = new DateTime(2024, 5, 1)
            }
        };
    }
}