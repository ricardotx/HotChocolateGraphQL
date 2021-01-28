// <auto-generated />
using System;

using HotChocolateGraphQL.Data.Context;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HotChocolateGraphQL.Data.Migrations
{
	[DbContext(typeof(ApplicationContext))]
	[Migration("20210128204830_Initial-migration")]
	partial class Initialmigration
	{
		protected override void BuildTargetModel(ModelBuilder modelBuilder)
		{
#pragma warning disable 612, 618
			modelBuilder
				.HasAnnotation("Relational:MaxIdentifierLength", 64)
				.HasAnnotation("ProductVersion", "5.0.2");

			modelBuilder.Entity("HotChocolateGraphQL.Data.Models.Account", b =>
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
							Id = new Guid("1a0d47ec-bd9c-4d38-8bc6-0bc1be7d1e84"),
							Description = "Cash account for our users",
							OwnerId = new Guid("c4133184-45ca-4056-b264-87be022b1a41"),
							Type = 0
						},
						new
						{
							Id = new Guid("e3738060-4c75-4c96-b53a-da9f54626d68"),
							Description = "Savings account for our users",
							OwnerId = new Guid("4c285165-025a-4f8c-9036-0e95a26501e7"),
							Type = 1
						},
						new
						{
							Id = new Guid("0abd04c0-ccc8-414c-88ac-e2317f35176d"),
							Description = "Income account for our users",
							OwnerId = new Guid("4c285165-025a-4f8c-9036-0e95a26501e7"),
							Type = 3
						});
				});

			modelBuilder.Entity("HotChocolateGraphQL.Data.Models.Owner", b =>
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
							Id = new Guid("c4133184-45ca-4056-b264-87be022b1a41"),
							Address = "John Doe's address",
							Name = "John Doe"
						},
						new
						{
							Id = new Guid("4c285165-025a-4f8c-9036-0e95a26501e7"),
							Address = "Jane Doe's address",
							Name = "Jane Doe"
						});
				});

			modelBuilder.Entity("HotChocolateGraphQL.Data.Models.Account", b =>
				{
					b.HasOne("HotChocolateGraphQL.Data.Models.Owner", "Owner")
						.WithMany("Accounts")
						.HasForeignKey("OwnerId")
						.OnDelete(DeleteBehavior.Cascade)
						.IsRequired();

					b.Navigation("Owner");
				});

			modelBuilder.Entity("HotChocolateGraphQL.Data.Models.Owner", b =>
				{
					b.Navigation("Accounts");
				});
#pragma warning restore 612, 618
		}
	}
}