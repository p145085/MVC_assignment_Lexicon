using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MVC_assignment_Lexicon.Controllers
{
    public class GuessController : Controller
    {
        [HttpGet]
        public IActionResult GuessView()
        {
            Random rnd = new Random();
            int rndTarget = rnd.Next(0, 100);

            HttpContext.Session.SetInt32("rndNumber", rndTarget);

            return View();
        }
        [HttpPost]
        public IActionResult GuessView(int guess)
        {
            if (HttpContext.Session.GetInt32("count") == null)
            {
                HttpContext.Session.SetInt32("count", 0);
            }
            HttpContext.Session.SetInt32("count", (int)HttpContext.Session.GetInt32("count") + 1);
            if (guess == HttpContext.Session.GetInt32("rndNumber"))
            {
                ViewBag.Msg = "Correct. " + "You guessed " + HttpContext.Session.GetInt32("count") + " times." + " And the highscore was " + HttpContext.Session.GetInt32("highscore");
                if (HttpContext.Session.GetInt32("count") < HttpContext.Session.GetInt32("highscore")) {
                    HttpContext.Session.SetInt32("highscore", (int)HttpContext.Session.GetInt32("count"));
                }
                HttpContext.Session.SetInt32("count", 0);
                GuessView();
            } else if (guess < HttpContext.Session.GetInt32("rndNumber"))
            {
                ViewBag.Msg = "Your number was lesser than the target.";
            }
            else if (guess > HttpContext.Session.GetInt32("rndNumber"))
            {
                ViewBag.Msg = "Your number was greater than the target.";
            }
            return View();
        }
    }
}
