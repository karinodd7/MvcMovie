using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        public string Index()
        {
            return "Это моё стандартное действие...";
        }

        //public string Welcome()
        //{
        //    return "Это действие при открытии Welcome...";
        //}

        public string Welcome(string name, int numTimes = -1)
        {
            if (string.IsNullOrEmpty(name) || numTimes == -1)
                return "Необходимо ввести параметры";
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes: {numTimes}");
        }
    }
}
