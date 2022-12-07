using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Films.Models;
using Films.Interfaces;

namespace Films.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryiesController : ControllerBase
    {
        private readonly ICategoryiesRepository _repository;

        public CategoryiesController(ICategoryiesRepository context) => _repository = context;

        // GET: api/Categoryies
        [HttpGet]
        public async Task<ActionResult<List<Categoryies>>> GetCategoryies()
        {
            return await _repository.GetCategoryies();
        }

        // GET: api/Categoryies/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Categoryies>> GetCategoryies(int id)
        {
            var categoryies = await _repository.GetCategoryies(id);

            if (categoryies == null)
            {
                return NotFound();
            }

            return categoryies;
        }

        // PUT: api/Categoryies/5
        [HttpPut("{id}")]
        public async Task<ActionResult<object>> PutCategoryies(int id, Categoryies categoryies)
        {
            var categoryiesEx = await _repository.GetCategoryies(id);
            if (categoryiesEx == null)
            {
                return BadRequest();
            }
            return await _repository.UpdateCategoryies(categoryies);
        }

        // POST: api/Categoryies
        [HttpPost]
        public async Task<ActionResult<object>> PostCategoryies(Categoryies categoryies)
        {
            return await _repository.AddCategoryies(categoryies);
        }

        // DELETE: api/Categoryies/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<object>> DeleteCategoryies(int id)
        {
            var contries = await _repository.GetCategoryies(id);
            if (contries == null)
            {
                return NotFound();
            }

            return await _repository.RemoveCategoryies(contries);
        }
    }
}
