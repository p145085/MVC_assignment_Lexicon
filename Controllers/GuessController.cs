using Microsoft.AspNetCore.Mvc;

namespace MVC_assignment_Lexicon.Controllers
{
    public class GuessController : Controller
    {
        [HttpGet]
        public IActionResult GuessView()
        {
            //Random rnd = new Random();
            //int rndTarget = rnd.Next(0, 100);
            //Console.WriteLine(rndTarget);
            return View();
        }
    }
}
