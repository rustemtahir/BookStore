using Microsoft.AspNetCore.Mvc;

namespace BookWebSyteBackEndMVC.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
