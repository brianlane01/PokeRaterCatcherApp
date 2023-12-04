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
                name: "HealthRestorationItems",
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
                    table.PrimaryKey("PK_HealthRestorationItems", x => x.Id);
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
                    NameOfPlayer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfPotions = table.Column<int>(type: "int", nullable: false),
                    NumberOfSuperPotions = table.Column<int>(type: "int", nullable: false),
                    NumberOfHyperPotions = table.Column<int>(type: "int", nullable: false),
                    NumberOfMaxPotions = table.Column<int>(type: "int", nullable: false),
                    NumberOfRevives = table.Column<int>(type: "int", nullable: false),
                    NumberOfMaxRevives = table.Column<int>(type: "int", nullable: false),
                    NumberOfPokeBalls = table.Column<int>(type: "int", nullable: false),
                    NumberOfGreatBalls = table.Column<int>(type: "int", nullable: false),
                    NumberOfUltraBalls = table.Column<int>(type: "int", nullable: false),
                    NumberOfMasterBalls = table.Column<int>(type: "int", nullable: false),
                    NumberOfAntidotes = table.Column<int>(type: "int", nullable: false),
                    NumberOfParalyzeHeals = table.Column<int>(type: "int", nullable: false),
                    NumberOfAwakening = table.Column<int>(type: "int", nullable: false),
                    NumberOfBurnHeals = table.Column<int>(type: "int", nullable: false),
                    NumberOfIceHeals = table.Column<int>(type: "int", nullable: false),
                    NumberOfFullHeals = table.Column<int>(type: "int", nullable: false),
                    NumberOfEnergyPowder = table.Column<int>(type: "int", nullable: false),
                    NumberOfEnergyRoot = table.Column<int>(type: "int", nullable: false),
                    NumberOfHealPowder = table.Column<int>(type: "int", nullable: false),
                    NumberOfRevivalHerb = table.Column<int>(type: "int", nullable: false),
                    NumberOfSodaPop = table.Column<int>(type: "int", nullable: false),
                    NumberOfLemonade = table.Column<int>(type: "int", nullable: false),
                    NumberOfMoomooMilk = table.Column<int>(type: "int", nullable: false),
                    NumberOfBerryJuice = table.Column<int>(type: "int", nullable: false),
                    NumberOfSacredAsh = table.Column<int>(type: "int", nullable: false),
                    NumberOfRageCandyBar = table.Column<int>(type: "int", nullable: false),
                    NumberOfLavaCookie = table.Column<int>(type: "int", nullable: false),
                    NumberOfCasteliacone = table.Column<int>(type: "int", nullable: false),
                    NumberOfOldGateau = table.Column<int>(type: "int", nullable: false),
                    NumberOfShalourSable = table.Column<int>(type: "int", nullable: false),
                    NumberOfLumioseGalette = table.Column<int>(type: "int", nullable: false),
                    NumberOfFineRemendy = table.Column<int>(type: "int", nullable: false),
                    NumberOfSafariBall = table.Column<int>(type: "int", nullable: false),
                    NumberOfPremierBall = table.Column<int>(type: "int", nullable: false),
                    NumberOfRepeatBall = table.Column<int>(type: "int", nullable: false),
                    NumberOfTimerBall = table.Column<int>(type: "int", nullable: false),
                    NumberOfNestBall = table.Column<int>(type: "int", nullable: false),
                    NumberOfNetBall = table.Column<int>(type: "int", nullable: false),
                    NumberOfDiveBall = table.Column<int>(type: "int", nullable: false),
                    NumberOfLuxuryBall = table.Column<int>(type: "int", nullable: false),
                    NumberOfHealBall = table.Column<int>(type: "int", nullable: false),
                    NumberOfQuickBall = table.Column<int>(type: "int", nullable: false),
                    NumberOfDuskBall = table.Column<int>(type: "int", nullable: false),
                    NumberOfCherishBall = table.Column<int>(type: "int", nullable: false),
                    NumberOfFullRestore = table.Column<int>(type: "int", nullable: false),
                    NumberOfFreshWater = table.Column<int>(type: "int", nullable: false)
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
                        name: "FK_HealthItemEntityPlayerItemInventoryEntity_HealthRestorationItems_HealthItemsId",
                        column: x => x.HealthItemsId,
                        principalTable: "HealthRestorationItems",
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
                name: "InventoryHealthItems",
                columns: table => new
                {
                    PlayerInventoryId = table.Column<int>(type: "int", nullable: false),
                    HealthItemId = table.Column<int>(type: "int", nullable: false),
                    PlayerItemInventoryId = table.Column<int>(type: "int", nullable: false),
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
                        column: x => x.PlayerItemInventoryId,
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
                    ItemInventoryId = table.Column<int>(type: "int", nullable: true)
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
                        name: "FK_Players_PlayerItemInventories_ItemInventoryId",
                        column: x => x.ItemInventoryId,
                        principalTable: "PlayerItemInventories",
                        principalColumn: "Id");
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
                name: "PlayerPokemon",
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
                    table.PrimaryKey("PK_PlayerPokemon", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlayerPokemon_PokemonAbilities_AbilityId",
                        column: x => x.AbilityId,
                        principalTable: "PokemonAbilities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayerPokemon_PokemonMoves_MoveFourId",
                        column: x => x.MoveFourId,
                        principalTable: "PokemonMoves",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_PlayerPokemon_PokemonMoves_MoveOneId",
                        column: x => x.MoveOneId,
                        principalTable: "PokemonMoves",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_PlayerPokemon_PokemonMoves_MoveThreeId",
                        column: x => x.MoveThreeId,
                        principalTable: "PokemonMoves",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_PlayerPokemon_PokemonMoves_MoveTwoId",
                        column: x => x.MoveTwoId,
                        principalTable: "PokemonMoves",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_PlayerPokemon_PokemonTypes_PokeTypeIdOne",
                        column: x => x.PokeTypeIdOne,
                        principalTable: "PokemonTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayerPokemon_PokemonTypes_PokeTypeIdTwo",
                        column: x => x.PokeTypeIdTwo,
                        principalTable: "PokemonTypes",
                        principalColumn: "Id");
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
                name: "PlayerEntityPlayerPokemonEntity",
                columns: table => new
                {
                    ActivePokemonId = table.Column<int>(type: "int", nullable: false),
                    PlayerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerEntityPlayerPokemonEntity", x => new { x.ActivePokemonId, x.PlayerId });
                    table.ForeignKey(
                        name: "FK_PlayerEntityPlayerPokemonEntity_PlayerPokemon_ActivePokemonId",
                        column: x => x.ActivePokemonId,
                        principalTable: "PlayerPokemon",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayerEntityPlayerPokemonEntity_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
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
                table: "HealthRestorationItems",
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
                    { 127, 100, 0, true, 15, "The user torches everything around it in an inferno of scarlet flames. This may also leave those it hits with a burn.", "Lava Plume", 80, false, "Fire", 436, 1002 },
                    { 128, 85, 0, true, 5, "The target is attacked with an intense blast of all-consuming fire. This may also leave the target with a burn.", "Fire Blast", 110, false, "Fire", 126, 1002 },
                    { 129, 100, 0, true, 15, "The user transforms into a copy of the target right down to having the same move set.", "Transform", 0, false, "Normal", 53, 1002 },
                    { 130, 100, 20, false, 15, "A nutrient-draining attack. The user's HP is restored by half the damage taken by the target.", "Mega Drain", 40, true, "Grass", 72, 1007 },
                    { 131, 100, 0, true, 10, "Unsanitary sludge is hurled at the target. This may also poison the target.", "Sludge Bomb", 90, false, "Poison", 188, 1004 },
                    { 132, 100, 0, true, 10, "The user strikes everything around it by swamping the area with a giant sludge wave. This may also poison those hit.", "Sludge Wave", 95, false, "Poison", 482, 1004 },
                    { 133, 100, 0, true, 20, "The target is stabbed with a tentacle or arm steeped in poison. This may also poison the target.", "Poison Jab", 80, false, "Poison", 398, 1004 },
                    { 134, 100, 0, true, 20, "The user spits fluid that works to melt the target. This harshly lowers the target's Sp. Def stat.", "Acid Spray", 40, false, "Poison", 491, 1004 },
                    { 135, 100, 0, true, 30, "A move that leaves the target badly poisoned. Its poison damage worsens every turn.", "Toxic", 40, false, "Poison", 51, 1004 },
                    { 136, 100, 0, false, 30, " A spray of countless bubbles is jetted at the opposing Pokémon. This may also lower their Speed stats.", "Bubble", 40, false, "Water", 474, 1004 }
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
                columns: new[] { "Id", "AbilityId", "BaseExperience", "Description", "Health", "Height", "MoveFourId", "MoveOneId", "MoveThreeId", "MoveTwoId", "Name", "PokeNickName", "PokeTypeIdOne", "PokeTypeIdTwo", "PokedexNumber", "Weight" },
                values: new object[,]
                {
                    { 1001, 1009, 236, "Eevee has an unstable genetic makeup that suddenly mutates due to the environment in which it lives. Radiation from various stones causes this Pokémon to evolve.", 250, 25, 9, 5, 15, 7, "Eevee", "Eevee", 1000, 1018, 133, 1000 },
                    { 1002, 1001, 236, "Whenever Pikachu comes across something new, it blasts it with a jolt of electricity. If you come across a blackened berry, it's evidence that this Pokémon mistook the intensity of its charge.", 250, 25, 4, 5, 13, 1, "Pikachu", "Pikachu", 1012, 1018, 25, 1000 },
                    { 1003, 1001, 236, "It nests in small, horizontal holes in cave walls. It pounces to catch prey that stray too close.", 250, 25, 4, 5, 13, 1, "Gible", "Gible", 1004, 1018, 443, 1000 },
                    { 1004, 1001, 236, "It has special pads on the backs of its feet, and one on its nose. Once it's raring to fight, these pads radiate tremendous heat.", 250, 25, 1, 6, 5, 7, "Scorbunny", "Scorbunny", 1009, 1018, 813, 1000 },
                    { 1005, 1003, 236, "It is said to emerge from darkness to steal the lives of those who become lost in mountains.", 250, 25, 1, 6, 5, 7, "Gengar", "Gengar", 1007, 1003, 94, 1000 },
                    { 1006, 1003, 236, "This Pokémon slept for aeons while in the form of a statue. It was asleep for so long, people forgot that it ever existed.", 250, 25, 1, 6, 5, 7, "Zamazenta", "Zamazenta", 1001, 1017, 889, 1000 },
                    { 1007, 1003, 236, "The flame on its tail indicates Charmander's life force. If it is healthy, the flame burns brightly.", 250, 25, 1, 4, 14, 5, "Charmander", "Charmander", 1009, 1018, 4, 100 },
                    { 1008, 1030, 236, "When it retracts its long neck into its shell, it squirts out water with vigorous force.", 250, 25, 92, 1, 89, 87, "Squirtle", "Squirtle", 1010, 1018, 7, 100 },
                    { 1009, 1024, 236, "A strange seed was planted on its back at birth. The plant sprouts and grows with this Pokémon.", 250, 25, 1, 9, 11, 10, "Bulbasaur", "Bulbasaur", 1011, 1003, 1, 100 },
                    { 1010, 1003, 236, "It loves to bask in the sunlight. It uses the leaf on its head to seek out warm places.", 250, 25, 124, 10, 122, 121, "Chikorita", "Chikorita", 1011, 1018, 152, 100 },
                    { 1011, 1016, 236, "It has a timid nature. If it is startled, the flames on its back burn more vigorously.", 250, 25, 28, 15, 4, 5, "Cyndaquil", "Cyndaquil", 1009, 1018, 155, 1000 },
                    { 1012, 1003, 63, "Its well-developed jaws are powerful and capable of crushing anything. Even its trainer must be careful.", 250, 6, 1, 89, 92, 90, "Totodile", "Totodile", 1010, 1018, 158, 95 },
                    { 1013, 1003, 62, "It makes its nest in a giant tree in the forest. It ferociously guards against anything nearing its territory.", 250, 5, 124, 10, 122, 121, "Treecko", "Treecko", 1011, 1018, 252, 50 },
                    { 1014, 1016, 62, "It has a flame sac inside its belly that perpetually burns. It feels warm if it is hugged.", 250, 4, 28, 15, 4, 5, "Torchic", "Torchic", 1009, 1018, 255, 25 },
                    { 1015, 1018, 62, "The fin on Mudkip's head acts as highly sensitive radar. Using this fin to sense movements of water and air, this Pokémon can determine what is taking place around it without using its eyes.", 250, 4, 1, 89, 92, 90, "Mudkip", "Mudkip", 1010, 1018, 258, 75 },
                    { 1016, 1024, 64, "It undertakes photosynthesis with its body, making oxygen. The leaf on its head wilts if it is thirsty.", 250, 4, 1, 110, 95, 122, "Turtwig", "Turtwig", 1010, 1018, 387, 100 },
                    { 1017, 1016, 62, "It agilely scales sheer cliffs to live atop craggy mountains. Its fire is put out when it sleeps.", 250, 5, 28, 15, 4, 5, "Chimchar", "Torchic", 1009, 1018, 390, 62 },
                    { 1018, 1002, 63, "Because it is very proud, it hates accepting food from people. Its thick down guards it from cold.", 250, 5, 1, 87, 92, 89, "Piplup", "Piplup", 1010, 1018, 393, 52 },
                    { 1019, 1004, 300, "Latias is highly intelligent and capable of understanding human speech. It is covered with a glass-like down. The Pokémon enfolds its body with its down and refracts light to alter its appearance.", 300, 14, 32, 17, 31, 7, "Latias", "Latias", 1015, 1013, 380, 400 },
                    { 1020, 1028, 62, "They photosynthesize by bathing their tails in sunlight. When they are not feeling well, their tails droop.", 250, 7, 9, 103, 10, 122, "Snivy", "Snivy", 1011, 1018, 495, 81 },
                    { 1021, 1015, 62, "It can deftly dodge its foe's attacks while shooting fireballs from its nose. It roasts berries before it eats them.", 225, 5, 125, 5, 16, 4, "Tepig", "Tepig", 1009, 1018, 498, 99 },
                    { 1022, 1009, 62, "It fights using the scalchop on its stomach. In response to an attack, it retaliates immediately by slashing.", 225, 5, 89, 87, 90, 88, "Oshawott", "Oshawott", 1010, 1018, 501, 59 },
                    { 1023, 1024, 63, "The quills on its head are usually soft. When it flexes them, the points become so hard and sharp that they can pierce rock.", 225, 4, 122, 104, 121, 110, "Chespin", "Chespin", 1011, 1018, 650, 90 },
                    { 1024, 1028, 63, "Eating a twig fills it with energy, and its roomy ears give vent to air hotter than 390 degrees Fahrenheit.", 225, 4, 127, 125, 4, 5, "Fennekin", "Fennekin", 1009, 1018, 653, 90 },
                    { 1025, 1010, 63, "It secretes flexible bubbles from its chest and back. The bubbles reduce the damage it would otherwise take when attacked.", 225, 3, 90, 87, 21, 55, "Froakie", "Froakie", 1010, 1018, 656, 70 },
                    { 1026, 1032, 63, "It attacks with rapid beats of its stick. As it strikes with amazing speed, it gets more and more pumped.", 225, 3, 10, 121, 9, 122, "Grookey", "Grookey", 1011, 1018, 810, 50 },
                    { 1027, 1004, 64, "It sends its feathers, which are as sharp as blades, flying in attack. Its legs are strong, and its aim is excellent.", 225, 3, 82, 1, 13, 11, "Rowlet", "Rowlet", 1011, 1002, 722, 15 },
                    { 1028, 1019, 63, "While grooming itself, it builds up fur inside its stomach. It sets the fur alight and spews fiery attacks, which change based on how it coughs.", 225, 4, 93, 4, 1, 5, "Litten", "Litten", 1009, 1018, 725, 43 },
                    { 1029, 1001, 63, "It can throw bubble-covered pebbles with precise control, hitting empty cans up to a hundred feet away.", 225, 4, 89, 87, 24, 1, "Popplio", "Popplio", 1010, 1018, 728, 75 },
                    { 1030, 1011, 63, "When scared, this Pokémon cries. Its tears pack the chemical punch of 100 onions, and attackers won't be able to resist weeping.", 225, 4, 90, 87, 97, 95, "Sobble", "Sobble", 1010, 1018, 816, 40 },
                    { 1031, 1026, 63, "It has a habit of biting anything with its developed jaws. Even its Trainer needs to be careful.", 225, 4, 121, 9, 12, 10, "Sprigatito", "Sprigatito", 1011, 1018, 906, 43 },
                    { 1032, 1019, 63, "It stores flammable gas in its body and uses it to generate heat. The yellow sections on its belly get particularly hot.", 225, 4, 93, 4, 1, 5, "Fuecoco", "Fuecoco", 1009, 1018, 909, 98 },
                    { 1033, 1019, 63, "It dives underwater to hunt prey. When swimming rapidly, it rockets out of the water and startles prey.", 225, 5, 1, 87, 89, 88, "Quaxly", "Quaxly", 1010, 1018, 912, 61 },
                    { 1034, 1034, 340, "A Pokémon created by recombining Mew's genes. It's said to have the most savage heart among Pokémon.", 350, 20, 120, 17, 7, 38, "Mewtwo", "Mewtwo", 1013, 1018, 150, 1220 },
                    { 1035, 1034, 270, "So rare that it is still said to be a mirage by many experts. Only a few people have seen it worldwide.", 350, 4, 120, 17, 7, 38, "Mew", "Mew", 1013, 1018, 151, 40 },
                    { 1036, 1034, 261, "A legendary bird Pokémon that is said to appear from clouds while dropping enormous lightning bolts.", 350, 16, 112, 6, 117, 78, "Zapdos", "Zapdos", 1012, 1002, 145, 526 },
                    { 1037, 1034, 261, "Known as the legendary bird of fire. Every flap of its wings creates a dazzling flash of flames.", 350, 20, 126, 5, 47, 6, "Moltres", "Moltres", 1009, 1002, 146, 600 },
                    { 1038, 1034, 261, "A legendary bird Pokémon. It can create blizzards by freezing moisture in the air.", 350, 17, 79, 78, 74, 80, "Articuno", "Articuno", 1014, 1002, 144, 554 },
                    { 1039, 1034, 261, "RAIKOU embodies the speed of lightning. The roars of this POKéMON send shock waves shuddering through the air and shake the ground as if lightning bolts had come crashing down.", 350, 19, 112, 6, 117, 78, "Raikou", "Raikou", 1012, 1018, 243, 1780 },
                    { 1040, 1034, 261, "ENTEI embodies the passion of magma. This POKéMON is thought to have been born in the eruption of a volcano. It sends up massive bursts of fire that utterly consume all that they touch.", 350, 21, 126, 5, 47, 6, "Entei", "Entei", 1009, 1018, 244, 1980 },
                    { 1041, 1034, 261, "SUICUNE embodies the compassion of a pure spring of water. It runs across the land with gracefulness. This POKéMON has the power to purify dirty water.", 350, 20, 89, 78, 90, 91, "Suicune", "Suicune", 1014, 1018, 245, 1870 },
                    { 1042, 1034, 306, "LUGIA's wings pack devastating power—a light fluttering of its wings can blow apart regular houses. As a result, this POKéMON chooses to live out of sight deep under the sea.", 350, 52, 20, 17, 19, 18, "Lugia", "Lugia", 1013, 1002, 249, 2160 },
                    { 1043, 1034, 306, "HO-OH's feathers glow in seven colors depending on the angle at which they are struck by light. These feathers are said to bring happiness to the bearers. This POKéMON is said to live at the foot of a rainbow.", 350, 38, 126, 5, 47, 6, "Ho-Oh", "Ho-Oh", 1009, 1002, 250, 1990 },
                    { 1044, 1034, 270, "This POKéMON came from the future by crossing over time. It is thought that so long as CELEBI appears, a bright and shining future awaits us.", 350, 6, 120, 17, 121, 124, "Celebi", "Celebi", 1011, 1013, 251, 50 },
                    { 1045, 1034, 302, "KYOGRE has the power to create massive rain clouds that cover the entire sky and bring about torrential downpours. This POKéMON saved people who were suffering from droughts.", 350, 45, 88, 74, 91, 96, "Kyogre", "Kyogre", 1010, 1018, 382, 3520 },
                    { 1046, 1034, 302, "GROUDON has long been described in mythology as the POKéMON that raised lands and expanded continents. This POKéMON took to sleep after a cataclysmic battle with KYOGRE.", 350, 35, 44, 46, 41, 6, "Groudon", "Groudon", 1004, 1018, 383, 9500 },
                    { 1047, 1034, 306, "RAYQUAZA lived for hundreds of millions of years in the earth's ozone layer, never descending to the ground. This POKéMON appears to feed on water and particles in the atmosphere.", 350, 70, 33, 6, 30, 31, "Rayquaza", "Rayquaza", 1015, 1002, 384, 2065 },
                    { 1048, 1034, 270, "The DNA of a space virus underwent a sudden mutation upon exposure to a laser beam and resulted in DEOXYS. The crystalline organ on this POKéMON's chest appears to be its brain.", 350, 17, 20, 17, 19, 18, "Deoxys", "Deoxys", 1013, 1018, 386, 608 },
                    { 1049, 1034, 270, "JIRACHI will awaken from its sleep of a thousand years if you sing to it in a voice of purity. It is said to make true any wish that people desire.", 350, 3, 20, 17, 19, 18, "Jirachi", "Jirachi", 1011, 1013, 385, 11 },
                    { 1050, 1024, 142, "When the bulb on its back grows large, it appears to lose the ability to stand on its hind legs.", 250, 10, 1, 9, 11, 10, "Ivysaur", "Ivysaur", 1011, 1003, 2, 130 },
                    { 1051, 1016, 142, "It has a barbaric nature. In battle, it whips its fiery tail around and slashes away with sharp claws.", 250, 11, 16, 15, 4, 5, "Charmeleon", "Charmeleon", 1009, 1018, 5, 190 },
                    { 1052, 1024, 236, "Its plant blooms when it is absorbing solar energy. It stays on the move to seek sunlight.", 250, 20, 1, 9, 11, 10, "Venusaur", "Venusaur", 1011, 1003, 3, 1000 },
                    { 1053, 1016, 240, "It spits fire that is hot enough to melt boulders. It may cause forest fires by blowing flames.", 250, 17, 16, 15, 14, 5, "Charizard", "Charizard", 1009, 1002, 6, 905 },
                    { 1054, 1018, 239, "It crushes its foe under its heavy body to cause fainting. In a pinch, it will withdraw inside its shell.", 250, 16, 1, 89, 92, 90, "Blastoise", "Blastoise", 1010, 1018, 9, 855 },
                    { 1055, 1018, 142, "It is recognized as a symbol of longevity. If its shell has algae on it, that WARTORTLE is very old.", 250, 10, 91, 89, 92, 90, "Wartortle", "Wartortle", 1010, 1018, 8, 225 },
                    { 1056, 1012, 178, "It loves the honey of flowers and can locate flower patches that have even tiny amounts of pollen.", 250, 11, 20, 17, 19, 18, "Catarpie", "Catarpie", 1006, 1018, 10, 320 },
                    { 1057, 1012, 72, "Its shell is filled with a thick liquid. All of the cells throughout its body are being rebuilt in preparation for evolution.", 250, 7, 20, 17, 19, 18, "Metapod", "Metapod", 1006, 1018, 11, 99 },
                    { 1058, 1012, 178, "It loves the honey of flowers and can locate flower patches that have even tiny amounts of pollen.", 250, 11, 20, 17, 19, 18, "Butterfree", "Butterfree", 1006, 1002, 12, 320 },
                    { 1059, 1012, 39, "Often found in forests, eating leaves. It has a sharp venomous stinger on its head.", 250, 3, 67, 52, 55, 54, "Weedle", "Weedle", 1006, 1003, 13, 32 },
                    { 1060, 1012, 72, "Almost incapable of moving, this POKéMON can only harden its shell to protect itself from predators.", 250, 6, 67, 52, 55, 54, "Kakuna", "Kakuna", 1006, 1003, 14, 100 },
                    { 1061, 1012, 178, "It has three poisonous stingers on its forelegs and its tail. They are used to jab its enemy repeatedly.", 250, 10, 67, 52, 55, 54, "Beedrill", "Beedrill", 1006, 1003, 15, 295 },
                    { 1062, 1020, 50, "Very docile. If attacked, it will often kick up sand to protect itself rather than fight back.", 250, 3, 86, 81, 85, 82, "Pidgey", "Pidgey", 1000, 1002, 16, 18 },
                    { 1063, 1020, 122, "The claws on its feet are well developed. It can carry prey such as an EXEGGCUTE to its nest over 60 miles away.", 250, 11, 86, 81, 85, 82, "Pidgeotto", "Pidgeotto", 1000, 1002, 17, 300 },
                    { 1064, 1020, 216, "When hunting, it skims the surface of water at high speed to pick off unwary prey such as MAGIKARP.", 250, 15, 86, 81, 85, 82, "Pidgeot", "Pidgeot", 1000, 1002, 18, 395 },
                    { 1065, 1011, 51, "Bites anything when it attacks. Small and very quick, it is a common sight in many places.", 250, 3, 93, 1, 78, 45, "Rattata", "Rattata", 1000, 1018, 19, 35 },
                    { 1066, 1011, 145, "It uses its whiskers to maintain its balance. It apparently slows down if they are cut off.", 250, 7, 93, 1, 78, 45, "Raticate", "Raticate", 1000, 1018, 20, 185 },
                    { 1067, 1020, 52, "Eats bugs in grassy areas. It has to flap its short wings at high speed to stay airborne.", 250, 3, 86, 81, 85, 82, "Spearow", "Spearow", 1000, 1002, 21, 20 },
                    { 1068, 1020, 155, "With its huge and magnificent wings, it can keep aloft without ever having to land for rest.", 250, 12, 86, 81, 85, 82, "Fearow", "Fearow", 1000, 1002, 22, 380 },
                    { 1069, 1011, 58, "Moves silently and stealthily. Eats the eggs of birds, such as PIDGEY and SPEAROW, whole.", 250, 20, 93, 1, 78, 45, "Ekans", "Ekans", 1003, 1018, 23, 69 },
                    { 1070, 1011, 153, "The pattern on its belly appears to be a frightening face. Weak foes will flee just at the sight of the pattern.", 250, 35, 93, 1, 78, 45, "Arbok", "Arbok", 1003, 1018, 24, 650 },
                    { 1071, 1019, 218, "Its long tail serves as a ground to protect itself from its own high-voltage power.", 250, 8, 113, 118, 116, 117, "Raichu", "Raichu", 1012, 1018, 26, 300 },
                    { 1072, 1011, 60, "Burrows deep underground in arid locations far from water. It only emerges to hunt for food.", 250, 6, 44, 41, 1, 42, "Sandshrew", "Sandshrew", 1004, 1018, 27, 120 },
                    { 1073, 1011, 158, "Curls up into a spiny ball when threatened. It can roll while curled up to attack or escape.", 250, 10, 44, 41, 43, 42, "Sandslash", "Sandslash", 1004, 1018, 28, 295 },
                    { 1074, 1011, 55, "NIDORAN has barbs that secrete a powerful poison. They are thought to have developed as protection for this small-bodied POKéMON. When enraged, it releases a horrible toxin from its horn.", 250, 4, 57, 1, 56, 45, "Nidoran♀", "Nidoran♀", 1003, 1018, 29, 70 },
                    { 1075, 1011, 128, "When NIDORINA are with their friends or family, they keep their barbs tucked away to prevent hurting each other. This POKéMON appears to become nervous if separated from the others.", 250, 8, 57, 1, 56, 45, "Nidorina", "Nidorina", 1003, 1018, 30, 200 },
                    { 1076, 1011, 227, "NIDOQUEEN's body is encased in extremely hard scales. It is adept at sending foes flying with harsh tackles. This POKéMON is at its strongest when it is defending its young.", 250, 13, 57, 1, 56, 45, "Nidoqueen", "Nidoqueen", 1003, 1004, 31, 600 },
                    { 1077, 1011, 55, "NIDORAN has developed muscles for moving its ears. Thanks to them, the ears can be freely moved in any direction. Even the slightest sound does not escape this POKéMON's notice.", 250, 5, 57, 1, 56, 45, "Nidoran♂", "Nidoran♂", 1003, 1018, 32, 90 },
                    { 1078, 1011, 128, "NIDORINO has a horn that is harder than a diamond. If it senses a hostile presence, all the barbs on its back bristle up at once, and it challenges the foe with all its might.", 250, 9, 57, 1, 56, 45, "Nidorino", "Nidorino", 1003, 1018, 33, 195 },
                    { 1079, 1011, 227, "NIDOKING's thick tail packs enormously destructive power. With one swing, it can topple a metal transmission tower. Once this POKéMON goes on a rampage, there is no stopping it.", 250, 14, 57, 1, 56, 45, "Nidoking", "Nidoking", 1003, 1004, 34, 620 },
                    { 1080, 1011, 113, "Its magical and cute appeal has many admirers. It is rare and found only in certain areas.", 250, 6, 20, 23, 19, 18, "Clefairy", "Clefairy", 1017, 1018, 35, 75 },
                    { 1081, 1011, 217, "A timid fairy POKéMON that is rarely seen. It will run and hide the moment it senses people.", 250, 13, 20, 23, 19, 18, "Clefable", "Clefable", 1017, 1018, 36, 400 },
                    { 1082, 1011, 60, "At the time of birth, it has just one tail. The tail splits from its tip as it grows older.", 250, 6, 16, 5, 14, 6, "Vulpix", "Vulpix", 1009, 1018, 37, 99 },
                    { 1083, 1011, 177, "Very smart and very vengeful. Grabbing one of its many tails could result in a 1000-year curse.", 250, 11, 16, 5, 14, 6, "Ninetales", "Ninetales", 1009, 1018, 38, 199 },
                    { 1084, 1011, 76, "When its huge eyes light up, it sings a mysteriously soothing melody that lulls its enemies to sleep.", 250, 5, 109, 105, 107, 106, "Jigglypuff", "Jigglypuff", 1000, 1017, 39, 55 },
                    { 1085, 1011, 109, "The body is soft and rubbery. When angered, it will suck in air and inflate itself to an enormous size.", 250, 10, 109, 105, 107, 106, "Wigglytuff", "Wigglytuff", 1000, 1017, 40, 120 },
                    { 1086, 1011, 49, "Forms colonies in perpetually dark places. Uses ultrasonic waves to identify and approach targets.", 250, 8, 82, 58, 55, 54, "Zubat", "Zubat", 1003, 1002, 41, 75 },
                    { 1087, 1011, 159, "Once it strikes, it will not stop draining energy from the victim even if it gets too heavy to fly.", 250, 16, 82, 58, 55, 54, "Golbat", "Golbat", 1003, 1002, 42, 550 },
                    { 1088, 1011, 64, "During the day, it keeps its face buried in the ground. At night, it wanders around sowing its seeds.", 250, 5, 97, 11, 10, 12, "Oddish", "Oddish", 1003, 1011, 43, 54 },
                    { 1089, 1011, 138, "The fluid that oozes from its mouth isn't drool. It is a nectar that is used to attract prey.", 250, 8, 97, 11, 10, 12, "Gloom", "Gloom", 1003, 1011, 44, 86 },
                    { 1090, 1011, 221, "The larger its petals, the more toxic pollen it contains. Its big head is heavy and hard to hold up.", 250, 12, 97, 11, 10, 12, "Vileplume", "Vileplume", 1003, 1011, 45, 186 },
                    { 1091, 1011, 57, "Burrows to suck tree roots. The mushrooms on its back grow by drawing nutrients from the bug host.", 250, 3, 67, 99, 66, 97, "Paras", "Paras", 1006, 1011, 46, 54 },
                    { 1092, 1011, 142, "A host-parasite pair in which the parasite mushroom has taken over the host bug. Prefers damp places.", 250, 10, 67, 99, 66, 97, "Parasect", "Parasect", 1006, 1011, 47, 295 },
                    { 1093, 1011, 61, "Lives in the shadows of tall trees where it eats insects. It is attracted by light at night.", 250, 10, 67, 52, 55, 54, "Venonat", "Venonat", 1006, 1003, 48, 300 },
                    { 1094, 1011, 158, "The dust-like scales covering its wings are color coded to indicate the kinds of poison it has.", 250, 15, 67, 52, 55, 54, "Venomoth", "Venomoth", 1006, 1003, 49, 125 },
                    { 1095, 1011, 53, "Lives about one yard underground where it feeds on plant roots. It sometimes appears above ground.", 250, 2, 44, 41, 43, 42, "Diglett", "Diglett", 1004, 1018, 50, 8 },
                    { 1096, 1011, 142, "A team of DIGLETT triplets. It triggers huge earthquakes by burrowing 60 miles underground.", 250, 7, 44, 41, 43, 42, "Dugtrio", "Dugtrio", 1004, 1018, 51, 333 },
                    { 1097, 1011, 58, "Adores circular objects. Wanders the streets on a nightly basis to look for dropped loose change.", 250, 4, 93, 1, 78, 45, "Meowth", "Meowth", 1000, 1018, 52, 42 },
                    { 1098, 1011, 154, "Although its fur has many admirers, it is tough to raise as a pet because of its fickle meanness.", 250, 10, 93, 1, 78, 45, "Persian", "Persian", 1000, 1018, 53, 320 },
                    { 1099, 1010, 64, "While lulling its enemies with its vacant look, this wily POKéMON will use psychokinetic powers.", 250, 8, 95, 89, 92, 90, "Psyduck", "Psyduck", 1011, 1018, 54, 196 },
                    { 1100, 1010, 175, "Often seen swimming elegantly by lake shores. It is often mistaken for the Japanese monster, Kappa.", 250, 17, 95, 89, 92, 90, "Golduck", "Golduck", 1011, 1018, 55, 766 },
                    { 1101, 1030, 61, "Extremely quick to anger. It could be docile one moment then thrashing away the next instant.", 350, 5, 68, 70, 72, 71, "Mankey", "Mankey", 1001, 1018, 56, 280 },
                    { 1102, 1030, 159, "Always furious and tenacious to boot. It will not abandon chasing its quarry until it is caught.", 350, 10, 68, 70, 72, 71, "Primeape", "Primeape", 1001, 1018, 57, 320 },
                    { 1103, 1011, 70, "Very protective of its territory. It will bark and bite to repel intruders from its space.", 250, 7, 16, 5, 14, 6, "Growlithe", "Growlithe", 1009, 1018, 58, 190 },
                    { 1104, 1011, 194, "A POKéMON that has been admired since the past for its beauty. It runs agilely as if on wings.", 250, 19, 16, 5, 14, 6, "Arcanine", "Arcanine", 1009, 1018, 59, 1550 },
                    { 1105, 1011, 60, "Its newly grown legs prevent it from running. It appears to prefer swimming than trying to stand.", 250, 6, 68, 70, 72, 71, "Poliwag", "Poliwag", 1010, 1018, 60, 124 },
                    { 1106, 1011, 135, "Capable of living in or out of water. When out of water, it sweats to keep its body slimy.", 250, 10, 68, 70, 72, 71, "Poliwhirl", "Poliwhirl", 1010, 1018, 61, 200 },
                    { 1107, 1011, 230, "An adept swimmer at both the front crawl and breast stroke. Easily overtakes the best human swimmers.", 250, 13, 68, 70, 72, 71, "Poliwrath", "Poliwrath", 1010, 1001, 62, 540 },
                    { 1108, 1011, 62, "Using its ability to read minds, it will identify impending danger and TELEPORT to safety.", 250, 9, 13, 19, 20, 18, "Abra", "Abra", 1013, 1018, 63, 195 },
                    { 1109, 1011, 140, "It emits special alpha waves from its body that induce headaches just by being close by.", 250, 13, 13, 19, 20, 18, "Kadabra", "Kadabra", 1013, 1018, 64, 565 },
                    { 1110, 1011, 225, "Its brain can outperform a supercomputer. Its intelligence quotient is said to be 5,000.", 250, 15, 13, 19, 20, 18, "Alakazam", "Alakazam", 1013, 1018, 65, 480 },
                    { 1111, 1011, 61, "Loves to build its muscles. It trains in all styles of martial arts to become even stronger.", 250, 8, 68, 70, 72, 71, "Machop", "Machop", 1001, 1018, 66, 195 },
                    { 1112, 1011, 142, "Its muscular body is so powerful, it must wear a power save belt to be able to regulate its motions.", 250, 15, 68, 70, 72, 71, "Machoke", "Machoke", 1001, 1018, 67, 705 },
                    { 1113, 1011, 227, "Using its heavy muscles, it throws powerful punches that can send the victim clear over the horizon.", 250, 16, 68, 70, 72, 71, "Machamp", "Machamp", 1001, 1018, 68, 1300 },
                    { 1114, 1011, 60, "A carnivorous POKéMON that traps and eats bugs. It uses its root feet to soak up needed moisture.", 250, 7, 97, 11, 10, 12, "Bellsprout", "Bellsprout", 1011, 1003, 69, 40 },
                    { 1115, 1011, 137, "It spits out POISONPOWDER to immobilize the enemy and then finishes it with a spray of ACID.", 250, 10, 97, 11, 10, 12, "Weepinbell", "Weepinbell", 1011, 1003, 70, 64 },
                    { 1116, 1011, 216, "Said to live in huge colonies deep in jungles, although no one has ever returned from there.", 250, 17, 97, 11, 10, 12, "Victreebel", "Victreebel", 1011, 1003, 71, 155 },
                    { 1117, 1011, 67, "Drifts in shallow seas. Anglers who hook them by accident are often punished by its stinging acid.", 250, 9, 92, 56, 87, 54, "Tentacool", "Tentacool", 1010, 1003, 72, 455 },
                    { 1118, 1011, 180, "The tentacles are normally kept short. On hunts, they are extended to ensnare and immobilize prey.", 250, 16, 92, 56, 87, 54, "Tentacruel", "Tentacruel", 1010, 1003, 73, 550 },
                    { 1119, 1028, 60, "Found in fields and mountains. Mistaking them for boulders, people often step or trip on them.", 250, 4, 41, 63, 61, 62, "Geodude", "Geodude", 1005, 1004, 74, 200 },
                    { 1120, 1028, 137, "Rolls down slopes to move. It rolls over any obstacle without slowing or changing its direction.", 250, 10, 41, 63, 61, 62, "Graveler", "Graveler", 1005, 1004, 75, 1050 },
                    { 1121, 1028, 223, "Its boulder-like body is extremely hard. It can easily withstand dynamite blasts without damage.", 250, 14, 41, 63, 61, 62, "Golem", "Golem", 1005, 1004, 76, 3000 },
                    { 1122, 1011, 82, "Its hooves are 10 times harder than diamonds. It can trample anything completely flat in little time.", 250, 10, 16, 5, 14, 6, "Ponyta", "Ponyta", 1009, 1018, 77, 300 },
                    { 1123, 1011, 175, "Very competitive, this POKéMON will chase anything that moves fast in the hopes of racing it.", 250, 17, 16, 5, 14, 6, "Rapidash", "Rapidash", 1009, 1018, 78, 950 },
                    { 1124, 1011, 63, "Incredibly slow and dopey. It takes 5 seconds for it to feel pain when under attack.", 250, 12, 95, 89, 92, 90, "Slowpoke", "Slowpoke", 1010, 1013, 79, 360 },
                    { 1125, 1011, 172, "The SHELLDER that is latched onto SLOWPOKE's tail is said to feed on the host's left over scraps.", 250, 16, 95, 89, 92, 90, "Slowbro", "Slowbro", 1010, 1013, 80, 785 },
                    { 1126, 1011, 65, "Uses anti-gravity to stay suspended. Appears without warning and uses THUNDER WAVE and similar moves.", 250, 3, 113, 51, 7, 6, "Magnemite", "Magnemite", 1012, 1008, 81, 60 },
                    { 1127, 1011, 163, "Formed by several MAGNEMITEs linked together. They frequently appear when sunspots flare up.", 250, 10, 113, 51, 7, 6, "Magneton", "Magneton", 1012, 1008, 82, 600 },
                    { 1128, 1001, 132, "The sprig of green onions it holds is its weapon. It is used much like a metal sword.", 250, 8, 81, 1, 95, 93, "Farfetch'd", "Farfetch'd", 1000, 1002, 83, 150 },
                    { 1129, 1011, 62, "A bird that makes up for its poor flying with its fast foot speed. Leaves giant footprints.", 250, 14, 81, 1, 95, 93, "Doduo", "Doduo", 1000, 1002, 84, 392 },
                    { 1130, 1011, 161, "Uses its three brains to execute complex plans. While two heads sleep, one head stays awake.", 250, 18, 81, 1, 95, 93, "Dodrio", "Dodrio", 1000, 1002, 85, 852 },
                    { 1131, 1011, 65, "The protruding horn on its head is very hard. It is used for bashing through thick ice.", 250, 11, 74, 90, 75, 92, "Seel", "Seel", 1010, 1018, 86, 900 },
                    { 1132, 1011, 166, "Stores thermal energy in its body. Swims at a steady 8 knots even in intensely cold waters.", 250, 17, 74, 90, 75, 92, "Dewgong", "Dewgong", 1010, 1014, 87, 1200 },
                    { 1133, 1011, 65, "Appears in filthy areas. Thrives by sucking up polluted sludge that is pumped out of factories.", 250, 9, 57, 54, 58, 55, "Grimer", "Grimer", 1003, 1018, 88, 300 },
                    { 1134, 1011, 175, "Thickly covered with a filthy, vile sludge. It is so toxic, even its footprints contain poison.", 250, 12, 57, 54, 58, 55, "Muk", "Muk", 1003, 1018, 89, 300 },
                    { 1135, 1011, 61, "Its hard shell repels any kind of attack. It is vulnerable only when its shell is open.", 250, 3, 74, 90, 75, 92, "Shellder", "Shellder", 1010, 1018, 90, 40 },
                    { 1136, 1011, 184, "When attacked, it launches its horns in quick volleys. Its innards have never been seen.", 250, 15, 74, 90, 75, 92, "Cloyster", "Cloyster", 1010, 1014, 91, 1325 },
                    { 1137, 1011, 62, "Almost invisible, this gaseous POKéMON cloaks the target and puts it to sleep without notice.", 250, 13, 40, 56, 38, 36, "Gastly", "Gastly", 1007, 1003, 92, 1 },
                    { 1138, 1011, 142, "Because of its ability to slip through block walls, it is said to be from another dimension.", 250, 16, 40, 56, 38, 36, "Haunter", "Haunter", 1007, 1003, 93, 1 },
                    { 1139, 1011, 225, "Under a full moon, this POKéMON likes to mimic the shadows of people and laugh at their fright.", 250, 15, 40, 56, 38, 36, "Gengar", "Gengar", 1007, 1003, 94, 405 },
                    { 1140, 1028, 77, "As it grows, the stone portions of its body harden to become similar to a diamond, but colored black.", 250, 88, 41, 63, 61, 62, "Onix", "Onix", 1005, 1004, 95, 2100 },
                    { 1141, 1011, 66, "Puts enemies to sleep then eats their dreams. Occasionally gets sick from eating bad dreams.", 250, 10, 13, 19, 20, 18, "Drowzee", "Drowzee", 1013, 1018, 96, 324 },
                    { 1142, 1011, 169, "When it locks eyes with an enemy, it will use a mix of PSI moves such as HYPNOSIS and CONFUSION.", 250, 16, 13, 19, 20, 18, "Hypno", "Hypno", 1013, 1018, 97, 756 },
                    { 1143, 1011, 65, "Its pincers are not only powerful weapons, they are used for balance when walking sideways.", 250, 4, 97, 91, 90, 93, "Krabby", "Krabby", 1010, 1018, 98, 65 },
                    { 1144, 1011, 166, "The large pincer has 10000 hp of crushing power. However, its huge size makes it unwieldy to use.", 250, 13, 97, 91, 90, 93, "Kingler", "Kingler", 1010, 1018, 99, 600 },
                    { 1145, 1011, 66, "Usually found in power plants. Easily mistaken for a POKé BALL, they have zapped many people.", 250, 5, 113, 51, 7, 6, "Voltorb", "Voltorb", 1012, 1018, 100, 104 },
                    { 1146, 1011, 172, "It stores electric energy under very high pressure. It often explodes with little or no provocation.", 250, 12, 113, 51, 7, 6, "Electrode", "Electrode", 1012, 1018, 101, 666 },
                    { 1147, 1011, 65, "Often mistaken for eggs. When disturbed, they quickly gather and attack in swarms.", 250, 4, 110, 121, 124, 120, "Exeggcute", "Exeggcute", 1011, 1013, 102, 25 },
                    { 1148, 1011, 182, "Legend has it that on rare occasions, one of its heads will drop off and continue on as an EXEGGCUTE.", 250, 20, 110, 121, 124, 120, "Exeggutor", "Exeggutor", 1011, 1013, 103, 1200 },
                    { 1149, 1001, 64, "Because it never removes its skull helmet, no one has ever seen this POKéMON's real face.", 250, 4, 41, 63, 61, 62, "Cubone", "Cubone", 1004, 1018, 104, 65 },
                    { 1150, 1001, 149, "The bone it holds is its key weapon. It throws the bone skillfully like a boomerang to KO targets.", 250, 10, 41, 63, 61, 62, "Marowak", "Marowak", 1004, 1018, 105, 450 },
                    { 1151, 1011, 159, "When in a hurry, its legs lengthen progressively. It runs smoothly with extra long, loping strides.", 250, 15, 68, 70, 72, 71, "Hitmonlee", "Hitmonlee", 1001, 1018, 106, 498 },
                    { 1152, 1011, 159, "While apparently doing nothing, it fires punches in lightning fast volleys that are impossible to see.", 250, 14, 68, 70, 72, 71, "Hitmonchan", "Hitmonchan", 1001, 1018, 107, 502 },
                    { 1153, 1011, 77, "Its tongue can be extended like a chameleon's. It leaves a tingling sensation when it licks enemies.", 250, 12, 13, 19, 20, 18, "Lickitung", "Lickitung", 1000, 1018, 108, 655 },
                    { 1154, 1011, 68, "Because it stores several kinds of toxic gases in its body, it is prone to exploding without warning.", 250, 6, 57, 54, 58, 55, "Koffing", "Koffing", 1003, 1018, 109, 10 },
                    { 1155, 1011, 172, "Where two kinds of poison gases meet, 2 KOFFINGs can fuse into a WEEZING over many years.", 250, 12, 57, 54, 58, 55, "Weezing", "Weezing", 1003, 1018, 110, 95 },
                    { 1156, 1001, 69, "Its massive bones are 1000 times harder than human bones. It can easily knock a trailer flying.", 250, 10, 41, 42, 61, 62, "Rhyhorn", "Rhyhorn", 1004, 1005, 111, 1150 },
                    { 1157, 1001, 170, "Protected by an armor-like hide, it is capable of living in molten lava of 3,600 degrees.", 250, 19, 41, 42, 61, 62, "Rhydon", "Rhydon", 1004, 1005, 112, 1200 },
                    { 1158, 1002, 395, "A rare and elusive POKéMON that is said to bring happiness to those who manage to get it.", 250, 11, 13, 19, 20, 18, "Chansey", "Chansey", 1000, 1018, 113, 346 },
                    { 1159, 1027, 87, "The whole body is swathed with wide vines that are similar to seaweed. Its vines shake as it walks.", 250, 10, 110, 121, 124, 120, "Tangela", "Tangela", 1011, 1018, 114, 350 },
                    { 1160, 1001, 172, "The infant rarely ventures out of its mother's protective pouch until it is 3 years old.", 250, 22, 93, 95, 96, 98, "Kangaskhan", "Kangaskhan", 1000, 1018, 115, 800 },
                    { 1161, 1011, 59, "Known to shoot down flying bugs with precision blasts of ink from the surface of the water.", 250, 4, 74, 90, 75, 92, "Horsea", "Horsea", 1010, 1018, 116, 80 },
                    { 1162, 1024, 154, "Capable of swimming backwards by rapidly flapping its wing-like pectoral fins and stout tail.", 250, 12, 74, 90, 75, 92, "Seadra", "Seadra", 1010, 1018, 117, 250 },
                    { 1163, 1011, 64, "Its tail fin billows like an elegant ballroom dress, giving it the nickname of the Water Queen.", 250, 6, 74, 90, 75, 92, "Goldeen", "Goldeen", 1010, 1018, 118, 150 },
                    { 1164, 1011, 158, "In the autumn spawning season, they can be seen swimming powerfully up rivers and creeks.", 250, 13, 74, 90, 75, 92, "Seaking", "Seaking", 1010, 1018, 119, 390 },
                    { 1165, 1011, 68, "An enigmatic POKéMON that can effortlessly regenerate any appendage it loses in battle.", 250, 8, 89, 90, 91, 92, "Staryu", "Staryu", 1010, 1018, 120, 345 },
                    { 1166, 1011, 182, "Its central core glows with the seven colors of the rainbow. Some people value the core as a gem.", 250, 11, 89, 90, 91, 92, "Starmie", "Starmie", 1010, 1014, 121, 800 },
                    { 1167, 1011, 161, "If interrupted while it is miming, it will slap around the offender with its broad hands.", 250, 13, 17, 107, 120, 108, "Mr. Mime", "Mr. Mime", 1013, 1017, 122, 545 },
                    { 1168, 1003, 100, "With ninja-like agility and speed, it can create the illusion that there is more than one.", 250, 15, 67, 51, 82, 65, "Scyther", "Scyther", 1006, 1002, 123, 560 },
                    { 1169, 1032, 159, "It seductively wiggles its hips as it walks. It can cause people to dance in unison with it.", 250, 14, 79, 120, 20, 18, "Jynx", "Jynx", 1014, 1013, 124, 406 },
                    { 1170, 1015, 172, "Normally found near power plants, they can wander away and cause major blackouts in cities.", 250, 11, 112, 7, 117, 118, "Electabuzz", "Electabuzz", 1012, 1018, 125, 300 },
                    { 1171, 1016, 173, "Its body always burns with an orange glow that enables it to hide perfectly among flames.", 250, 13, 127, 7, 125, 115, "Magmar", "Magmar", 1009, 1018, 126, 445 },
                    { 1172, 1026, 175, "If it fails to crush the victim in its pincers, it will swing it around and toss it hard.", 250, 15, 28, 64, 65, 67, "Pinsir", "Pinsir", 1006, 1018, 127, 550 },
                    { 1173, 1004, 172, "When it targets an enemy, it charges furiously while whipping its body with its long tails.", 250, 14, 93, 95, 96, 98, "Tauros", "Tauros", 1000, 1018, 128, 884 },
                    { 1174, 1002, 40, "In the distant past, it was somewhat stronger than the horribly weak descendants that exist today.", 250, 9, 1, 92, 87, 91, "Magikarp", "Magikarp", 1010, 1018, 129, 100 },
                    { 1175, 1032, 189, "Rarely seen in the wild. Huge and vicious, it is capable of destroying entire cities in a rage.", 250, 65, 88, 33, 30, 34, "Gyarados", "Gyarados", 1010, 1002, 130, 2350 },
                    { 1176, 1011, 187, "People have driven LAPRAS almost to the point of extinction. In the evenings, it is said to sing plaintively as it seeks what few others of its kind still remain.", 250, 25, 74, 90, 76, 92, "Lapras", "Lapras", 1010, 1014, 131, 2200 },
                    { 1177, 1023, 101, "Capable of copying an enemy's genetic code to instantly transform itself into a duplicate of the enemy.", 250, 3, 13, 96, 129, 95, "Ditto", "Ditto", 1000, 1018, 132, 40 },
                    { 1178, 1030, 184, "Lives close to water. Its long tail is ridged with a fin which is often mistaken for a mermaid's.", 400, 10, 74, 90, 87, 92, "Vaporeon", "Vaporeon", 1010, 1018, 134, 290 },
                    { 1179, 1008, 184, "It accumulates negative ions in the atmosphere to blast out 10000-volt lightning bolts.", 250, 8, 113, 117, 7, 118, "Jolteon", "Jolteon", 1012, 1018, 135, 245 },
                    { 1180, 1007, 184, "When storing thermal energy in its body, its temperature could soar to over 1600 degrees.", 250, 9, 16, 115, 7, 125, "Flareon", "Flareon", 1009, 1018, 136, 250 },
                    { 1181, 1012, 79, "A POKéMON that consists entirely of programming code. Capable of moving freely in cyberspace.", 250, 8, 113, 51, 7, 6, "Porygon", "Porygon", 1000, 1018, 137, 365 },
                    { 1182, 1017, 71, "Although long extinct, in rare cases, it can be genetically resurrected from fossils.", 250, 4, 91, 59, 89, 63, "Omanyte", "Omanyte", 1005, 1010, 138, 75 },
                    { 1183, 1017, 173, "A prehistoric POKéMON that died out when its heavy shell made it impossible to catch prey.", 250, 10, 91, 59, 89, 63, "Omastar", "Omastar", 1005, 1010, 139, 350 },
                    { 1184, 1017, 71, "A POKéMON that was resurrected from a fossil found in what was once the ocean floor eons ago.", 250, 5, 91, 59, 89, 63, "Kabuto", "Kabuto", 1005, 1010, 140, 115 },
                    { 1185, 1017, 173, "Its sleek shape is perfect for swimming. It slashes prey with its claws and drains the body fluids.", 250, 13, 91, 59, 89, 63, "Kabutops", "Kabutops", 1005, 1004, 141, 405 },
                    { 1186, 1004, 180, "A ferocious, prehistoric POKéMON that goes for the enemy's throat with its serrated saw-like fangs.", 250, 18, 82, 59, 81, 63, "Aerodactyl", "Aerodactyl", 1005, 1002, 142, 590 },
                    { 1187, 1001, 189, "Very lazy. Just eats and sleeps. As its rotund bulk builds, it becomes steadily more slothful.", 250, 21, 93, 95, 96, 98, "Snorlax", "Snorlax", 1000, 1018, 143, 4600 },
                    { 1188, 1004, 60, "Long considered a mythical POKéMON until recently when a small colony was found living underwater.", 250, 18, 88, 33, 30, 34, "Dratini", "Dratini", 1015, 1018, 147, 33 },
                    { 1189, 1004, 147, "A mystical POKéMON that exudes a gentle aura. Has the ability to change climate conditions.", 250, 40, 88, 33, 30, 34, "Dragonair", "Dragonair", 1015, 1018, 148, 165 },
                    { 1190, 1004, 270, "Dragonite is capable of circling the globe in just 16 hours. It is a kindhearted Pokémon that leads lost and foundering ships in a storm to the safety of land.", 250, 22, 88, 33, 30, 34, "Dragonite", "Dragonite", 1015, 1002, 149, 2100 },
                    { 1191, 1024, 142, "A spicy aroma emanates from around its neck. The aroma acts as a stimulant to restore health.", 250, 12, 110, 121, 124, 120, "Bayleef", "Bayleef", 1011, 1018, 153, 158 },
                    { 1192, 1024, 236, "The aroma that rises from its petals contains a substance that calms aggressive feelings.", 250, 18, 110, 121, 124, 120, "Meganium", "Meganium", 1011, 1018, 154, 1005 },
                    { 1193, 1005, 62, "Be careful if it turns its back during battle. It means that it will attack with the fire on its back.", 250, 5, 16, 115, 7, 125, "Quilava", "Quilava", 1009, 1018, 156, 79 },
                    { 1194, 1005, 240, "If its rage peaks, it becomes so hot that anything that touches it will instantly go up in flames.", 250, 17, 16, 115, 7, 125, "Typhlosion", "Typhlosion", 1009, 1018, 157, 795 },
                    { 1195, 1006, 66, "Once it bites down, it won't let go until it loses its fangs. New fangs quickly grow into place.", 250, 11, 74, 90, 75, 92, "Croconaw", "Croconaw", 1010, 1018, 159, 250 },
                    { 1196, 1006, 239, "It opens its huge mouth to intimidate enemies. In battle, it runs using its thick and powerful hind legs to charge the foe with incredible speed.", 250, 23, 74, 90, 75, 92, "Feraligator", "Feraligatr", 1010, 1018, 160, 888 },
                    { 1197, 1002, 43, "It stands on its tail so it can see a long way. If it spots an enemy, it cries loudly to warn its kind.", 250, 8, 13, 19, 20, 18, "Sentret", "Sentret", 1000, 1018, 161, 60 },
                    { 1198, 1002, 145, "The mother puts its offspring to sleep by curling up around them. It corners foes with speed.", 250, 18, 13, 19, 20, 18, "Furret", "Furret", 1000, 1018, 162, 325 },
                    { 1199, 1002, 52, "It has an internal organ that senses the earth's rotation. Using this special organ, a HOOTHOOT begins hooting at precisely the same time every day.", 250, 7, 86, 1, 83, 80, "Hoothoot", "Hoothoot", 1000, 1002, 163, 212 },
                    { 1200, 1002, 155, "Its eyes are specially developed to enable it to see clearly even in murky darkness and minimal light.", 250, 16, 86, 1, 83, 80, "Noctowl", "Noctowl", 1000, 1002, 164, 408 },
                    { 1201, 1002, 53, "It is very timid. It will be afraid to move if it is alone. But it will be active if it is in a group.", 250, 10, 67, 51, 82, 65, "Ledyba", "Ledyba", 1006, 1002, 165, 108 },
                    { 1202, 1002, 137, "When the stars flicker in the night sky, it flutters about, scattering a glowing powder.", 250, 14, 67, 51, 82, 65, "Ledian", "Ledian", 1006, 1002, 166, 356 },
                    { 1203, 1002, 50, "It spins a web using fine--but durable--thread. It then waits patiently for prey to be trapped.", 250, 5, 67, 51, 82, 65, "Spinarak", "Spinarak", 1006, 1003, 167, 85 },
                    { 1204, 1002, 137, "It spins string not only from its rear but also from its mouth. It's hard to tell which end is which.", 250, 11, 67, 51, 82, 65, "Ariados", "Ariados", 1006, 1003, 168, 335 },
                    { 1205, 1001, 66, "It shoots positive and negative electricity between the tips of its two antennae and zaps its enemies.", 250, 5, 82, 86, 57, 54, "Crobat", "Crobat", 1003, 1002, 169, 120 },
                    { 1206, 1002, 66, "It shoots positive and negative electricity between the tips of its two antennae and zaps its enemies.", 250, 5, 112, 7, 117, 118, "Chinchou", "Chinchou", 1012, 1010, 170, 120 },
                    { 1207, 1002, 161, "The light it emits is so bright that it can illuminate the sea's surface from a depth of over three miles.", 250, 12, 112, 7, 117, 118, "Lanturn", "Lanturn", 1012, 1010, 171, 225 },
                    { 1208, 1002, 41, "It is not yet skilled at storing electricity. It may send out a jolt if amused or startled.", 250, 3, 112, 7, 117, 118, "Pichu", "Pichu", 1012, 1018, 172, 20 },
                    { 1209, 1002, 44, "Because of its unusual, star-like silhouette, people believe that it came here on a meteor.", 250, 3, 1, 22, 107, 23, "Cleffa", "Cleffa", 1017, 1018, 173, 30 },
                    { 1210, 1002, 42, "Its extremely flexible and elastic body makes it bounce continuously--anytime, anywhere.", 250, 3, 1, 22, 107, 23, "Igglybuff", "Igglybuff", 1017, 1000, 174, 10 },
                    { 1211, 1002, 49, "It is considered to be a symbol of good luck. Its shell is said to be filled with happiness.", 250, 3, 1, 22, 107, 23, "Togepi", "Togepi", 1017, 1018, 175, 15 },
                    { 1212, 1002, 142, "It grows dispirited if it is not with kind people. It can float in midair without moving its wings.", 250, 6, 1, 22, 107, 23, "Togetic", "Togetic", 1017, 1002, 176, 32 },
                    { 1213, 1025, 64, "It usually forages for food on the ground but may, on rare occasions, hop onto branches to peck at shoots.", 250, 2, 101, 17, 119, 18, "Natu", "Natu", 1013, 1002, 177, 20 },
                    { 1214, 1025, 165, "They say that it stays still and quiet because it is seeing both the past and future at the same time.", 250, 15, 101, 17, 119, 18, "Xatu", "Xatu", 1013, 1002, 178, 150 },
                    { 1215, 1002, 56, "Its fluffy wool rubs together and builds a static charge. The more energy is charged, the more brightly the lightbulb at the tip of its tail glows.", 250, 6, 112, 7, 117, 118, "Mareep", "Mareep", 1012, 1018, 179, 78 },
                    { 1216, 1002, 128, "Its fluffy wool rubs together and builds a static charge. The more energy is charged, the more brightly the lightbulb at the tip of its tail glows.", 250, 8, 112, 7, 117, 118, "Flaaffy", "Flaaffy", 1012, 1018, 180, 133 },
                    { 1217, 1002, 230, "The tail's tip shines brightly and can be seen from far away. It acts as a beacon for lost people.", 250, 14, 112, 7, 117, 118, "Ampharos", "Ampharos", 1012, 1018, 181, 1000 },
                    { 1218, 1024, 221, "BELLOSSOM gather at times and seem to dance. They say that the dance is a ritual to summon the sun.", 250, 4, 110, 121, 124, 120, "Bellossom", "Bellossom", 1011, 1018, 182, 58 },
                    { 1219, 1002, 88, "The tip of its tail, which contains oil that is lighter than water, lets it swim without drowning.", 250, 4, 106, 90, 111, 92, "Marill", "Marill", 1010, 1017, 183, 85 },
                    { 1220, 1002, 189, "By keeping still and listening intently, it can even tell how close it is to evolving.", 250, 8, 106, 90, 111, 92, "Azumarill", "Azumarill", 1010, 1017, 184, 285 },
                    { 1221, 1002, 144, "It disguises itself as a tree to avoid attack. It hates water, so it will disappear if it starts raining.", 250, 12, 47, 59, 95, 60, "Sudowoodo", "Sudowoodo", 1005, 1018, 185, 380 },
                    { 1222, 1002, 225, "Whenever three or more of these get together, they sing in a loud voice that sounds like bellowing.", 250, 11, 106, 90, 111, 92, "Politoed", "Politoed", 1010, 1018, 186, 339 },
                    { 1223, 1002, 50, "It drifts on winds. It is said that when Hoppip gather in fields and mountains, spring is on the way.", 250, 4, 110, 121, 124, 120, "Hoppip", "Hoppip", 1011, 1002, 187, 5 },
                    { 1224, 1002, 119, "It blooms when the weather warms. It floats in the sky to soak up as much sunlight as possible.", 250, 6, 110, 121, 124, 120, "Skiploom", "Skiploom", 1011, 1002, 188, 10 },
                    { 1225, 1002, 203, "Once it catches the wind, it deftly controls its cotton-puff spores to float, even around the world.", 250, 8, 110, 121, 124, 120, "Jumpluff", "Jumpluff", 1011, 1002, 189, 30 },
                    { 1226, 1014, 72, "It lives atop tall trees. When leaping from branch to branch, it deftly uses its tail for balance.", 250, 8, 98, 69, 63, 72, "Aipom", "Aipom", 1000, 1018, 190, 115 },
                    { 1227, 1002, 36, "It lives by drinking only dewdrops from under the leaves of plants. It is said that it eats nothing else.", 250, 3, 110, 121, 124, 120, "Sunkern", "Sunkern", 1011, 1018, 191, 18 },
                    { 1228, 1002, 149, "It converts sun light into energy. In the darkness after sunset, it closes its petals and becomes still.", 250, 8, 110, 121, 124, 120, "Sunflora", "Sunflora", 1011, 1018, 192, 85 },
                    { 1229, 1028, 78, "Its large eyes can scan 360 degrees. It looks in all directions to seek out insects as its prey.", 250, 12, 65, 66, 21, 67, "Yanma", "Yanma", 1006, 1002, 193, 380 },
                    { 1230, 1002, 42, "When walking on land, it covers its body with a poisonous film that keeps its skin from dehydrating.", 250, 4, 44, 42, 89, 88, "Wooper", "Wooper", 1010, 1004, 194, 85 },
                    { 1231, 1012, 151, "It has a sluggish nature. It lies at the river's bottom, waiting for prey to stray into its mouth.", 250, 14, 44, 42, 89, 88, "Quagsire", "Quagsire", 1010, 1004, 195, 750 },
                    { 1232, 1019, 184, "It uses the fine hair that covers its body to sense air currents and predict its enemy's actions.", 250, 9, 120, 17, 101, 18, "Espeon", "Espeon", 1013, 1018, 196, 265 },
                    { 1233, 1019, 184, "When darkness falls, the rings on the body begin to glow, striking fear in the hearts of anyone nearby.", 250, 10, 8, 26, 21, 29, "Umbreon", "Umbreon", 1016, 1018, 197, 270 },
                    { 1234, 1019, 81, "It is said that when chased, it lures its attacker onto dark mountain trails where the foe will get lost.", 250, 5, 102, 26, 21, 29, "Murkrow", "Murkrow", 1016, 1002, 198, 21 },
                    { 1235, 1034, 172, "Every time it yawns, Shellder injects more poison into it. The poison makes it more intelligent.", 250, 20, 74, 20, 75, 21, "Slowking", "Slowking", 1010, 1013, 199, 795 },
                    { 1236, 1026, 87, "It likes playing mischievous tricks such as screaming and wailing to startle people at night.", 250, 7, 40, 35, 36, 37, "Misdreavus", "Misdreavus", 1007, 1018, 200, 10 },
                    { 1237, 1002, 118, "Their shapes look like hieroglyphs on ancient tablets. It is said the two are somehow related.", 250, 5, 1, 17, 107, 18, "Unown", "Unown", 1013, 1018, 201, 50 },
                    { 1238, 1002, 142, "It hates light and shock. If attacked, it inflates its body to pump up its counterstrike.", 250, 13, 40, 35, 36, 37, "Wobbuffet", "Wobbuffet", 1013, 1018, 202, 285 },
                    { 1239, 1019, 159, "Its tail has a small brain of its own. Beware! If you get close, it may react to your scent and bite.", 250, 15, 120, 17, 119, 18, "Girafarig", "Girafarig", 1013, 1000, 203, 415 },
                    { 1240, 1002, 58, "It likes to make its shell thicker by adding layers of tree bark. The additional weight doesn't bother it.", 250, 6, 103, 66, 1, 67, "Pineco", "Pineco", 1006, 1018, 204, 72 },
                    { 1241, 1002, 163, "It keeps itself inside its steel shell. The shell is opened when it is catching prey, but it is so quick that the shell's inside cannot be seen.", 250, 12, 103, 66, 1, 67, "Forretress", "Forretress", 1006, 1008, 205, 1258 },
                    { 1242, 1002, 145, "It has a drill for a tail. It uses this tail to burrow into the ground backwards. This Pokémon is known to make its nest in complex shapes deep under the ground.", 250, 15, 86, 1, 83, 80, "Dunsparce", "Dunsparce", 1000, 1018, 206, 140 },
                    { 1243, 1027, 86, "It glides without making a single sound. It grasps the face of its foe using its hind and large front claws, then stabs with its poison barb.", 250, 11, 85, 46, 81, 41, "Gligar", "Gligar", 1004, 1002, 207, 648 },
                    { 1244, 1002, 179, "It is said that if an Onix lives for over 100 years, its composition changes to become diamond-like.", 250, 92, 47, 59, 95, 60, "Steelix", "Steelix", 1008, 1004, 208, 4000 },
                    { 1245, 1018, 60, "By baring its fangs and making a scary face, Snubbull sends smaller Pokémon scurrying away in terror. However, this Pokémon seems a little sad at making its foes flee.", 250, 6, 102, 26, 21, 29, "Snubbull", "Snubbull", 1016, 1018, 209, 78 },
                    { 1246, 1018, 158, "It is actually timid and easily spooked. If attacked, it flails about to fend off its attacker.", 250, 14, 102, 26, 21, 29, "Granbull", "Granbull", 1016, 1018, 210, 487 },
                    { 1247, 1027, 88, "It shoots the poison spines on its body in all directions. Its round form makes it a poor swimmer.", 250, 5, 56, 53, 89, 88, "Qwilfish", "Qwilfish", 1010, 1003, 211, 39 },
                    { 1248, 1003, 175, "It swings its eye-patterned pincers up to scare its foes. This makes it look like it has three heads.", 250, 18, 53, 65, 51, 26, "Scizor", "Scizor", 1006, 1008, 212, 1180 },
                    { 1249, 1006, 177, "The berries it stores in its vase-like shell decompose and become a gooey liquid.", 250, 6, 47, 59, 95, 60, "Shuckle", "Shuckle", 1006, 1005, 213, 205 },
                    { 1250, 1002, 175, "This powerful Pokémon thrusts its prized horn under its enemies' bellies then lifts and throws them.", 250, 15, 64, 71, 65, 69, "Heracross", "Heracross", 1006, 1001, 214, 540 },
                    { 1251, 1019, 86, "It feeds on eggs stolen from nests. Its sharply hooked claws rip vulnerable spots on prey.", 250, 9, 74, 26, 21, 29, "Sneasel", "Sneasel", 1016, 1014, 215, 280 },
                    { 1252, 1018, 66, "It always licks honey. Its palm tastes sweet because of all the honey it has absorbed.", 250, 6, 102, 26, 21, 29, "Teddiursa", "Teddiursa", 1000, 1018, 216, 88 },
                    { 1253, 1018, 175, "Although it is a good climber, it prefers to snap trees with its forelegs and eat fallen Berries.", 250, 18, 102, 26, 21, 29, "Ursaring", "Ursaring", 1000, 1018, 217, 1258 },
                    { 1254, 1016, 50, "It is a species of Pokémon that lives in volcanic areas. If its body cools, its skin hardens and immobilizes it.", 250, 7, 127, 7, 126, 16, "Slugma", "Slugma", 1009, 1018, 218, 350 },
                    { 1255, 1016, 151, "Its brittle shell occasionally spouts intense flames that circulate throughout its body.", 250, 8, 127, 7, 126, 16, "Magcargo", "Magcargo", 1009, 1005, 219, 550 },
                    { 1256, 1018, 50, "It rubs its snout on the ground to find and dig up food. It sometimes discovers hot springs.", 250, 4, 78, 46, 76, 41, "Swinub", "Swinub", 1014, 1004, 220, 65 },
                    { 1257, 1018, 158, "It has a very sensitive nose. It can locate mushrooms, berries, and even hot springs buried under ice.", 250, 11, 78, 46, 76, 41, "Piloswine", "Piloswine", 1014, 1004, 221, 558 },
                    { 1258, 1018, 133, "It continuously sheds and grows. The tip of its head is prized as a treasure for its beauty.", 250, 6, 56, 53, 89, 88, "Corsola", "Corsola", 1010, 1005, 222, 50 },
                    { 1259, 1018, 60, "It has superb accuracy. The water it shoots out can strike even moving prey from more than 300 feet.", 250, 6, 92, 87, 89, 88, "Remoraid", "Remoraid", 1010, 1018, 223, 120 },
                    { 1260, 1018, 168, "It traps enemies with its suction-cupped tentacles then smashes them with its rock-hard head.", 250, 9, 92, 87, 89, 88, "Octillery", "Octillery", 1010, 1018, 224, 285 },
                    { 1261, 1018, 116, "It carries food bundled up in its tail. There was a famous explorer who managed to scale Mt. Everest thanks to a Delibird sharing its food.", 250, 9, 82, 24, 84, 74, "Delibird", "Delibird", 1014, 1002, 225, 160 },
                    { 1262, 1018, 170, "It swims along with a school of Remoraid. It leaps out of the water and catches prey Pokémon with its mouth.", 250, 21, 92, 87, 89, 88, "Mantine", "Mantine", 1010, 1002, 226, 2200 },
                    { 1263, 1001, 163, "Its sturdy wings look heavy, but they are actually hollow and light, allowing it to fly freely in the sky.", 250, 17, 47, 59, 95, 60, "Skarmory", "Skarmory", 1008, 1002, 227, 505 },
                    { 1264, 1018, 66, "It uses different kinds of cries for communicating with others of its kind and for pursuing its prey.", 250, 6, 102, 26, 21, 29, "Houndour", "Houndour", 1016, 1009, 228, 108 },
                    { 1265, 1018, 175, "Upon hearing its eerie howls, other Pokémon get the shivers and head straight back to their nests.", 250, 14, 102, 26, 21, 29, "Houndoom", "Houndoom", 1016, 1009, 229, 350 },
                    { 1266, 1009, 243, "It sleeps quietly, deep on the seafloor. When it comes up to the surface, it creates a huge whirlpool that can swallow even ships.", 250, 18, 34, 87, 89, 88, "Kingdra", "Kingdra", 1010, 1015, 230, 1520 },
                    { 1267, 1032, 66, "It swings its long snout around playfully, but because it is so strong, that can be dangerous.", 250, 5, 44, 42, 43, 41, "Phanpy", "Phanpy", 1004, 1018, 231, 335 },
                    { 1268, 1032, 175, "It has sharp, hard tusks and a rugged hide. Its Tackle is strong enough to knock down a house.", 250, 11, 44, 42, 43, 41, "Donphan", "Donphan", 1004, 1018, 232, 1200 },
                    { 1269, 1002, 180, "Further research enhanced its abilities. Sometimes, it may exhibit motions that were not programmed.", 250, 6, 1, 17, 107, 18, "Porygon2", "Porygon2", 1000, 1018, 233, 325 },
                    { 1270, 1018, 163, "The curved antlers subtly change the flow of air to create a strange space where reality is distorted.", 250, 14, 102, 26, 21, 29, "Stantler", "Stantler", 1000, 1018, 234, 712 },
                    { 1271, 1018, 88, "A special fluid oozes from the tip of its tail. It paints the fluid everywhere to mark its territory.", 250, 12, 102, 26, 21, 29, "Smeargle", "Smeargle", 1000, 1018, 235, 580 },
                    { 1272, 1003, 42, "It is always bursting with energy. To make itself stronger, it keeps on fighting even if it loses.", 250, 7, 72, 68, 73, 69, "Tyrogue", "Tyrogue", 1001, 1018, 236, 210 },
                    { 1273, 1003, 159, "If you become enchanted by its smooth, elegant, dance-like kicks, you may get drilled hard.", 250, 14, 72, 68, 73, 69, "Hitmontop", "Hitmontop", 1001, 1018, 237, 480 },
                    { 1274, 1028, 61, "Its lips are the most sensitive parts on its body. It always uses its lips first to examine things.", 250, 4, 1, 17, 107, 18, "Smoochum", "Smoochum", 1014, 1013, 238, 60 },
                    { 1275, 1028, 72, "It generates electricity by whirling its arms. However, it can't store the energy it makes.", 250, 6, 114, 117, 116, 85, "Elekid", "Elekid", 1012, 1018, 239, 235 },
                    { 1276, 1028, 73, "It is found in volcanic craters. Its body temp. is over 1100 degrees, so don't underestimate it.", 250, 7, 127, 7, 126, 16, "Magby", "Magby", 1009, 1018, 240, 214 },
                    { 1277, 1018, 172, "It gives over five gallons of milk daily. Its sweet milk is enjoyed by children and grown-ups alike. People who can't drink milk turn it into yogurt and eat it instead.", 250, 12, 102, 26, 21, 29, "Miltank", "Miltank", 1000, 1018, 241, 755 },
                    { 1278, 1018, 608, "It has a very compassionate nature. If it sees a sick Pokémon, it will nurse the sufferer back to health.", 250, 15, 102, 26, 21, 29, "Blissey", "Blissey", 1000, 1018, 242, 468 },
                    { 1279, 1023, 60, "It feeds on soil. After it has eaten a large mountain, it will fall asleep so it can grow.", 250, 6, 29, 59, 28, 60, "Larvitar", "Larvitar", 1005, 1004, 246, 720 },
                    { 1280, 1023, 144, "Its shell is as hard as sheet rock, and it is also very strong. Its THRASHING can topple a mountain.", 250, 12, 29, 59, 28, 60, "Pupitar", "Pupitar", 1005, 1004, 247, 1520 },
                    { 1281, 1023, 270, "Its body can't be harmed by any sort of attack, so it is very eager to make challenges against enemies.", 250, 20, 29, 59, 28, 60, "Tyranitar", "Tyranitar", 1005, 1004, 248, 2020 }
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
                name: "IX_InventoryHealthItems_HealthItemId",
                table: "InventoryHealthItems",
                column: "HealthItemId");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryHealthItems_PlayerItemInventoryId",
                table: "InventoryHealthItems",
                column: "PlayerItemInventoryId");

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
                name: "IX_PlayerEntityPlayerPokemonEntity_PlayerId",
                table: "PlayerEntityPlayerPokemonEntity",
                column: "PlayerId");

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
                name: "IX_PlayerPokemon_AbilityId",
                table: "PlayerPokemon",
                column: "AbilityId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerPokemon_MoveFourId",
                table: "PlayerPokemon",
                column: "MoveFourId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerPokemon_MoveOneId",
                table: "PlayerPokemon",
                column: "MoveOneId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerPokemon_MoveThreeId",
                table: "PlayerPokemon",
                column: "MoveThreeId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerPokemon_MoveTwoId",
                table: "PlayerPokemon",
                column: "MoveTwoId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerPokemon_PokeTypeIdOne",
                table: "PlayerPokemon",
                column: "PokeTypeIdOne");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerPokemon_PokeTypeIdTwo",
                table: "PlayerPokemon",
                column: "PokeTypeIdTwo");

            migrationBuilder.CreateIndex(
                name: "IX_Players_ItemInventoryId",
                table: "Players",
                column: "ItemInventoryId");

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
                name: "InventoryHealthItems");

            migrationBuilder.DropTable(
                name: "Keys");

            migrationBuilder.DropTable(
                name: "PersistedGrants");

            migrationBuilder.DropTable(
                name: "PlayerEntityPlayerPokemonEntity");

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
                name: "HealthRestorationItems");

            migrationBuilder.DropTable(
                name: "PlayerPokemon");

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
