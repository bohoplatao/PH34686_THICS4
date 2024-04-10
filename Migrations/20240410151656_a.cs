using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PH34686_THICS4.Migrations
{
    public partial class a : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DongVats",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Ho = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThucAn = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DongVats", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Cas",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tuoi = table.Column<int>(type: "int", nullable: false),
                    NoiSong = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ID_DongVat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DongVatID = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cas", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Cas_DongVats_DongVatID",
                        column: x => x.DongVatID,
                        principalTable: "DongVats",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cas_DongVatID",
                table: "Cas",
                column: "DongVatID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cas");

            migrationBuilder.DropTable(
                name: "DongVats");
        }
    }
}
