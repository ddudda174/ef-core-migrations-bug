namespace EfCoreOwnedType.Data.Configurations;

using EFCoreOwnedType.Entities.Contact;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class AddressConfig : BaseEntityTypeConfig<Address>
{
    public override void Configure(EntityTypeBuilder<Address> builder)
    {
        base.Configure(builder);

        builder.ToTable("Addresses");

        builder.Property(x => x.Street).HasMaxLength(128).IsRequired();
        builder.Property(x => x.HouseNumber).HasMaxLength(16).IsRequired();
        builder.Property(x => x.PostalCode).HasMaxLength(16).IsRequired();
        builder.Property(x => x.City).HasMaxLength(128).IsRequired();
    }
}
