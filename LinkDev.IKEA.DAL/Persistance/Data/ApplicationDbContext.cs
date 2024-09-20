using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using LinkDev.IKEA.DAL.Models.Department;
using Microsoft.EntityFrameworkCore;

namespace LinkDev.IKEA.DAL.Persistance.Data
{
    internal class ApplicationDbContext : DbContext
    {
        //public ApplicationDbContext() : base()
        //{
        //}
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {


            optionsBuilder.UseSqlServer("Server = .; Databasse = IKEA_G03; Trusted_");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());


        }

        public DbSet<Department> Department { get; set; }   


    }
}
