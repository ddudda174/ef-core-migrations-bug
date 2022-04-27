namespace EfCoreOwnedType.Data.Extensions;

using System;
using EFCoreOwnedType.Entities;
using EFCoreOwnedType.Entities.Account;
using EFCoreOwnedType.Entities.Contact;
using Microsoft.EntityFrameworkCore;

public static class ModelBuilderExtensions
{
    public static void SeedData(this ModelBuilder builder)
    {
        SeedAdmin(builder);
    }

    private static void SeedAdmin(ModelBuilder builder)
    {
        var userId    = new DbId(Guid.NewGuid());
        var dataId    = new DbId(Guid.NewGuid());
        var addressId = new DbId(Guid.NewGuid());

        var user = new
                   {
                       Id          = userId,
                       DataId      = dataId,
                       AddressId   = addressId, // shadow property
                       AccountType = "IsAdmin",
                       Mail        = "test@mail.de",
                       LastActive  = new DateTime(2022, 2, 23, 12, 38, 6, 165, DateTimeKind.Utc).AddTicks(3803),
                       Created     = new DateTime(2022, 2, 23, 12, 38, 6, 165, DateTimeKind.Utc).AddTicks(3804),
                       Status      = "active",
                       IsDeleted   = false
                   };

        var data = new
                   {
                       UserId     = userId,
                       Id         = dataId,
                       Salutation = "Herr",
                       Gender     = "male",
                       FirstName  = "Test",
                       FamilyName = "Person",
                       BirthName  = "PersonBirth",
                       BirthDate  = new DateTime(2002, 10, 1),
                       BirthPlace = "Cityname",
                       IsDeleted  = false
                   };

        var address = new Address(addressId)
                      {
                          Street      = "Street",
                          HouseNumber = "1",
                          PostalCode  = "12345",
                          City        = "Citname",
                          IsDeleted   = false
                      };

        builder.Entity<User>().HasData(user);
        builder.Entity<User>().OwnsOne(x => x.Data, build => { build.HasData(data); });
        builder.Entity<Address>().HasData(address);
    }
}