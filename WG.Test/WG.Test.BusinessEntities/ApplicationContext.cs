using Microsoft.EntityFrameworkCore;
using WG.Test.BusinessEntities.Entities;

namespace WG.Test.BusinessEntities
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Manager> Managers { get; set; }


        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .HasOne(p => p.Manager)
                .WithMany(t => t.Employees)
                .HasForeignKey(p => p.ManagerId).IsRequired(false);
        }
    }
}
