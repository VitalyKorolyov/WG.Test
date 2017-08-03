using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WG.Test.BusinessEntities;
using WG.Test.BusinessEntities.Entities;
using WG.Test.IData.Interfaces;

namespace WG.Test.Data.Repositories
{
    public class ManagersRepository :IManagersRepository
    {
        private readonly ApplicationContext _dbContext;

        public ManagersRepository(ApplicationContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Manager>> GetAsync()
        {
            return await _dbContext.Managers.ToListAsync();
        }
    }
}
