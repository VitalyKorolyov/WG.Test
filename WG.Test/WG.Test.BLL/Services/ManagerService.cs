using System.Collections.Generic;
using System.Threading.Tasks;
using WG.Test.BusinessEntities.Entities;
using WG.Test.IBLL.Interfaces;
using WG.Test.IData.Interfaces;

namespace WG.Test.BLL.Services
{
    public class ManagerService :IManagerService
    {
        private readonly IManagerRepository _managerRepository;

        public ManagerService(IManagerRepository managerRepository)
        {
            _managerRepository = managerRepository;
        }

        public async Task<List<Manager>> GetAsync()
        {
            return await _managerRepository.GetAsync();
        }

        public async Task<bool> CreateAsync(Manager manager)
        {
            return await _managerRepository.CreateAsync(manager);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            return await _managerRepository.DeleteAsync(id);
        }
    }
}
