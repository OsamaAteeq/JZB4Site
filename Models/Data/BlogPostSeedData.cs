using GameStudioSite.Models;

public static class BlogPostSeedData
{
    private static readonly List<BlogPost> _posts = new()
    {
        new BlogPost
            {
                Title = "Esports World Cup 2024 Schedule Revealed",
                Slug = "esports-world-cup-2024-schedule-revealed-gamings-grand-event-in-saudi-arabia",
                Excerpt = "The official schedule for the Esports World Cup 2024 has been unveiled, setting the stage for an epic showdown in Riyadh with a record-breaking $60 million prize pool.",
                ContentHtml = "The official schedule for the Esports World Cup 2024 has been unveiled, setting the stage for an epic showdown in Riyadh with a record-breaking $60 million prize pool.",
                FeaturedImageUrl = "/images/esport.jpg",
                PublishedDate = new DateTime(2024, 5, 1),
                ImageAltText = "Esport image"
            },
            new BlogPost
            {
                Title = "Unity and Mazda Collaborate to Revolutionize In-Vehicle Experiences",
                Slug = "unity-and-mazda-collaborate-to-revolutionize-in-vehicle-experiences",
                Excerpt = "Unity Japan and Mazda Motor Corporation have announced a groundbreaking partnership aimed at transforming in-vehicle Human-Machine Interfaces.",
                ContentHtml = "Unity Japan and Mazda Motor Corporation have announced a groundbreaking partnership aimed at transforming in-vehicle Human-Machine Interfaces.",
                FeaturedImageUrl = "/images/mazda.jpg",
                PublishedDate = new DateTime(2024, 5, 1),
                ImageAltText = "Mazda Interior"
            }
    };

    public static List<BlogPost> GetLatest(int count)
    {
        return _posts
            .OrderByDescending(p => p.PublishedDate)
            .Take(count)
            .ToList();
    }
}