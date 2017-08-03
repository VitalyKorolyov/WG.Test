using System.Collections.Generic;
using System.Threading.Tasks;
using WG.Test.BusinessEntities.Entities;
using WG.Test.IBLL.Interfaces;
using WG.Test.IData.Interfaces;

namespace WG.Test.BLL.Services
{
    public class ManagersService :IManagersService
    {
        private readonly IManagersRepository _managersRepository;

        public ManagersService(IManagersRepository managersRepository)
        {
            _managersRepository = managersRepository;
        }

        public async Task<List<Manager>> GetAsync()
        {
            return await _managersRepository.GetAsync();
        }

        public async Task<bool> CreateAsync(Manager manager)
        {
            return await _managersRepository.CreateAsync(manager);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            return await _managersRepository.DeleteAsync(id);
        }
    }
}
