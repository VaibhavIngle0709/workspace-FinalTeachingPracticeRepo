using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace EMS_CodeFirst.Models
{
    public class EmsDbContext:DbContext
    {
        public virtual DbSet<Dept> Depts{get;set;}
        public virtual DbSet<Employee> Employees{get;set;}

        public EmsDbContext(){}

        public EmsDbContext(DbContextOptions<EmsDbContext> options):base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {   
                optionsBuilder.UseSqlServer("User ID=sa;password=examlyMssql@123; server=localhost;Database=EmsDb;trusted_connection=false;Persist Security Info=False;Encrypt=False;");
            }
        }

    }
}