using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor_Pages_ASPNET_Core_NET_6.Data;
using Razor_Pages_ASPNET_Core_NET_6.Model;

namespace Razor_Pages_ASPNET_Core_NET_6.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public IEnumerable<Category> Categories { get; set; }

        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public void OnGet()
        {
            Categories = _db.Category; //.ToList();
        }
    }
}
