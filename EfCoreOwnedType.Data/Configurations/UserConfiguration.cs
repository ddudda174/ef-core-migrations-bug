namespace EfCoreOwnedType.Data.Configurations
{
    using EfCoreOwnedType.Data.ValueGenerators;
    using EFCoreOwnedType.Entities.Account;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    internal class UserConfiguration : BaseEntityTypeConfig<User>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            base.Configure(builder);

            builder.ToTable("Users");

            builder.HasIndex(x => x.Mail).IsUnique();
            builder.Property(x => x.Mail).HasMaxLength(320).IsRequired();
            builder.Property(x => x.Status).HasMaxLength(100).IsRequired();
            builder.Property(x => x.AccountType).HasMaxLength(100).IsRequired();
            builder.Property(x => x.LastActive).IsRequired();
            builder.Property(x => x.Created).IsRequired();

            builder.OwnsOne(user => user.Data, build =>
            {
                build.ToTable("PersonalData");

                build.HasKey(x => x.Id);
                build.Property(x => x.Id)
                .HasValueGenerator<DbIdGenerator>()
                .ValueGeneratedOnAdd();

                build.Property(x => x.Salutation).IsRequired().HasMaxLength(16);
                build.Property(x => x.NameAffix).HasMaxLength(64);
                build.Property(x => x.Gender).IsRequired().HasMaxLength(16);
                build.Property(x => x.FirstName).IsRequired().HasMaxLength(64);
                build.Property(x => x.FamilyName).IsRequired().HasMaxLength(64);
                build.Property(x => x.BirthName).HasMaxLength(64);
                build.Property(x => x.BirthPlace).IsRequired().HasMaxLength(128);
                build.Property(x => x.BirthDate).IsRequired();

                build.Property(x => x.ResidentSince);
                build.Property(x => x.TaxNo).HasMaxLength(64);
                build.Property(x => x.FamilyStatus).HasMaxLength(32);
                build.Property(x => x.Nationality).HasMaxLength(64);

                build.Property(x => x.IsDeleted).IsRequired().HasDefaultValue(false);

                build.Ignore(x => x.Age);
            });
        }
    }
}