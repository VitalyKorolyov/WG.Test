using System.Collections.Generic;
using System.Threading.Tasks;
using WG.Test.BLL.Models;
using WG.Test.Data.Repositories;

namespace WG.Test.BLL.Services
{
    public class EmployeesService :IEmployeesService
    {
        private readonly IEmployeesRepository _employeeRepository;

        public EmployeesService(IEmployeesRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<List<EmployeeModel>> GetAsync()
        {
            var employees = await _employeeRepository.GetAsync();

            return new List<EmployeeModel>();
        }
    }
}
