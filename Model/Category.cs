using System.ComponentModel.DataAnnotations;

namespace Razor_Pages_ASPNET_Core_NET_6.Model
{
    /// <summary>
    /// Category Class 
    /// </summary>
    public class Category
    {
        [Key]
        public int ID { get; set; }
        
        
        [Required]
        public string Name { get; set; }
        
        public int DisplayOrder { get; set; }
    }
}
