using Microsoft.EntityFrameworkCore;
 
using TyeBank.Core.Entities;


namespace TyeBank.Repository.Configurations
{
    internal class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.FirstName).HasColumnType("nvarchar").HasMaxLength(50).IsRequired();
            builder.Property(x => x.LastName).HasColumnType("nvarchar").HasMaxLength(50).IsRequired();
            builder.Property(x => x.Email).HasColumnType("nvarchar").HasMaxLength(50).IsRequired();
            builder.Property(x => x.PhoneNumber).HasColumnType("nvarchar").HasMaxLength(50).IsRequired();

            builder.HasOne(x => x.Address).WithOne(x => x.Employee).HasForeignKey<Employee>(x => x.AddressId);
            builder.HasOne(x => x.Position).WithMany(x => x.Employees).HasForeignKey(x => x.PositionId);
            builder.HasOne(x => x.Department).WithMany(x => x.Employees).HasForeignKey(x => x.DepartmentId); 

            builder.Property(x => x.IsActive).HasColumnType("bit");

            builder.ToTable("Employee"); 
        }
    }
}
