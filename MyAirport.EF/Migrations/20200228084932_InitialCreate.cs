using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NR.MyAirport.EF.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bagages",
                columns: table => new
                {
                    BagageId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VolId = table.Column<int>(nullable: false),
                    CodeIATA = table.Column<string>(nullable: true),
                    DateCreation = table.Column<DateTime>(nullable: false),
                    Classe = table.Column<string>(nullable: true),
                    Priorite = table.Column<bool>(nullable: false),
                    Sta = table.Column<string>(nullable: true),
                    Ssur = table.Column<int>(nullable: false),
                    Destination = table.Column<int>(nullable: false),
                    Escale = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bagages", x => x.BagageId);
                });

            migrationBuilder.CreateTable(
                name: "Vols",
                columns: table => new
                {
                    VolId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cie = table.Column<string>(nullable: true),
                    Des = table.Column<string>(nullable: true),
                    Dhc = table.Column<DateTime>(nullable: false),
                    Imm = table.Column<string>(nullable: true),
                    Lig = table.Column<string>(nullable: true),
                    Pkg = table.Column<string>(nullable: true),
                    Pax = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vols", x => x.VolId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bagages");

            migrationBuilder.DropTable(
                name: "Vols");
        }
    }
}
