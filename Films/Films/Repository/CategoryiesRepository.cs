using Films.Interfaces;
using Films.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Films.Repository
{
    public class CategoryiesRepository : ICategoryiesRepository
    {
        private readonly FilmsDbContext _context;

        public async Task<object> AddCategoryies(Categoryies categoryies)
        {
            _context.Categoryies.Add(categoryies);
            await _context.SaveChangesAsync();
            var response = new
            {
                succes = true,
                message = "Category added!"
            };
            return response;
        }

        public async Task<List<Categoryies>> GetCategoryies()
        {
            return await _context.Categoryies.ToListAsync();
        }

        public async Task<Categoryies> GetCategoryies(int id) => await _context.Categoryies.AsNoTracking()
                .SingleOrDefaultAsync(x => x.ID == id);

        public async Task<object> RemoveCategoryies(Categoryies categoryies)
        {
            _context.Categoryies.Remove(categoryies);
            await _context.SaveChangesAsync();
            var response = new
            {
                succes = true,
                message = "Category deleted!"
            };
            return response;
        }

        public async Task<object> UpdateCategoryies(Categoryies categoryies)
        {
            _context.Categoryies.Update(categoryies);
            await _context.SaveChangesAsync();
            var response = new
            {
                succes = true,
                message = "Category updated!"
            };
            return response;
        }
    }
}
