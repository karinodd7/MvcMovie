using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        //public string Index()
        //{
        //    return "Это моё стандартное действие...";
        //}

        //public string Welcome()
        //{
        //    return "Это действие при открытии Welcome...";
        //}

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(string name, int numTimes = -1)
        {
            if (string.IsNullOrEmpty(name) || numTimes == -1)
            {
                ViewData["Message"] = "Отсутствуют параметры";
                ViewData["NumTimes"] = 1;
                return View();
            }

            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}
