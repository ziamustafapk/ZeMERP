using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ZeMERP.Models;

namespace ZeMERP.Data.Configuration
{
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.ToTable("STP_ADDRESS");
            builder.HasKey(a => a.AddressId);
            builder.Property(a => a.StreetAddress)
                .HasMaxLength(100);
        }
    }
}
