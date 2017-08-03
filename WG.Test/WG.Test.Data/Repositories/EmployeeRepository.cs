using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WG.Test.BusinessEntities;
using WG.Test.BusinessEntities.Entities;
using WG.Test.IData.Interfaces;

namespace WG.Test.Data.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationContext _dbContext;

        public EmployeeRepository(ApplicationContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<Employee>> GetAsync()
        {
            return await _dbContext.Employees.Include("Manager").ToListAsync();
        }

        public async Task<bool> CreateAsync(Employee employee)
        {
            await _dbContext.Employees.AddAsync(employee);
            var number = await _dbContext.SaveChangesAsync();

            return number != 0;
        }

        public async Task<bool> UpdateAsync(Employee employee)
        {
            _dbContext.Entry(employee).State = EntityState.Modified;
            var number = await _dbContext.SaveChangesAsync();

            return number != 0;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var employee = new Employee { Id = id };
            _dbContext.Entry(employee).State = EntityState.Deleted;

            var number = await _dbContext.SaveChangesAsync();

            return number != 0;
        }
    }
}
