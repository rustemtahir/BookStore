using BookWebSyteBackEndMVC.Context;
using BookWebSyteBackEndMVC.Helper;
using BookWebSyteBackEndMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookWebSyteBackEndMVC.Areas.admin.Controllers
{
    [Area("admin")]
    public class BlogController : Controller
    {
        
        
        private readonly BookDb _context;
        private IWebHostEnvironment _env;

        public BlogController(BookDb context)
        {
            _context = context;
        }

        public BlogController(IWebHostEnvironment env)
        {
            _env = env;
        }

        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Blog blog)
        {
            if (!ModelState.IsValid)
            {
                return View(blog);
            }
            if (!FileHelper.HasValidSize(blog.File, 2))
            {
                ModelState.AddModelError(nameof(File), "File size must be max 2-mb");
                return View(blog);
            }
            if (!FileHelper.IsImage(blog.File))
            {
                ModelState.AddModelError(nameof(File), "File must be an image ");
                return View(blog);
            }

            var root = _env.WebRootPath;
            var path = "assets/img/blog";
            await _context.Blogs.AddAsync(blog);
            await _context.SaveChangesAsync();
            return View();
        }
    }
}
