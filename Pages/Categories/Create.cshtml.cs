using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor_Pages_ASPNET_Core_NET_6.Data;
using Razor_Pages_ASPNET_Core_NET_6.Model;

namespace Razor_Pages_ASPNET_Core_NET_6.Pages.Categories
{

    [BindProperties(SupportsGet = true)]
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public Category Categories { get; set; }
        public void OnGet()
        {
            
        }


        // dependices injection
        public CreateModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<IActionResult> OnPost(Category category)
        {

            if (ModelState.IsValid)
            {
                _db.Category.AddAsync(category);
                await _db.SaveChangesAsync();
                return RedirectToPage("Index");
            }

            
            return Page(); 
           
        }


        


    }
}
