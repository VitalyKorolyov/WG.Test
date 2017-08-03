using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using WG.Test.BusinessEntities.Entities;
using WG.Test.IBLL.Interfaces;
using WG.Test.IData.Interfaces;

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

        public async Task<List<Employee>> GetAsync()
        {
            var employees = await _employeeRepository.GetAsync();

            return _mapper.Map<List<Employee>>(employees);
        }
    }
}
