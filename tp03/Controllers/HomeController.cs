using Microsoft.AspNetCore.Mvc;

namespace TP03.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Creditos()
        {
            return View();
        }
    }
}