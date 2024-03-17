using Microsoft.EntityFrameworkCore;
using TyeBank.Core.Entities;

namespace TyeBank.Repository.Configurations
{
    internal class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Address> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Country).HasColumnType("nvarchar").HasMaxLength(50);
            builder.Property(x => x.City).HasColumnType("nvarchar").HasMaxLength(50);
            builder.Property(x => x.District).HasColumnType("nvarchar").HasMaxLength(50);
            builder.Property(x => x.NeighborHood).HasColumnType("nvarchar").HasMaxLength(50);
            builder.Property(x => x.Street).HasColumnType("nvarchar").HasMaxLength(250);
            builder.Property(x => x.PostalCode).HasColumnType("nvarchar").HasMaxLength(50);
            builder.ToTable("Address");
        }
    }
}
