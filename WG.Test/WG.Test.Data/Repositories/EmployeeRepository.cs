﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WG.Test.BusinessEntities;
using WG.Test.BusinessEntities.Entities;
using WG.Test.IData.Interfaces;

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

        public async Task<bool> CreateAsync(Employee employee)
        {
            await _dbContext.Employees.AddAsync(employee);
            var number = await _dbContext.SaveChangesAsync();

            return number != 0;
        }
    }
}
