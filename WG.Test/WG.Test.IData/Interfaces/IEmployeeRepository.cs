using System.Collections.Generic;
using System.Threading.Tasks;
using WG.Test.BusinessEntities.Entities;

namespace WG.Test.IData.Interfaces
{
    public interface IEmployeesRepository
    {
        Task<List<Employee>> GetAsync();
        Task<bool> CreateAsync(Employee employee);
    }
}
