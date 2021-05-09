using Microsoft.EntityFrameworkCore.Migrations;

namespace Softbinator_Project.Migrations
{
    public partial class Numar_Cabinet_String_to_int : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pacient_Tutore_TutoreId",
                table: "Pacient");

            migrationBuilder.DropForeignKey(
                name: "FK_Programari_Pacient_PacientId",
                table: "Programari");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tutore",
                table: "Tutore");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pacient",
                table: "Pacient");

            migrationBuilder.RenameTable(
                name: "Tutore",
                newName: "Tutori");

            migrationBuilder.RenameTable(
                name: "Pacient",
                newName: "Pacienti");

            migrationBuilder.RenameIndex(
                name: "IX_Pacient_TutoreId",
                table: "Pacienti",
                newName: "IX_Pacienti_TutoreId");

            migrationBuilder.AlterColumn<int>(
                name: "Etaj",
                table: "Cabinete",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tutori",
                table: "Tutori",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pacienti",
                table: "Pacienti",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Pacienti_Tutori_TutoreId",
                table: "Pacienti",
                column: "TutoreId",
                principalTable: "Tutori",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Programari_Pacienti_PacientId",
                table: "Programari",
                column: "PacientId",
                principalTable: "Pacienti",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pacienti_Tutori_TutoreId",
                table: "Pacienti");

            migrationBuilder.DropForeignKey(
                name: "FK_Programari_Pacienti_PacientId",
                table: "Programari");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tutori",
                table: "Tutori");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pacienti",
                table: "Pacienti");

            migrationBuilder.RenameTable(
                name: "Tutori",
                newName: "Tutore");

            migrationBuilder.RenameTable(
                name: "Pacienti",
                newName: "Pacient");

            migrationBuilder.RenameIndex(
                name: "IX_Pacienti_TutoreId",
                table: "Pacient",
                newName: "IX_Pacient_TutoreId");

            migrationBuilder.AlterColumn<string>(
                name: "Etaj",
                table: "Cabinete",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tutore",
                table: "Tutore",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pacient",
                table: "Pacient",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Pacient_Tutore_TutoreId",
                table: "Pacient",
                column: "TutoreId",
                principalTable: "Tutore",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Programari_Pacient_PacientId",
                table: "Programari",
                column: "PacientId",
                principalTable: "Pacient",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
