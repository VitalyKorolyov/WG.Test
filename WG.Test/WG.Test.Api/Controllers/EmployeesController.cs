using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using WG.Test.Api.Models;
using WG.Test.BusinessEntities.Entities;
using WG.Test.IBLL.Interfaces;

namespace WG.Test.Api.Controllers
{
    [EnableCors("CorsPolicy")]
    [Route("api/[controller]")]
    public class EmployeesController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IEmployeeService _employeeService;

        public EmployeesController(IEmployeeService employeeService, IMapper mapper)
        {
            _employeeService = employeeService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<List<EmployeeViewModel>> Get()
        {
            var employees = await _employeeService.GetAsync();

            return _mapper.Map<List<EmployeeViewModel>>(employees);
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create([FromBody]EmployeeViewModel model)
        {
            var employee = _mapper.Map<Employee>(model);

            var isSuccess = await _employeeService.CreateAsync(employee);
            if (isSuccess)
            {
                return new OkResult();
            }

            return new BadRequestResult();
        }

        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var isSuccess = await _employeeService.DeleteAsync(id);
            if (isSuccess)
            {
                return new OkResult();
            }

            return new BadRequestResult();
        }
    }
}
