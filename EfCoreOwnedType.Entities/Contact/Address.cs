namespace EFCoreOwnedType.Entities.Contact;

using EFCoreOwnedType.Entities;

public class Address : BaseEntity
{
    public string Street { get; set; }
    public string HouseNumber { get; set; }
    public string PostalCode { get; set; }
    public string City { get; set; }

    public Address() { }

    public Address(DbId id) : base(id) { }
}
