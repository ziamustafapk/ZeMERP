using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ZeMERP.Models;

namespace ZeMERP.Data.Configuration
{
    public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.ToTable("STP_DEPARTMENT");

            // Base Model Configuration Start

            builder.HasKey(bm => bm.DepartmentId);
            builder.Property(bm => bm.Code)
                .HasMaxLength(10)
                .IsRequired();
            builder.Property(bm => bm.Name)
                .HasMaxLength(100)
                .IsRequired();
            builder.Property(bm => bm.Description)
                .HasMaxLength(200);
           
            // Base Model Configuration End


        }
    }
}