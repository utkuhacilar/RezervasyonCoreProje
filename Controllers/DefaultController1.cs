using Microsoft.AspNetCore.Mvc;

namespace RezervasyonCoreProje.Controllers
{
    public class DefaultController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
