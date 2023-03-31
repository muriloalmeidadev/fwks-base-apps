using Fwks.FwksApp.Core.Entities;
using Fwks.Postgres.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fwks.FwksApp.Infra.Postgres.Configuration;

public sealed class CustomerConfiguration : EntityTypeConfiguration<Customer, int>
{
    public override void Configure(EntityTypeBuilder<Customer> builder)
    {
        base.Configure(builder);

        builder
            .ToTable("Customers", "App");
    }
}