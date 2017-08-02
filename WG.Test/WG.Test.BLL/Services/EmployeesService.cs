using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using WG.Test.BLL.Models;
using WG.Test.Data.Repositories;

namespace WG.Test.BLL.Services
{
    public class EmployeesService :IEmployeesService
    {
        private readonly IMapper _mapper;
        private readonly IEmployeesRepository _employeeRepository;

        public EmployeesService(IEmployeesRepository employeeRepository, IMapper mapper)
        {
            _employeeRepository = employeeRepository;
            _mapper = mapper;
        }

        public async Task<List<EmployeeModel>> GetAsync()
        {
            var employees = await _employeeRepository.GetAsync();

            return _mapper.Map<List<EmployeeModel>>(employees);
        }
    }
}
