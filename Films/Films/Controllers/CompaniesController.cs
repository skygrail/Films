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
    public class CompaniesController : ControllerBase
    {
        private readonly ICompaniesRepository _repository;

        public CompaniesController(ICompaniesRepository context) => _repository = context;


        // GET: api/Companies
        [HttpGet]
        public async Task<ActionResult<List<Companies>>> GetCompanies()
        {
            return await _repository.GetCompanies();
        }

        // GET: api/Companies/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Companies>> GetCompanies(int id)
        {
            var companies = await _repository.GetCompanies(id);

            if (companies == null)
            {
                return NotFound();
            }

            return companies;
        }

        // PUT: api/Companies/5
        [HttpPut("{id}")]
        public async Task<ActionResult<object>> PutCompanies(int id, Companies company)
        {
            var companyEx = await _repository.GetCompanies(id);
            if(companyEx == null)
            {
                return BadRequest();
            }
            return await _repository.UpdateCompanies(company);
        }

        // POST: api/Companies
        [HttpPost]
        public async Task<ActionResult<object>> PostCompanies(Companies companies)
        {
            return await _repository.AddCompanies(companies);  
        }

        // DELETE: api/Companies/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<object>> DeleteCompanies(int id)
        {
            var company = await _repository.GetCompanies(id);
            if (company == null)
            {
                return NotFound();
            }

            return await _repository.RemoveCompanies(company);
        }
    }
}
