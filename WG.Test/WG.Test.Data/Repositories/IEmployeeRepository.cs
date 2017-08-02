using System.Collections.Generic;
using System.Threading.Tasks;
using WG.Test.Data.Entities;

namespace WG.Test.Data.Repositories
{
    public interface IEmployeesRepository
    {
        Task<List<Employee>> GetAsync();
    }
}
