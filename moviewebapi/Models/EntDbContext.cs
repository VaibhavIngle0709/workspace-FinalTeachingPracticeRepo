using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using moviewebapi.ViewModel;

namespace moviewebapi.Models
{
    public class EntDbContext: DbContext
    {
        virtual public DbSet<Detail> Details{get;set;}
        virtual public  DbSet<Movie> Movies{get;set;}
        virtual public DbSet<Movie_VM> Movie_VMs{get;set;}
        public EntDbContext(){}
        public EntDbContext(DbContextOptions<EntDbContext> options):base(options){}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("User ID=sa;password=examlyMssql@123; server=localhost;Database=EntDb;trusted_connection=false;Persist Security Info=False;Encrypt=False;");
            }
        }
    }
}