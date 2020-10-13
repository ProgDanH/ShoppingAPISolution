using System.ComponentModel.DataAnnotations;

namespace ShoppingAPI.Models.Catalog
{
    public class PostCatalogRequest
    {
        [Required]
        public string Description { get; set; }
        [Required]
        public decimal Cost { get; set; }
    }
}
