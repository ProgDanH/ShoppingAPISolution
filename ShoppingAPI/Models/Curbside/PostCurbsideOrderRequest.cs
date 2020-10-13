using System.ComponentModel.DataAnnotations;

namespace ShoppingAPI.Models.Curbside
{
    public class PostCurbsideOrderRequest
    {
        [Required]
        public string For { get; set; }
        [Required]
        public string Items { get; set; }
    }
}
