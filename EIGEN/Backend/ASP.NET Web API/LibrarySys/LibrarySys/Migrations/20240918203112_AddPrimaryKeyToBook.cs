using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LibrarySys.Migrations
{
    /// <inheritdoc />
    public partial class AddPrimaryKeyToBook : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Books",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Books");

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "Books",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Books",
                table: "Books",
                column: "Code");

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Code", "Author", "Stock", "Title" },
                values: new object[,]
                {
                    { "HOB-83", "J.R.R. Tolkien", 1, "The Hobbit, or There and Back Again" },
                    { "JK-45", "J.K Rowling", 1, "Harry Potter" },
                    { "NRN-7", "C.S. Lewis", 1, "The Lion, the Witch and the Wardrobe" },
                    { "SHR-1", "Arthur Conan Doyle", 1, "A Study in Scarlet" },
                    { "TW-11", "Stephenie Meyer", 1, "Twilight" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Books",
                table: "Books");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Code",
                keyColumnType: "nvarchar(450)",
                keyValue: "HOB-83");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Code",
                keyColumnType: "nvarchar(450)",
                keyValue: "JK-45");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Code",
                keyColumnType: "nvarchar(450)",
                keyValue: "NRN-7");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Code",
                keyColumnType: "nvarchar(450)",
                keyValue: "SHR-1");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Code",
                keyColumnType: "nvarchar(450)",
                keyValue: "TW-11");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "Books");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Books",
                table: "Books",
                column: "Id");
        }
    }
}
