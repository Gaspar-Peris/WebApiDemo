using AutoMapper;
using DataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using Services.Service;
using Shared;
using Shared.Dto;

namespace WebApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _service;
        private readonly IMapper _mapper;
        public CategoryController(ICategoryService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var categories = await _service.GetAll();
            var dto = _mapper.Map<IEnumerable<CategoryResponseDto>>(categories);
            return Ok(dto);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var category = await _service.GetById(id);

            if (category == null)
            {
                return NotFound();
            }


            var dto = _mapper.Map<CategoryResponseDto>(category);

            return Ok(dto);
        }

        [HttpPost]
        public async Task<IActionResult> Post(CategoryRequestDto categoryRequestDto)
        {
            var category = _mapper.Map<Category>(categoryRequestDto);

            await _service.Create(category);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, CategoryRequestDto categoryRequestDto)
        {
            var category = _mapper.Map<Category>(categoryRequestDto);
            category.IdCategory = id;

            var result = await _service.Update(id, category);

            if (!result) return NotFound();
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
