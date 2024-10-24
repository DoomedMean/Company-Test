using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SimpleStore.Migrations
{
    /// <inheritdoc />
    public partial class Addrole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "bfcafaf4-3d01-4a5f-98b9-87b570e779a5", null, "Cashier", "CASHIER" },
                    { "ee77aa50-46c7-428a-aede-52e4cfc413fb", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "fe397e2a-f320-495a-a2aa-f8288fa48dec", 0, "2cfe7d80-fd07-4528-a3f0-0647d16c5073", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEN4qNQpY6cc89vI0d9vtyQtEvx1SL1ovEHM+C3xX7lTOR/J9rnE7kd0V25aO1ZVcHw==", null, false, "08b76121-75f3-4b37-af04-367d005f85a9", false, "admin@example.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "b7ee3906-81cf-41c4-b50c-f186376242a4", "fe397e2a-f320-495a-a2aa-f8288fa48dec" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bfcafaf4-3d01-4a5f-98b9-87b570e779a5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ee77aa50-46c7-428a-aede-52e4cfc413fb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b7ee3906-81cf-41c4-b50c-f186376242a4", "fe397e2a-f320-495a-a2aa-f8288fa48dec" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fe397e2a-f320-495a-a2aa-f8288fa48dec");

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
    }
}
