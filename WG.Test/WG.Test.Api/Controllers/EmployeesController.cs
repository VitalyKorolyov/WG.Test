using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WG.Test.Api.Models;
using WG.Test.BLL.Services;

namespace WG.Test.Api.Controllers
{
    [Route("api/[controller]")]
    public class EmployeesController : Controller
    {
        private readonly IEmployeesService _employeeService;

        public EmployeesController(IEmployeesService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        public async Task<List<EmployeeViewModel>> Get()
        {
            var emp = await _employeeService.GetAsync();
            return new List<EmployeeViewModel>();
        }

        [HttpGet("{id}")]
        public string GetById(int id)
        {
            return "value";
        }

        [HttpPost]
        public void Create([FromBody]string value)
        {
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
