using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LibrarySys.Migrations
{
    /// <inheritdoc />
    public partial class MemberAndBorrowing : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    Code = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "Borrowings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MemberCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BorrowedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReturnedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Borrowings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Borrowings_Books_BookCode",
                        column: x => x.BookCode,
                        principalTable: "Books",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Borrowings_Members_MemberCode",
                        column: x => x.MemberCode,
                        principalTable: "Members",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "Code", "Name" },
                values: new object[,]
                {
                    { "M001", "Angga" },
                    { "M002", "Ferry" },
                    { "M003", "Putri" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Borrowings_BookCode",
                table: "Borrowings",
                column: "BookCode");

            migrationBuilder.CreateIndex(
                name: "IX_Borrowings_MemberCode",
                table: "Borrowings",
                column: "MemberCode");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Borrowings");

            migrationBuilder.DropTable(
                name: "Members");
        }
    }
}
