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

        public async Task<bool> CreateAsync(Manager manager)
        {
            await _dbContext.Managers.AddAsync(manager);
            var number = await _dbContext.SaveChangesAsync();

            return number != 0;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var manager = new Manager { Id = id };
            _dbContext.Entry(manager).State = EntityState.Deleted;

            var number = await _dbContext.SaveChangesAsync();

            return number != 0;
        }
    }
}
