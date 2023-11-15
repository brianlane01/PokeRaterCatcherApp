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
                    ReviveHealthAmount = table.Column<double>(type: "float", nullable: false)
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
                    RemovesBurn = table.Column<bool>(type: "bit", nullable: false)
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
                name: "HealthRestoratinItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HealthItemName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    HealthItemDescription = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    AmountOfHealthRestored = table.Column<double>(type: "float", nullable: false),
                    PlayerItemInventoryEntityId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthRestoratinItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HealthRestoratinItems_PlayerItemInventories_PlayerItemInventoryEntityId",
                        column: x => x.PlayerItemInventoryEntityId,
                        principalTable: "PlayerItemInventories",
                        principalColumn: "Id");
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
                });

            migrationBuilder.CreateTable(
                name: "Pokemon",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PokedexNumber = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    PlayerEntityId = table.Column<int>(type: "int", nullable: true),
                    TrainerOpponentEntityId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokemon", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pokemon_Opponents_TrainerOpponentEntityId",
                        column: x => x.TrainerOpponentEntityId,
                        principalTable: "Opponents",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Pokemon_Players_PlayerEntityId",
                        column: x => x.PlayerEntityId,
                        principalTable: "Players",
                        principalColumn: "Id");
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
                name: "PokemonAbilities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AbilityName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AbilityEffect = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PokemonEntityId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonAbilities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PokemonAbilities_Pokemon_PokemonEntityId",
                        column: x => x.PokemonEntityId,
                        principalTable: "Pokemon",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PokemonMoves",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MoveName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MoveDescription = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Accuracy = table.Column<int>(type: "int", nullable: false),
                    MoveBasePP = table.Column<int>(type: "int", nullable: false),
                    MovePower = table.Column<int>(type: "int", nullable: false),
                    MoveType = table.Column<string>(type: "nvarchar(55)", maxLength: 55, nullable: false),
                    MoveRestoresHealth = table.Column<bool>(type: "bit", nullable: false),
                    HealthRestorationAmount = table.Column<int>(type: "int", nullable: false),
                    MoveAppliesAStatusCondition = table.Column<bool>(type: "bit", nullable: false),
                    StatusConditionId = table.Column<int>(type: "int", nullable: true),
                    PokemonEntityId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonMoves", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PokemonMoves_Pokemon_PokemonEntityId",
                        column: x => x.PokemonEntityId,
                        principalTable: "Pokemon",
                        principalColumn: "Id");
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
                    MoveName = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    MoveDescription = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    MoveBasePP = table.Column<int>(type: "int", nullable: false),
                    MovePower = table.Column<int>(type: "int", nullable: false),
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
                    PokemonEntityId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TMs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TMs_Pokemon_PokemonEntityId",
                        column: x => x.PokemonEntityId,
                        principalTable: "Pokemon",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TMs_StatusConditions_StatusConditionId",
                        column: x => x.StatusConditionId,
                        principalTable: "StatusConditions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                columns: new[] { "Id", "AbilityEffect", "AbilityName", "PokemonEntityId" },
                values: new object[,]
                {
                    { 1000, "This Pokémon's damaging moves have a 10% chance to make the target flinch with each hit if they do not already cause flinching as a secondary effect. This ability does not stack with a held item. Overworld: The wild encounter rate is halved while this Pokémon is first in the party.", "Stench", null },
                    { 1001, "The weather changes to rain when this Pokémon enters battle and does not end unless replaced by another weather condition. If multiple Pokémon with this ability, drought, sand stream, or snow warning are sent out at the same time, the abilities will activate in order of Speed, respecting trick room. Each ability's weather will cancel the previous weather, and only the weather summoned by the slowest of the Pokémon will stay.", "Drizzle", null },
                    { 1002, "This Pokémon's Speed rises one stage after each turn.", "Speed-Boost", null },
                    { 1003, "This Pokémon's Speed rises one stage after each turn.", "Battle-Armor", null },
                    { 1004, "When this Pokémon is at full HP, any hit that would knock it out will instead leave it with 1 HP. Regardless of its current HP, it is also immune to the one-hit KO moves: fissure, guillotine, horn drill, and sheer cold. If this Pokémon is holding a focus sash, this ability takes precedence and the item will not be consumed.", "Sturdy", null },
                    { 1005, "While this Pokémon is in battle, self destruct and explosion will fail and aftermath will not take effect.", "Damp", null },
                    { 1006, "During a sandstorm, this Pokémon has 1.25xits evasion, and it does not take sandstorm damage regardless of type. The evasion bonus does not count as a stat modifier. Overworld: If the lead Pokémon has this ability, the wild encounter rate is halved in a sandstorm.", "Sand-Veil", null },
                    { 1007, "Whenever a move makes contact with this Pokémon, the move's user has a 30% chance of being paralyzed. Pokémon that are immune to electric-type moves can still be paralyzed by this ability. Overworld: If the lead Pokémon has this ability, there is a 50% chance that encounters will be with an electric Pokémon, if applicable.", "Static", null },
                    { 1008, "Whenever an electric-type move hits this Pokémon, it heals for 1/4 of its maximum HP, negating any other effect on it. This ability will not take effect if this Pokémon is ground-type and thus immune to Electric moves. Electric moves will ignore this Pokémon's substitute. This effect includes non-damaging moves, i.e. thunder wave.", "Volt-Absorb", null },
                    { 1009, "Whenever a water-type move hits this Pokémon, it heals for 1/4 of its maximum HP, negating any other effect on it. Water moves will ignore this Pokémon's substitute.", "Water-Absorb", null },
                    { 1010, "Whenever a water-type move hits this Pokémon, it heals for 1/4 of its maximum HP, negating any other effect on it. Water moves will ignore this Pokémon's substitute.", "Water-Absorb", null },
                    { 1011, "This Pokémon cannot be infatuated and is immune to captivate. If a Pokémon is infatuated and acquires this ability, its infatuation is cleared.", "Oblivious", null },
                    { 1012, "This Pokémon's moves have 1.3xtheir accuracy. This ability has no effect on the one-hit KO moves (fissure, guillotine, horn drill, and sheer cold). Overworld: If the first Pokémon in the party has this ability, the chance of a wild Pokémon holding a particular item is raised from 50%, 5%, or 1% to 60%, 20%, or 5%, respectively.", "Compound-Eyes", null },
                    { 1013, "This Pokémon cannot be asleep. This causes rest to fail altogether. If a Pokémon is asleep and acquires this ability, it will immediately wake up; this includes when regaining a lost ability upon leaving battle. This ability functions identically to vital spirit in battle.", "Insomnia", null },
                    { 1014, "Whenever this Pokémon takes damage from a move, the Pokémon's type changes to match the move. If the Pokémon has two types, both are overridden. The Pokémon must directly take damage; for example, moves blocked by a substitute will not trigger this ability, nor will moves that deal damage indirectly, such as spikes. This ability takes effect on only the last hit of a multiple-hit attack.", "Color-Change", null },
                    { 1015, "This Pokémon cannot be poisoned. This includes bad poison. If a Pokémon is poisoned and acquires this ability, its poison is healed; this includes when regaining a lost ability upon leaving battle.", "Immunity", null },
                    { 1016, "This Pokémon is immune to fire-type moves. Once this Pokémon has been hit by a Fire move, its own Fire moves will inflict 1.5xas much damage until it leaves battle. This ability has no effect while the Pokémon is frozen. The Fire damage bonus is retained even if the Pokémon is frozen and thawed or the ability is lost or disabled. Fire moves will ignore this Pokémon's substitute. This ability takes effect even on non-damaging moves, i.e. will o wisp.", "Flash-Fire", null },
                    { 1017, "This Pokémon cannot be confused. If a Pokémon is confused and acquires this ability, its confusion will immediately be healed.", "Own-Tempo", null },
                    { 1018, "When this Pokémon enters battle, the opponent's Attack is lowered by one stage. In a double battle, both opponents are affected. This ability also takes effect when acquired during a battle, but will not take effect again if lost and reobtained without leaving battle. This ability has no effect on an opponent that has a substitute. Overworld: If the first Pokémon in the party has this ability, any random encounter with a Pokémon five or more levels lower than it has a 50% chance of being skipped.", "Intimidate", null },
                    { 1019, "Whenever a move makes contact with this Pokémon, the move's user takes 1/8 of its maximum HP in damage. This ability functions identically to iron barbs.", "Rough-Skin", null },
                    { 1020, "This Pokémon is immune to ground-type moves, spikes, toxic spikes, and arena trap. This ability is disabled during gravity or ingrain, or while holding an iron ball. This ability is not disabled during roost.", "Levitate", null },
                    { 1021, "Whenever a move makes contact with this Pokémon, the move's user has a 30% chance of being paralyzed, poisoned, or put to sleep, chosen at random. Nothing is done to compensate if the move's user is immune to one of these ailments; there is simply a lower chance that the move's user will be affected.", "Effect-Spore", null },
                    { 1022, "Whenever this Pokémon is burned, paralyzed, or poisoned, the Pokémon who gave this Pokémon that ailment is also given the ailment. This ability passes back bad poison when this Pokémon is badly poisoned. This ability cannot pass on a status ailment that the Pokémon did not directly receive from another Pokémon, such as the poison from toxic spikes or the burn from a flame orb. Overworld: If the lead Pokémon has this ability, wild Pokémon have a 50% chance of having the lead Pokémon's nature, and a 50% chance of being given a random nature as usual, including the lead Pokémon's nature. This does not work on Pokémon received outside of battle or roaming legendaries.", "Synchronize", null },
                    { 1023, "This Pokémon is cured of any major status ailment when it is switched out for another Pokémon. If this ability is acquired during battle, the Pokémon is cured upon leaving battle before losing the temporary ability.", "Natural-Cure", null },
                    { 1024, "This Pokémon's Speed is doubled during strong sunlight. This bonus does not count as a stat modifier.", "Chlorophyll", null },
                    { 1025, "When this Pokémon enters battle, it copies a random opponent's ability. This ability cannot copy flower gift, forecast, illusion, imposter, multitype, trace, wonder guard, or zen mode.", "Trace", null },
                    { 1026, "This Pokémon's Attack is doubled while in battle. This bonus does not count as a stat modifier. This ability functions identically to pure power.", "Huge-Power", null },
                    { 1027, "Whenever a move makes contact with this Pokémon, the move's user has a 30% chance of being poisoned.", "Poison-Point", null },
                    { 1028, "This Pokémon cannot flinch.", "Inner-Focus", null },
                    { 1029, "This Pokémon cannot be frozen. If a Pokémon is frozen and acquires this ability, it will immediately thaw out; this includes when regaining a lost ability upon leaving battle. Overworld: If any Pokémon in the party has this ability, each egg in the party has its hatch counter decreased by 2 (rather than 1) each step cycle, making eggs hatch roughly twice as quickly. This effect does not stack if multiple Pokémon have this ability or flame body.", "Magma-Armor", null },
                    { 1030, "This Pokémon cannot be burned. If a Pokémon is burned and acquires this ability, its burn is healed; this includes when regaining a lost ability upon leaving battle.", "Water-Veil", null },
                    { 1031, "This Pokémon heals for 1/16 of its maximum HP after each turn during rain.", "Rain-Dish", null },
                    { 1032, "Moves targetting this Pokémon use one extra PP. This ability stacks if multiple targets have it. This ability still affects moves that fail or miss. This ability does not affect ally moves that target either the entire field or just its side, nor this Pokémon's self-targetted moves; it does, however, affect single-targetted ally moves aimed at this Pokémon, ally moves that target all other Pokémon, and opponents' moves that target the entire field. If this ability raises a move's PP cost above its remaining PP, it will use all remaining PP. When this Pokémon enters battle, all participating trainers are notified that it has this ability. Overworld: If the lead Pokémon has this ability, higher-levelled Pokémon have their encounter rate increased.", "Pressure", null },
                    { 1033, "Whenever a move makes contact with this Pokémon, the move's user has a 30% chance of being burned. Overworld: If any Pokémon in the party has this ability, each egg in the party has its hatch counter decreased by 2 (rather than 1) each step cycle, making eggs hatch roughly twice as quickly. This effect does not stack if multiple Pokémon have this ability or magma armor.", "Flame-Body", null },
                    { 1034, "This Pokémon cannot have its accuracy lowered. This ability does not prevent any accuracy losses other than stat modifiers, such as the accuracy cut from fog; nor does it prevent other Pokémon's evasion from making this Pokémon's moves less accurate. This Pokémon can still be passed negative accuracy modifiers through heart swap. Overworld: If the first Pokémon in the party has this ability, any random encounter with a Pokémon five or more levels lower than it has a 50% chance of being skipped.", "Keen-Eye", null },
                    { 1035, "Every second turn on which this Pokémon should attempt to use a move, it will instead do nothing (loaf around). Loafing around interrupts moves that take multiple turns the same way paralysis, flinching, etc do. Most such moves, for example bide or rollout, are simply cut off upon loafing around. Attacks with a recharge turn, such as hyper beam, do not have to recharge; attacks with a preparation turn, such as fly, do not end up being used. Moves that are forced over multiple turns and keep going through failure, such as outrage, uproar, or any move forced by encore, keep going as usual. If this Pokémon is confused, its confusion is not checked when loafing around; the Pokémon cannot hurt itself, and its confusion does not end or come closer to ending. If this Pokémon attempts to move but fails, e.g. because of paralysis or gravity, it still counts as having moved and will loaf around the next turn. If it does not attempt to move, e.g. because it is asleep or frozen, whatever it would have done will be postponed until its next attempt; that is, it will either loaf around or move as usual, depending on what it last did. This ability cannot be changed with worry seed, but it can be disabled with gastro acid, changed with role play, or traded away with skill swap.", "Truant", null },
                    { 1036, "After each turn, this Pokémon has a 33% of being cured of any major status ailment.", "Shed-Skin", null },
                    { 1037, "Whenever a Pokémon would heal after hitting this Pokémon with a leeching move like absorb, it instead loses as many HP as it would usually gain. dream eater is unaffected.", "Liquid-Ooze", null },
                    { 1038, "Whenever a Pokémon would heal after hitting this Pokémon with a leeching move like absorb, it instead loses as many HP as it would usually gain. dream eater is unaffected.", "Liquid-Ooze", null }
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
                    { 1017, "Fairy" }
                });

            migrationBuilder.InsertData(
                table: "StatusConditions",
                columns: new[] { "Id", "BurnEffect", "ConditionDoesDamage", "ConditionDuration", "DamageAmount", "DamageFrequency", "FreezeEffect", "ParalysisEffect", "PoisonEffect", "SleepEffect", "StatusConditionDescription", "StatusConditionName" },
                values: new object[,]
                {
                    { 1001, false, false, "The affect lasts four turns, unless it is removed by an item.", 0.0, "Last for four turns.", false, true, false, false, "The Pokémon afflicted Speed stat is reduced to 50% of it's maximum. The Pokémon has a 25% chance of being unable to attack each turn", "Paralysis" },
                    { 1002, true, true, "Last until healed or pokemon faints.", 15.0, "Last until healed or pokemon faints.", false, false, false, false, "The pokemon is afflicted with a severe burn. Each turn, the Pokémon afflicted with the Burn loses 1/8th of it's Max HP.", "Burn" },
                    { 1003, false, false, "The affect lasts four turns, unless it is removed by an item.", 0.0, "Last for four turns.", true, false, false, false, "The Pokemon is frozen solid. The Pokémon cannot use any attacks (apart from those that thaw it)", "Freeze " },
                    { 1004, false, true, "Last until the Pokemon is healed or the Pokemon Faints.", 15.0, "Last until the Pokemon is healed or the Pokemon Faints.", false, false, true, false, "Poisons the targeted pokemon gradually lowering the Pokémon's Hit Points until the Pokémon faint.", "Poison" },
                    { 1005, false, false, "Last for up to seven turns unless removed.", 0.0, "Last for up to seven turns unless removed.", false, false, false, true, "The targeted Pokemon is put to sleep for up to seven turns. The pokemon is not able to use any moves while asleep.", "Sleep" }
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
                name: "IX_HealthRestoratinItems_PlayerItemInventoryEntityId",
                table: "HealthRestoratinItems",
                column: "PlayerItemInventoryEntityId");

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
                name: "IX_Pokemon_PlayerEntityId",
                table: "Pokemon",
                column: "PlayerEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Pokemon_PokeTypeIdOne",
                table: "Pokemon",
                column: "PokeTypeIdOne");

            migrationBuilder.CreateIndex(
                name: "IX_Pokemon_PokeTypeIdTwo",
                table: "Pokemon",
                column: "PokeTypeIdTwo");

            migrationBuilder.CreateIndex(
                name: "IX_Pokemon_TrainerOpponentEntityId",
                table: "Pokemon",
                column: "TrainerOpponentEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonAbilities_PokemonEntityId",
                table: "PokemonAbilities",
                column: "PokemonEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonMoves_PokemonEntityId",
                table: "PokemonMoves",
                column: "PokemonEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonMoves_StatusConditionId",
                table: "PokemonMoves",
                column: "StatusConditionId");

            migrationBuilder.CreateIndex(
                name: "IX_TMs_PokemonEntityId",
                table: "TMs",
                column: "PokemonEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_TMs_StatusConditionId",
                table: "TMs",
                column: "StatusConditionId");

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerItemInventoryEntityTechnicalMachineMoveEntity_TMs_TMsId",
                table: "PlayerItemInventoryEntityTechnicalMachineMoveEntity",
                column: "TMsId",
                principalTable: "TMs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pokemon_PokemonMoves_MoveFourId",
                table: "Pokemon",
                column: "MoveFourId",
                principalTable: "PokemonMoves",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Pokemon_PokemonMoves_MoveOneId",
                table: "Pokemon",
                column: "MoveOneId",
                principalTable: "PokemonMoves",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Pokemon_PokemonMoves_MoveThreeId",
                table: "Pokemon",
                column: "MoveThreeId",
                principalTable: "PokemonMoves",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Pokemon_PokemonMoves_MoveTwoId",
                table: "Pokemon",
                column: "MoveTwoId",
                principalTable: "PokemonMoves",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Players_AspNetUsers_UserId",
                table: "Players");

            migrationBuilder.DropForeignKey(
                name: "FK_Players_PlayerItemInventories_ItemIventoryId",
                table: "Players");

            migrationBuilder.DropForeignKey(
                name: "FK_Pokemon_Opponents_TrainerOpponentEntityId",
                table: "Pokemon");

            migrationBuilder.DropForeignKey(
                name: "FK_Pokemon_Players_PlayerEntityId",
                table: "Pokemon");

            migrationBuilder.DropForeignKey(
                name: "FK_Pokemon_PokemonMoves_MoveFourId",
                table: "Pokemon");

            migrationBuilder.DropForeignKey(
                name: "FK_Pokemon_PokemonMoves_MoveOneId",
                table: "Pokemon");

            migrationBuilder.DropForeignKey(
                name: "FK_Pokemon_PokemonMoves_MoveThreeId",
                table: "Pokemon");

            migrationBuilder.DropForeignKey(
                name: "FK_Pokemon_PokemonMoves_MoveTwoId",
                table: "Pokemon");

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
                name: "HealthRestoratinItems");

            migrationBuilder.DropTable(
                name: "Keys");

            migrationBuilder.DropTable(
                name: "PersistedGrants");

            migrationBuilder.DropTable(
                name: "PlayerItemInventoryEntityPokeBallEntity");

            migrationBuilder.DropTable(
                name: "PlayerItemInventoryEntityRejuvenationItemEntity");

            migrationBuilder.DropTable(
                name: "PlayerItemInventoryEntityStatusConditionItemEntity");

            migrationBuilder.DropTable(
                name: "PlayerItemInventoryEntityTechnicalMachineMoveEntity");

            migrationBuilder.DropTable(
                name: "PokemonAbilities");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "PokeBalls");

            migrationBuilder.DropTable(
                name: "ReviveItems");

            migrationBuilder.DropTable(
                name: "StatusConditionItems");

            migrationBuilder.DropTable(
                name: "TMs");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "PlayerItemInventories");

            migrationBuilder.DropTable(
                name: "Opponents");

            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "PokemonMoves");

            migrationBuilder.DropTable(
                name: "Pokemon");

            migrationBuilder.DropTable(
                name: "StatusConditions");

            migrationBuilder.DropTable(
                name: "PokemonTypes");
        }
    }
}
