using AutoMapper;
using WG.Test.Api.Models;
using WG.Test.BusinessEntities.Entities;

namespace WG.Test.Api.AutoMapper
{
    public class AutoMapperProfileConfiguration : Profile
    {
        public AutoMapperProfileConfiguration() :this("WG.Test")
        {
        }

        protected AutoMapperProfileConfiguration(string profileName) :base(profileName)
        {
            CreateMap<Employee, EmployeeModel>();
            CreateMap<Manager, ManagerModel>();
            CreateMap<ManagerModel, Manager>();
            CreateMap<EmployeeModel, Employee>();
        }
    }
}
