using BookWebSyteBackEndMVC.Models.Base;
//using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookWebSyteBackEndMVC.Models
{
    public class Category:BaseModel
    {
        [Required]
        [StringLength(30,ErrorMessage ="Name max length should be 30 characters ")]
        public string Name { get; set; }

        public List<Blog>Blogs { get; set; }
      


    }
}
