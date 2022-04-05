namespace EfCoreOwnedType.Data.ValueGenerators
{
    using System;
    using Microsoft.EntityFrameworkCore.ChangeTracking;
    using Microsoft.EntityFrameworkCore.ValueGeneration;

    public class UserCustomerIdGenerator : ValueGenerator<string>
    {
        public override string Next(EntityEntry entry)
        {
            return $"KD-{DateTimeOffset.UtcNow.ToUnixTimeSeconds()}";
        }

        public override bool GeneratesTemporaryValues => false;
    }
}
