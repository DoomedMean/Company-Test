using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SimpleStore.Migrations
{
    /// <inheritdoc />
    public partial class AddSampleProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "16eb3730-504f-456f-867a-0ee5e160b080", null, "Admin", "ADMIN" },
                    { "366a7eaf-9df5-4b3b-82f1-7dd13a95792c", null, "Cashier", "CASHIER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f24ac619-fcaf-43f9-949a-279386e6a296", 0, "908b5ccb-6c5d-4452-b75a-3bcd8d9bd260", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEF1FsHL/o9IWB53zSbte4Ecfd2afJz8r6hra/jU7oxnZID4R4iuyjyBjC/QN1g4MpA==", null, false, "f2fd4ec5-c563-4559-90d4-c5df505c39e1", false, "admin@example.com" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Name", "Price", "Stock" },
                values: new object[] { 1, "Sample Product", 2390m, 10 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "16eb3730-504f-456f-867a-0ee5e160b080");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "366a7eaf-9df5-4b3b-82f1-7dd13a95792c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f24ac619-fcaf-43f9-949a-279386e6a296");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

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
    }
}
