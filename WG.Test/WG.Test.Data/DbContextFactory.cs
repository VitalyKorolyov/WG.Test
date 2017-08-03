using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;

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

            var builder = new DbContextOptionsBuilder<ApplicationContext>();
            builder.UseSqlServer(
                "Data Source=DESKTOP-62OCN16\\KOROLEV;Initial Catalog=WG;Integrated Security=True;MultipleActiveResultSets=true");

            return new ApplicationContext(builder.Options);
        }
    }
}
