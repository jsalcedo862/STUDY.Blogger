using Blogger.Web.Data;
using Blogger.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Blogger.Web.Pages.Categories
{
    public class IndexModel : PageModel
    {
        // create readonly ApplicationDbContext
        private readonly ApplicationDbContext _context;

        public IEnumerable<Category> Categories { get; set; }

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            Categories = _context.Category;
        }
    }
}
