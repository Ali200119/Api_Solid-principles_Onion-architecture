using System;
using System.Reflection;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Repository.Data
{
	public class AppDbContext: DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> option):base(option) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());



            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = 1,
                    FullName = "Ali Talibov",
                    Address = "Xetai",
                    Age = 21
                },

                new Employee
                {
                    Id = 2,
                    FullName = "Roya Meherremova",
                    Address = "Xetai",
                    Age = 27
                },

                new Employee
                {
                    Id = 3,
                    FullName = "Cavid Bashirov",
                    Address = "Elekber",
                    Age = 29
                }
            );

            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "Azerbaijan"
                },

                new Country
                {
                    Id = 2,
                    Name = "Turkey"
                },

                new Country
                {
                    Id = 3,
                    Name = "USA"
                }
            );
        }
    }
}