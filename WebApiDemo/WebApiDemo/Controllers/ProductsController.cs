using AutoMapper;
using DataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using Services.Service;
using Shared;

namespace WebApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        private readonly IProductService _service;
        private readonly IMapper _mapper;
        public ProductsController(IProductService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var products = await _service.GetAll();
            var dto = _mapper.Map<IEnumerable<ProductResponseDto>>(products);
            return Ok(dto);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var product = await _service.GetById(id);

            if (product == null)
            {
                return NotFound();
            }

            
            var dto = _mapper.Map<ProductResponseDto>(product);

            return Ok(dto);
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
