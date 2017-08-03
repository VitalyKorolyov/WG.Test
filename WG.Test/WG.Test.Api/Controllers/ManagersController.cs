using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using WG.Test.Api.Models;
using WG.Test.IBLL.Interfaces;

namespace WG.Test.Api.Controllers
{
    [EnableCors("CorsPolicy")]
    [Route("api/[controller]")]
    public class ManagersController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IManagersService _managersService;

        public ManagersController(IMapper mapper, IManagersService managersService)
        {
            _mapper = mapper;
            _managersService = managersService;
        }

        [HttpGet]
        public async Task<List<ManagerViewModel>> Get()
        {
            var managers = await _managersService.GetAsync();
            return _mapper.Map<List<ManagerViewModel>>(managers);
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
