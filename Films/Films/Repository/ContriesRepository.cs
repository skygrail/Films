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
    public class ContriesRepository : IContriesRepository
    {
        private readonly FilmsDbContext _context;

        public async Task<object> AddContries(Contries contries)
        {
            _context.Contries.Add(contries);
            await _context.SaveChangesAsync();
            var response = new
            {
                succes = true,
                message = "Contry added!"
            };
            return response;
        }

        public async Task<List<Contries>> GetContries()
        {
            return await _context.Contries.ToListAsync();
        }

        public async Task<Contries> GetContries(int id) => await _context.Contries.AsNoTracking()
                .SingleOrDefaultAsync(x => x.ID == id);

        public async Task<object> RemoveContries(Contries contries)
        {
            _context.Contries.Remove(contries);
            await _context.SaveChangesAsync();
            var response = new
            {
                succes = true,
                message = "Contry deleted!"
            };
            return response;
        }

        public async Task<object> UpdateContries(Contries contries)
        {
            _context.Contries.Update(contries);
            await _context.SaveChangesAsync();
            var response = new
            {
                succes = true,
                message = "Contry updated!"
            };
            return response;
        }
    }
}
