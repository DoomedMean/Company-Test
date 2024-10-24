using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SimpleStore.Migrations
{
    /// <inheritdoc />
    public partial class ChgPss : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0f394cb3-a074-41c2-b621-33acb56f5a97");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ff60c452-fe0d-4baf-97b6-a3ef13f55e04");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e4f0985c-d5bf-4906-967b-50b40275f117");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "9de1735c-0093-423e-a2db-2d625ef6854d", null, "Admin", "ADMIN" },
                    { "d7a5da3f-cf9c-4144-b8ea-f695c34bd46e", null, "Cashier", "CASHIER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "dd22ba6d-878b-43c8-b39d-b0edfa401761", 0, "4b018f37-9514-4f29-b35e-2541ca2a18b2", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEA50OeL3xfZdSP3UO+oc/+9a0aH3UcsE4CvZdRq0E1GhYlEWUmNpXn0cxeJvTE/mMA==", null, false, "61f4f29e-3b9e-4659-b8a5-f6c4a4523046", false, "admin@example.com" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9de1735c-0093-423e-a2db-2d625ef6854d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d7a5da3f-cf9c-4144-b8ea-f695c34bd46e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dd22ba6d-878b-43c8-b39d-b0edfa401761");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0f394cb3-a074-41c2-b621-33acb56f5a97", null, "Admin", "ADMIN" },
                    { "ff60c452-fe0d-4baf-97b6-a3ef13f55e04", null, "Cashier", "CASHIER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e4f0985c-d5bf-4906-967b-50b40275f117", 0, "e1630756-7cd9-481a-a1f6-af66a2c78216", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEIAQh32Wc+E7LWOy5oX/7wU2TOo8V02e/UYxOsIbfcjvaiUPMlooV8YuFidvU0q1gQ==", null, false, "3f1ed089-00b1-41a4-bf00-a5c79733b0c7", false, "admin@example.com" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Name", "Price", "Stock" },
                values: new object[] { 1, "Sample Product", 2390m, 10 });
        }
    }
}
