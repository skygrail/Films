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
    public class ContriesController : ControllerBase
    {
        private readonly IContriesRepository _repository;

        public ContriesController(IContriesRepository context) => _repository = context;

        // GET: api/Contries
        [HttpGet]
        public async Task<ActionResult<List<Contries>>> GetContries()
        {
            return await _repository.GetContries();
        }

        // GET: api/Contries/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Contries>> GetContries(int id)
        {
            var contries = await _repository.GetContries(id);

            if (contries == null)
            {
                return NotFound();
            }

            return contries;
        }

        // PUT: api/Contries/5
        [HttpPut("{id}")]
        public async Task<ActionResult<object>> PutContries(int id, Contries contry)
        {
            var contriesEx = await _repository.GetContries(id);
            if (contriesEx == null)
            {
                return BadRequest();
            }
            return await _repository.UpdateContries(contry);
        }

        // POST: api/Contries
        [HttpPost]
        public async Task<ActionResult<object>> PostContries(Contries contries)
        {
            return await _repository.AddContries(contries);
        }

        // DELETE: api/Contries/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<object>> DeleteContries(int id)
        {
            var contries = await _repository.GetContries(id);
            if (contries == null)
            {
                return NotFound();
            }

            return await _repository.RemoveContries(contries);
        }
    }
}
