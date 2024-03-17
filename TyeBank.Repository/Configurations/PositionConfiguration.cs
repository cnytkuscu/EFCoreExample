using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TyeBank.Core.Entities;

namespace TyeBank.Repository.Configurations
{
    internal class PositionConfiguration : IEntityTypeConfiguration<Position>
    {
        public void Configure(EntityTypeBuilder<Position> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Title).HasColumnType("nvarchar").HasMaxLength(50);
            builder.Property(x => x.Description).HasColumnType("nvarchar").HasMaxLength(500);

            builder.HasOne(x => x.Department).WithMany(x => x.Positions).HasForeignKey(x => x.DepartmentId);
 
            builder.ToTable("Position");
        }
    }
}
