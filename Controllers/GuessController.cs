using Microsoft.AspNetCore.Http;
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
            int guessCount = 0;
            HttpContext.Session.SetInt32("guessCount", (guessCount + 1));

            if (HttpContext.Session.GetInt32("rndNumber") == null)
            {
                HttpContext.Session.SetInt32("rndNumber", rndTarget);
            }

            if (guess == HttpContext.Session.GetInt32("rndNumber"))
            {
                ViewBag.Msg = "Correct.";
                if (guessCount > HttpContext.Session.GetInt32("highscore"))
                {
                    int temp = (int)HttpContext.Session.GetInt32("guessCount");
                    HttpContext.Session.SetInt32("highscore", temp);
                    ViewBag.Msg = "The highscore is " + HttpContext.Session.GetInt32("highscore");
                }
                guessCount = 0;
            } else if (guess < HttpContext.Session.GetInt32("rndNumber"))
            {
                ViewBag.Msg = "Your number was lesser than the target and you have guessed " + guessCount + " times.";
                HttpContext.Session.SetInt32("guessCount", guessCount++);
            }
            else if (guess > HttpContext.Session.GetInt32("rndNumber"))
            {
                ViewBag.Msg = "Your number was greater than the target and you have guessed " + guessCount + " times.";
                HttpContext.Session.SetInt32("guessCount", guessCount++);
            }
            return View();
        }
    }
}
