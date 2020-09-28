using System.ComponentModel.DataAnnotations.Schema;
namespace WebApp.Models
{
    public class Product
    {
        public long ProductId { get; set; }
        public string Title { get; set; }

        public string Description { get; set; }
        [Column(TypeName = "decimal(8, 2)")] 
        public decimal Price { get; set; }
        public long Quantity { get; set; }
        public string Image { get; set; }

    }
}