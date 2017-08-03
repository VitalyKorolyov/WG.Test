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

        [HttpPost("create")]
        public async Task<IActionResult> Create([FromBody]ManagerViewModel model)
        {
            var manager = _mapper.Map<Manager>(model);

            var isSuccess = await _managersService.CreateAsync(manager);
            if(isSuccess)
            {
                return new OkResult();
            }

            return new BadRequestResult();
        }

        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var isSuccess = await _managersService.DeleteAsync(id);
            if (isSuccess)
            {
                return new OkResult();
            }

            return new BadRequestResult();
        }
    }
}
