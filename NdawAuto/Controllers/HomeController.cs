using Microsoft.AspNetCore.Mvc;
using NdawAuto.Models;
using System.Diagnostics;

namespace NdawAuto.Controllers
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
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Gamme()
        {
            return View();
        }

        public IActionResult Offres()
        {
            return View();
        }

        public IActionResult APropos()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
