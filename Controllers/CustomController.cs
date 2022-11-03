using Microsoft.AspNetCore.Mvc;

namespace MVC_assignment_Lexicon.Controllers
{
    public class CustomController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Projects()
        {
            return View();
        }
    }
}
