using Microsoft.EntityFrameworkCore.Migrations;

namespace Softbinator_Project.Migrations
{
    public partial class Pacient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Tutori",
                table: "Tutori");

            migrationBuilder.RenameTable(
                name: "Tutori",
                newName: "Tutore");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tutore",
                table: "Tutore",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Pacient",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nume = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Prenume = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    CNP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inaltime = table.Column<double>(type: "float", nullable: false),
                    Greutate = table.Column<double>(type: "float", nullable: false),
                    Alergie = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TutoreId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacient", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pacient_Tutore_TutoreId",
                        column: x => x.TutoreId,
                        principalTable: "Tutore",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pacient_TutoreId",
                table: "Pacient",
                column: "TutoreId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pacient");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tutore",
                table: "Tutore");

            migrationBuilder.RenameTable(
                name: "Tutore",
                newName: "Tutori");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tutori",
                table: "Tutori",
                column: "Id");
        }
    }
}
