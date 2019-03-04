using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ZeMERP.Models;

namespace ZeMERP.Data.Configuration
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("STP_EMPLOYEE");


            // Base Model Configuration Start

            builder.HasKey(bm => bm.EmployeeId);
            builder.Property(bm => bm.Code)
                .HasMaxLength(10)
                .IsRequired();
            builder.Property(bm => bm.Description)
                .HasMaxLength(100);
            builder.Property(bm => bm.CreatedBy)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(bm => bm.UpdatedBy)
                .HasMaxLength(100);
            builder.Property(bm => bm.CreatedDate)
                .IsRequired();
            // Base Model Configuration End
            builder.Property(e => e.FirstName)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(e => e.MiddleName)
                .HasMaxLength(50);
            builder.Property(e => e.LastName)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(e => e.FatherName)
                .HasMaxLength(100);
            
          
            builder.Property(e => e.FaxNo)
                .HasMaxLength(50);

            builder.Property(e => e.MaritalStatus)
                .HasMaxLength(50);
            builder.Property(e => e.Picture)
                .HasMaxLength(200);

            builder.Property(e => e.Gender)
                .IsRequired()
                .HasMaxLength(10);
            
            builder.Property(e => e.Remarks)
                .HasMaxLength(200);
            //builder.Property(c => c.CityId).IsRequired();
            // builder.Property(c => c.CountryId).IsRequired();
            // builder.Property(c => c.DepartmentId).IsRequired();

            //builder.HasOne<City>()
            //    .WithMany()
            //    .IsRequired(false)
            //    //.HasForeignKey("CityId")
            //    .HasForeignKey(e => e.CityId)
            //    .HasConstraintName("ForeignKey_Employee_City"); ;

            //builder.HasOne(o => o.City)
            //    .WithMany()
            //    .HasForeignKey("CityId");

            //.HasOne<City>(s => s.)
            // .WithMany(g => g.Students)
            // .HasForeignKey(s => s.CurrentGradeId);


        }
    }
}