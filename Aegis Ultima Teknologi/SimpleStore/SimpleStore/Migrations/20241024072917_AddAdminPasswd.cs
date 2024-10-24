using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SimpleStore.Migrations
{
    /// <inheritdoc />
    public partial class AddAdminPasswd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "693b8398-acb2-47d4-a31e-92687572fc31");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b94e3e60-03a9-4b5e-9cf5-4307ba257d42");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "887c1baa-2638-4366-b9b2-956f2e862a50", null, "Cashier", "CASHIER" },
                    { "e67eb49f-307d-4466-8731-4dbcabfe3bf3", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1fc27e16-7e9a-4f24-82db-3f050243eeea", 0, "11147e0e-565d-4d63-84d7-3b73b5ce84a6", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEEObZmTGAFqCfsWK+2CDPX8Ip8e7VsYP4H4aUq5OyQj6YIIFFLxp+mQPMJ0dsAeYTg==", null, false, "b3560ab1-42f7-4f30-b903-1489eb6ea2ec", false, "admin@example.com" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "887c1baa-2638-4366-b9b2-956f2e862a50");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e67eb49f-307d-4466-8731-4dbcabfe3bf3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1fc27e16-7e9a-4f24-82db-3f050243eeea");

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "693b8398-acb2-47d4-a31e-92687572fc31", null, "Cashier", "CASHIER" },
                    { "b94e3e60-03a9-4b5e-9cf5-4307ba257d42", null, "Admin", "ADMIN" }
                });
        }
    }
}
