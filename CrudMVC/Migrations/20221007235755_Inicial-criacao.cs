using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CrudMVC.Migrations
{
    public partial class Inicialcriacao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CLIENTE",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CPF = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NOME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DATADENASCIMENTO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SEXO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ENDERECO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ESTADO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CIDADE = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CLIENTE", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CLIENTE");
        }
    }
}
