using Microsoft.EntityFrameworkCore.Migrations;

namespace SushiRestaurant.data.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProduktId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NazwaProdukt = table.Column<string>(nullable: false),
                    JednostkaProdukt = table.Column<string>(nullable: true),
                    IloscProdukt = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProduktId);
                });

            migrationBuilder.CreateTable(
                name: "Sushi",
                columns: table => new
                {
                    SushiId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NazwaSushi = table.Column<string>(nullable: false),
                    IloscSushi = table.Column<int>(nullable: false),
                    CenaSushi = table.Column<double>(nullable: false),
                    OpisSushi = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sushi", x => x.SushiId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Login = table.Column<string>(maxLength: 12, nullable: false),
                    Password = table.Column<string>(maxLength: 12, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Zestawy",
                columns: table => new
                {
                    ZestawyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NazwaZestaw = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zestawy", x => x.ZestawyId);
                });

            migrationBuilder.CreateTable(
                name: "ProductsSushi",
                columns: table => new
                {
                    ProductsSushiId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: false),
                    SushiId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsSushi", x => x.ProductsSushiId);
                    table.ForeignKey(
                        name: "FK_ProductsSushi_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProduktId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductsSushi_Sushi_SushiId",
                        column: x => x.SushiId,
                        principalTable: "Sushi",
                        principalColumn: "SushiId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ZestawySushi",
                columns: table => new
                {
                    ZestawySushiId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SushiId = table.Column<int>(nullable: false),
                    ZestawyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZestawySushi", x => x.ZestawySushiId);
                    table.ForeignKey(
                        name: "FK_ZestawySushi_Sushi_SushiId",
                        column: x => x.SushiId,
                        principalTable: "Sushi",
                        principalColumn: "SushiId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ZestawySushi_Zestawy_ZestawyId",
                        column: x => x.ZestawyId,
                        principalTable: "Zestawy",
                        principalColumn: "ZestawyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductsSushi_ProductId",
                table: "ProductsSushi",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsSushi_SushiId",
                table: "ProductsSushi",
                column: "SushiId");

            migrationBuilder.CreateIndex(
                name: "IX_ZestawySushi_SushiId",
                table: "ZestawySushi",
                column: "SushiId");

            migrationBuilder.CreateIndex(
                name: "IX_ZestawySushi_ZestawyId",
                table: "ZestawySushi",
                column: "ZestawyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductsSushi");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "ZestawySushi");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Sushi");

            migrationBuilder.DropTable(
                name: "Zestawy");
        }
    }
}
