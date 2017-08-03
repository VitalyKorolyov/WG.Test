using System.Collections.Generic;
using System.Threading.Tasks;
using WG.Test.BusinessEntities.Entities;

namespace WG.Test.IBLL.Interfaces
{
    public interface IManagersService
    {
        Task<List<Manager>> GetAsync();
    }
}