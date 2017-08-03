using System.Collections.Generic;
using System.Threading.Tasks;
using WG.Test.BusinessEntities.Entities;

namespace WG.Test.IBLL.Interfaces
{
    public interface IEmployeeService
    {
        Task<List<Employee>> GetAsync();
        Task<bool> CreateAsync(Employee employee);
        Task<bool> UpdateAsync(Employee employee);
        Task<bool> DeleteAsync(int id);
    }
}
