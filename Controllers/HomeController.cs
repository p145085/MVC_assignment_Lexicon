using Microsoft.AspNetCore.Mvc;

namespace MVC_assignment_Lexicon.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
