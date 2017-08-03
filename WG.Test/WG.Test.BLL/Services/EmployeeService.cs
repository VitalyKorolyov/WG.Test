using System.Collections.Generic;
using System.Threading.Tasks;
using WG.Test.BusinessEntities.Entities;
using WG.Test.IBLL.Interfaces;
using WG.Test.IData.Interfaces;

namespace WG.Test.BLL.Services
{
    public class EmployeeService :IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
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

        public async Task<bool> DeleteAsync(int id)
        {
            return await _employeeRepository.DeleteAsync(id);
        }
    }
}
