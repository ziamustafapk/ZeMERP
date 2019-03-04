using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ZeMERP.Models;

namespace ZeMERP.Data.Configuration
{
    public class EmailConfiguration : IEntityTypeConfiguration<Email>
    {
        public void Configure(EntityTypeBuilder<Email> builder)
        {
            builder.ToTable("STP_EMAIL");
            builder.HasKey(e => e.EmailId);
            builder.Property(e => e.EmailAddress)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(e => e.Type)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}