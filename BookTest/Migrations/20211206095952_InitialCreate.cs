using Microsoft.EntityFrameworkCore.Migrations;

namespace BookTest.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategType",
                columns: table => new
                {
                    Type = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategType", x => x.Type);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    NameToken = table.Column<string>(nullable: false),
                    Descriptions = table.Column<string>(nullable: true),
                    TypeId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.NameToken);
                    table.ForeignKey(
                        name: "FK_Categories_CategType_TypeId",
                        column: x => x.TypeId,
                        principalTable: "CategType",
                        principalColumn: "Type",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Book",
                columns: table => new
                {
                    ISBNNumber = table.Column<string>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    CategoryId = table.Column<string>(nullable: true),
                    Author = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book", x => x.ISBNNumber);
                    table.ForeignKey(
                        name: "FK_Book_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "NameToken",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Book_CategoryId",
                table: "Book",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_TypeId",
                table: "Categories",
                column: "TypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Book");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "CategType");
        }
    }
}
