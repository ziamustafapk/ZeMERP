using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ZeMERP.Models;

namespace ZeMERP.Data.Configuration
{
    public class PhoneConfiguration : IEntityTypeConfiguration<Phone>
    {
        public void Configure(EntityTypeBuilder<Phone> builder)
        {
            builder.ToTable("STP_PHONE");
            builder.HasKey(p => p.PhoneNumberId);
            builder.Property(p => p.PhoneNumber)
                .IsRequired()
                .HasMaxLength(20);
            builder.Property(p => p.Type)
                .HasMaxLength(50);
        }
    }
}