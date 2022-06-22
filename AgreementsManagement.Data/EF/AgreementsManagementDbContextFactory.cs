using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgreementsManagement.Data.EF
{
    public class AgreementsManagementDbContextFactory : IDesignTimeDbContextFactory<AgreementsManagementDbContext>
    {
        public AgreementsManagementDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json")
               .Build();

            var connectionString = configuration.GetConnectionString("AgreementsManagementDb");

            var optionsBuilder = new DbContextOptionsBuilder<AgreementsManagementDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new AgreementsManagementDbContext(optionsBuilder.Options);
        }
    }
}
