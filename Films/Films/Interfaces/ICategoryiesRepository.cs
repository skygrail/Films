using Films.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Films.Interfaces
{
    public interface ICategoryiesRepository
    {
        Task<List<Categoryies>> GetCategoryies();

        Task<Categoryies> GetCategoryies(int id);

        Task<object> UpdateCategoryies(Categoryies categoryies);

        Task<object> AddCategoryies(Categoryies categoryies);

        Task<object> RemoveCategoryies(Categoryies categoryies);
    }
}
