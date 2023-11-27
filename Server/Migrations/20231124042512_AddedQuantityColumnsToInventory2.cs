using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonCatcherGame.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddedQuantityColumnsToInventory2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberOf",
                table: "PlayerItemInventories");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NumberOf",
                table: "PlayerItemInventories",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
