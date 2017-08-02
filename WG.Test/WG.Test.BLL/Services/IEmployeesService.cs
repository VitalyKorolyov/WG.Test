using System.Collections.Generic;
using System.Threading.Tasks;
using WG.Test.BLL.Models;

namespace WG.Test.BLL.Services
{
    public interface IEmployeesService
    {
        Task<List<EmployeeModel>> GetAsync();
    }
}
