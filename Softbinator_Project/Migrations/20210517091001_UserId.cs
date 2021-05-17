using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Softbinator_Project.Migrations
{
    public partial class UserId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Doctori_DoctorId1",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_DoctorId1",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DoctorId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DoctorId1",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Pacienti",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Doctori",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pacienti_UserId",
                table: "Pacienti",
                column: "UserId",
                unique: true,
                filter: "[UserId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Doctori_UserId",
                table: "Doctori",
                column: "UserId",
                unique: true,
                filter: "[UserId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctori_AspNetUsers_UserId",
                table: "Doctori",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Pacienti_AspNetUsers_UserId",
                table: "Pacienti",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctori_AspNetUsers_UserId",
                table: "Doctori");

            migrationBuilder.DropForeignKey(
                name: "FK_Pacienti_AspNetUsers_UserId",
                table: "Pacienti");

            migrationBuilder.DropIndex(
                name: "IX_Pacienti_UserId",
                table: "Pacienti");

            migrationBuilder.DropIndex(
                name: "IX_Doctori_UserId",
                table: "Doctori");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Pacienti");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Doctori");

            migrationBuilder.AddColumn<Guid>(
                name: "DoctorId",
                table: "AspNetUsers",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DoctorId1",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_DoctorId1",
                table: "AspNetUsers",
                column: "DoctorId1");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Doctori_DoctorId1",
                table: "AspNetUsers",
                column: "DoctorId1",
                principalTable: "Doctori",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
