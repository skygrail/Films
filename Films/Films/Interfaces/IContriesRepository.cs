using Films.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Films.Interfaces
{
    public interface IContriesRepository
    {
        Task<List<Contries>> GetContries();

        Task<Contries> GetContries(int id);

        Task<object> UpdateContries(Contries contries);

        Task<object> AddContries(Contries companies);

        Task<object> RemoveContries(Contries companies);
    }
}
