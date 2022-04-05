namespace EfCoreOwnedType.Data.Converters;

using EFCoreOwnedType.Entities;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

public class DbIdConverter : ValueConverter<DbId, string>
{
    public DbIdConverter() : base(dbId => dbId.Value,
                                  value => (DbId)value)
    { }
}
