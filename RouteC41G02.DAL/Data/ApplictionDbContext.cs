using Microsoft.EntityFrameworkCore;
using RouteC41G02.DAL.Data.Configuration;
using RouteC41G02.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RouteC41G02.DAL.Data
{
    internal class ApplictionDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        
            
            =>optionsBuilder.UseSqlServer("Server=.;Database =MVCApplictionG02;Trusted_Connection=True;MultipleActiveResultsets=False");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration<Department>(new DepartmentConfiguration());

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        }


        public DbSet<Department>Departments { get; set; }




    }

}
