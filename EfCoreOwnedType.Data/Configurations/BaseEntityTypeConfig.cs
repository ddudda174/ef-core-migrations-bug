namespace EfCoreOwnedType.Data.Configurations;

using EFCoreOwnedType.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ValueGenerators;

public abstract class BaseEntityTypeConfig<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : BaseEntity
{
    public virtual void Configure(EntityTypeBuilder<TEntity> builder)
    {
        // Conversion and MaxLength is configured inside AppDbContext.ConfigureConventions

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id)
               .HasValueGenerator<DbIdGenerator>()
               .ValueGeneratedOnAdd();

        builder.Property(x => x.IsDeleted).HasDefaultValue(false);
    }
}
