using BookWebSyteBackEndMVC.Context;
using BookWebSyteBackEndMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Update.Internal;

namespace BookWebSyteBackEndMVC.Areas.admin.Controllers
{
    [Area("admin")]
    public class CategoryController : Controller
    {
        private readonly BookDb _context;

        public CategoryController(BookDb context)
        {
            _context = context;
        }
             
        public async Task<IActionResult> Index()
        {
          var categories= await _context.Categories.Where(c=>!c.IsDeleted).ToListAsync();
            return View(categories);
        }
        public async Task<IActionResult>Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Category category)
        {
            if (!ModelState.IsValid)
            {
                return View(category);  
            }
            category.CreatedAt = DateTime.UtcNow.AddHours(4);
            await _context.Categories.AddAsync(category);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
      public async Task<IActionResult>Delete(int id)
        {
            var category=await _context.Categories.FirstOrDefaultAsync(c=>c.Id==id);
            if (category is null)
            {
                return NotFound();
            }
            category.IsDeleted=true;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult>Update(int id)
        {
            var category = await _context.Categories.FirstOrDefaultAsync(c => c.Id == id);
            if (category is null)
            {
                return NotFound();
            }
            return View(category);
        }

        [HttpPost]
        public async Task<IActionResult>Update(int id,Category category)
        {
            var updatedCategory = await _context.Categories.FirstOrDefaultAsync(c => c.Id == id);
            if (category is null)
            {
                return NotFound();
            }
            if (!ModelState.IsValid)
            {
                return View(updatedCategory);
            }
            updatedCategory.Name = category.Name;
            updatedCategory.UpdtedAt = DateTime.UtcNow.AddHours(4);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
