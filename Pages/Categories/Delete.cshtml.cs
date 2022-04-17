using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor_Pages_ASPNET_Core_NET_6.Data;
using Razor_Pages_ASPNET_Core_NET_6.Model;

namespace Razor_Pages_ASPNET_Core_NET_6.Pages.Categories
{
    public class DeleteModel : PageModel
    {

        private readonly ApplicationDbContext _db;
        public Category Categories { get; set; }
        public void OnGet()
        {
        }

        //public CreateModel(ApplicationDbContext db)
        //{
        //    _db = db;
        //}

        public async Task<IActionResult> OnPostDelete(int id)
        {
            var category = await _db.Category.FindAsync(id);
            _db.Category.Remove(category);
            await _db.SaveChangesAsync();
            return RedirectToPage("Index");
        }
    }
}
