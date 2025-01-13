using Blogger.Web.Data;
using Blogger.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Blogger.Web.Pages.Categories
{
    public class CreateModel : PageModel
    {
        // to work with database add ApplicationDbContext
        private readonly ApplicationDbContext _db;

        public Category Category { get; set; }

        public CreateModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public void OnGet()
        {
        }

        // fetch the data from the form and save it to the database
        public async Task<IActionResult> OnPost(Category category)
        {
            await _db.Category.AddAsync(category);
            await _db.SaveChangesAsync();
            return RedirectToPage("Index");
        }
    }
}
