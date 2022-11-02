using Microsoft.AspNetCore.Mvc;

namespace Raicu_Nicole_Lab1.Controllers
{
    public class ControllerNou : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
