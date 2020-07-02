using Insurance.Domain.Banks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Insurance.Persistance.Banks
{
    public class BankConfiguration
    {
        public BankConfiguration(EntityTypeBuilder<Bank> entityTypeBuilder)
        {
            entityTypeBuilder.Property(e => e.Bankname).HasMaxLength(510);
        }
    }
}
