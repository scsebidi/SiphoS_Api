using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SiphoCoreApi.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StockItem",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VehicleRegistration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Make = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModelYear = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KMS = table.Column<int>(type: "int", nullable: false),
                    Colour = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VIN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RetailPrice = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    CostPrice = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    DTCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DTUpdated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockItem", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Image",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StockItemModelid = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Image", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Image_StockItem_StockItemModelid",
                        column: x => x.StockItemModelid,
                        principalTable: "StockItem",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StockAccessory",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StockItemModelid = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockAccessory", x => x.id);
                    table.ForeignKey(
                        name: "FK_StockAccessory_StockItem_StockItemModelid",
                        column: x => x.StockItemModelid,
                        principalTable: "StockItem",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Image_StockItemModelid",
                table: "Image",
                column: "StockItemModelid");

            migrationBuilder.CreateIndex(
                name: "IX_StockAccessory_StockItemModelid",
                table: "StockAccessory",
                column: "StockItemModelid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Image");

            migrationBuilder.DropTable(
                name: "StockAccessory");

            migrationBuilder.DropTable(
                name: "StockItem");
        }
    }
}
