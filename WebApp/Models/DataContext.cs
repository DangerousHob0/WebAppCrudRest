using Microsoft.EntityFrameworkCore;
namespace WebApp.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> opts)
            : base(opts) { }
        public DbSet<Product> Products { get; set; }
    }
}