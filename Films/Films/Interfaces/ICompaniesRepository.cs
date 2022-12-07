using Films.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Films.Interfaces
{
    public interface ICompaniesRepository
    {
        Task<List<Companies>> GetCompanies();

        Task<Companies> GetCompanies(int id);

        Task<object> UpdateCompanies(Companies companies);

        Task<object> AddCompanies(Companies companies);

        Task<object> RemoveCompanies(Companies companies);
    }
}
