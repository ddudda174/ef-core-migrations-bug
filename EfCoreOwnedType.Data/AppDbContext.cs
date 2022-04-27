namespace EfCoreOwnedType.Data
{
    using System.Reflection;
    using Converters;
    using EFCoreOwnedType.Entities;
    using EFCoreOwnedType.Entities.Person;
    using Extensions;
    using Microsoft.EntityFrameworkCore;

    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<DbId>()
                                .HaveConversion<DbIdConverter>()
                                .HaveMaxLength(DbId.MAX_LENGTH);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            // System.InvalidOperationException: The entity type 'PersonalData' cannot be configured as non-owned because it has already been configured as a owned. Use the nested builder in `OwnsOne` or `OwnsMany` on the owner entity type builder to further configure this type. 
            //builder.Ignore<PersonalData>();
            
            builder.SeedData();
        }
    }
}
