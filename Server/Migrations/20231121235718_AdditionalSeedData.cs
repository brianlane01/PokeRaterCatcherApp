using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonCatcherGame.Server.Migrations
{
    /// <inheritdoc />
    public partial class AdditionalSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HealthItemEntityPlayerItemInventoryEntity_HealthRestoratinItems_HealthItemsId",
                table: "HealthItemEntityPlayerItemInventoryEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_Players_PlayerItemInventories_ItemIventoryId",
                table: "Players");

            migrationBuilder.DropIndex(
                name: "IX_Players_ItemIventoryId",
                table: "Players");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HealthRestoratinItems",
                table: "HealthRestoratinItems");

            migrationBuilder.DropColumn(
                name: "ItemIventoryId",
                table: "Players");

            migrationBuilder.RenameTable(
                name: "HealthRestoratinItems",
                newName: "HealthRestorationItems");

            migrationBuilder.AddColumn<int>(
                name: "ItemInventoryId",
                table: "Players",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_HealthRestorationItems",
                table: "HealthRestorationItems",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Players_ItemInventoryId",
                table: "Players",
                column: "ItemInventoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_HealthItemEntityPlayerItemInventoryEntity_HealthRestorationItems_HealthItemsId",
                table: "HealthItemEntityPlayerItemInventoryEntity",
                column: "HealthItemsId",
                principalTable: "HealthRestorationItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Players_PlayerItemInventories_ItemInventoryId",
                table: "Players",
                column: "ItemInventoryId",
                principalTable: "PlayerItemInventories",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HealthItemEntityPlayerItemInventoryEntity_HealthRestorationItems_HealthItemsId",
                table: "HealthItemEntityPlayerItemInventoryEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_Players_PlayerItemInventories_ItemInventoryId",
                table: "Players");

            migrationBuilder.DropIndex(
                name: "IX_Players_ItemInventoryId",
                table: "Players");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HealthRestorationItems",
                table: "HealthRestorationItems");

            migrationBuilder.DropColumn(
                name: "ItemInventoryId",
                table: "Players");

            migrationBuilder.RenameTable(
                name: "HealthRestorationItems",
                newName: "HealthRestoratinItems");

            migrationBuilder.AddColumn<int>(
                name: "ItemIventoryId",
                table: "Players",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_HealthRestoratinItems",
                table: "HealthRestoratinItems",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Players_ItemIventoryId",
                table: "Players",
                column: "ItemIventoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_HealthItemEntityPlayerItemInventoryEntity_HealthRestoratinItems_HealthItemsId",
                table: "HealthItemEntityPlayerItemInventoryEntity",
                column: "HealthItemsId",
                principalTable: "HealthRestoratinItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Players_PlayerItemInventories_ItemIventoryId",
                table: "Players",
                column: "ItemIventoryId",
                principalTable: "PlayerItemInventories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
