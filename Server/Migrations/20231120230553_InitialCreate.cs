using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PokemonCatcherGame.Server.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeviceCodes",
                columns: table => new
                {
                    UserCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DeviceCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    SubjectId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SessionId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ClientId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Expiration = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Data = table.Column<string>(type: "nvarchar(max)", maxLength: 50000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceCodes", x => x.UserCode);
                });

            migrationBuilder.CreateTable(
                name: "HealthRestoratinItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HealthItemName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    HealthItemDescription = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    AmountOfHealthRestored = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthRestoratinItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Keys",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Version = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Use = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Algorithm = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsX509Certificate = table.Column<bool>(type: "bit", nullable: false),
                    DataProtected = table.Column<bool>(type: "bit", nullable: false),
                    Data = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Keys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Opponents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OpponentName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Opponents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersistedGrants",
                columns: table => new
                {
                    Key = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SubjectId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SessionId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ClientId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Expiration = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ConsumedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Data = table.Column<string>(type: "nvarchar(max)", maxLength: 50000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersistedGrants", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "PlayerItemInventories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameOfPlayer = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerItemInventories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PokeBalls",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameOfBall = table.Column<string>(type: "nvarchar(55)", maxLength: 55, nullable: false),
                    DescriptionOfPokeBall = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    CatchRate = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokeBalls", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PokemonAbilities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AbilityName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AbilityEffect = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonAbilities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PokemonTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PokeType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReviveItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RejuvenationItemName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    RejuvenationItemDescription = table.Column<string>(type: "nvarchar(800)", maxLength: 800, nullable: false),
                    ReviveHealthAmount = table.Column<double>(type: "float", nullable: false),
                    ReviveAllFaintedPokemon = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReviveItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StatusConditionItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusConditionItemName = table.Column<string>(type: "nvarchar(65)", maxLength: 65, nullable: false),
                    StatusConditionItemDescription = table.Column<string>(type: "nvarchar(800)", maxLength: 800, nullable: false),
                    RemovesSleep = table.Column<bool>(type: "bit", nullable: false),
                    RemovesParalysis = table.Column<bool>(type: "bit", nullable: false),
                    RemovesFreeze = table.Column<bool>(type: "bit", nullable: false),
                    RemovesPoison = table.Column<bool>(type: "bit", nullable: false),
                    RemovesBurn = table.Column<bool>(type: "bit", nullable: false),
                    RemovesConfusion = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusConditionItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StatusConditions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusConditionName = table.Column<string>(type: "nvarchar(55)", maxLength: 55, nullable: false),
                    StatusConditionDescription = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    ConditionDoesDamage = table.Column<bool>(type: "bit", nullable: false),
                    DamageAmount = table.Column<double>(type: "float", nullable: false),
                    DamageFrequency = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParalysisEffect = table.Column<bool>(type: "bit", nullable: false),
                    BurnEffect = table.Column<bool>(type: "bit", nullable: false),
                    FreezeEffect = table.Column<bool>(type: "bit", nullable: false),
                    SleepEffect = table.Column<bool>(type: "bit", nullable: false),
                    PoisonEffect = table.Column<bool>(type: "bit", nullable: false),
                    ConfusionEffect = table.Column<bool>(type: "bit", nullable: false),
                    ConditionDuration = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusConditions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HealthItemEntityPlayerItemInventoryEntity",
                columns: table => new
                {
                    HealthItemsId = table.Column<int>(type: "int", nullable: false),
                    PlayerInventoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthItemEntityPlayerItemInventoryEntity", x => new { x.HealthItemsId, x.PlayerInventoryId });
                    table.ForeignKey(
                        name: "FK_HealthItemEntityPlayerItemInventoryEntity_HealthRestoratinItems_HealthItemsId",
                        column: x => x.HealthItemsId,
                        principalTable: "HealthRestoratinItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HealthItemEntityPlayerItemInventoryEntity_PlayerItemInventories_PlayerInventoryId",
                        column: x => x.PlayerInventoryId,
                        principalTable: "PlayerItemInventories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ItemIventoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Players_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Players_PlayerItemInventories_ItemIventoryId",
                        column: x => x.ItemIventoryId,
                        principalTable: "PlayerItemInventories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlayerItemInventoryEntityPokeBallEntity",
                columns: table => new
                {
                    PlayerInventoryId = table.Column<int>(type: "int", nullable: false),
                    PokeBallsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerItemInventoryEntityPokeBallEntity", x => new { x.PlayerInventoryId, x.PokeBallsId });
                    table.ForeignKey(
                        name: "FK_PlayerItemInventoryEntityPokeBallEntity_PlayerItemInventories_PlayerInventoryId",
                        column: x => x.PlayerInventoryId,
                        principalTable: "PlayerItemInventories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayerItemInventoryEntityPokeBallEntity_PokeBalls_PokeBallsId",
                        column: x => x.PokeBallsId,
                        principalTable: "PokeBalls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlayerItemInventoryEntityRejuvenationItemEntity",
                columns: table => new
                {
                    PlayerInventoryId = table.Column<int>(type: "int", nullable: false),
                    ReviveItemsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerItemInventoryEntityRejuvenationItemEntity", x => new { x.PlayerInventoryId, x.ReviveItemsId });
                    table.ForeignKey(
                        name: "FK_PlayerItemInventoryEntityRejuvenationItemEntity_PlayerItemInventories_PlayerInventoryId",
                        column: x => x.PlayerInventoryId,
                        principalTable: "PlayerItemInventories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayerItemInventoryEntityRejuvenationItemEntity_ReviveItems_ReviveItemsId",
                        column: x => x.ReviveItemsId,
                        principalTable: "ReviveItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlayerItemInventoryEntityStatusConditionItemEntity",
                columns: table => new
                {
                    PlayerInventoryId = table.Column<int>(type: "int", nullable: false),
                    RemoveStatusConditionItemsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerItemInventoryEntityStatusConditionItemEntity", x => new { x.PlayerInventoryId, x.RemoveStatusConditionItemsId });
                    table.ForeignKey(
                        name: "FK_PlayerItemInventoryEntityStatusConditionItemEntity_PlayerItemInventories_PlayerInventoryId",
                        column: x => x.PlayerInventoryId,
                        principalTable: "PlayerItemInventories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayerItemInventoryEntityStatusConditionItemEntity_StatusConditionItems_RemoveStatusConditionItemsId",
                        column: x => x.RemoveStatusConditionItemsId,
                        principalTable: "StatusConditionItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PokemonMoves",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PokeApiMoveId = table.Column<int>(type: "int", nullable: false),
                    MoveName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MoveDescription = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Accuracy = table.Column<int>(type: "int", nullable: true),
                    MoveBasePP = table.Column<int>(type: "int", nullable: false),
                    MovePower = table.Column<int>(type: "int", nullable: true),
                    MoveType = table.Column<string>(type: "nvarchar(55)", maxLength: 55, nullable: false),
                    MoveRestoresHealth = table.Column<bool>(type: "bit", nullable: false),
                    HealthRestorationAmount = table.Column<int>(type: "int", nullable: false),
                    MoveAppliesAStatusCondition = table.Column<bool>(type: "bit", nullable: false),
                    StatusConditionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonMoves", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PokemonMoves_StatusConditions_StatusConditionId",
                        column: x => x.StatusConditionId,
                        principalTable: "StatusConditions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TMs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TMNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MoveName = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    MoveDescription = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    MoveBasePP = table.Column<int>(type: "int", nullable: false),
                    MovePower = table.Column<int>(type: "int", nullable: false),
                    MoveAccuracy = table.Column<int>(type: "int", nullable: false),
                    MoveType = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    MoveRestoresHealth = table.Column<bool>(type: "bit", nullable: false),
                    HealthRestorationAmount = table.Column<int>(type: "int", nullable: false),
                    MoveAppliesAStatusCondition = table.Column<bool>(type: "bit", nullable: false),
                    StatusConditionId = table.Column<int>(type: "int", nullable: false),
                    PsychicCanLearn = table.Column<bool>(type: "bit", nullable: false),
                    FireCanLearn = table.Column<bool>(type: "bit", nullable: false),
                    GrassCanLearn = table.Column<bool>(type: "bit", nullable: false),
                    ElectricCanLearn = table.Column<bool>(type: "bit", nullable: false),
                    FightingCanLearn = table.Column<bool>(type: "bit", nullable: false),
                    FairyCanLearn = table.Column<bool>(type: "bit", nullable: false),
                    DragonCanLearn = table.Column<bool>(type: "bit", nullable: false),
                    PoisonCanLearn = table.Column<bool>(type: "bit", nullable: false),
                    BugCanLearn = table.Column<bool>(type: "bit", nullable: false),
                    WaterCanLearn = table.Column<bool>(type: "bit", nullable: false),
                    RockCanLearn = table.Column<bool>(type: "bit", nullable: false),
                    GroundCanLearn = table.Column<bool>(type: "bit", nullable: false),
                    GhostCanLearn = table.Column<bool>(type: "bit", nullable: false),
                    DarkCanLearn = table.Column<bool>(type: "bit", nullable: false),
                    SteelCanLearn = table.Column<bool>(type: "bit", nullable: false),
                    NormalCanLearn = table.Column<bool>(type: "bit", nullable: false),
                    IceCanLearn = table.Column<bool>(type: "bit", nullable: false),
                    FlyingCanLearn = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TMs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TMs_StatusConditions_StatusConditionId",
                        column: x => x.StatusConditionId,
                        principalTable: "StatusConditions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pokemon",
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
                    table.PrimaryKey("PK_Pokemon", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pokemon_PokemonAbilities_AbilityId",
                        column: x => x.AbilityId,
                        principalTable: "PokemonAbilities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pokemon_PokemonMoves_MoveFourId",
                        column: x => x.MoveFourId,
                        principalTable: "PokemonMoves",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Pokemon_PokemonMoves_MoveOneId",
                        column: x => x.MoveOneId,
                        principalTable: "PokemonMoves",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Pokemon_PokemonMoves_MoveThreeId",
                        column: x => x.MoveThreeId,
                        principalTable: "PokemonMoves",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Pokemon_PokemonMoves_MoveTwoId",
                        column: x => x.MoveTwoId,
                        principalTable: "PokemonMoves",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Pokemon_PokemonTypes_PokeTypeIdOne",
                        column: x => x.PokeTypeIdOne,
                        principalTable: "PokemonTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pokemon_PokemonTypes_PokeTypeIdTwo",
                        column: x => x.PokeTypeIdTwo,
                        principalTable: "PokemonTypes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PlayerItemInventoryEntityTechnicalMachineMoveEntity",
                columns: table => new
                {
                    PlayerInventoryId = table.Column<int>(type: "int", nullable: false),
                    TMsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerItemInventoryEntityTechnicalMachineMoveEntity", x => new { x.PlayerInventoryId, x.TMsId });
                    table.ForeignKey(
                        name: "FK_PlayerItemInventoryEntityTechnicalMachineMoveEntity_PlayerItemInventories_PlayerInventoryId",
                        column: x => x.PlayerInventoryId,
                        principalTable: "PlayerItemInventories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayerItemInventoryEntityTechnicalMachineMoveEntity_TMs_TMsId",
                        column: x => x.TMsId,
                        principalTable: "TMs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlayerEntityPokemonEntity",
                columns: table => new
                {
                    CaughtPokemonId = table.Column<int>(type: "int", nullable: false),
                    PlayerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerEntityPokemonEntity", x => new { x.CaughtPokemonId, x.PlayerId });
                    table.ForeignKey(
                        name: "FK_PlayerEntityPokemonEntity_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayerEntityPokemonEntity_Pokemon_CaughtPokemonId",
                        column: x => x.CaughtPokemonId,
                        principalTable: "Pokemon",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PokemonEntityTrainerOpponentEntity",
                columns: table => new
                {
                    OpponentsId = table.Column<int>(type: "int", nullable: false),
                    UsablePokemonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonEntityTrainerOpponentEntity", x => new { x.OpponentsId, x.UsablePokemonId });
                    table.ForeignKey(
                        name: "FK_PokemonEntityTrainerOpponentEntity_Opponents_OpponentsId",
                        column: x => x.OpponentsId,
                        principalTable: "Opponents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PokemonEntityTrainerOpponentEntity_Pokemon_UsablePokemonId",
                        column: x => x.UsablePokemonId,
                        principalTable: "Pokemon",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "HealthRestoratinItems",
                columns: new[] { "Id", "AmountOfHealthRestored", "HealthItemDescription", "HealthItemName" },
                values: new object[,]
                {
                    { 1001, 20.0, "A spray-type medicine for treating wounds. It can be used to restore 20 HP to a single Pokémon.", "Potion" },
                    { 1002, 60.0, "A spray-type medicine for treating wounds. It can be used to restore 60 HP to a single Pokémon.", "Super Potion" },
                    { 1003, 120.0, "A spray-type medicine for treating wounds. It can be used to restore 120 HP to a single Pokémon.", "Hyper Potion" },
                    { 1004, 350.0, "A spray-type medicine for treating wounds. It can be used to completely restore the max HP of a single Pokémon.", "Max Potion" },
                    { 1005, 350.0, "A medicine that can be used to fully restore the HP of a single Pokémon and heal any status conditions it has.", "Full Restore" },
                    { 1006, 50.0, "A very bitter medicine powder. It restores the HP of one Pokémon by just 50 points.", "Energy Powder" },
                    { 1007, 200.0, "A very bitter medicine root. It restores the HP of one Pokémon by 200 points.", "Energy Root" },
                    { 1008, 0.0, "A very bitter medicine powder. It heals all the status conditions of a single Pokémon.", "Heal Powder" },
                    { 1009, 50.0, "Water with a high mineral content. It restores the HP of one Pokémon by 50 points.", "Fresh Water" },
                    { 1010, 60.0, "A fizzy soda drink. It restores the HP of one Pokémon by 60 points.", "Soda Pop" },
                    { 1011, 80.0, "A very sweet drink. It restores the HP of one Pokémon by 80 points.", "Lemonade" },
                    { 1012, 100.0, "Milk with a very high nutrition content. It restores the HP of one Pokémon by 100 points.", "Moomoo Milk" },
                    { 1013, 20.0, "A 100% pure juice made of Berries. It restores the HP of one Pokémon by 20 points.", "Berry Juice" },
                    { 1014, 100.0, "An herbal medicine that can restore 100 HP to a Pokémon, just as a Super Potion does. Yet the bitter taste will make the Pokémon less friendly toward you.", "Fine Remedy" }
                });

            migrationBuilder.InsertData(
                table: "PokeBalls",
                columns: new[] { "Id", "CatchRate", "DescriptionOfPokeBall", "NameOfBall" },
                values: new object[,]
                {
                    { 1001, 0.25, "Used in battle : Attempts to catch a wild Pokémon, using a catch rate of 1x. If used in a trainer battle, nothing happens and the ball is lost.", "Poke Ball" },
                    { 1002, 0.5, "Used in battle : Attempts to catch a wild Pokémon, using a catch rate of 1.5x. If used in a trainer battle, nothing happens and the ball is lost.", "Great Ball" },
                    { 1003, 0.75, "Used in battle : Attempts to catch a wild Pokémon, using a catch rate of 2x. If used in a trainer battle, nothing happens and the ball is lost.", "Ultra Ball" },
                    { 1004, 100.0, "Used in battle : Catches a wild Pokémon without fail. If used in a trainer battle, nothing happens and the ball is lost.", "Master Ball" },
                    { 1005, 0.5, "Used in battle : Attempts to catch a wild Pokémon, using a catch rate of 1.5x. This item can only be used in the great marsh or kanto safari zone.", "Safari Ball" },
                    { 1006, 1.25, "Used in battle : Attempts to catch a wild Pokémon. If the wild Pokémon is water- or bug-type, this ball has a catch rate of 3x. Otherwise, it has a catch rate of 1x. If used in a trainer battle, nothing happens and the ball is lost.", "Net Ball" },
                    { 1007, 1.5, "Used in battle : Attempts to catch a wild Pokémon. If the wild Pokémon was encountered by surfing or fishing, this ball has a catch rate of 3.5x. Otherwise, it has a catch rate of 1x. If used in a trainer battle, nothing happens and the ball is lost.", "Dive Ball" },
                    { 1008, 1.8500000000000001, "Attempts to catch a wild Pokémon. Has a catch rate of given by `(40 - level) / 10`, where `level` is the wild Pokémon's level, to a maximum of 3.9xfor level 1 Pokémon. If the wild Pokémon's level is higher than 30, this ball has a catch rate of 1x.", "Nest Ball" },
                    { 1009, 1.25, "Used in battle : Attempts to catch a wild Pokémon. If the wild Pokémon's species is marked as caught in the trainer's Pokédex, this ball has a catch rate of 3x. Otherwise, it has a catch rate of 1x. If used in a trainer battle, nothing happens and the ball is lost.", "Repeat Ball" },
                    { 1010, 1.25, "Used in battle : Attempts to catch a wild Pokémon. Has a catch rate of 1.1x on the first turn of the battle and increases by 0.1x every turn, to a maximum of 4xon turn 30. If used in a trainer battle, nothing happens and the ball is lost.", "Timer ball" },
                    { 1011, 0.25, "Used in battle : Attempts to catch a wild Pokémon, using a catch rate of 1x. Whenever the caught Pokémon's happiness increases, it increases by one extra point. If used in a trainer battle, nothing happens and the ball is lost.", "Luxury Ball" },
                    { 1012, 0.25, "Used in battle : Attempts to catch a wild Pokémon, using a catch rate of 1×. If used in a trainer battle, nothing happens and the ball is lost.", "Premier Ball" },
                    { 1013, 1.5, "Used in battle : Attempts to catch a wild Pokémon. If it's currently nighttime or the wild Pokémon was encountered while walking in a cave, this ball has a catch rate of 3.5×. Otherwise, it has a catch rate of 1×. If used in a trainer battle, nothing happens and the ball is lost.", "Dusk Ball" },
                    { 1014, 0.25, "Used in battle : Attempts to catch a wild Pokémon, using a catch rate of 1×. The caught Pokémon's HP is immediately restored, PP for all its moves is restored, and any status ailment is cured. If used in a trainer battle, nothing happens and the ball is lost.", "Heal Ball" },
                    { 1015, 2.0, "Used in battle : Attempts to catch a wild Pokémon, using a catch rate of 4× on the first turn of a battle, but 1× any other time. If used in a trainer battle, nothing happens and the ball is lost.", "Quick Ball" },
                    { 1016, 0.25, "Used in battle : Attempts to catch a wild Pokémon, using a catch rate of 1×. If used in a trainer battle, nothing happens and the ball is lost.", "Cherish Ball" }
                });

            migrationBuilder.InsertData(
                table: "PokemonAbilities",
                columns: new[] { "Id", "AbilityEffect", "AbilityName" },
                values: new object[,]
                {
                    { 1000, "This Pokémon's damaging moves have a 10% chance to make the target flinch with each hit if they do not already cause flinching as a secondary effect. This ability does not stack with a held item. Overworld: The wild encounter rate is halved while this Pokémon is first in the party.", "Stench" },
                    { 1001, "The weather changes to rain when this Pokémon enters battle and does not end unless replaced by another weather condition. If multiple Pokémon with this ability, drought, sand stream, or snow warning are sent out at the same time, the abilities will activate in order of Speed, respecting trick room. Each ability's weather will cancel the previous weather, and only the weather summoned by the slowest of the Pokémon will stay.", "Drizzle" },
                    { 1002, "This Pokémon's Speed rises one stage after each turn.", "Speed-Boost" },
                    { 1003, "This Pokémon's Speed rises one stage after each turn.", "Battle-Armor" },
                    { 1004, "When this Pokémon is at full HP, any hit that would knock it out will instead leave it with 1 HP. Regardless of its current HP, it is also immune to the one-hit KO moves: fissure, guillotine, horn drill, and sheer cold. If this Pokémon is holding a focus sash, this ability takes precedence and the item will not be consumed.", "Sturdy" },
                    { 1005, "While this Pokémon is in battle, self destruct and explosion will fail and aftermath will not take effect.", "Damp" },
                    { 1006, "During a sandstorm, this Pokémon has 1.25xits evasion, and it does not take sandstorm damage regardless of type. The evasion bonus does not count as a stat modifier. Overworld: If the lead Pokémon has this ability, the wild encounter rate is halved in a sandstorm.", "Sand-Veil" },
                    { 1007, "Whenever a move makes contact with this Pokémon, the move's user has a 30% chance of being paralyzed. Pokémon that are immune to electric-type moves can still be paralyzed by this ability. Overworld: If the lead Pokémon has this ability, there is a 50% chance that encounters will be with an electric Pokémon, if applicable.", "Static" },
                    { 1008, "Whenever an electric-type move hits this Pokémon, it heals for 1/4 of its maximum HP, negating any other effect on it. This ability will not take effect if this Pokémon is ground-type and thus immune to Electric moves. Electric moves will ignore this Pokémon's substitute. This effect includes non-damaging moves, i.e. thunder wave.", "Volt-Absorb" },
                    { 1009, "Whenever a water-type move hits this Pokémon, it heals for 1/4 of its maximum HP, negating any other effect on it. Water moves will ignore this Pokémon's substitute.", "Water-Absorb" },
                    { 1010, "Whenever a water-type move hits this Pokémon, it heals for 1/4 of its maximum HP, negating any other effect on it. Water moves will ignore this Pokémon's substitute.", "Water-Absorb" },
                    { 1011, "This Pokémon cannot be infatuated and is immune to captivate. If a Pokémon is infatuated and acquires this ability, its infatuation is cleared.", "Oblivious" },
                    { 1012, "This Pokémon's moves have 1.3xtheir accuracy. This ability has no effect on the one-hit KO moves (fissure, guillotine, horn drill, and sheer cold). Overworld: If the first Pokémon in the party has this ability, the chance of a wild Pokémon holding a particular item is raised from 50%, 5%, or 1% to 60%, 20%, or 5%, respectively.", "Compound-Eyes" },
                    { 1013, "This Pokémon cannot be asleep. This causes rest to fail altogether. If a Pokémon is asleep and acquires this ability, it will immediately wake up; this includes when regaining a lost ability upon leaving battle. This ability functions identically to vital spirit in battle.", "Insomnia" },
                    { 1014, "Whenever this Pokémon takes damage from a move, the Pokémon's type changes to match the move. If the Pokémon has two types, both are overridden. The Pokémon must directly take damage; for example, moves blocked by a substitute will not trigger this ability, nor will moves that deal damage indirectly, such as spikes. This ability takes effect on only the last hit of a multiple-hit attack.", "Color-Change" },
                    { 1015, "This Pokémon cannot be poisoned. This includes bad poison. If a Pokémon is poisoned and acquires this ability, its poison is healed; this includes when regaining a lost ability upon leaving battle.", "Immunity" },
                    { 1016, "This Pokémon is immune to fire-type moves. Once this Pokémon has been hit by a Fire move, its own Fire moves will inflict 1.5xas much damage until it leaves battle. This ability has no effect while the Pokémon is frozen. The Fire damage bonus is retained even if the Pokémon is frozen and thawed or the ability is lost or disabled. Fire moves will ignore this Pokémon's substitute. This ability takes effect even on non-damaging moves, i.e. will o wisp.", "Flash-Fire" },
                    { 1017, "This Pokémon cannot be confused. If a Pokémon is confused and acquires this ability, its confusion will immediately be healed.", "Own-Tempo" },
                    { 1018, "When this Pokémon enters battle, the opponent's Attack is lowered by one stage. In a double battle, both opponents are affected. This ability also takes effect when acquired during a battle, but will not take effect again if lost and reobtained without leaving battle. This ability has no effect on an opponent that has a substitute. Overworld: If the first Pokémon in the party has this ability, any random encounter with a Pokémon five or more levels lower than it has a 50% chance of being skipped.", "Intimidate" },
                    { 1019, "Whenever a move makes contact with this Pokémon, the move's user takes 1/8 of its maximum HP in damage. This ability functions identically to iron barbs.", "Rough-Skin" },
                    { 1020, "This Pokémon is immune to ground-type moves, spikes, toxic spikes, and arena trap. This ability is disabled during gravity or ingrain, or while holding an iron ball. This ability is not disabled during roost.", "Levitate" },
                    { 1021, "Whenever a move makes contact with this Pokémon, the move's user has a 30% chance of being paralyzed, poisoned, or put to sleep, chosen at random. Nothing is done to compensate if the move's user is immune to one of these ailments; there is simply a lower chance that the move's user will be affected.", "Effect-Spore" },
                    { 1022, "Whenever this Pokémon is burned, paralyzed, or poisoned, the Pokémon who gave this Pokémon that ailment is also given the ailment. This ability passes back bad poison when this Pokémon is badly poisoned. This ability cannot pass on a status ailment that the Pokémon did not directly receive from another Pokémon, such as the poison from toxic spikes or the burn from a flame orb. Overworld: If the lead Pokémon has this ability, wild Pokémon have a 50% chance of having the lead Pokémon's nature, and a 50% chance of being given a random nature as usual, including the lead Pokémon's nature. This does not work on Pokémon received outside of battle or roaming legendaries.", "Synchronize" },
                    { 1023, "This Pokémon is cured of any major status ailment when it is switched out for another Pokémon. If this ability is acquired during battle, the Pokémon is cured upon leaving battle before losing the temporary ability.", "Natural-Cure" },
                    { 1024, "This Pokémon's Speed is doubled during strong sunlight. This bonus does not count as a stat modifier.", "Chlorophyll" },
                    { 1025, "When this Pokémon enters battle, it copies a random opponent's ability. This ability cannot copy flower gift, forecast, illusion, imposter, multitype, trace, wonder guard, or zen mode.", "Trace" },
                    { 1026, "This Pokémon's Attack is doubled while in battle. This bonus does not count as a stat modifier. This ability functions identically to pure power.", "Huge-Power" },
                    { 1027, "Whenever a move makes contact with this Pokémon, the move's user has a 30% chance of being poisoned.", "Poison-Point" },
                    { 1028, "This Pokémon cannot flinch.", "Inner-Focus" },
                    { 1029, "This Pokémon cannot be frozen. If a Pokémon is frozen and acquires this ability, it will immediately thaw out; this includes when regaining a lost ability upon leaving battle. Overworld: If any Pokémon in the party has this ability, each egg in the party has its hatch counter decreased by 2 (rather than 1) each step cycle, making eggs hatch roughly twice as quickly. This effect does not stack if multiple Pokémon have this ability or flame body.", "Magma-Armor" },
                    { 1030, "This Pokémon cannot be burned. If a Pokémon is burned and acquires this ability, its burn is healed; this includes when regaining a lost ability upon leaving battle.", "Water-Veil" },
                    { 1031, "This Pokémon heals for 1/16 of its maximum HP after each turn during rain.", "Rain-Dish" },
                    { 1032, "Moves targetting this Pokémon use one extra PP. This ability stacks if multiple targets have it. This ability still affects moves that fail or miss. This ability does not affect ally moves that target either the entire field or just its side, nor this Pokémon's self-targetted moves; it does, however, affect single-targetted ally moves aimed at this Pokémon, ally moves that target all other Pokémon, and opponents' moves that target the entire field. If this ability raises a move's PP cost above its remaining PP, it will use all remaining PP. When this Pokémon enters battle, all participating trainers are notified that it has this ability. Overworld: If the lead Pokémon has this ability, higher-levelled Pokémon have their encounter rate increased.", "Pressure" },
                    { 1033, "Whenever a move makes contact with this Pokémon, the move's user has a 30% chance of being burned. Overworld: If any Pokémon in the party has this ability, each egg in the party has its hatch counter decreased by 2 (rather than 1) each step cycle, making eggs hatch roughly twice as quickly. This effect does not stack if multiple Pokémon have this ability or magma armor.", "Flame-Body" },
                    { 1034, "This Pokémon cannot have its accuracy lowered. This ability does not prevent any accuracy losses other than stat modifiers, such as the accuracy cut from fog; nor does it prevent other Pokémon's evasion from making this Pokémon's moves less accurate. This Pokémon can still be passed negative accuracy modifiers through heart swap. Overworld: If the first Pokémon in the party has this ability, any random encounter with a Pokémon five or more levels lower than it has a 50% chance of being skipped.", "Keen-Eye" },
                    { 1035, "Every second turn on which this Pokémon should attempt to use a move, it will instead do nothing (loaf around). Loafing around interrupts moves that take multiple turns the same way paralysis, flinching, etc do. Most such moves, for example bide or rollout, are simply cut off upon loafing around. Attacks with a recharge turn, such as hyper beam, do not have to recharge; attacks with a preparation turn, such as fly, do not end up being used. Moves that are forced over multiple turns and keep going through failure, such as outrage, uproar, or any move forced by encore, keep going as usual. If this Pokémon is confused, its confusion is not checked when loafing around; the Pokémon cannot hurt itself, and its confusion does not end or come closer to ending. If this Pokémon attempts to move but fails, e.g. because of paralysis or gravity, it still counts as having moved and will loaf around the next turn. If it does not attempt to move, e.g. because it is asleep or frozen, whatever it would have done will be postponed until its next attempt; that is, it will either loaf around or move as usual, depending on what it last did. This ability cannot be changed with worry seed, but it can be disabled with gastro acid, changed with role play, or traded away with skill swap.", "Truant" },
                    { 1036, "After each turn, this Pokémon has a 33% of being cured of any major status ailment.", "Shed-Skin" },
                    { 1037, "Whenever a Pokémon would heal after hitting this Pokémon with a leeching move like absorb, it instead loses as many HP as it would usually gain. dream eater is unaffected.", "Liquid-Ooze" },
                    { 1038, "Whenever a Pokémon would heal after hitting this Pokémon with a leeching move like absorb, it instead loses as many HP as it would usually gain. dream eater is unaffected.", "Liquid-Ooze" }
                });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "Id", "PokeType" },
                values: new object[,]
                {
                    { 1000, "Normal" },
                    { 1001, "Fighting" },
                    { 1002, "Flying" },
                    { 1003, "Poison" },
                    { 1004, "Ground" },
                    { 1005, "Rock" },
                    { 1006, "Bug" },
                    { 1007, "Ghost" },
                    { 1008, "Steel" },
                    { 1009, "Fire" },
                    { 1010, "Water" },
                    { 1011, "Grass" },
                    { 1012, "Electric" },
                    { 1013, "Psychic" },
                    { 1014, "Ice" },
                    { 1015, "Dragon" },
                    { 1016, "Dark" },
                    { 1017, "Fairy" },
                    { 1018, "None" }
                });

            migrationBuilder.InsertData(
                table: "ReviveItems",
                columns: new[] { "Id", "RejuvenationItemDescription", "RejuvenationItemName", "ReviveAllFaintedPokemon", "ReviveHealthAmount" },
                values: new object[,]
                {
                    { 1001, "A medicine that can revive fainted Pokémon. It also restores a small portion of a fainted Pokémon's maximum HP.", "Revive", false, 100.0 },
                    { 1002, "A medicine that can revive fainted Pokémon. It also fully restores a fainted Pokémon's maximum HP.", "Max Revive", false, 350.0 },
                    { 1003, "A terribly bitter medicine. It revives a fainted Pokémon, fully restoring its HP.", "Revival Herb", false, 350.0 },
                    { 1004, "A sacred medicine used to revive fainted Pokémon. It fully restores the HP of all fainted Pokémon.", "Sacred Ash", true, 350.0 }
                });

            migrationBuilder.InsertData(
                table: "StatusConditionItems",
                columns: new[] { "Id", "RemovesBurn", "RemovesConfusion", "RemovesFreeze", "RemovesParalysis", "RemovesPoison", "RemovesSleep", "StatusConditionItemDescription", "StatusConditionItemName" },
                values: new object[,]
                {
                    { 1001, false, false, false, false, true, false, "A spray-type medicine. It lifts the effects of poison from one Pokémon.", "Antidote" },
                    { 1002, true, false, false, false, false, false, "A spray-type medicine. It heals a single Pokémon that is suffering from a burn.", "Burn Heal" },
                    { 1003, false, false, true, false, false, false, "A spray-type medicine. It defrosts a Pokémon that has been frozen solid.", "Ice Heal" },
                    { 1004, false, false, false, true, false, false, "A spray-type medicine. It eliminates paralysis from a single Pokémon.", "Paralyze Heal" },
                    { 1005, false, false, false, false, false, true, "A spray-type medicine. It awakens a single Pokémon that is asleep.", "Awakening" },
                    { 1006, true, true, true, true, true, true, "A spray-type medicine. It heals all the status conditions of a single Pokémon.", "Full Heal" },
                    { 1007, true, true, true, true, true, true, "A medicine that can be used to fully restore the HP and heal any status conditions of a single Pokémon.", "Full Restore" },
                    { 1008, true, true, true, true, true, true, "A cookie packed with the energy of Mt. Chimney. It heals all the status conditions of a single Pokémon.", "Lava Cookie" },
                    { 1009, true, true, true, true, true, true, "A dessert that's too rich and sweet for most people to finish. It heals all the status conditions of a single Pokémon.", "Old Gateau" },
                    { 1010, true, true, true, true, true, true, "A popular treat in Castelia City. It heals all the status conditions of a single Pokémon.", "Casteliacone" },
                    { 1011, true, true, true, true, true, true, "A candy bar that was produced to commemorate an ancient city. It heals all the status conditions of a single Pokémon.", "Rage Candy Bar" },
                    { 1012, true, true, true, true, true, true, "A cookie made in the hilly city of Shalour. It heals all the status conditions of a single Pokémon.", "Shalour Sable" },
                    { 1013, true, true, true, true, true, true, "A cookie made in the hilly city of Shalour. It heals all the status conditions of a single Pokémon.", "Lumiose Galette" },
                    { 1014, true, true, true, true, true, true, "A cookie made in the hilly city of Shalour. It heals all the status conditions of a single Pokémon.", "Shalour Sable" }
                });

            migrationBuilder.InsertData(
                table: "StatusConditions",
                columns: new[] { "Id", "BurnEffect", "ConditionDoesDamage", "ConditionDuration", "ConfusionEffect", "DamageAmount", "DamageFrequency", "FreezeEffect", "ParalysisEffect", "PoisonEffect", "SleepEffect", "StatusConditionDescription", "StatusConditionName" },
                values: new object[,]
                {
                    { 1001, false, false, "The affect lasts four turns, unless it is removed by an item.", false, 0.0, "Last for four turns.", false, true, false, false, "The Pokémon afflicted Speed stat is reduced to 50% of it's maximum. The Pokémon has a 25% chance of being unable to attack each turn", "Paralysis" },
                    { 1002, true, true, "Last until healed or pokemon faints.", false, 15.0, "Last until healed or pokemon faints.", false, false, false, false, "The pokemon is afflicted with a severe burn. Each turn, the Pokémon afflicted with the Burn loses 1/8th of it's Max HP.", "Burn" },
                    { 1003, false, false, "The affect lasts four turns, unless it is removed by an item.", false, 0.0, "Last for four turns.", true, false, false, false, "The Pokemon is frozen solid. The Pokémon cannot use any attacks (apart from those that thaw it)", "Freeze " },
                    { 1004, false, true, "Last until the Pokemon is healed or the Pokemon Faints.", false, 15.0, "Last until the Pokemon is healed or the Pokemon Faints.", false, false, true, false, "Poisons the targeted pokemon gradually lowering the Pokémon's Hit Points until the Pokémon faint.", "Poison" },
                    { 1005, false, false, "Last for up to seven turns unless removed.", false, 0.0, "Last for up to seven turns unless removed.", false, false, false, true, "The targeted Pokemon is put to sleep for up to seven turns. The pokemon is not able to use any moves while asleep.", "Sleep" },
                    { 1006, false, false, "Last for up to seven turns unless removed.", true, 0.0, "Last for up to seven turns unless removed.", false, false, false, true, "The targeted Pokemon is confused and has a 50% chance of hurting itself in its confusion.", "Confusion" },
                    { 1007, false, false, "No Status Condition is applied by this move.", false, 0.0, "No Status Condition is applied by this move.", false, false, false, false, "No Status Condition is applied by this move.", "No Status Condition" }
                });

            migrationBuilder.InsertData(
                table: "PokemonMoves",
                columns: new[] { "Id", "Accuracy", "HealthRestorationAmount", "MoveAppliesAStatusCondition", "MoveBasePP", "MoveDescription", "MoveName", "MovePower", "MoveRestoresHealth", "MoveType", "PokeApiMoveId", "StatusConditionId" },
                values: new object[,]
                {
                    { 1, 100, 0, false, 35, "A physical attack in which the user charges and slams into the target with its whole body.", "Tackle", 40, false, "Normal", 33, 1007 },
                    { 2, 100, 0, false, 40, "The user growls in an endearing way, making opposing Pokémon less wary. This lowers their Attack stat.", "Growl", 0, false, "Normal", 45, 1007 },
                    { 3, 100, 0, false, 30, "The user wags its tail cutely, making opposing Pokémon less wary and lowering their Defense stats.", "Tail Whip", 0, false, "Normal", 39, 1007 },
                    { 4, 100, 0, true, 25, "The target is attacked with small flames. This may also leave the target with a burn.", "Ember", 40, false, "Fire", 52, 1002 },
                    { 5, 100, 0, true, 15, "The target is scorched with an intense blast of fire. This may also leave the target with a burn.", "Flamethrower", 90, false, "Fire", 53, 1002 },
                    { 6, 100, 0, true, 15, "A strong electric blast crashes down on the target. This may also leave the target with paralysis.", "Thunderbolt", 90, false, "Electric", 85, 1001 },
                    { 7, 70, 0, true, 10, "A wicked thunderbolt is dropped on the target to inflict damage. This may also leave the target with paralysis.", "Thunder", 110, false, "Electric", 87, 1001 },
                    { 8, 100, 0, true, 15, "The user electrifies itself and charges the target. This also damages the user quite a lot. This attack may leave the target with paralysis.", "Volt Tackle", 120, false, "Electric", 344, 1001 },
                    { 9, 100, 0, false, 20, "The user scatters curious leaves that chase the target. This attack never misses.", "Magical Leaf", 60, false, "Grass", 345, 1007 },
                    { 10, 95, 0, false, 25, "Sharp-edged leaves are launched to slash at opposing Pokémon. Critical hits land more easily.", "Razor Leaf", 55, false, "Grass", 75, 1007 },
                    { 11, 100, 20, false, 25, "A nutrient-draining attack. The user's HP is restored by half the damage taken by the target.", "Absorb", 20, true, "Grass", 71, 1007 },
                    { 12, 100, 0, false, 10, "A seed that causes worry is planted on the target. It prevents sleep by making its Ability Insomnia.", "Worry Seed", 0, false, "Grass", 388, 1007 },
                    { 13, 100, 0, false, 10, "In this two-turn attack, the user gathers light, then blasts a bundled beam on the next turn.", "Solar Beam", 120, false, "Grass", 76, 1007 },
                    { 14, 85, 0, true, 5, "The target is attacked with an intense blast of all-consuming fire. This may also leave the target with a burn.", "Fire Blast", 110, false, "Fire", 126, 1002 },
                    { 15, 85, 0, false, 15, "The target becomes trapped within a fierce vortex of fire that rages for four to five turns.", "Fire Spin", 35, false, "Fire", 83, 1007 },
                    { 16, 100, 0, false, 15, "The user attacks the target with a bursting flame. The bursting flame damages Pokémon next to the target as well.", "Flame Burst", 70, false, "Fire", 481, 1007 },
                    { 17, 100, 0, true, 20, "The target is attacked with a peculiar ray. This may also leave the target confused.", "Psybeam", 65, false, "Psychic", 60, 1006 },
                    { 18, 100, 0, true, 10, "The target is hit by a strong telekinetic force. This may also lower the target's Sp. Def stat.", "Psychic", 90, false, "Psychic", 94, 1006 },
                    { 19, 100, 0, false, 20, "The user tears at the target with blades formed by psychic power. Critical hits land more easily.", "Psycho Cut", 70, false, "Psychic", 427, 1007 },
                    { 20, 100, 0, false, 10, "Two turns after this move is used, a hunk of psychic energy attacks the target.", "Future Sight", 120, false, "Psychic", 248, 1007 },
                    { 21, 100, 0, false, 15, "The user releases a horrible aura imbued with dark thoughts. This may also make the target flinch.", "Dark Pulse", 80, false, "Dark", 399, 1007 },
                    { 22, 100, 50, false, 10, "The user steals the target's energy with a kiss. The user's HP is restored by over half of the damage taken by the target.", "Draining Kiss", 50, true, "Fairy", 577, 1007 },
                    { 23, 100, 0, false, 15, "Borrowing the power of the moon, the user attacks the target. This may also lower the target's Sp. Atk stat.", "Moonblast", 95, false, "Fairy", 585, 1007 },
                    { 24, 100, 0, true, 25, "The user attacks with a chilling gust of powdery snow. This may also freeze opposing Pokémon.", "Powder Snow", 40, false, "Ice", 181, 1003 },
                    { 25, 100, 0, false, 15, "The user slashes the target with huge, sharp claws.", "Dragon Claw", 80, false, "Dragon", 337, 1007 },
                    { 26, 100, 0, false, 15, "The user slashes the target the instant an opportunity arises. Critical hits land more easily.", "Night Slash", 70, false, "Dark", 400, 1007 },
                    { 27, 100, 0, false, 15, "The user attacks the target from behind with a secret power. Its added effects vary depending on the user's environment.", "Sneak Attack", 70, false, "Dark", 693, 1007 },
                    { 28, 100, 0, false, 15, "The user crunches up the target with sharp fangs. This may also lower the target's Defense stat.", "Crunch", 80, false, "Dark", 242, 1007 },
                    { 29, 100, 0, false, 5, "This move enables the user to attack first. This move fails if the target is not readying an attack.", "Sucker Punch", 70, false, "Dark", 389, 1007 },
                    { 30, 100, 0, false, 20, "The user swings its body around violently to inflict damage on everything in its vicinity.", "Brutal Swing", 60, false, "Dark", 693, 1007 },
                    { 31, 90, 0, false, 5, "Comets are summoned down from the sky onto the target. The attack's recoil harshly lowers the user's Sp. Atk stat.", "Draco Meteor", 130, false, "Dragon", 434, 1007 },
                    { 32, 100, 0, false, 10, "The user rampages and attacks for two to three turns. However, it then becomes confused.", "Outrage", 120, false, "Dragon", 200, 1007 },
                    { 33, 90, 0, false, 10, "The target is knocked away, and a different Pokémon is dragged out. In the wild, this ends a battle against a single Pokémon.", "Dragon Tail", 60, false, "Dragon", 525, 1007 },
                    { 34, 100, 0, false, 10, "The target is attacked with a shock wave generated by the user's gaping mouth.", "Dragon Pulse", 85, false, "Dragon", 406, 1007 },
                    { 35, 100, 0, true, 30, "The target is licked with a long tongue, causing damage. This may also leave the target with paralysis.", "Lick", 30, false, "Ghost", 122, 1001 },
                    { 36, 100, 0, true, 5, "The user disappears, then strikes the target on the next turn. This move hits even if the target protects itself.", "Shadow Force", 120, false, "Ghost", 467, 1001 },
                    { 37, 100, 0, false, 10, "This relentless attack does massive damage to a target affected by status conditions.", "Hex", 65, false, "Ghost", 506, 1007 },
                    { 38, 100, 0, false, 15, "The user hurls a shadowy blob at the target. This may also lower the target's Sp. Def stat.", "Shadow Ball", 80, false, "Ghost", 247, 1007 },
                    { 39, 100, 0, false, 10, "The user vanishes somewhere, then strikes the target on the next turn. This move hits even if the target protects itself.", "Phantom Force", 90, false, "Ghost", 566, 1007 },
                    { 40, 100, 0, false, 15, "The user makes the target see a frightening mirage. It inflicts damage equal to the user's level.", "Night Shade", 40, false, "Ghost", 101, 1007 },
                    { 41, 100, 0, false, 10, "The user sets off an earthquake that strikes every Pokémon around it.", "Earthquake", 100, false, "Ground", 89, 1007 },
                    { 42, 30, 0, false, 5, "The user opens up a fissure in the ground and drops the target in. The target instantly faints if it hits.", "Fissure", 300, false, "Ground", 90, 1007 },
                    { 43, 100, 0, false, 10, "The user burrows, then attacks on the next turn.", "Dig", 80, false, "Ground", 91, 1007 },
                    { 44, 85, 0, false, 10, "The user attacks opposing Pokémon by manifesting the power of the land in fearsome blades of stone.", "Precipice Blades", 120, false, "Ground", 619, 1007 },
                    { 45, 100, 0, false, 20, "The user strikes everything around it by stomping down on the ground. This lowers the Speed stat of those hit.", "Bulldoze", 60, false, "Ground", 523, 1007 },
                    { 46, 100, 0, false, 10, "The user makes the ground under the target erupt with power. This may also lower the target's Sp. Def stat.", "Earth Power", 90, false, "Ground", 414, 1007 },
                    { 47, 100, 0, false, 10, "The user gathers all its light energy and releases it all at once. This may also lower the target's Sp. Def stat.", "Flash Cannon", 80, false, "Steel", 430, 1007 },
                    { 48, 95, 0, false, 35, "The target is raked with steel claws. This may also raise the user's Attack stat.", "Metal Claw", 50, false, "Steel", 232, 1007 },
                    { 49, 90, 0, false, 10, "The target is hit with a hard punch fired like a meteor. This may also raise the user's Attack stat.", "Meteor Mash", 90, false, "Steel", 309, 1007 },
                    { 50, 90, 0, false, 5, "The user hits the target with a hard punch. This may also lower the target's Defense stat.", "Gigaton Hammer", 100, false, "Steel", 892, 1007 },
                    { 51, 100, 0, false, 5, "The user tackles the target with a high-speed spin. The slower the user compared to the target, the greater the move's power.", "Gyro Ball", 30, false, "Steel", 360, 1007 },
                    { 52, 75, 0, false, 15, "The target is slammed with a steel-hard tail. This may also lower the target's Defense stat.", "Iron Tail", 100, false, "Steel", 231, 1007 },
                    { 53, 100, 0, false, 5, "The user becomes a gigantic sword and cuts the target. This move deals twice the damage if the target is Dynamaxed.", "Behemoth Blade", 100, false, "Steel", 781, 1007 },
                    { 54, 100, 0, true, 30, "The opposing Pokémon are attacked with a spray of harsh acid. This may also lower their Sp. Def stats.", "Acid", 40, false, "Poison", 51, 1005 },
                    { 55, 100, 0, true, 20, "A slashing attack with a poisonous blade that may also poison the target. Critical hits land more easily.", "Cross Poison", 70, false, "Poison", 440, 1005 },
                    { 56, 100, 0, true, 10, "Unsanitary sludge is hurled at the target. This may also poison the target.", "Sludge Bomb", 90, false, "Poison", 188, 1005 },
                    { 57, 100, 0, true, 10, "The user drenches the target in a special poisonous liquid. This move's power is doubled if the target is poisoned.", "Venoshock", 65, false, "Poison", 474, 1005 },
                    { 58, 90, 0, true, 10, "The user lets out a damaging belch at the target. The user must eat a held Berry to use this move.", "Belch", 120, false, "Poison", 562, 1005 },
                    { 59, 100, 0, false, 5, "The user attacks with a prehistoric power. This may also raise all the user's stats at once.", "Ancient Power", 60, false, "Rock", 246, 1007 },
                    { 60, 80, 0, false, 5, "The user stabs the target from below with sharpened stones. Critical hits land more easily.", "Stone Edge", 100, false, "Rock", 444, 1007 },
                    { 61, 90, 0, false, 10, "Large boulders are hurled at opposing Pokémon to inflict damage. This may also make the opposing Pokémon flinch.", "Rock Slide", 75, false, "Rock", 157, 1007 },
                    { 62, 90, 0, false, 5, "The user launches a huge boulder at the target to attack. The user can't move on the next turn.", "Rock Wrecker", 150, false, "Rock", 439, 1007 },
                    { 63, 100, 0, false, 20, "The user attacks with a ray of light that sparkles as if it were made of gemstones.", "Power Gem", 80, false, "Rock", 408, 1007 },
                    { 64, 85, 0, false, 10, "Using its tough and impressive horn, the user rams into the target with no letup.", "Megahorn", 120, false, "Bug", 224, 1007 },
                    { 65, 100, 0, false, 15, "The user slashes at the target by crossing its scythes or claws as if they were a pair of scissors.", "X-Scissor", 80, false, "Bug", 404, 1007 },
                    { 66, 100, 50, false, 10, "The user drains the target's blood. The user's HP is restored by half the damage taken by the target.", "Leech Life", 80, true, "Bug", 141, 1007 },
                    { 67, 100, 0, false, 10, "The user generates a damaging sound wave by vibration. This may also lower the target's Sp. Def stat.", "Bug Buzz", 90, false, "Bug", 405, 1007 },
                    { 68, 100, 0, false, 5, "The user fights the target up close without guarding itself. This also lowers the user's Defense and Sp. Def stats.", "Close Combat", 120, false, "Fighting", 370, 1007 },
                    { 69, 70, 0, false, 5, "The user heightens its mental focus and unleashes its power. This may also lower the target's Sp. Def stat.", "Focus Blast", 120, false, "Fighting", 411, 1007 },
                    { 70, 90, 0, false, 10, "The target is attacked with a knee kick from a jump. If it misses, the user is hurt instead.", "High Jump Kick", 130, false, "Fighting", 136, 1007 },
                    { 71, 100, 0, false, 5, "The user attacks the target with great power. However, this also lowers the user's Attack and Defense stats.", "Superpower", 120, false, "Fighting", 276, 1007 },
                    { 72, 100, 0, false, 20, "The user makes a swift attack on the target's legs, which lowers the target's Speed stat.", "Low Sweep", 65, false, "Fighting", 490, 1007 },
                    { 73, 100, 35, false, 10, "An energy-draining punch. The user's HP is restored by half the damage taken by the target.", "Drain Punch", 75, true, "Fighting", 409, 1007 },
                    { 74, 100, 0, true, 20, "The target is hit with a rainbow-colored beam. This may also lower the target's Attack stat.", "Aurora Beam", 65, false, "Ice", 62, 1003 },
                    { 75, 70, 0, false, 5, "A howling blizzard is summoned to strike opposing Pokémon. This may also leave the opposing Pokémon frozen.", "Blizzard", 110, false, "Ice", 59, 1007 },
                    { 76, 100, 0, false, 10, "The power of this attack move is doubled if the user has been hurt by the target in the same turn.", "Avalanche", 60, false, "Ice", 419, 1007 },
                    { 77, 100, 0, true, 15, "The target is punched with an icy fist. This may also leave the target frozen.", "Ice Punch", 75, false, "Ice", 8, 1003 },
                    { 78, 95, 0, true, 15, "The user bites with cold-infused fangs. This may also make the target flinch or leave it frozen.", "Ice Fang", 65, false, "Ice", 423, 1003 },
                    { 79, 100, 0, true, 10, "The user attacks with a crystal made of cold frozen haze. It eliminates every stat change among all the Pokémon engaged in battle.", "Freezy Frost", 90, false, "Ice", 837, 1003 },
                    { 80, 100, 0, false, 10, "The user tucks in its wings and charges from a low altitude. This also damages the user quite a lot.", "Brave Bird", 120, false, "Flying", 413, 1007 },
                    { 81, 95, 0, false, 15, "The user soars, then strikes its target on the second turn. It can also be used for flying to any familiar town.", "Fly", 90, false, "Flying", 19, 1007 },
                    { 82, 100, 0, false, 35, "The target is struck with large, imposing wings spread wide to inflict damage.", "Wing Attack", 60, false, "Flying", 17, 1007 },
                    { 83, 100, 0, false, 20, "A corkscrewing attack with the sharp beak acting as a drill.", "Drill Peck", 80, false, "Flying", 65, 1007 },
                    { 84, 95, 0, false, 15, "The user floats in the air, and then dives at a steep angle to attack the target. This may also make the target flinch.", "Floaty Fall", 90, false, "Flying", 826, 1007 },
                    { 85, 90, 0, false, 5, "A second-turn attack move where critical hits land more easily. This may also make the target flinch.", "Sky Attack", 140, false, "Flying", 143, 1007 },
                    { 86, 100, 0, false, 20, "The user attacks with a blade of air that slices even the sky. This may also make the target flinch.", "Air Slash", 75, false, "Flying", 402, 1007 },
                    { 87, 90, 0, false, 10, "The user attacks by swinging its tail as if it were a vicious wave in a raging storm.", "Aqua Tail", 90, false, "Water", 401, 1007 },
                    { 88, 80, 0, false, 5, "The target is blasted by a huge volume of water launched under great pressure.", "Hydro Pump", 110, false, "Water", 56, 1007 },
                    { 89, 100, 0, true, 20, "The user attacks the target with a pulsing blast of water. This may also confuse the target.", "Water Pulse", 60, false, "Water", 352, 1006 },
                    { 90, 100, 0, false, 15, "The user charges at the target and may make it flinch. This can also be used to climb a waterfall.", "Waterfall", 80, false, "Water", 127, 1007 },
                    { 91, 100, 0, false, 10, "The user slams into the target using a full-force blast of water. This may also lower the target's Defense stat.", "Liquidation", 85, false, "Water", 710, 1007 },
                    { 92, 100, 0, false, 20, "A spray of bubbles is forcefully ejected at the target. This may also lower its Speed stat.", "Bubble Beam", 65, false, "Water", 61, 1007 },
                    { 93, 100, 0, true, 15, "The user drops onto the target with its full body weight. This may also leave the target with paralysis.", "Body Slam", 85, false, "Normal", 34, 1001 },
                    { 94, 95, 0, false, 30, "The target is cut with a scythe or claw.", "Cut", 50, false, "Normal", 15, 1007 },
                    { 95, 100, 0, false, 15, "The user sticks out its head and attacks by charging straight into the target. This may also make the target flinch.", "Headbutt", 70, false, "Normal", 29, 1007 },
                    { 96, 90, 0, false, 5, "The target is attacked with a powerful beam. The user can't move on the next turn.", "Hyper Beam", 150, false, "Normal", 63, 1007 },
                    { 97, 100, 0, false, 30, "The user lunges at the target at a speed that makes it almost invisible. This move always goes first.", "Quick Attack", 40, false, "Normal", 98, 1007 },
                    { 98, 90, 0, false, 5, "The user charges at the target using every bit of its power. The user can't move on the next turn.", "Giga Impact", 150, false, "Normal", 416, 1007 },
                    { 99, 100, 0, false, 10, "In this two-turn attack, blades of wind hit opposing Pokémon on the second turn. Critical hits land more easily.", "Razor Wind", 80, false, "Normal", 13, 1007 },
                    { 100, 55, 0, true, 15, "A soothing lullaby is sung in a calming voice that puts the target into a deep slumber.", "Sing", 0, false, "Normal", 47, 1005 },
                    { 101, 60, 0, true, 20, "The user employs hypnotic suggestion to make the target fall into a deep sleep.", "Hypnosis", 0, false, "Psychic", 95, 1005 },
                    { 102, 50, 0, true, 10, "Opposing Pokémon are dragged into a world of total darkness that makes them sleep.", "Dark Void", 0, false, "Dark", 464, 1005 },
                    { 103, 75, 0, true, 15, "The user scatters a big cloud of sleep-inducing dust around the target.", "Sleep Powder", 0, false, "Grass", 79, 1005 },
                    { 104, 55, 0, true, 15, "The user plays a pleasant melody that lulls the target into a deep sleep.", "Grass Whistle", 0, false, "Grass", 320, 1005 },
                    { 105, 75, 0, true, 10, "With a scary face, the user tries to force a kiss on the target. If it succeeds, the target falls asleep.", "Lovely Kiss", 0, false, "Normal", 142, 1005 },
                    { 106, 100, 0, false, 10, "The user damages opposing Pokémon by emitting a powerful flash.", "Dazzling Gleam", 80, false, "Fairy", 605, 1007 },
                    { 107, 90, 0, false, 10, "The user plays rough with the target and attacks it. This may also lower the target's Attack stat.", "Play Rough", 90, false, "Fairy", 583, 1007 },
                    { 108, 100, 0, false, 30, "The user stirs up a fairy wind and strikes the target with it.", "Fairy Wind", 40, false, "Fairy", 584, 1007 },
                    { 109, 0, 50, false, 10, "The user restores the target's HP by up to half of its max HP. It restores more HP when the terrain is grass.", "Floral Healing", 0, true, "Fairy", 666, 1007 },
                    { 110, 100, 35, false, 10, "A nutrient-draining attack. The user's HP is restored by half the damage taken by the target.", "Giga Drain", 75, true, "Grass", 202, 1007 },
                    { 111, 0, 50, false, 5, "The user restores its own HP. The amount of HP regained varies with the weather.", "Moonlight", 0, true, "Fairy", 236, 1007 },
                    { 112, 100, 35, false, 20, "The user attacks everything around it. The user's HP is restored by half the damage taken by those hit.", "Parabolic Charge", 65, true, "Electric", 570, 1007 },
                    { 113, 100, 0, true, 15, "The user strikes everything around it by letting loose a flare of electricity. This may also cause paralysis.", "Discharge", 80, false, "Electric", 435, 1001 },
                    { 114, 100, 0, true, 15, "The target is punched with an electrified fist. This may also leave the target with paralysis.", "Thunder Punch", 75, false, "Electric", 9, 1001 },
                    { 115, 100, 0, true, 15, "The target is punched with a fiery fist. This may also leave the target with a burn.", "Fire Punch", 75, false, "Fire", 7, 1002 },
                    { 116, 100, 0, false, 15, "The user shrouds itself in electricity and smashes into its target. This also damages the user a little.", "Wild Charge", 90, false, "Electric", 528, 1007 },
                    { 117, 50, 0, true, 5, "The user fires an electric blast like a cannon to inflict damage and cause paralysis.", "Zap Cannon", 120, false, "Electric", 192, 1001 },
                    { 118, 95, 0, true, 15, "The user bites with electrified fangs. This may also make the target flinch or leave it with paralysis.", "Thunder Fang", 65, false, "Electric", 422, 1001 },
                    { 119, 100, 0, true, 25, "The target is hit by a weak telekinetic force. This may also confuse the target.", "Confusion", 50, false, "Psychic", 93, 1006 },
                    { 120, 100, 0, false, 10, "The user materializes an odd psychic wave to attack the target. This attack does physical damage.", "Psystrike", 100, false, "Psychic", 540, 1007 },
                    { 121, 100, 0, false, 10, "The user draws power from nature and fires it at the target. This may also lower the target's Sp. Def stat.", "Energy Ball", 90, false, "Grass", 412, 1007 },
                    { 122, 100, 0, false, 10, "A column of grass hits opposing Pokémon. When used with its water equivalent, its damage increases into a vast swamp.", "Grass Pledge", 80, false, "Grass", 520, 1007 },
                    { 123, 100, 0, false, 15, "The user handles a sharp leaf like a sword and attacks by cutting its target. Critical hits land more easily.", "Leaf Blade", 90, false, "Grass", 348, 1007 },
                    { 124, 100, 0, false, 15, "The user stirs up a violent petal blizzard and attacks everything around it.", "Petal Blizzard", 90, false, "Grass", 572, 1007 },
                    { 125, 90, 0, false, 5, "The user attacks the target at full power. The attack's recoil harshly lowers the user's Sp. Atk stat.", "Overheat", 130, false, "Fire", 315, 1007 },
                    { 126, 100, 0, true, 10, "The user attacks by breathing a special, hot fire. This also lowers the target's Sp. Atk stat.", "Mystical Fire", 75, false, "Fire", 595, 1002 },
                    { 127, 100, 0, true, 15, "The user torches everything around it in an inferno of scarlet flames. This may also leave those it hits with a burn.", "Lava Plume", 80, false, "Fire", 436, 1002 }
                });

            migrationBuilder.InsertData(
                table: "TMs",
                columns: new[] { "Id", "BugCanLearn", "DarkCanLearn", "DragonCanLearn", "ElectricCanLearn", "FairyCanLearn", "FightingCanLearn", "FireCanLearn", "FlyingCanLearn", "GhostCanLearn", "GrassCanLearn", "GroundCanLearn", "HealthRestorationAmount", "IceCanLearn", "MoveAccuracy", "MoveAppliesAStatusCondition", "MoveBasePP", "MoveDescription", "MoveName", "MovePower", "MoveRestoresHealth", "MoveType", "NormalCanLearn", "PoisonCanLearn", "PsychicCanLearn", "RockCanLearn", "StatusConditionId", "SteelCanLearn", "TMNumber", "WaterCanLearn" },
                values: new object[,]
                {
                    { 1001, true, true, true, true, true, true, true, true, true, true, true, 0, true, 85, false, 20, "The target is slugged by a punch thrown with muscle-packed power.", "Mega Punch", 80, false, "Normal", true, true, true, true, 1007, true, "TM00", true },
                    { 1002, true, true, true, true, true, true, true, true, true, true, true, 0, true, 75, false, 5, "The target is attacked by a kick launched with muscle-packed power.", "Mega Kick", 120, false, "Normal", true, true, true, true, 1007, true, "TM01", true },
                    { 1003, false, false, false, false, false, false, false, true, false, false, false, 0, false, 100, false, 10, "In this two-turn attack, blades of wind hit opposing Pokémon on the second turn. Critical hits land more easily.", "Razor Wind", 80, false, "Normal", true, false, false, false, 1007, false, "TM02", false },
                    { 1004, true, true, true, true, true, true, true, false, false, true, true, 0, true, 100, false, 20, "A frenetic dance to uplift the fighting spirit. This sharply raises the user's Attack stat.", "Swords Dance", 0, false, "Normal", true, true, true, true, 1007, true, "TM03", true },
                    { 1005, false, false, false, false, false, false, false, true, false, false, false, 0, false, 100, false, 20, "The target is blown away, to be replaced by another Pokémon in its party. In the wild, the battle ends.", "Whirlwind", 0, false, "Normal", true, false, false, false, 1007, false, "TM04", false },
                    { 1006, true, true, false, false, true, false, false, false, true, true, false, 20, false, 100, false, 15, "A nutrient-draining attack. The user's HP is restored by half the damage taken by the target.", "Mega Drain", 40, true, "Grass", true, true, true, false, 1007, false, "TM05", true },
                    { 1007, true, true, false, false, true, false, true, true, true, true, false, 0, true, 90, true, 10, "A move that leaves the target badly poisoned. Its poison damage worsens every turn.", "Toxic", 0, false, "Poison", true, true, true, false, 1004, false, "TM06", true },
                    { 1008, true, false, true, false, false, false, false, true, false, false, true, 0, false, 30, true, 5, "The user stabs the target with a horn that rotates like a drill. The target faints instantly if this attack hits.", "Horn Drill", 0, false, "Normal", true, false, false, false, 1007, false, "TM07", false },
                    { 1009, true, false, true, true, true, true, true, false, false, true, true, 0, true, 100, true, 15, "The user drops onto the target with its full body weight. This may also leave the target with paralysis.", "Body Slam", 85, false, "Normal", true, true, true, true, 1001, true, "TM08", true },
                    { 1010, true, true, true, true, true, true, true, true, false, true, true, 0, true, 85, false, 20, "A reckless, full-body charge attack for slamming into the target. This also damages the user a little.", "Take Down", 90, false, "Normal", true, true, true, true, 1007, true, "TM09", true },
                    { 1011, true, true, true, true, true, true, true, true, false, true, true, 0, true, 100, false, 15, "A reckless, life-risking tackle. This also damages the user quite a lot.", "Double-Edge", 120, false, "Normal", true, true, true, true, 1007, true, "TM10", true },
                    { 1012, false, true, false, true, false, false, false, true, false, false, false, 0, true, 100, false, 20, "A spray of bubbles is forcefully ejected at the target. This may also lower its Speed stat.", "Bubble Beam", 65, false, "Water", false, true, true, false, 1007, false, "TM11", true },
                    { 1013, false, true, false, true, false, false, false, true, false, false, false, 0, true, 100, false, 25, "The target is blasted with a forceful shot of water.", "Water Gun", 40, false, "Water", false, true, true, false, 1007, false, "TM12", true },
                    { 1014, false, true, false, true, false, false, false, true, false, false, false, 0, true, 100, true, 10, "The target is struck with an icy-cold beam of energy. This may also leave the target frozen.", "Ice Beam", 90, false, "Ice", false, true, true, false, 1003, false, "TM13", true },
                    { 1015, false, true, false, true, false, false, false, true, false, false, false, 0, true, 70, true, 5, "A howling blizzard is summoned to strike opposing Pokémon. This may also leave the opposing Pokémon frozen.", "Blizzard", 110, false, "Ice", false, true, true, false, 1003, false, "TM14", true },
                    { 1016, true, true, true, true, true, true, true, true, true, true, true, 0, true, 90, false, 5, "The target is attacked with a powerful beam. The user can't move on the next turn.", "Hyper Beam", 150, false, "Normal", true, true, true, true, 1007, true, "TM15", true },
                    { 1017, false, true, false, false, false, false, false, false, false, false, false, 0, false, 100, false, 20, "Numerous coins are hurled at the target to inflict damage. Money is earned after the battle.", "Pay Day", 40, false, "Normal", true, false, false, false, 1007, false, "TM16", false },
                    { 1018, false, false, true, false, false, true, false, false, false, false, true, 0, false, 80, false, 20, "The user grabs the target and recklessly dives for the ground. This also damages the user a little.", "Submission", 80, false, "Fighting", true, false, false, false, 1007, false, "TM17", false },
                    { 1019, false, false, true, false, false, true, false, false, true, false, false, 0, false, 100, false, 20, "A retaliation move that counters any physical attack, inflicting double the damage taken.", "Counter", 0, false, "Fighting", false, false, false, false, 1007, false, "TM18", false },
                    { 1020, false, false, true, false, false, true, false, false, true, false, false, 0, false, 100, false, 20, "The target is thrown using the power of gravity. It inflicts damage equal to the user's level.", "Seismic Toss", 0, false, "Fighting", false, false, false, false, 1007, false, "TM19", false },
                    { 1021, true, true, true, true, true, true, true, true, true, true, true, 0, true, 100, false, 20, "As long as this move is in use, the power of rage raises the Attack stat each time the user is hit in battle.", "Rage", 20, false, "Normal", true, true, true, true, 1007, true, "TM20", true },
                    { 1022, true, true, false, false, true, false, false, false, true, true, false, 20, false, 100, false, 15, "A nutrient-draining attack. The user's HP is restored by half the damage taken by the target.", "Mega Drain", 40, true, "Grass", true, true, true, false, 1007, false, "TM21", true },
                    { 1023, true, false, false, false, true, false, false, false, false, true, true, 0, false, 100, false, 10, "In this two-turn attack, the user gathers light, then blasts a bundled beam on the next turn.", "Solar Beam", 120, false, "Grass", true, true, true, false, 1007, false, "TM22", false },
                    { 1024, false, false, true, true, false, false, true, true, false, false, false, 0, false, 100, false, 10, "This attack hits the target with a shock wave of pure rage. This attack always inflicts 40 HP damage.", "Dragon Rage", 75, false, "Dragon", false, false, false, true, 1007, false, "TM23", true },
                    { 1025, false, false, true, true, false, false, true, true, false, false, false, 0, true, 100, true, 15, "A strong electric blast crashes down on the target. This may also leave the target with paralysis.", "Thunderbolt", 90, false, "Electric", false, true, true, false, 1001, true, "TM24", true },
                    { 1026, false, false, true, true, false, false, true, true, false, false, false, 0, true, 70, true, 10, "A wicked thunderbolt is dropped on the target to inflict damage. This may also leave the target with paralysis.", "Thunder", 110, false, "Electric", false, true, true, false, 1001, true, "TM25", true },
                    { 1027, false, true, true, false, false, false, false, false, false, false, true, 0, false, 100, false, 10, "The user sets off an earthquake that strikes every Pokémon around it.", "Earthquake", 100, false, "Ground", false, true, true, true, 1007, true, "TM26", false },
                    { 1028, false, false, true, false, false, false, false, false, false, false, true, 0, false, 30, false, 5, "The user opens up a fissure in the ground and drops the target in. The target instantly faints if it hits.", "Fissure", 0, false, "Ground", false, true, false, true, 1007, true, "TM27", false },
                    { 1029, false, false, true, false, false, false, false, false, false, false, true, 0, false, 100, false, 10, "The user burrows, then attacks on the next turn.", "Dig", 80, false, "Ground", false, true, true, true, 1007, true, "TM28", false },
                    { 1030, true, false, false, true, true, false, true, true, true, true, false, 0, true, 100, false, 10, "The target is hit by a strong telekinetic force. This may also lower the target's Sp. Def stat.", "Psychic", 90, false, "Psychic", false, true, true, true, 1007, true, "TM29", true },
                    { 1031, true, false, false, true, true, false, true, true, true, true, false, 0, true, 100, false, 20, "Use it to flee from any wild Pokémon. It can also warp to the last Pokémon Center visited.", "Teleport", 0, false, "Psychic", false, true, true, true, 1007, true, "TM30", true },
                    { 1032, true, true, true, true, true, true, true, true, true, true, true, 0, true, 100, false, 10, "The user copies the target's last move. The move can be used during battle until the Pokémon is switched out.", "Mimic", 0, false, "Normal", true, true, true, true, 1007, true, "TM31", true },
                    { 1033, true, true, true, true, true, true, true, true, true, true, true, 0, true, 100, false, 15, "By moving rapidly, the user makes illusory copies of itself to raise its evasiveness.", "Double Team", 0, false, "Normal", true, true, true, true, 1007, true, "TM32", true },
                    { 1034, false, false, false, false, true, false, false, false, true, false, false, 0, false, 100, false, 20, "A wondrous wall of light is put up to suppress damage from physical attacks for five turns.", "Reflect", 0, false, "Psychic", false, false, true, false, 1007, false, "TM33", false },
                    { 1035, false, true, true, true, false, true, true, false, true, true, true, 0, true, 100, false, 10, "The user endures attacks for two turns, then strikes back to cause double the damage taken. '", "Bide", 0, false, "Normal", true, false, false, true, 1007, true, "TM34", true },
                    { 1036, true, true, true, true, true, true, true, true, true, true, true, 0, true, 100, false, 10, "The user waggles a finger and stimulates its brain into randomly using nearly any move.", "Metronome", 0, false, "Normal", true, true, true, true, 1007, true, "TM35", true },
                    { 1037, false, false, false, true, false, false, true, false, false, true, true, 0, true, 100, false, 5, "The user attacks everything around it by causing an explosion. The user faints upon using this move.", "Self-Destruct", 200, false, "Normal", true, false, false, true, 1007, true, "TM36", true },
                    { 1038, false, false, true, false, false, false, false, true, false, false, false, 0, false, 75, false, 10, "A large egg is hurled at the target with maximum force to inflict damage.", "Egg Bomb", 100, false, "Normal", true, false, false, true, 1007, true, "TM37", false },
                    { 1039, false, true, true, false, false, false, true, true, false, false, true, 0, false, 85, true, 5, "The target is attacked with an intense blast of all-consuming fire. This may also leave the target with a burn.", "Fire Blast", 110, false, "Fire", false, false, true, true, 1002, true, "TM38", false },
                    { 1040, true, true, true, true, true, true, true, true, false, true, true, 0, true, 100, false, 20, "Star-shaped rays are shot at the opposing Pokémon. This attack never misses.", "Swift", 60, false, "Normal", true, true, true, true, 1007, true, "TM39", true },
                    { 1041, true, true, true, true, false, true, true, true, false, true, true, 0, true, 100, false, 10, "The user tucks in its head to raise its Defense stat on the first turn, then rams the target on the next turn.", "Skull Bash", 130, false, "Normal", true, true, true, true, 1007, true, "TM40", true },
                    { 1042, false, true, false, false, false, true, false, false, true, true, false, 50, false, 100, false, 10, "The user restores its own HP by up to half of its maximum HP. May also be used in the field to heal HP.", "Soft-Boiled", 0, true, "Normal", true, false, false, false, 1007, false, "TM41", false },
                    { 1043, true, true, false, false, false, false, false, false, true, true, false, 50, false, 100, false, 15, "The user eats the dreams of a sleeping target. It absorbs half the damage caused to heal the user's HP.", "Dream Eater", 100, true, "Psychic", false, false, true, false, 1007, false, "TM42", false },
                    { 1044, false, false, false, true, false, true, true, false, false, false, true, 0, true, 100, false, 5, "It enables the user to evade all attacks. Its chance of failing rises if it is used in succession.", "Detect", 0, false, "Fighting", false, false, false, false, 1007, false, "TM43", true },
                    { 1045, true, true, true, true, true, true, true, true, true, true, true, 100, true, 100, false, 10, "The user goes to sleep for two turns. This fully restores the user's HP and heals any status conditions.", "Rest", 0, true, "Psychic", true, true, true, true, 1007, true, "TM44", true },
                    { 1046, true, true, false, true, true, false, true, true, false, false, false, 0, true, 90, true, 20, "The user launches a weak jolt of electricity that paralyzes the target.", "Thunder Wave", 0, false, "Electric", false, true, true, false, 1001, true, "TM45", true },
                    { 1047, true, true, false, true, true, false, true, true, true, true, false, 0, true, 100, false, 15, "The target is attacked with an odd psychic wave. The attack varies in intensity.", "Psywave", 0, false, "Psychic", false, true, true, true, 1007, true, "TM46", true },
                    { 1048, false, false, false, true, false, false, true, false, false, true, true, 0, true, 100, false, 5, "The user attacks everything around it by causing a tremendous explosion. The user faints upon using this move.", "Explosion", 250, false, "Normal", true, false, false, true, 1007, true, "TM47", true },
                    { 1049, false, true, true, false, false, false, false, true, false, false, true, 0, true, 90, false, 10, "Large boulders are hurled at the opposing Pokémon to inflict damage. This may also make the opposing Pokémon flinch.", "Rock Slide", 75, false, "Rock", true, false, false, true, 1007, false, "TM48", false },
                    { 1050, true, false, false, true, true, false, true, true, false, true, false, 0, true, 100, true, 10, "The user strikes with a simultaneous three-beam attack. May also burn, freeze, or paralyze the target.", "Tri Attack", 80, false, "Normal", true, false, false, false, 1007, false, "TM49", true },
                    { 1051, true, true, true, true, true, true, true, true, true, true, true, 25, true, 100, false, 10, "The user makes a copy of itself using some of its HP. The copy serves as the user's decoy.", "Substitute", 0, true, "Normal", true, true, true, true, 1007, true, "TM50", true },
                    { 1052, false, false, false, false, false, false, false, true, false, false, false, 50, false, 100, false, 10, "The user lands and rests its body. It restores the user's HP by up to half of its max HP.", "Roost", 0, true, "Flying", false, false, false, false, 1007, false, "TM51", false },
                    { 1053, true, true, false, false, false, true, false, true, false, true, false, 0, true, 70, true, 5, "The user heightens its mental focus and unleashes its power. This may also lower the target's Sp. Def.", "Focus Blast", 120, false, "Fighting", false, true, true, false, 1001, false, "TM52", false },
                    { 1054, true, true, false, false, true, false, true, true, false, true, false, 0, true, 100, false, 10, "The user draws power from nature and fires it at the target. This may also lower the target's Sp. Def stat.", "Energy Ball", 90, false, "Grass", false, true, true, false, 1007, false, "TM53", false },
                    { 1055, true, true, true, true, true, true, true, true, true, true, true, 0, true, 100, false, 40, "A restrained attack that prevents the target from fainting. The target is left with at least 1 HP.", "False Swipe", 40, false, "Normal", true, true, true, true, 1007, true, "TM54", true },
                    { 1056, false, true, false, false, false, false, false, true, true, false, false, 0, true, 100, false, 10, "If the target's HP is down to about half, this attack will hit with double the power.", "Brine", 65, false, "Water", false, false, false, false, 1007, false, "TM55", true },
                    { 1057, true, true, true, true, true, false, true, true, true, true, false, 0, true, 100, false, 10, "The user flings its held item at the target to attack. Its power and effects depend on the item.", "Fling", 0, false, "Dark", true, false, false, true, 1007, true, "TM56", true },
                    { 1058, false, true, false, true, true, false, false, false, true, false, false, 0, false, 90, true, 10, "The user attacks with an electric charge. The user may use any remaining electricity to raise its Sp. Atk stat.", "Charge Beam", 50, false, "Electric", false, true, true, false, 1001, true, "TM57", false },
                    { 1059, false, false, false, false, false, false, false, true, false, false, false, 0, false, 100, false, 10, "The user takes the target into the sky, then drops it during the next turn. The target cannot attack while in the sky.", "Sky Drop", 60, false, "Flying", false, false, false, false, 1007, false, "TM58", false },
                    { 1060, false, false, true, false, false, false, true, true, true, false, true, 0, false, 100, true, 15, "The user attacks opposing Pokémon with fire. If a Pokémon is holding a certain item, such as a Berry, the item becomes burned up and unusable.", "Incinerate", 60, false, "Fire", false, false, true, false, 1002, true, "TM59", false },
                    { 1061, false, true, false, false, false, false, false, false, true, true, false, 0, false, 100, false, 15, "The user suppresses the target and makes its move go last.", "Quash", 0, false, "Dark", true, true, false, false, 1007, false, "TM60", false },
                    { 1062, true, true, true, false, true, false, true, false, true, false, false, 0, false, 85, true, 15, "The user shoots a sinister, bluish-white flame at the target to inflict a burn.", "Will-O-Wisp", 0, false, "Fire", false, true, true, false, 1002, true, "TM61", false },
                    { 1063, false, false, false, false, false, false, false, true, false, false, false, 0, false, 100, false, 15, "The user nimbly strikes the target. If the user is not holding an item, this attack inflicts massive damage.", "Acrobatics", 55, false, "Flying", false, false, false, false, 1007, false, "TM62", false },
                    { 1064, true, true, false, false, true, false, false, false, true, true, false, 0, false, 100, false, 15, "This move prevents the target from using its held item for five turns. Its Trainer is also prevented from using items on it.", "Embargo", 0, false, "Dark", true, true, false, false, 1007, true, "TM63", false },
                    { 1065, false, true, false, true, false, false, true, false, true, false, true, 0, false, 100, false, 5, "The user attacks everything around it by causing a tremendous explosion. The user faints upon using this move.", "Explosion", 250, false, "Normal", true, false, true, true, 1007, true, "TM64", false },
                    { 1066, false, true, true, false, false, false, false, true, true, false, false, 0, false, 100, false, 15, "The user slashes with a sharp claw made from shadows. Critical hits land more easily.", "Shadow Claw", 70, false, "Ghost", false, false, true, true, 1007, true, "TM65", false },
                    { 1067, true, true, true, true, false, false, true, true, true, true, false, 0, true, 100, false, 10, "The user stores power, then attacks. If the user can use this attack after the target, its power is doubled.", "Payback", 50, false, "Dark", true, true, true, true, 1007, true, "TM66", true },
                    { 1068, false, false, false, false, false, true, false, false, false, false, false, 0, true, 100, false, 5, "The user gets revenge for a fainted ally. If an ally fainted in the previous turn, this move's power is increased.", "Retaliate", 70, false, "Normal", true, false, true, true, 1007, false, "TM67", true },
                    { 1069, true, true, true, true, true, true, true, true, true, true, true, 0, true, 90, true, 5, "The user charges at the target using every bit of its power. The user can't move on the next turn.", "Giga Impact", 150, false, "Normal", true, true, true, true, 1001, true, "TM68", true },
                    { 1070, false, false, true, false, false, true, false, false, false, false, true, 0, true, 100, false, 20, "The user polishes its body to reduce drag. This can sharply raise the Speed stat.", "Rock Polish", 0, false, "Rock", false, false, false, true, 1007, false, "TM69", false },
                    { 1071, true, true, true, true, true, false, true, true, true, true, false, 0, true, 100, false, 20, "The user flashes a bright light that cuts the target's accuracy. It can also be used to illuminate caves.", "Flash", 0, false, "Normal", true, true, true, true, 1007, true, "TM70", true },
                    { 1072, false, false, true, false, false, false, false, false, false, false, true, 0, false, 80, false, 5, "The user stabs the target from below with sharpened stones. Critical hits land more easily.", "Stone Edge", 100, false, "Rock", true, false, false, true, 1007, false, "TM71", false },
                    { 1073, false, false, true, true, false, false, false, false, false, false, false, 0, false, 100, true, 20, "After making its attack, the user rushes back to switch places with a party Pokémon in waiting.", "Volt Switch", 70, false, "Electric", false, false, true, false, 1001, true, "TM72", false },
                    { 1074, true, false, false, true, true, false, false, false, false, false, false, 0, false, 90, true, 20, "The user launches a weak jolt of electricity that paralyzes the target.", "Thunder Wave", 0, false, "Electric", false, false, true, false, 1001, true, "TM73", false },
                    { 1075, false, false, true, false, false, false, true, false, false, false, true, 0, true, 100, false, 5, "The user tackles the target with a high-speed spin. The slower the user compared to the target, the greater the move's power.", "Gyro Ball", 0, false, "Steel", false, false, false, true, 1007, true, "TM74", false },
                    { 1076, true, true, false, false, false, true, false, false, false, false, true, 0, true, 100, false, 20, "A frenetic dance to uplift the fighting spirit. This sharply raises the user's Attack stat.", "Swords Dance", 0, false, "Normal", true, false, false, true, 1007, false, "TM75", true },
                    { 1077, true, false, false, false, true, false, false, true, false, false, false, 0, false, 100, false, 20, "While resisting, the user attacks the opposing Pokémon. This lowers the Sp. Atk stat of those hit.", "Struggle Bug", 50, false, "Bug", false, true, false, false, 1007, false, "TM76", false },
                    { 1078, true, true, true, true, true, true, true, true, true, true, true, 25, true, 100, false, 10, "The user hypnotizes itself into copying any stat change made by the target.", "Psych Up", 0, true, "Normal", true, true, true, true, 1007, true, "TM77", true },
                    { 1079, false, false, true, false, false, false, true, true, false, true, true, 0, false, 100, false, 20, "The user strikes everything around it by stomping down on the ground. This lowers the Speed stat of those hit.", "Bulldoze", 60, false, "Ground", false, false, false, true, 1007, true, "TM78", false },
                    { 1080, false, false, false, false, false, false, false, false, false, false, false, 0, true, 90, true, 10, "The user blows its cold breath on the target. This attack always results in a critical hit.", "Frost Breath", 60, false, "Ice", false, false, false, false, 1003, false, "TM79", true },
                    { 1081, true, true, false, false, false, false, false, false, true, true, false, 0, false, 100, true, 10, "The user drenches the target in a special poisonous liquid. This move's power is doubled if the target is poisoned.", "Venoshock", 65, false, "Poison", false, true, false, false, 1004, false, "TM80", false },
                    { 1082, false, false, false, false, true, false, false, false, true, false, false, 0, false, 100, false, 10, "The user vanishes somewhere, then strikes the target on the next turn. This move hits even if the target protects itself.", "Phantom Force", 90, false, "Ghost", false, false, true, false, 1007, false, "TM86", false }
                });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "AbilityId", "BaseExperience", "Health", "Height", "MoveFourId", "MoveOneId", "MoveThreeId", "MoveTwoId", "Name", "PokeNickName", "PokeTypeIdOne", "PokeTypeIdTwo", "PokedexNumber", "Weight" },
                values: new object[,]
                {
                    { 1001, 1000, 236, 250, 25, 9, 5, 15, 7, "Eevee", "Eevee", 1000, 1018, 133, 1000 },
                    { 1002, 1001, 236, 250, 25, 4, 5, 13, 1, "Pikachu", "Pikachu", 1012, 1018, 25, 1000 },
                    { 1003, 1001, 236, 250, 25, 4, 5, 13, 1, "Gible", "Gible", 1004, 1018, 443, 1000 },
                    { 1004, 1001, 236, 250, 25, 1, 6, 5, 7, "Scorbunny", "Scorbunny", 1009, 1018, 813, 1000 },
                    { 1005, 1003, 236, 250, 25, 1, 6, 5, 7, "Gengar", "Gengar", 1007, 1003, 94, 1000 },
                    { 1006, 1003, 236, 250, 25, 1, 6, 5, 7, "Zamazenta", "Zamazenta", 1001, 1017, 889, 1000 },
                    { 1007, 1003, 236, 250, 25, 1, 4, 14, 5, "Charmander", "Charmander", 1009, 1018, 4, 100 },
                    { 1008, 1030, 236, 250, 25, 92, 1, 89, 87, "Squirtle", "Squirtle", 1010, 1018, 7, 100 },
                    { 1009, 1024, 236, 250, 25, 1, 9, 11, 10, "Bulbasaur", "Bulbasaur", 1011, 1003, 1, 100 },
                    { 1010, 1003, 236, 250, 25, 124, 10, 122, 121, "Chikorita", "Chikorita", 1011, 1018, 152, 100 },
                    { 1011, 1016, 236, 250, 25, 28, 15, 4, 5, "Cyndaquil", "Cyndaquil", 1009, 1018, 155, 1000 },
                    { 1012, 1003, 63, 250, 6, 1, 89, 92, 90, "Totodile", "Totodile", 1010, 1018, 158, 95 },
                    { 1013, 1003, 62, 250, 5, 124, 10, 122, 121, "Treecko", "Treecko", 1011, 1018, 252, 50 },
                    { 1014, 1016, 62, 250, 4, 28, 15, 4, 5, "Torchic", "Torchic", 1009, 1018, 255, 25 },
                    { 1015, 1018, 62, 250, 4, 1, 89, 92, 90, "Mudkip", "Mudkip", 1010, 1018, 258, 75 },
                    { 1016, 1024, 64, 250, 4, 1, 110, 95, 122, "Turtwig", "Turtwig", 1010, 1018, 387, 100 },
                    { 1017, 1016, 62, 250, 5, 28, 15, 4, 5, "Chimchar", "Torchic", 1009, 1018, 390, 62 },
                    { 1018, 1002, 63, 250, 5, 1, 87, 92, 89, "Piplup", "Piplup", 1010, 1018, 393, 52 },
                    { 1019, 1004, 300, 300, 14, 32, 17, 31, 7, "Latias", "Latias", 1015, 1013, 380, 400 },
                    { 1020, 1028, 62, 250, 7, 9, 103, 10, 122, "Snivy", "Snivy", 1011, 1018, 495, 81 },
                    { 1021, 1015, 62, 225, 5, 125, 5, 16, 4, "Tepig", "Tepig", 1009, 1018, 498, 99 },
                    { 1022, 1009, 62, 225, 5, 89, 87, 90, 88, "Oshawott", "Oshawott", 1010, 1018, 501, 59 },
                    { 1023, 1024, 63, 225, 4, 122, 104, 121, 110, "Chespin", "Chespin", 1011, 1018, 650, 90 },
                    { 1024, 1028, 63, 225, 4, 127, 125, 4, 5, "Fennekin", "Fennekin", 1009, 1018, 653, 90 },
                    { 1025, 1010, 63, 225, 3, 90, 87, 21, 55, "Froakie", "Froakie", 1010, 1018, 656, 70 },
                    { 1026, 1032, 63, 225, 3, 10, 121, 9, 122, "Grookey", "Grookey", 1011, 1018, 810, 50 },
                    { 1027, 1004, 64, 225, 3, 82, 1, 13, 11, "Rowlet", "Rowlet", 1011, 1002, 722, 15 },
                    { 1028, 1019, 63, 225, 4, 93, 4, 1, 5, "Litten", "Litten", 1009, 1018, 725, 43 },
                    { 1029, 1001, 63, 225, 4, 89, 87, 24, 1, "Popplio", "Popplio", 1010, 1018, 728, 75 },
                    { 1030, 1011, 63, 225, 4, 90, 87, 97, 95, "Sobble", "Sobble", 1010, 1018, 816, 40 },
                    { 1031, 1026, 63, 225, 4, 121, 9, 12, 10, "Sprigatito", "Sprigatito", 1011, 1018, 906, 43 },
                    { 1032, 1019, 63, 225, 4, 93, 4, 1, 5, "Fuecoco", "Fuecoco", 1009, 1018, 909, 98 },
                    { 1033, 1019, 63, 225, 5, 1, 87, 89, 88, "Quaxly", "Quaxly", 1010, 1018, 912, 61 },
                    { 1034, 1034, 340, 350, 20, 120, 17, 7, 38, "Mewtwo", "Mewtwo", 1013, 1018, 150, 1220 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DeviceCodes_DeviceCode",
                table: "DeviceCodes",
                column: "DeviceCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DeviceCodes_Expiration",
                table: "DeviceCodes",
                column: "Expiration");

            migrationBuilder.CreateIndex(
                name: "IX_HealthItemEntityPlayerItemInventoryEntity_PlayerInventoryId",
                table: "HealthItemEntityPlayerItemInventoryEntity",
                column: "PlayerInventoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Keys_Use",
                table: "Keys",
                column: "Use");

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_ConsumedTime",
                table: "PersistedGrants",
                column: "ConsumedTime");

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_Expiration",
                table: "PersistedGrants",
                column: "Expiration");

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_SubjectId_ClientId_Type",
                table: "PersistedGrants",
                columns: new[] { "SubjectId", "ClientId", "Type" });

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_SubjectId_SessionId_Type",
                table: "PersistedGrants",
                columns: new[] { "SubjectId", "SessionId", "Type" });

            migrationBuilder.CreateIndex(
                name: "IX_PlayerEntityPokemonEntity_PlayerId",
                table: "PlayerEntityPokemonEntity",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerItemInventoryEntityPokeBallEntity_PokeBallsId",
                table: "PlayerItemInventoryEntityPokeBallEntity",
                column: "PokeBallsId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerItemInventoryEntityRejuvenationItemEntity_ReviveItemsId",
                table: "PlayerItemInventoryEntityRejuvenationItemEntity",
                column: "ReviveItemsId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerItemInventoryEntityStatusConditionItemEntity_RemoveStatusConditionItemsId",
                table: "PlayerItemInventoryEntityStatusConditionItemEntity",
                column: "RemoveStatusConditionItemsId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerItemInventoryEntityTechnicalMachineMoveEntity_TMsId",
                table: "PlayerItemInventoryEntityTechnicalMachineMoveEntity",
                column: "TMsId");

            migrationBuilder.CreateIndex(
                name: "IX_Players_ItemIventoryId",
                table: "Players",
                column: "ItemIventoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Players_UserId",
                table: "Players",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Pokemon_AbilityId",
                table: "Pokemon",
                column: "AbilityId");

            migrationBuilder.CreateIndex(
                name: "IX_Pokemon_MoveFourId",
                table: "Pokemon",
                column: "MoveFourId");

            migrationBuilder.CreateIndex(
                name: "IX_Pokemon_MoveOneId",
                table: "Pokemon",
                column: "MoveOneId");

            migrationBuilder.CreateIndex(
                name: "IX_Pokemon_MoveThreeId",
                table: "Pokemon",
                column: "MoveThreeId");

            migrationBuilder.CreateIndex(
                name: "IX_Pokemon_MoveTwoId",
                table: "Pokemon",
                column: "MoveTwoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pokemon_PokeTypeIdOne",
                table: "Pokemon",
                column: "PokeTypeIdOne");

            migrationBuilder.CreateIndex(
                name: "IX_Pokemon_PokeTypeIdTwo",
                table: "Pokemon",
                column: "PokeTypeIdTwo");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonEntityTrainerOpponentEntity_UsablePokemonId",
                table: "PokemonEntityTrainerOpponentEntity",
                column: "UsablePokemonId");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonMoves_StatusConditionId",
                table: "PokemonMoves",
                column: "StatusConditionId");

            migrationBuilder.CreateIndex(
                name: "IX_TMs_StatusConditionId",
                table: "TMs",
                column: "StatusConditionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "DeviceCodes");

            migrationBuilder.DropTable(
                name: "HealthItemEntityPlayerItemInventoryEntity");

            migrationBuilder.DropTable(
                name: "Keys");

            migrationBuilder.DropTable(
                name: "PersistedGrants");

            migrationBuilder.DropTable(
                name: "PlayerEntityPokemonEntity");

            migrationBuilder.DropTable(
                name: "PlayerItemInventoryEntityPokeBallEntity");

            migrationBuilder.DropTable(
                name: "PlayerItemInventoryEntityRejuvenationItemEntity");

            migrationBuilder.DropTable(
                name: "PlayerItemInventoryEntityStatusConditionItemEntity");

            migrationBuilder.DropTable(
                name: "PlayerItemInventoryEntityTechnicalMachineMoveEntity");

            migrationBuilder.DropTable(
                name: "PokemonEntityTrainerOpponentEntity");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "HealthRestoratinItems");

            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "PokeBalls");

            migrationBuilder.DropTable(
                name: "ReviveItems");

            migrationBuilder.DropTable(
                name: "StatusConditionItems");

            migrationBuilder.DropTable(
                name: "TMs");

            migrationBuilder.DropTable(
                name: "Opponents");

            migrationBuilder.DropTable(
                name: "Pokemon");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "PlayerItemInventories");

            migrationBuilder.DropTable(
                name: "PokemonAbilities");

            migrationBuilder.DropTable(
                name: "PokemonMoves");

            migrationBuilder.DropTable(
                name: "PokemonTypes");

            migrationBuilder.DropTable(
                name: "StatusConditions");
        }
    }
}
