using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleAppEFwoensdag.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Uitgeverijen",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailContact = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uitgeverijen", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BoekenY",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Beschrijving = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UitgeverijId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BoekenY", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BoekenY_Uitgeverijen_UitgeverijId",
                        column: x => x.UitgeverijId,
                        principalTable: "Uitgeverijen",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Auteurs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailContact = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BoekId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Auteurs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Auteurs_BoekenY_BoekId",
                        column: x => x.BoekId,
                        principalTable: "BoekenY",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Auteurs_BoekId",
                table: "Auteurs",
                column: "BoekId");

            migrationBuilder.CreateIndex(
                name: "IX_BoekenY_UitgeverijId",
                table: "BoekenY",
                column: "UitgeverijId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Auteurs");

            migrationBuilder.DropTable(
                name: "BoekenY");

            migrationBuilder.DropTable(
                name: "Uitgeverijen");
        }
    }
}
