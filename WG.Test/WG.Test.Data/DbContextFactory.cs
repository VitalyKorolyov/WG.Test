using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;
using WG.Test.BusinessEntities;

namespace WG.Test.Data
{
    public class DbContextFactory : IDbContextFactory<ApplicationContext>
    {
        public ApplicationContext Create(DbContextFactoryOptions options)
        {
            var configurator = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", false, true)
                .AddEnvironmentVariables();

            var configuration = configurator.Build();
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            var builder = new DbContextOptionsBuilder<ApplicationContext>();
            builder.UseSqlServer(connectionString, x => x.MigrationsAssembly("WG.Test.BusinessEntities"));

            return new ApplicationContext(builder.Options);
        }
    }
}
