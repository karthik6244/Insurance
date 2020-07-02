using Insurance.Application.Interfaces;
using Insurance.Domain.Banks;
using Insurance.Persistance.Banks;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Insurance.Persistance
{
    public class DatabaseService : DbContext, IDatabaseService
    {
        public DbSet<Bank> Bank { get; set; }
        public DatabaseService()
        {

        }
        public DatabaseService(DbContextOptions<DatabaseService> options) : base(options)
        {
            
        }

        public void Save()
        {
            this.SaveChanges();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new BankConfiguration(modelBuilder.Entity<Bank>());
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=tcp:homeloans.database.windows.net,1433;Initial Catalog=mortgage;Persist Security Info=False;User ID=skunapuli;Password=Pavan@48;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
            base.OnConfiguring(optionsBuilder);
        }
    }
}
