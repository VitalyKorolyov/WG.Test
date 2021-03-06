﻿using System.Collections.Generic;
using System.Threading.Tasks;
using WG.Test.BusinessEntities.Entities;

namespace WG.Test.IData.Interfaces
{
    public interface IManagerRepository
    {
        Task<List<Manager>> GetAsync();
        Task<bool> CreateAsync(Manager manager);
        Task<bool> DeleteAsync(int id);
    }
}
