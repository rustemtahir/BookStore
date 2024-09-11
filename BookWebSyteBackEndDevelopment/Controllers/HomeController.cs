
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BookWebSyteBackEndDevelopment.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

       

    }
}
