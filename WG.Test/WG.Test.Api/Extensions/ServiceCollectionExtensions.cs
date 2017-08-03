using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WG.Test.Api.AutoMapper;
using WG.Test.BLL.Services;
using WG.Test.BusinessEntities;
using WG.Test.Data.Repositories;
using WG.Test.IBLL.Interfaces;
using WG.Test.IData.Interfaces;

namespace WG.Test.Api.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void ConfigureDb(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(connectionString, b => b.MigrationsAssembly("WG.Test.Data")));
        }

        public static void ConfigureDi(this IServiceCollection services)
        {
            var config = new MapperConfiguration(cfg => { cfg.AddProfile(new AutoMapperProfileConfiguration()); });
            var mapper = config.CreateMapper();

            services.AddSingleton(mapper);
            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<IManagerService, ManagerService>();
            services.AddScoped<IManagerRepository, ManagerRepository>();
        }
    }
}
