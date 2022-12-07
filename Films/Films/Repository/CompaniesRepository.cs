using Films.Interfaces;
using Films.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Security.Claims;

namespace Films.Repository
{
    public class CompaniesRepository : ICompaniesRepository
    {
        private readonly FilmsDbContext _context;

        public async Task<object> AddCompanies(Companies companies)
        {
            _context.Companies.Add(companies);
            await _context.SaveChangesAsync();
            var response = new
            {
                succes = true,
                message = "Company added!"
            };
            return response;
        }

        public async Task<List<Companies>> GetCompanies()
        {
            return await _context.Companies.ToListAsync();
        }

        public async Task<Companies> GetCompanies(int id) => await _context.Companies.AsNoTracking()
                .SingleOrDefaultAsync(x => x.ID == id);

        public async Task<object> RemoveCompanies(Companies companies)
        {
            _context.Companies.Remove(companies);
            await _context.SaveChangesAsync();
            var response = new
            {
                succes = true,
                message = "Company deleted!"
            };
            return response;
        }

        public async Task<object> UpdateCompanies(Companies companies)
        {
            _context.Companies.Update(companies);
            await _context.SaveChangesAsync();
            var response = new
            {
                succes = true,
                message = "Company updated!"
            };
            return response;
        }
    }
}
