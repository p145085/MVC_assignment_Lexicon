using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using System.Xml;

namespace MVC_assignment_Lexicon.Controllers
{
    public class Doctor : Controller
    {
        [HttpGet]
        public IActionResult DoctorPage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DoctorPage(double temp)
        {
            if (temp >= 0)
            {
                ViewBag.Msg = Models.TestFever.TestFeverMethod(temp);
                return View();
            }
            else
            {
                ViewBag.Msg = "Please enter your temperature and then hit Submit.";
                return View();
            }
        }
    }
}
