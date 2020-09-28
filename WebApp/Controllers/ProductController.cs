using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApp.Models;
using Microsoft.Extensions.Logging;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace WebApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private DataContext context;
        public ProductController(DataContext ctx)
        {
            context = ctx;
        }

        [HttpGet]
        public IAsyncEnumerable<Product> GetProducts() => context.Products;

        [HttpPost]
        public async Task<IActionResult> SaveProduct([FromBody] ProductBindingTarget target)
        {
            Product p = target.ToProduct();
            if (p != null)
            {
                await context.Products.AddAsync(p);
                await context.SaveChangesAsync();
                return StatusCode(201, new JsonResult(new { message = "a new product was created" }));
            }
            return StatusCode(500, new JsonResult(new { error = "error" }));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(long id)
        {
            Product p  = await context.Products.FindAsync(id);

            if (p != null)
            {
                context.Products.Remove(p);
                await context.SaveChangesAsync();
                return StatusCode(204);
            }
            return StatusCode(502, new JsonResult(new { error = "error" }));
        }
    }
}