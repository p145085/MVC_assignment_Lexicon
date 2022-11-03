using Microsoft.AspNetCore.Mvc;

namespace MVC_assignment_Lexicon.Controllers
{
    public class GuessController : Controller
    {
        [HttpGet]
        public IActionResult GuessView()
        {
            return View();
        }
        [HttpPost]
        public IActionResult GuessView(int guess)
        {
            Random rnd = new Random();
            int rndTarget = rnd.Next(0, 100);

            if (HttpContext.Session.GetInt32("rndNumber") == null)
            {
                HttpContext.Session.SetInt32("rndNumber", rndTarget);
            }

            if (guess == HttpContext.Session.GetInt32("rndNumber"))
            {
                ViewBag.Msg = "Correct.";
            } else if (guess < HttpContext.Session.GetInt32("rndNumber"))
            {
                ViewBag.Msg = "Your number was lesser than the target.";
            } else if (guess > HttpContext.Session.GetInt32("rndNumber"))
            {
                ViewBag.Msg = "Your number was greater than the target.";
            }
            return View();
        }
    }
}
