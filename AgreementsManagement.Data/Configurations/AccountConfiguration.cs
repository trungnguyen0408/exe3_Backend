using AgreementsManagement.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgreementsManagement.Data.Configurations
{
    public class AccountConfiguration : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.ToTable("Account");
            builder.HasKey(account => account.userName);
            builder.Property(account => account.fullName).IsRequired();
            builder.Property(account => account.email).IsRequired();
            builder.Property(account => account.password).IsRequired();
        }
    }
}
