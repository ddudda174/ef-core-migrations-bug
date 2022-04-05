namespace EfCoreOwnedType.Data.ValueGenerators;

using EFCoreOwnedType.Entities;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using System;

public class DbIdGenerator : ValueGenerator<DbId>
{
    public override bool GeneratesTemporaryValues => false;

    public override DbId Next(EntityEntry entry)
    {
        if (entry == null)
        {
            throw new ArgumentNullException(nameof(entry));
        }

        return new DbId();
    }
}
