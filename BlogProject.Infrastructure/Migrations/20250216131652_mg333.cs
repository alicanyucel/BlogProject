using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogProject.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class mg333 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "LanguageId1",
                table: "Sliders",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sliders_LanguageId1",
                table: "Sliders",
                column: "LanguageId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Sliders_Languages_LanguageId1",
                table: "Sliders",
                column: "LanguageId1",
                principalTable: "Languages",
                principalColumn: "LanguageId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sliders_Languages_LanguageId1",
                table: "Sliders");

            migrationBuilder.DropIndex(
                name: "IX_Sliders_LanguageId1",
                table: "Sliders");

            migrationBuilder.DropColumn(
                name: "LanguageId1",
                table: "Sliders");
        }
    }
}
