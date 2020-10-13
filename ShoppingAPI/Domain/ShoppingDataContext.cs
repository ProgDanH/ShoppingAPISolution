using Microsoft.EntityFrameworkCore;

namespace ShoppingAPI.Domain
{
    public class ShoppingDataContext : DbContext
    {
        public ShoppingDataContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet <ShoppingItem> ShoppingItems { get; set; }
        public DbSet <CurbsideOrder> CurbsideOrders { get; set; }
    }
}
