using System.Collections.Generic;
using System.Threading.Tasks;
using WG.Test.BusinessEntities.Entities;
using WG.Test.IBLL.Interfaces;
using WG.Test.IData.Interfaces;

namespace WG.Test.BLL.Services
{
    public class EmployeesService :IEmployeesService
    {
        private readonly IEmployeesRepository _employeeRepository;

        public EmployeesService(IEmployeesRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<List<Employee>> GetAsync()
        {
            return await _employeeRepository.GetAsync();
        }

        public async Task<bool> CreateAsync(Employee employee)
        {
            return await _employeeRepository.CreateAsync(employee);
        }
    }
}
