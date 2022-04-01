using Microsoft.AspNetCore.Mvc;

namespace CalisanTakip.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
