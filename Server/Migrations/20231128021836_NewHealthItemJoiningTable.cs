using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonCatcherGame.Server.Migrations
{
    /// <inheritdoc />
    public partial class NewHealthItemJoiningTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "InventoryHealthItems",
                columns: table => new
                {
                    PlayerInventoryId = table.Column<int>(type: "int", nullable: false),
                    HealthItemId = table.Column<int>(type: "int", nullable: false),
                    ItemQuantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventoryHealthItems", x => new { x.PlayerInventoryId, x.HealthItemId });
                    table.ForeignKey(
                        name: "FK_InventoryHealthItems_HealthRestorationItems_HealthItemId",
                        column: x => x.HealthItemId,
                        principalTable: "HealthRestorationItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InventoryHealthItems_PlayerItemInventories_PlayerItemInventoryId",
                        column: x => x.PlayerInventoryId,
                        principalTable: "PlayerItemInventories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_InventoryHealthItems_HealthItemId",
                table: "InventoryHealthItems",
                column: "HealthItemId");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryHealthItems_PlayerItemInventoryId",
                table: "InventoryHealthItems",
                column: "PlayerInventoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InventoryHealthItems");
        }
    }
}
