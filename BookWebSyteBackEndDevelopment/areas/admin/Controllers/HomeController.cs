using Microsoft.AspNetCore.Mvc;

namespace BookWebSyteBackEndMVC.areas.admin.Controllers
{
    [Area("admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
