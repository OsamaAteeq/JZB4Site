using GameStudioSite.Models;
using GameStudioSite.Services;
using Microsoft.AspNetCore.Mvc;

namespace GameStudioSite.Controllers
{
    public class ContactController : Controller
    {
        private readonly IEmailService _emailService;
        private readonly ILogger<ContactController> _logger;

        public ContactController(IEmailService emailService, ILogger<ContactController> logger)
        {
            _emailService = emailService;
            _logger = logger;
        }

        [Route("/Contact")]
        [HttpGet]
        public IActionResult Index()
        {
            return View(new ContactFormModel());
        }

        [Route("/Contact")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(ContactFormModel form)
        {
            // Honeypot check — if this hidden field has anything in it, it's a bot. Pretend success, do nothing.
            if (!string.IsNullOrEmpty(form.Website))
            {
                return RedirectToAction("Success");
            }

            if (!ModelState.IsValid)
            {
                return View(form);
            }

            try
            {
                await _emailService.SendContactFormEmailAsync(form);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to send contact form email.");
                ModelState.AddModelError("", "Something went wrong sending your message. Please try again later.");
                return View(form);
            }

            return RedirectToAction("Success");
        }

        [Route("/Contact/Success")]
        public IActionResult Success()
        {
            return View();
        }
    }
}