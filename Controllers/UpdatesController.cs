using GameStudioSite.Models;
using Microsoft.AspNetCore.Mvc;

namespace GameStudioSite.Controllers
{
    public class UpdatesController : Controller
    {
        private const int PageSize = 6;

        public IActionResult Index(int page = 1, string? category = null)
        {
            if (page < 1) page = 1;

            var (posts, totalCount) = BlogPostSeedData.GetPage(page, PageSize, category);

            var viewModel = new BlogIndexViewModel
            {
                Posts = posts,
                Categories = BlogPostSeedData.GetAllCategories(),
                SelectedCategory = category,
                CurrentPage = page,
                TotalPages = (int)Math.Ceiling(totalCount / (double)PageSize)
            };

            return View(viewModel);
        }
    }
}