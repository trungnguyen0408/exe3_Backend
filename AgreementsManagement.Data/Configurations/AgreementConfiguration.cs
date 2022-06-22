using AgreementsManagement.DTO.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgreementsManagement.Data.Configurations
{
    public class AgreementConfiguration : IEntityTypeConfiguration<Agreement>
    {
        public void Configure(EntityTypeBuilder<Agreement> builder)
        {
            builder.ToTable("Agreements");
            builder.HasKey(agreement => agreement.Id);
            builder.Property(agreement => agreement.Status).IsRequired();
            builder.Property(agreement => agreement.QuoteNumber).IsRequired();
            builder.Property(agreement => agreement.AgreementName).IsRequired();
            builder.Property(agreement => agreement.AgreementType).IsRequired();
            builder.Property(agreement => agreement.DistributorName).IsRequired();
            builder.Property(agreement => agreement.EffectiveDate).IsRequired().HasDefaultValue(DateTime.Now);
            builder.Property(agreement => agreement.ExpirationDate).IsRequired();
            builder.Property(agreement => agreement.CreatedDate).IsRequired().HasDefaultValue(DateTime.Now);
        }
    }
}
