using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingAPI.Models.Catalog
{
    public class PostCatalogRequest
    {
        public string Description { get; set; }
        public decimal Cost { get; set; }
    }
}
