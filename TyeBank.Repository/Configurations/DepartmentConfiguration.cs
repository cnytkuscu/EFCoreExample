using Microsoft.EntityFrameworkCore;
using TyeBank.Core.Entities;

namespace TyeBank.Repository.Configurations
{
    internal class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Department> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasColumnType("nvarchar").HasMaxLength(50);
            builder.Property(x => x.Description).HasColumnType("nvarchar").HasMaxLength(250);
             
            builder.ToTable("Department");
        }
    }
}
