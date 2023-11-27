using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonCatcherGame.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddedQuantityColumnsToInventory4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NumberOfFreshWater",
                table: "PlayerItemInventories",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberOfFreshWater",
                table: "PlayerItemInventories");
        }
    }
}
