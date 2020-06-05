using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        public string Index()
        {
            return "Это моё стандартное действие...";
        }

        public string Welcome()
        {
            return "Это действие при открытии Welcome...";
        }
    }
}
