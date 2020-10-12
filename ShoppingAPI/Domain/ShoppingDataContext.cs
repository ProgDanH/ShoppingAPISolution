using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ShoppingAPI.Domain
{
    public class ShoppingDataContext : DbContext
    {
        public ShoppingDataContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet <ShoppingItem> ShoppingItems { get; set; }
    }
}
