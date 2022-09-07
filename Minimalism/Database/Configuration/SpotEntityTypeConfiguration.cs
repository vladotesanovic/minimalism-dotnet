using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Minimalism.Domain.Entities;

namespace Minimalism.Database.Configuration;

public class SpotEntityTypeConfiguration : IEntityTypeConfiguration<Spot>
{
    public void Configure(EntityTypeBuilder<Spot> orderConfiguration)
    {
        orderConfiguration.ToTable("Spots");
        orderConfiguration.HasKey(o => o.Id);
        
        orderConfiguration.OwnsOne(s => s.Electrified);

    }
}