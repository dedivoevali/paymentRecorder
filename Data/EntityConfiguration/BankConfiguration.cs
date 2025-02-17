﻿using Common.Validation.Constraints;
using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.EntityConfiguration;

public class BankConfiguration : IEntityTypeConfiguration<Bank>
{
    public void Configure(EntityTypeBuilder<Bank> builder)
    {
        builder.ToTable(nameof(Bank));

        builder.HasKey(e => e.Id);

        builder.HasIndex(e => e.Code)
            .IsUnique();

        builder.Property(e => e.Version)
            .IsConcurrencyToken()
            .HasDefaultValueSql(UtilSqlCommands.SqlServerNewGuidCommand);


        builder.Property(e => e.Code)
            .HasMaxLength(BankValidationConstraints.BankCodeLengthFixed)
            .IsFixedLength();

        builder.Property(e => e.Name)
            .HasMaxLength(CommonValidationConstraints.NameMaxLength);

        builder.HasMany(e => e.Accounts)
            .WithOne(e => e.Bank)
            .OnDelete(DeleteBehavior.NoAction);
    }
}