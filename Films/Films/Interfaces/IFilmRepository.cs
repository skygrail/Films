using Films.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Films.Interfaces
{
    public interface IFilmRepository
    {
        Task<List<Film>> GetFilm();

        Task<Film> GetFilm(int id);

        Task<object> UpdateFilm(Film film);

        Task<object> AddFilm(Film film);

        Task<object> RemoveFilm(Film film);
    }
}
