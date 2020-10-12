using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace PowerProsRosterTool.Migrations
{
    public partial class AddsPositionTableToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Position",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Number = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Abbreviation = table.Column<string>(nullable: false),
                    SingularPlayerName = table.Column<string>(nullable: false),
                    PluralPlayerName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Position", x => x.Id);
                });

            migrationBuilder.Sql(@"
INSERT INTO pp.Position (`Number`, `Name`, Abbreviation, SingularPlayerName, PluralPlayerName)
VALUES
    (1, 'Pitcher', 'P', 'Pitcher', 'Pitchers'),
    (2, 'Catcher', 'C', 'Catcher', 'Catchers'),
    (3, 'First Base', '1B', 'First Baseman', 'First Basemen'),
    (4, 'Second Base', '2B', 'Second Baseman', 'Second Basemen'),
    (5, 'Third Base', '3B', 'Third Baseman', 'Third Basemen'),
    (6, 'Shortstop', 'SS', 'Shortstop', 'Shortstops'),
    (7, 'Left Field', 'LF', 'Left Fielder', 'Left Fielders'),
    (8, 'Center Field', 'CF', 'Center Fielder', 'Center Fielders'),
    (9, 'Right Field', 'RF', 'Right Fielder', 'Right Fielders'),
    (10, 'Designated Hitter', 'DH', 'Designated Hitter', 'Designated Hitters')
");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "Position");
        }
    }
}
