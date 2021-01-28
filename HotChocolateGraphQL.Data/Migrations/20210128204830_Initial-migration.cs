using Microsoft.EntityFrameworkCore.Migrations;

using System;

namespace HotChocolateGraphQL.Data.Migrations
{
	public partial class Initialmigration : Migration
	{
		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropTable(
				name: "Accounts");

			migrationBuilder.DropTable(
				name: "Owners");
		}

		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.CreateTable(
				name: "Owners",
				columns: table => new
				{
					Id = table.Column<Guid>(type: "char(36)", nullable: false),
					Address = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
					Name = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Owners", x => x.Id);
				});

			migrationBuilder.CreateTable(
				name: "Accounts",
				columns: table => new
				{
					Id = table.Column<Guid>(type: "char(36)", nullable: false),
					Description = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
					OwnerId = table.Column<Guid>(type: "char(36)", nullable: false),
					Type = table.Column<int>(type: "int", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Accounts", x => x.Id);
					table.ForeignKey(
						name: "FK_Accounts_Owners_OwnerId",
						column: x => x.OwnerId,
						principalTable: "Owners",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
				});

			migrationBuilder.InsertData(
				table: "Owners",
				columns: new[] { "Id", "Address", "Name" },
				values: new object[] { new Guid("c4133184-45ca-4056-b264-87be022b1a41"), "John Doe's address", "John Doe" });

			migrationBuilder.InsertData(
				table: "Owners",
				columns: new[] { "Id", "Address", "Name" },
				values: new object[] { new Guid("4c285165-025a-4f8c-9036-0e95a26501e7"), "Jane Doe's address", "Jane Doe" });

			migrationBuilder.InsertData(
				table: "Accounts",
				columns: new[] { "Id", "Description", "OwnerId", "Type" },
				values: new object[] { new Guid("1a0d47ec-bd9c-4d38-8bc6-0bc1be7d1e84"), "Cash account for our users", new Guid("c4133184-45ca-4056-b264-87be022b1a41"), 0 });

			migrationBuilder.InsertData(
				table: "Accounts",
				columns: new[] { "Id", "Description", "OwnerId", "Type" },
				values: new object[] { new Guid("e3738060-4c75-4c96-b53a-da9f54626d68"), "Savings account for our users", new Guid("4c285165-025a-4f8c-9036-0e95a26501e7"), 1 });

			migrationBuilder.InsertData(
				table: "Accounts",
				columns: new[] { "Id", "Description", "OwnerId", "Type" },
				values: new object[] { new Guid("0abd04c0-ccc8-414c-88ac-e2317f35176d"), "Income account for our users", new Guid("4c285165-025a-4f8c-9036-0e95a26501e7"), 3 });

			migrationBuilder.CreateIndex(
				name: "IX_Accounts_OwnerId",
				table: "Accounts",
				column: "OwnerId");
		}
	}
}
