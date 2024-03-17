using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TyeBank.Core.Entites;
using TyeBank.Core.Entities;

namespace TyeBank.Repository.Configurations
{
    internal class SalaryConfiguration : IEntityTypeConfiguration<Salary>
    {
        public void Configure(EntityTypeBuilder<Salary> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Employee).WithOne(x => x.Salary).HasForeignKey<Salary>(x => x.EmployeeId);
            builder.Property(x => x.Amount).HasColumnType("decimal(8,2)");
            builder.Property(x => x.IsActive).HasColumnType("bit");
            builder.Property(x => x.Currency).HasColumnType("nvarchar").HasMaxLength(3);
             
            builder.ToTable("Salary");
        }
    }
}
