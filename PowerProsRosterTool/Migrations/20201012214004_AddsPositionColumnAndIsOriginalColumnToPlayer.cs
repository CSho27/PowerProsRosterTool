using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace PowerProsRosterTool.Migrations
{
    public partial class AddsPositionColumnAndIsOriginalColumnToPlayer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PositionId",
                table: "Player",
                nullable: false,
                defaultValue: 1);

            migrationBuilder.AddColumn<bool>(
                name: "IsOriginal",
                table: "Player",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddForeignKey(
                name: "FK_Player_Position_PositionId_Position_Id",
                table: "Player",
                column: "PositionId",
                principalTable: "Position",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Player_Position_PositionId_Position_Id",
                table: "Player");

            migrationBuilder.DropColumn(
                name: "PositionId",
                table: "Player");

            migrationBuilder.DropColumn(
                name: "IsOriginal",
                table: "Player");
        }
    }
}
