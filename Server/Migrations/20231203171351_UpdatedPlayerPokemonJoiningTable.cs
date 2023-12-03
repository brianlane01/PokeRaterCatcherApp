using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonCatcherGame.Server.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedPlayerPokemonJoiningTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlayerPokemonEntity_PokemonMoves_MoveFourId",
                table: "PlayerPokemonEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_PlayerPokemonEntity_PokemonMoves_MoveOneId",
                table: "PlayerPokemonEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_PlayerPokemonEntity_PokemonMoves_MoveThreeId",
                table: "PlayerPokemonEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_PlayerPokemonEntity_PokemonMoves_MoveTwoId",
                table: "PlayerPokemonEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PlayerEntityPlayerPokemonEntity",
                table: "PlayerEntityPlayerPokemonEntity");

            migrationBuilder.DropIndex(
                name: "IX_PlayerEntityPlayerPokemonEntity_ActivePokemonId",
                table: "PlayerEntityPlayerPokemonEntity");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "PlayerEntityPlayerPokemonEntity");

            migrationBuilder.DropColumn(
                name: "PokedexNumber",
                table: "PlayerEntityPlayerPokemonEntity");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PlayerEntityPlayerPokemonEntity",
                table: "PlayerEntityPlayerPokemonEntity",
                columns: new[] { "ActivePokemonId", "PlayerId" });

            migrationBuilder.CreateIndex(
                name: "IX_PlayerEntityPlayerPokemonEntity_PlayerId",
                table: "PlayerEntityPlayerPokemonEntity",
                column: "PlayerId");

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerPokemonEntity_PokemonMoves_MoveFourId",
                table: "PlayerPokemonEntity",
                column: "MoveFourId",
                principalTable: "PokemonMoves",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerPokemonEntity_PokemonMoves_MoveOneId",
                table: "PlayerPokemonEntity",
                column: "MoveOneId",
                principalTable: "PokemonMoves",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerPokemonEntity_PokemonMoves_MoveThreeId",
                table: "PlayerPokemonEntity",
                column: "MoveThreeId",
                principalTable: "PokemonMoves",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerPokemonEntity_PokemonMoves_MoveTwoId",
                table: "PlayerPokemonEntity",
                column: "MoveTwoId",
                principalTable: "PokemonMoves",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlayerPokemonEntity_PokemonMoves_MoveFourId",
                table: "PlayerPokemonEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_PlayerPokemonEntity_PokemonMoves_MoveOneId",
                table: "PlayerPokemonEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_PlayerPokemonEntity_PokemonMoves_MoveThreeId",
                table: "PlayerPokemonEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_PlayerPokemonEntity_PokemonMoves_MoveTwoId",
                table: "PlayerPokemonEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PlayerEntityPlayerPokemonEntity",
                table: "PlayerEntityPlayerPokemonEntity");

            migrationBuilder.DropIndex(
                name: "IX_PlayerEntityPlayerPokemonEntity_PlayerId",
                table: "PlayerEntityPlayerPokemonEntity");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "PlayerEntityPlayerPokemonEntity",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PokedexNumber",
                table: "PlayerEntityPlayerPokemonEntity",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PlayerEntityPlayerPokemonEntity",
                table: "PlayerEntityPlayerPokemonEntity",
                columns: new[] { "PlayerId", "ActivePokemonId" });

            migrationBuilder.CreateIndex(
                name: "IX_PlayerEntityPlayerPokemonEntity_ActivePokemonId",
                table: "PlayerEntityPlayerPokemonEntity",
                column: "ActivePokemonId");

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerPokemonEntity_PokemonMoves_MoveFourId",
                table: "PlayerPokemonEntity",
                column: "MoveFourId",
                principalTable: "PokemonMoves",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerPokemonEntity_PokemonMoves_MoveOneId",
                table: "PlayerPokemonEntity",
                column: "MoveOneId",
                principalTable: "PokemonMoves",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerPokemonEntity_PokemonMoves_MoveThreeId",
                table: "PlayerPokemonEntity",
                column: "MoveThreeId",
                principalTable: "PokemonMoves",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerPokemonEntity_PokemonMoves_MoveTwoId",
                table: "PlayerPokemonEntity",
                column: "MoveTwoId",
                principalTable: "PokemonMoves",
                principalColumn: "Id");
        }
    }
}
