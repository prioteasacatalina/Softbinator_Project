using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Softbinator_Project.Migrations
{
    public partial class UserUpdateColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
