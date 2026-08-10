namespace GameStudioSite.Models
{
    public class Service
    {
        public string Title { get; set; } = "";
        public string Description { get; set; } = "";
    }

    public static class ServiceSeedData
    {
        public static List<Service> All => new()
        {
            new Service { Title = "Game Development", Description = "We bring your game to life with cutting-edge technology and expertise, crafting engaging experiences for PC, console, and mobile platforms. Our developers specialize in implementing game functions like physics, AI, and animation." },
            new Service { Title = "Game Design", Description = "Our team creates immersive experiences that captivate players, developing game elements and mechanics that bring your idea or story to life. We collaborate closely with clients to understand their vision and goals." },
            new Service { Title = "Multiplayer Development", Description = "We develop local and online multiplayer games that connect players worldwide and create an exciting shared experience, using Multiplay, PlayFab, Photon, and other top-notch services." },
            new Service { Title = "2D/3D Art", Description = "Our artists create stunning visuals that bring your game to life, including 2D and 3D assets, characters, environments, and special effects, across various art styles and software." },
            new Service { Title = "Gamification", Description = "We introduce engaging game mechanics into non-gaming applications to boost user engagement, retention, and motivation through strategically designed reward systems." },
            new Service { Title = "Consultation", Description = "Providing expert guidance and insights to elevate your project, tailored to your specific needs and goals." }
        };
    }
}