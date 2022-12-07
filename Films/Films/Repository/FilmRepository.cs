using Films.Interfaces;
using Films.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Films.Repository
{
    public class FilmRepository : IFilmRepository
    {
        private readonly FilmsDbContext _context;

        public async Task<object> AddFilm(Film film)
        {
            _context.Film.Add(film);
            await _context.SaveChangesAsync();
            var response = new
            {
                succes = true,
                message = "Film added!"
            };
            return response;
        }

        public async Task<List<Film>> GetFilm()
        {
            return await _context.Film.ToListAsync();
        }

        public async Task<Film> GetFilm(int id) => await _context.Film.AsNoTracking()
                .SingleOrDefaultAsync(x => x.ID == id);

        public async Task<object> RemoveFilm(Film film)
        {
            _context.Film.Remove(film);
            await _context.SaveChangesAsync();
            var response = new
            {
                succes = true,
                message = "Film deleted!"
            };
            return response;
        }

        public async Task<object> UpdateFilm(Film film)
        {
            _context.Film.Update(film);
            await _context.SaveChangesAsync();
            var response = new
            {
                succes = true,
                message = "Film updated!"
            };
            return response;
        }
    }
}
