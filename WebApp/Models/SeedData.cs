using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace WebApp.Models
{
    public static class SeedData
    {
        public static void SeedDatabase(DataContext context)
        {
            context.Database.Migrate();
            if (context.Products.Count() == 0)
            {
                context.Products.AddRange(
                    new Product 
                    {
                        Title = "Propduct1",
                        Description = "Desc1",
                        Price = 99.99M,
                        Quantity = 10,
                        Image = null
                    },
                    new Product 
                    {
                        Title = "Propduct2",
                        Description = "Desc2",
                        Price = 99.99M,
                        Quantity = 10,
                        Image = null
                    },
                    new Product 
                    {
                        Title = "Propduct3",
                        Description = "Desc3",
                        Price = 99.99M,
                        Quantity = 10,
                        Image = null
                    }
                );
                context.SaveChanges();
            }
        }
    }
}