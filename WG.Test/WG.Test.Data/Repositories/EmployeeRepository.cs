using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WG.Test.Data.Entities;

namespace WG.Test.Data.Repositories
{
    public class EmployeesRepository : IEmployeesRepository
    {
        private readonly ApplicationContext _dbContext;

        public EmployeesRepository(ApplicationContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<Employee>> GetAsync()
        {
            return await _dbContext.Employees.Include("Manager").ToListAsync();
        }
    }
}
