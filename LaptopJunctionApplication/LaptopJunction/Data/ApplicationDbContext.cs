using LaptopJunction.Models;
using Microsoft.EntityFrameworkCore;
namespace LaptopJunction.Data
{
    public class ApplicationDbContext:DbContext
    {
       public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options){

        }
        public DbSet<Laptop> Laptops { get; set; }
        public DbSet<Login> logins { get; set; }
        public DbSet<Cart> carts { get; set; }  
    }
}
