using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WG.Test.Api.Models;
using WG.Test.BLL.Services;
using WG.Test.IBLL.Interfaces;

namespace WG.Test.Api.Controllers
{
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
