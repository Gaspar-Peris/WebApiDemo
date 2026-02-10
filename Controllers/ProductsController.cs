using Microsoft.AspNetCore.Mvc;
using WebApiDemo.Entity;
using WebApiDemo.Service;

namespace WebApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _service;

        
        public ProductsController(IProductService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var products = await _service.GetAll();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var product = await _service.GetById(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Product product)
        {
            await _service.Create(product);
            return Ok(); 
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Product product)
        {
            var result = await _service.Update(id, product);

            if (!result)
            {
                return NotFound();
            }
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _service.Delete(id);

            if (!result)
            {
                return NotFound();
            }
            return Ok();
        }
    }
}
