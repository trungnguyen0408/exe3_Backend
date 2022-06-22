using AgreementsManagement.Data.Configurations;
using AgreementsManagement.Data.Extensions;
using AgreementsManagement.DTO.Entities;
using AgreementsManagement.Model.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgreementsManagement.Data.EF
{
    public class AgreementsManagementDbContext:DbContext
    {
        public AgreementsManagementDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        #region database
        public DbSet<Agreement> Agreements { set; get; }
        public DbSet<Account> Accounts { set; get; }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //configure using fluent API
            modelBuilder.ApplyConfiguration(new AgreementConfiguration());
            modelBuilder.ApplyConfiguration(new AccountConfiguration());
            //Data seeding
            modelBuilder.Seed();
            base.OnModelCreating(modelBuilder);
        }
    }
}
