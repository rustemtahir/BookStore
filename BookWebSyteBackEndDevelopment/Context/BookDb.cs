using BookWebSyteBackEndMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace BookWebSyteBackEndMVC.Context
{
    public class BookDb:DbContext
    {
        public DbSet<Category>Categories { get; set; }
        public DbSet<Blog>Blogs { get; set; }
        public BookDb(DbContextOptions<BookDb>options ):base (options)
        {
            
        }
    }
}
