using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonCatcherGame.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddedQuantityColumnsToInventory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NumberOf",
                table: "PlayerItemInventories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfAntidotes",
                table: "PlayerItemInventories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfAwakening",
                table: "PlayerItemInventories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfBerryJuice",
                table: "PlayerItemInventories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfBurnHeals",
                table: "PlayerItemInventories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfCasteliacone",
                table: "PlayerItemInventories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfCherishBall",
                table: "PlayerItemInventories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfDiveBall",
                table: "PlayerItemInventories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfDuskBall",
                table: "PlayerItemInventories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfEnergyPowder",
                table: "PlayerItemInventories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfEnergyRoot",
                table: "PlayerItemInventories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfFineRemendy",
                table: "PlayerItemInventories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfFullHeals",
                table: "PlayerItemInventories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfGreatBalls",
                table: "PlayerItemInventories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfHealBall",
                table: "PlayerItemInventories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfHealPowder",
                table: "PlayerItemInventories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfHyperPotions",
                table: "PlayerItemInventories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfIceHeals",
                table: "PlayerItemInventories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfLavaCookie",
                table: "PlayerItemInventories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfLemonade",
                table: "PlayerItemInventories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfLumioseGalette",
                table: "PlayerItemInventories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfLuxuryBall",
                table: "PlayerItemInventories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfMasterBalls",
                table: "PlayerItemInventories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfMaxPotions",
                table: "PlayerItemInventories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfMaxRevives",
                table: "PlayerItemInventories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfMoomooMilk",
                table: "PlayerItemInventories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfNestBall",
                table: "PlayerItemInventories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfNetBall",
                table: "PlayerItemInventories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfOldGateau",
                table: "PlayerItemInventories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfParalyzeHeals",
                table: "PlayerItemInventories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfPokeBalls",
                table: "PlayerItemInventories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfPotions",
                table: "PlayerItemInventories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfPremierBall",
                table: "PlayerItemInventories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfQuickBall",
                table: "PlayerItemInventories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfRageCandyBar",
                table: "PlayerItemInventories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfRepeatBall",
                table: "PlayerItemInventories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfRevivalHerb",
                table: "PlayerItemInventories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfRevives",
                table: "PlayerItemInventories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfSacredAsh",
                table: "PlayerItemInventories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfSafariBall",
                table: "PlayerItemInventories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfShalourSable",
                table: "PlayerItemInventories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfSodaPop",
                table: "PlayerItemInventories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfSuperPotions",
                table: "PlayerItemInventories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfTimerBall",
                table: "PlayerItemInventories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfUltraBalls",
                table: "PlayerItemInventories",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberOf",
                table: "PlayerItemInventories");

            migrationBuilder.DropColumn(
                name: "NumberOfAntidotes",
                table: "PlayerItemInventories");

            migrationBuilder.DropColumn(
                name: "NumberOfAwakening",
                table: "PlayerItemInventories");

            migrationBuilder.DropColumn(
                name: "NumberOfBerryJuice",
                table: "PlayerItemInventories");

            migrationBuilder.DropColumn(
                name: "NumberOfBurnHeals",
                table: "PlayerItemInventories");

            migrationBuilder.DropColumn(
                name: "NumberOfCasteliacone",
                table: "PlayerItemInventories");

            migrationBuilder.DropColumn(
                name: "NumberOfCherishBall",
                table: "PlayerItemInventories");

            migrationBuilder.DropColumn(
                name: "NumberOfDiveBall",
                table: "PlayerItemInventories");

            migrationBuilder.DropColumn(
                name: "NumberOfDuskBall",
                table: "PlayerItemInventories");

            migrationBuilder.DropColumn(
                name: "NumberOfEnergyPowder",
                table: "PlayerItemInventories");

            migrationBuilder.DropColumn(
                name: "NumberOfEnergyRoot",
                table: "PlayerItemInventories");

            migrationBuilder.DropColumn(
                name: "NumberOfFineRemendy",
                table: "PlayerItemInventories");

            migrationBuilder.DropColumn(
                name: "NumberOfFullHeals",
                table: "PlayerItemInventories");

            migrationBuilder.DropColumn(
                name: "NumberOfGreatBalls",
                table: "PlayerItemInventories");

            migrationBuilder.DropColumn(
                name: "NumberOfHealBall",
                table: "PlayerItemInventories");

            migrationBuilder.DropColumn(
                name: "NumberOfHealPowder",
                table: "PlayerItemInventories");

            migrationBuilder.DropColumn(
                name: "NumberOfHyperPotions",
                table: "PlayerItemInventories");

            migrationBuilder.DropColumn(
                name: "NumberOfIceHeals",
                table: "PlayerItemInventories");

            migrationBuilder.DropColumn(
                name: "NumberOfLavaCookie",
                table: "PlayerItemInventories");

            migrationBuilder.DropColumn(
                name: "NumberOfLemonade",
                table: "PlayerItemInventories");

            migrationBuilder.DropColumn(
                name: "NumberOfLumioseGalette",
                table: "PlayerItemInventories");

            migrationBuilder.DropColumn(
                name: "NumberOfLuxuryBall",
                table: "PlayerItemInventories");

            migrationBuilder.DropColumn(
                name: "NumberOfMasterBalls",
                table: "PlayerItemInventories");

            migrationBuilder.DropColumn(
                name: "NumberOfMaxPotions",
                table: "PlayerItemInventories");

            migrationBuilder.DropColumn(
                name: "NumberOfMaxRevives",
                table: "PlayerItemInventories");

            migrationBuilder.DropColumn(
                name: "NumberOfMoomooMilk",
                table: "PlayerItemInventories");

            migrationBuilder.DropColumn(
                name: "NumberOfNestBall",
                table: "PlayerItemInventories");

            migrationBuilder.DropColumn(
                name: "NumberOfNetBall",
                table: "PlayerItemInventories");

            migrationBuilder.DropColumn(
                name: "NumberOfOldGateau",
                table: "PlayerItemInventories");

            migrationBuilder.DropColumn(
                name: "NumberOfParalyzeHeals",
                table: "PlayerItemInventories");

            migrationBuilder.DropColumn(
                name: "NumberOfPokeBalls",
                table: "PlayerItemInventories");

            migrationBuilder.DropColumn(
                name: "NumberOfPotions",
                table: "PlayerItemInventories");

            migrationBuilder.DropColumn(
                name: "NumberOfPremierBall",
                table: "PlayerItemInventories");

            migrationBuilder.DropColumn(
                name: "NumberOfQuickBall",
                table: "PlayerItemInventories");

            migrationBuilder.DropColumn(
                name: "NumberOfRageCandyBar",
                table: "PlayerItemInventories");

            migrationBuilder.DropColumn(
                name: "NumberOfRepeatBall",
                table: "PlayerItemInventories");

            migrationBuilder.DropColumn(
                name: "NumberOfRevivalHerb",
                table: "PlayerItemInventories");

            migrationBuilder.DropColumn(
                name: "NumberOfRevives",
                table: "PlayerItemInventories");

            migrationBuilder.DropColumn(
                name: "NumberOfSacredAsh",
                table: "PlayerItemInventories");

            migrationBuilder.DropColumn(
                name: "NumberOfSafariBall",
                table: "PlayerItemInventories");

            migrationBuilder.DropColumn(
                name: "NumberOfShalourSable",
                table: "PlayerItemInventories");

            migrationBuilder.DropColumn(
                name: "NumberOfSodaPop",
                table: "PlayerItemInventories");

            migrationBuilder.DropColumn(
                name: "NumberOfSuperPotions",
                table: "PlayerItemInventories");

            migrationBuilder.DropColumn(
                name: "NumberOfTimerBall",
                table: "PlayerItemInventories");

            migrationBuilder.DropColumn(
                name: "NumberOfUltraBalls",
                table: "PlayerItemInventories");
        }
    }
}
