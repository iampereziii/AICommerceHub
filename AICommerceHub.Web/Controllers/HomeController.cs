using AICommerceHub.Service.Implementation;
using AICommerceHub.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AICommerceHub.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            AiService aiService = new AiService();
            String html = aiService.GenerateHTML();

            ViewData["HtmlContent"] = html;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
