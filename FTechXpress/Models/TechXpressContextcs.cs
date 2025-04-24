using Microsoft.EntityFrameworkCore;

namespace FTechXpress.Models
{
    public class TechXpressContextcs:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=TechXpress;Integrated Security=True;Encrypt=False");
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<Review>  Reviews { get; set; }
        public DbSet<WishList> wishLists { get; set; }
 
    }
}
