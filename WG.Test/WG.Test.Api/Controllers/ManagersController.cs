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
    public class ManagersController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IManagerService _managerService;

        public ManagersController(IMapper mapper, IManagerService managerService)
        {
            _mapper = mapper;
            _managerService = managerService;
        }

        [HttpGet]
        public async Task<List<ManagerModel>> Get()
        {
            var managers = await _managerService.GetAsync();
            return _mapper.Map<List<ManagerModel>>(managers);
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create([FromBody]ManagerModel model)
        {
            var manager = _mapper.Map<Manager>(model);

            var isSuccess = await _managerService.CreateAsync(manager);
            if(isSuccess)
            {
                return new OkResult();
            }

            return new BadRequestResult();
        }

        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var isSuccess = await _managerService.DeleteAsync(id);
            if (isSuccess)
            {
                return new OkResult();
            }

            return new BadRequestResult();
        }
    }
}
