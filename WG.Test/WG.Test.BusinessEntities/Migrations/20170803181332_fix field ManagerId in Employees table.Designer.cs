using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using WG.Test.BusinessEntities;

namespace WG.Test.BusinessEntities.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20170803181332_fix field ManagerId in Employees table")]
    partial class fixfieldManagerIdinEmployeestable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WG.Test.BusinessEntities.Entities.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Department");

                    b.Property<string>("FirstName");

                    b.Property<int?>("ManagerId");

                    b.Property<string>("MiddleName");

                    b.Property<string>("Position");

                    b.Property<string>("Surname");

                    b.HasKey("Id");

                    b.HasIndex("ManagerId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("WG.Test.BusinessEntities.Entities.Manager", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FirstName");

                    b.Property<string>("MiddleName");

                    b.Property<string>("Surname");

                    b.HasKey("Id");

                    b.ToTable("Managers");
                });

            modelBuilder.Entity("WG.Test.BusinessEntities.Entities.Employee", b =>
                {
                    b.HasOne("WG.Test.BusinessEntities.Entities.Manager", "Manager")
                        .WithMany("Employees")
                        .HasForeignKey("ManagerId");
                });
        }
    }
}
