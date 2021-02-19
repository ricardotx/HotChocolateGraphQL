﻿// <auto-generated />
using System;
using HotChocolateGraphQL.Data.Source.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HotChocolateGraphQL.Data.Source.Migrations
{
    [DbContext(typeof(StorageContext))]
    [Migration("20210204214753_Initial-migration")]
    partial class Initialmigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("HotChocolateGraphQL.Core.Source.Entities.Account", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Description")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<Guid>("OwnerId")
                        .HasColumnType("char(36)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("Accounts");

                    b.HasData(
                        new
                        {
                            Id = new Guid("e913680c-1427-476e-855a-8c1f04aff95a"),
                            Description = "Cash account for our users",
                            OwnerId = new Guid("0cdded52-9e3a-4249-be4d-3a5dca8e99f8"),
                            Type = 0
                        },
                        new
                        {
                            Id = new Guid("c11ec666-03e6-4e95-ab1e-664ff1e09615"),
                            Description = "Savings account for our users",
                            OwnerId = new Guid("778ff453-8593-424a-ba9b-a7e32fba0478"),
                            Type = 1
                        },
                        new
                        {
                            Id = new Guid("6454474e-f180-470e-9447-6a325903a92c"),
                            Description = "Income account for our users",
                            OwnerId = new Guid("778ff453-8593-424a-ba9b-a7e32fba0478"),
                            Type = 3
                        });
                });

            modelBuilder.Entity("HotChocolateGraphQL.Core.Source.Entities.Owner", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Address")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Owners");

                    b.HasData(
                        new
                        {
                            Id = new Guid("0cdded52-9e3a-4249-be4d-3a5dca8e99f8"),
                            Address = "John Doe's address",
                            Name = "John Doe"
                        },
                        new
                        {
                            Id = new Guid("778ff453-8593-424a-ba9b-a7e32fba0478"),
                            Address = "Jane Doe's address",
                            Name = "Jane Doe"
                        });
                });

            modelBuilder.Entity("HotChocolateGraphQL.Core.Source.Entities.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.HasIndex("Code")
                        .IsUnique()
                        .HasDatabaseName("UniqueCode");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("5cd0d301-c3f2-40ee-9736-b37826e4f027"),
                            Code = "admin",
                            Name = "Admin"
                        },
                        new
                        {
                            Id = new Guid("24417ea1-2528-431b-89fc-6fd2611238fa"),
                            Code = "user",
                            Name = "User"
                        });
                });

            modelBuilder.Entity("HotChocolateGraphQL.Core.Source.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("char(36)");

                    b.Property<int>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(1);

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique()
                        .HasDatabaseName("UniqueUserEmail");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("224a0932-2140-4cb7-a5f5-47342b5d6579"),
                            Email = "admin@mail.com",
                            Name = "Admin",
                            Password = "123",
                            RoleId = new Guid("5cd0d301-c3f2-40ee-9736-b37826e4f027"),
                            Status = 1
                        });
                });

            modelBuilder.Entity("HotChocolateGraphQL.Core.Source.Entities.Account", b =>
                {
                    b.HasOne("HotChocolateGraphQL.Core.Source.Entities.Owner", "Owner")
                        .WithMany("Accounts")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("HotChocolateGraphQL.Core.Source.Entities.User", b =>
                {
                    b.HasOne("HotChocolateGraphQL.Core.Source.Entities.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("HotChocolateGraphQL.Core.Source.Entities.Owner", b =>
                {
                    b.Navigation("Accounts");
                });

            modelBuilder.Entity("HotChocolateGraphQL.Core.Source.Entities.Role", b =>
                {
                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
