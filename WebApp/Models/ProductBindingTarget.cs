using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class ProductBindingTarget
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        [DataType("decimal(8 ,2)")]
        public decimal Price { get; set; }
        [Range(1, long.MaxValue)]
        public long Quantity { get; set; }
        public string Image { get; set; }


        public Product ToProduct() =>new Product {
                Title = this.Title,
                Description = this.Description,
                Price = this.Price,
                Quantity = this.Quantity,
                Image = this.Image
            };
    }
}