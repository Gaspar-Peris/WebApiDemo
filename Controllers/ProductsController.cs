using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiDemo.Data;
using WebApiDemo.Entity;

namespace WebApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly AplicationDbContext _context;

        public ProductsController(AplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public  IActionResult Get()
        {
            return Ok(_context.Products.ToList());
        }
        [HttpGet("{id}")]
        public async Task<IActionResult>Get(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product==null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            return Ok();    
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id,Product products)
        {
            var obj=await _context.Products.FindAsync(id);
            if (obj == null)
            {
                return NotFound();
            }

            obj.Name = products.Name;
            obj.Description = products.Description;
            obj.Price = products.Price;
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product==null)
            {
                return NotFound();
            }
            await _context.SaveChangesAsync();
            return Ok(product);
        }
    }
}
