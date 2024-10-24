using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SimpleStore.Migrations
{
    /// <inheritdoc />
    public partial class ChgPasswd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
