using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Qtasnim_Digital_Teknologi.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "inventories",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_inventories", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "inventories",
                columns: new[] { "ID", "Description", "Name", "Quantity" },
                values: new object[,]
                {
                    { 1, "Test Object", "Pencil", 1 },
                    { 2, "Test Object", "Pen", 1 },
                    { 3, "Test Object", "Marker", 1 },
                    { 4, "Test Object", "Book", 1 },
                    { 5, "Test Object", "Box", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "inventories");
        }
    }
}
