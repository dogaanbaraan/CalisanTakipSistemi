using Microsoft.AspNetCore.Mvc;

namespace CalisanTakip.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index(int pageNumber = 1)
        {
            ViewBag.PageNumber = pageNumber;
            return View();
        }
    }
}
