using Microsoft.EntityFrameworkCore.Migrations;

namespace CIS174CourseWebsite.Migrations.Country
{
    public partial class m6t3initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    GameID = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.GameID);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    CountryID = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    GameID = table.Column<string>(nullable: true),
                    CategoryID = table.Column<string>(nullable: true),
                    LogoImage = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.CountryID);
                    table.ForeignKey(
                        name: "FK_Countries_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Countries_Games_GameID",
                        column: x => x.GameID,
                        principalTable: "Games",
                        principalColumn: "GameID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "Name" },
                values: new object[,]
                {
                    { "indoor", "Indoor" },
                    { "outdoor", "Outdoor" }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameID", "Name" },
                values: new object[,]
                {
                    { "winter", "Winter Olympics" },
                    { "summer", "Summer Olympics" },
                    { "para", "Paraympics" },
                    { "youth", "Youth Olympic Games" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryID", "CategoryID", "GameID", "LogoImage", "Name" },
                values: new object[,]
                {
                    { "canada", "indoor", "winter", "M6T3/canada.png", "Canada" },
                    { "finland", "outdoor", "youth", "M6T3/finland.png", "Finland" },
                    { "russia", "indoor", "youth", "M6T3/russia.png", "Russia" },
                    { "cyprus", "indoor", "youth", "M6T3/cyprus.png", "Cyprus" },
                    { "france", "indoor", "youth", "M6T3/france.png", "France" },
                    { "zimbabwe", "outdoor", "para", "M6T3/zimbabwe.png", "Zimbabwe" },
                    { "pakistan", "outdoor", "para", "M6T3/pakistan.png", "Pakistan" },
                    { "austria", "outdoor", "para", "M6T3/austria.png", "Austria" },
                    { "ukraine", "indoor", "para", "M6T3/ukraine.png", "Ukraine" },
                    { "uruguay", "indoor", "para", "M6T3/uruguay.png", "Uruguay" },
                    { "thailand", "indoor", "para", "M6T3/thailand.png", "Thailand" },
                    { "usa", "outdoor", "summer", "M6T3/usa.png", "USA" },
                    { "netherlands", "outdoor", "summer", "M6T3/netherlands.png", "Netherlands" },
                    { "brazil", "outdoor", "summer", "M6T3/brazil.png", "Brazil" },
                    { "mexico", "indoor", "summer", "M6T3/mexico.png", "Mexico" },
                    { "china", "indoor", "summer", "M6T3/china.png", "China" },
                    { "germany", "indoor", "summer", "M6T3/germany.png", "Germany" },
                    { "japan", "outdoor", "winter", "M6T3/japan.png", "Japan" },
                    { "italy", "outdoor", "winter", "M6T3/italy.png", "Italy" },
                    { "jamaica", "outdoor", "winter", "M6T3/jamaica.png", "Jamaica" },
                    { "greatbritain", "indoor", "winter", "M6T3/greatbritain.png", "Great Britain" },
                    { "sweden", "indoor", "winter", "M6T3/sweden.png", "Sweden" },
                    { "slovakia", "outdoor", "youth", "M6T3/slovakia.png", "Slovakia" },
                    { "portugal", "outdoor", "youth", "M6T3/portugal.png", "Portugal" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Countries_CategoryID",
                table: "Countries",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Countries_GameID",
                table: "Countries",
                column: "GameID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Games");
        }
    }
}
