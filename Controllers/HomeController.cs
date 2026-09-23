using System.Diagnostics;
using GameStudioSite.Models;
using Microsoft.AspNetCore.Mvc;

namespace GameStudioSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Route("/")]
        public IActionResult Index()
        {
            var viewModel = new HomeIndexViewModel
            {
                Services = ServiceSeedData.All,
                LatestGames = GameSeedData.GetLatest(3),
                LatestBlogPosts = BlogPostSeedData.GetLatest(2)
            };

            return View(viewModel);
        }

        [Route("/Privacy")]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [Route("/Games")]
        public IActionResult Games()
        {
            return View(GameSeedData.All());
        }

        [Route("/Services")]
        public IActionResult Services()
        {
            return View(ServiceSeedData.All);
        }

        [Route("/About")]
        public IActionResult About()
        {
            return View();
        }
    }
}
