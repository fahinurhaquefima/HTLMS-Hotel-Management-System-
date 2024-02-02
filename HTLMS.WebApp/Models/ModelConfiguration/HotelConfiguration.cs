using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HTLMS.WebApp.Models.ModelConfiguration;

public class HotelConfiguration : IEntityTypeConfiguration<Hotel>
{
    public void Configure(EntityTypeBuilder<Hotel> builder)
    {
        builder.ToTable(nameof(Hotel));
        builder.HasKey(x => x.HotelId);
        builder.Property(x  => x.HotelName).HasMaxLength(256).IsRequired();
        builder.Property(x  => x.HotelDescription).HasMaxLength(1000).IsRequired();
        builder.Property(x  => x.HotelType).HasMaxLength(250).IsRequired();
        builder.Property(x  => x.HotelAddress).HasMaxLength(300).IsRequired();
        builder.Property(x  => x.HotelCode).HasMaxLength(20).IsRequired();
        builder.Property(x  => x.HotelPhoneNumber).HasMaxLength(30).IsRequired();

    }
}
