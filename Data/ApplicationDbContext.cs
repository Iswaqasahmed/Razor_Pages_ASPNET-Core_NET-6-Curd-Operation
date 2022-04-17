using Microsoft.EntityFrameworkCore;
using Razor_Pages_ASPNET_Core_NET_6.Model;

namespace Razor_Pages_ASPNET_Core_NET_6.Data
{
    public class ApplicationDbContext:DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }


        public DbSet<Category>  Category { get; set; }
    
    }

}
    