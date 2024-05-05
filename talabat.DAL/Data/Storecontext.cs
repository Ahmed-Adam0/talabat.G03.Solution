using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using talabat.DAL.Entities;

namespace talabat.DAL.Data
{
    public  class Storecontext:DbContext
    {
        public Storecontext(DbContextOptions<Storecontext> options):base(options) 
        {
        }
        public DbSet<product> products { get; set; }

        public DbSet<producttype> producttypes { get; set; }    
        public DbSet<productBrand> productBrand { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           //  modelBuilder.Entity<product>().Ignore(p => p.name);

            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly()); 
        }
    }
}
