using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace WG.Test.Data
{
    class DbContextFactory :IDbContextFactory<ApplicationContext>
    {
        public ApplicationContext Create(DbContextFactoryOptions options)
        {
            var builder = new DbContextOptionsBuilder<ApplicationContext>();
            builder.UseSqlServer("Data Source=DESKTOP-62OCN16\\KOROLEV;Initial Catalog=WG;Integrated Security=True;MultipleActiveResultSets=true");

            return new ApplicationContext(builder.Options);
        }
    }
}
