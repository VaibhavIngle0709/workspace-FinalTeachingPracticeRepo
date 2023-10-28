using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
namespace ProdMVC.Models;
public class DemoDatabaseContext: DbContext
{
    public virtual DbSet<Product> Product {get;set;}
    public DemoDatabaseContext()
    {
    }
    public DemoDatabaseContext(DbContextOptions<DemoDatabaseContext> options):base(options)
    {

    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if(!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("User ID=sa;password=examlyMssql@123; server=localhost;Database=DemoDatabase;trusted_connection=false;Persist Security Info=False;Encrypt=False");
        }

    }
}