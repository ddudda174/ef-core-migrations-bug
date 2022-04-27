﻿// <auto-generated />
using System;
using EfCoreOwnedType.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EfCoreOwnedType.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("EFCoreOwnedType.Entities.Account.User", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(22)
                        .HasColumnType("varchar(22)");

                    b.Property<string>("AccountType")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("AddressId")
                        .HasMaxLength(22)
                        .HasColumnType("varchar(22)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(false);

                    b.Property<DateTime>("LastActive")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasMaxLength(320)
                        .HasColumnType("varchar(320)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("Mail")
                        .IsUnique();

                    b.ToTable("Users", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "dQR_8UZvPk61eK5bNTJWlg",
                            AccountType = "IsAdmin",
                            AddressId = "uXMHgZAkm0K3A4LBsxGhZg",
                            Created = new DateTime(2022, 2, 23, 12, 38, 6, 165, DateTimeKind.Utc).AddTicks(3804),
                            IsDeleted = false,
                            LastActive = new DateTime(2022, 2, 23, 12, 38, 6, 165, DateTimeKind.Utc).AddTicks(3803),
                            Mail = "test@mail.de",
                            Status = "active"
                        });
                });

            modelBuilder.Entity("EFCoreOwnedType.Entities.Contact.Address", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(22)
                        .HasColumnType("varchar(22)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("HouseNumber")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("varchar(16)");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(false);

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("varchar(16)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.HasKey("Id");

                    b.ToTable("Addresses", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "uXMHgZAkm0K3A4LBsxGhZg",
                            City = "Citname",
                            HouseNumber = "1",
                            IsDeleted = false,
                            PostalCode = "12345",
                            Street = "Street"
                        });
                });

            modelBuilder.Entity("EFCoreOwnedType.Entities.Account.User", b =>
                {
                    b.HasOne("EFCoreOwnedType.Entities.Contact.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId");

                    b.OwnsOne("EFCoreOwnedType.Entities.Person.PersonalData", "Data", b1 =>
                        {
                            b1.Property<string>("Id")
                                .ValueGeneratedOnAdd()
                                .HasMaxLength(22)
                                .HasColumnType("varchar(22)");

                            b1.Property<DateTime>("BirthDate")
                                .HasColumnType("datetime(6)");

                            b1.Property<string>("BirthName")
                                .HasMaxLength(64)
                                .HasColumnType("varchar(64)");

                            b1.Property<string>("BirthPlace")
                                .IsRequired()
                                .HasMaxLength(128)
                                .HasColumnType("varchar(128)");

                            b1.Property<string>("FamilyName")
                                .IsRequired()
                                .HasMaxLength(64)
                                .HasColumnType("varchar(64)");

                            b1.Property<string>("FamilyStatus")
                                .HasMaxLength(32)
                                .HasColumnType("varchar(32)");

                            b1.Property<string>("FirstName")
                                .IsRequired()
                                .HasMaxLength(64)
                                .HasColumnType("varchar(64)");

                            b1.Property<string>("Gender")
                                .IsRequired()
                                .HasMaxLength(16)
                                .HasColumnType("varchar(16)");

                            b1.Property<bool>("IsDeleted")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("tinyint(1)")
                                .HasDefaultValue(false);

                            b1.Property<string>("NameAffix")
                                .HasMaxLength(64)
                                .HasColumnType("varchar(64)");

                            b1.Property<string>("Nationality")
                                .HasMaxLength(64)
                                .HasColumnType("varchar(64)");

                            b1.Property<DateTime?>("ResidentSince")
                                .HasColumnType("datetime(6)");

                            b1.Property<string>("Salutation")
                                .IsRequired()
                                .HasMaxLength(16)
                                .HasColumnType("varchar(16)");

                            b1.Property<string>("TaxNo")
                                .HasMaxLength(64)
                                .HasColumnType("varchar(64)");

                            b1.Property<string>("UserId")
                                .IsRequired()
                                .HasMaxLength(22)
                                .HasColumnType("varchar(22)");

                            b1.HasKey("Id");

                            b1.HasIndex("UserId")
                                .IsUnique();

                            b1.ToTable("PersonalData", (string)null);

                            b1.WithOwner()
                                .HasForeignKey("UserId");

                            b1.HasData(
                                new
                                {
                                    Id = "Bw9CbRsw20--SRUEM8-Xrg",
                                    BirthDate = new DateTime(2002, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                                    BirthName = "PersonBirth",
                                    BirthPlace = "Cityname",
                                    FamilyName = "Person",
                                    FirstName = "Test",
                                    Gender = "male",
                                    IsDeleted = false,
                                    Salutation = "Herr",
                                    UserId = "dQR_8UZvPk61eK5bNTJWlg"
                                });
                        });

                    b.Navigation("Address");

                    b.Navigation("Data");
                });
#pragma warning restore 612, 618
        }
    }
}
