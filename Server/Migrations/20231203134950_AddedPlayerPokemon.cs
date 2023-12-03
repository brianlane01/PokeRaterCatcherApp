using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonCatcherGame.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddedPlayerPokemon : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PlayerPokemonEntity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PokedexNumber = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PokeNickName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Weight = table.Column<int>(type: "int", nullable: false),
                    Height = table.Column<int>(type: "int", nullable: false),
                    Health = table.Column<int>(type: "int", nullable: false),
                    BaseExperience = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PokeTypeIdOne = table.Column<int>(type: "int", nullable: false),
                    PokeTypeIdTwo = table.Column<int>(type: "int", nullable: true),
                    MoveOneId = table.Column<int>(type: "int", nullable: false),
                    MoveTwoId = table.Column<int>(type: "int", nullable: false),
                    MoveThreeId = table.Column<int>(type: "int", nullable: false),
                    MoveFourId = table.Column<int>(type: "int", nullable: false),
                    AbilityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerPokemonEntity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlayerPokemonEntity_PokemonAbilities_AbilityId",
                        column: x => x.AbilityId,
                        principalTable: "PokemonAbilities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayerPokemonEntity_PokemonMoves_MoveFourId",
                        column: x => x.MoveFourId,
                        principalTable: "PokemonMoves",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_PlayerPokemonEntity_PokemonMoves_MoveOneId",
                        column: x => x.MoveOneId,
                        principalTable: "PokemonMoves",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_PlayerPokemonEntity_PokemonMoves_MoveThreeId",
                        column: x => x.MoveThreeId,
                        principalTable: "PokemonMoves",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_PlayerPokemonEntity_PokemonMoves_MoveTwoId",
                        column: x => x.MoveTwoId,
                        principalTable: "PokemonMoves",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_PlayerPokemonEntity_PokemonTypes_PokeTypeIdOne",
                        column: x => x.PokeTypeIdOne,
                        principalTable: "PokemonTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayerPokemonEntity_PokemonTypes_PokeTypeIdTwo",
                        column: x => x.PokeTypeIdTwo,
                        principalTable: "PokemonTypes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PlayerEntityPlayerPokemonEntity",
                columns: table => new
                {
                    PlayerId = table.Column<int>(type: "int", nullable: false),
                    ActivePokemonId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PokedexNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerEntityPlayerPokemonEntity", x => new { x.PlayerId, x.ActivePokemonId });
                    table.ForeignKey(
                        name: "FK_PlayerEntityPlayerPokemonEntity_PlayerPokemonEntity_ActivePokemonId",
                        column: x => x.ActivePokemonId,
                        principalTable: "PlayerPokemonEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayerEntityPlayerPokemonEntity_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PlayerEntityPlayerPokemonEntity_ActivePokemonId",
                table: "PlayerEntityPlayerPokemonEntity",
                column: "ActivePokemonId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerPokemonEntity_AbilityId",
                table: "PlayerPokemonEntity",
                column: "AbilityId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerPokemonEntity_MoveFourId",
                table: "PlayerPokemonEntity",
                column: "MoveFourId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerPokemonEntity_MoveOneId",
                table: "PlayerPokemonEntity",
                column: "MoveOneId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerPokemonEntity_MoveThreeId",
                table: "PlayerPokemonEntity",
                column: "MoveThreeId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerPokemonEntity_MoveTwoId",
                table: "PlayerPokemonEntity",
                column: "MoveTwoId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerPokemonEntity_PokeTypeIdOne",
                table: "PlayerPokemonEntity",
                column: "PokeTypeIdOne");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerPokemonEntity_PokeTypeIdTwo",
                table: "PlayerPokemonEntity",
                column: "PokeTypeIdTwo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlayerEntityPlayerPokemonEntity");

            migrationBuilder.DropTable(
                name: "PlayerPokemonEntity");
        }
    }
}
