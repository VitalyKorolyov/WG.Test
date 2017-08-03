using System.Collections.Generic;
using System.Threading.Tasks;
using WG.Test.BusinessEntities.Entities;

namespace WG.Test.IData.Interfaces
{
    public interface IEmployeeRepository
    {
        Task<List<Employee>> GetAsync();
        Task<bool> CreateAsync(Employee employee);
        Task<bool> DeleteAsync(int id);
    }
}
