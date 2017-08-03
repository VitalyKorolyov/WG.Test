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
        private readonly IEmployeesService _employeesService;

        public EmployeesController(IEmployeesService employeesService, IMapper mapper)
        {
            _employeesService = employeesService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<List<EmployeeViewModel>> Get()
        {
            var employees = await _employeesService.GetAsync();

            return _mapper.Map<List<EmployeeViewModel>>(employees);
        }

        [HttpGet("{id}")]
        public string GetById(int id)
        {
            return "value";
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create([FromBody]EmployeeViewModel model)
        {
            var employee = _mapper.Map<Employee>(model);

            var isSuccess = await _employeesService.CreateAsync(employee);
            if (isSuccess)
            {
                return new OkResult();
            }

            return new BadRequestResult();
        }

        [HttpPost("{id}")]
        public void Update(int id, [FromBody]string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
