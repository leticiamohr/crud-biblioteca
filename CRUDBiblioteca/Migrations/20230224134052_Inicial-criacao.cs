using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRUDBiblioteca.Migrations
{
    /// <inheritdoc />
    public partial class Inicialcriacao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "varchar(250)", nullable: false),
                    Author = table.Column<string>(type: "varchar(100)", nullable: false),
                    Genre = table.Column<string>(type: "varchar(80)", nullable: false),
                    Classification = table.Column<string>(type: "varchar(80)", nullable: false),
                    NumPages = table.Column<string>(type: "varchar(100)", nullable: false),
                    Edition = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BookId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
