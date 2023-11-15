using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Duende.IdentityServer.EntityFramework.Options;
using PokemonCatcherGame.Server.Entities;
using Server.Entities;

namespace PokemonCatcherGame.Server.Data;

public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
{
    public ApplicationDbContext(
        DbContextOptions options,
        IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
    {
    }

    public DbSet<HealthItemEntity> HealthRestoratinItems { get; set; }
    public DbSet<PlayerEntity> Players { get; set; }
    public DbSet<RejuvenationItemEntity> ReviveItems { get; set; }
    public DbSet<PlayerItemInventoryEntity> PlayerItemInventories { get; set; }
    public DbSet<PokeBallEntity> PokeBalls { get; set; }
    public DbSet<PokemonAbilityEntity> PokemonAbilities { get; set; }
    public DbSet<PokemonEntity> Pokemon { get; set; }
    public DbSet<PokemonMoveEntity> PokemonMoves { get; set; }
    public DbSet<PokemonTypeEntity> PokemonTypes { get; set; }
    public DbSet<StatusConditionEntity> StatusConditions { get; set; }
    public DbSet<StatusConditionItemEntity> StatusConditionItems { get; set; }
    public DbSet<TechnicalMachineMoveEntity> TMs { get; set; }
    public DbSet<TrainerOpponentEntity> Opponents { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<PokemonAbilityEntity>().HasData(
            new PokemonAbilityEntity 
            {
                Id = 1000,
                AbilityName = "Stench",
                AbilityEffect = "This Pokémon's damaging moves have a 10% chance to make the target flinch with each hit if they do not already cause flinching as a secondary effect. This ability does not stack with a held item. Overworld: The wild encounter rate is halved while this Pokémon is first in the party.",
            },
            new PokemonAbilityEntity 
            {
                Id = 1001,
                AbilityName = "Drizzle",
                AbilityEffect = "The weather changes to rain when this Pokémon enters battle and does not end unless replaced by another weather condition. If multiple Pokémon with this ability, drought, sand stream, or snow warning are sent out at the same time, the abilities will activate in order of Speed, respecting trick room. Each ability's weather will cancel the previous weather, and only the weather summoned by the slowest of the Pokémon will stay.",
            },
            new PokemonAbilityEntity 
            {
                Id = 1002,
                AbilityName = "Speed-Boost",
                AbilityEffect = "This Pokémon's Speed rises one stage after each turn.",
            },
            new PokemonAbilityEntity 
            {
                Id = 1003,
                AbilityName = "Battle-Armor",
                AbilityEffect = "This Pokémon's Speed rises one stage after each turn.",
            },
            new PokemonAbilityEntity 
            {
                Id = 1004,
                AbilityName = "Sturdy",
                AbilityEffect = "When this Pokémon is at full HP, any hit that would knock it out will instead leave it with 1 HP. Regardless of its current HP, it is also immune to the one-hit KO moves: fissure, guillotine, horn drill, and sheer cold. If this Pokémon is holding a focus sash, this ability takes precedence and the item will not be consumed.",
            },
            new PokemonAbilityEntity 
            {
                Id = 1005,
                AbilityName = "Damp",
                AbilityEffect = "While this Pokémon is in battle, self destruct and explosion will fail and aftermath will not take effect.",
            },
            new PokemonAbilityEntity 
            {
                Id = 1006,
                AbilityName = "Sand-Veil",
                AbilityEffect = "During a sandstorm, this Pokémon has 1.25× its evasion, and it does not take sandstorm damage regardless of type. The evasion bonus does not count as a stat modifier. Overworld: If the lead Pokémon has this ability, the wild encounter rate is halved in a sandstorm.",
            },
            new PokemonAbilityEntity 
            {
                Id = 1007,
                AbilityName = "Static",
                AbilityEffect = "Whenever a move makes contact with this Pokémon, the move's user has a 30% chance of being paralyzed. Pokémon that are immune to electric-type moves can still be paralyzed by this ability. Overworld: If the lead Pokémon has this ability, there is a 50% chance that encounters will be with an electric Pokémon, if applicable.",
            },
            new PokemonAbilityEntity 
            {
                Id = 1008,
                AbilityName = "Volt-Absorb",
                AbilityEffect = "Whenever an electric-type move hits this Pokémon, it heals for 1/4 of its maximum HP, negating any other effect on it. This ability will not take effect if this Pokémon is ground-type and thus immune to Electric moves. Electric moves will ignore this Pokémon's substitute. This effect includes non-damaging moves, i.e. thunder wave.",
            },
            new PokemonAbilityEntity 
            {
                Id = 1009,
                AbilityName = "Water-Absorb",
                AbilityEffect = "Whenever a water-type move hits this Pokémon, it heals for 1/4 of its maximum HP, negating any other effect on it. Water moves will ignore this Pokémon's substitute.",
            },
            new PokemonAbilityEntity 
            {
                Id = 1010,
                AbilityName = "Water-Absorb",
                AbilityEffect = "Whenever a water-type move hits this Pokémon, it heals for 1/4 of its maximum HP, negating any other effect on it. Water moves will ignore this Pokémon's substitute.",
            },
            new PokemonAbilityEntity 
            {
                Id = 1011,
                AbilityName = "Oblivious",
                AbilityEffect = "This Pokémon cannot be infatuated and is immune to captivate. If a Pokémon is infatuated and acquires this ability, its infatuation is cleared.",
            },
            new PokemonAbilityEntity 
            {
                Id = 1012,
                AbilityName = "Compound-Eyes",
                AbilityEffect = "This Pokémon's moves have 1.3× their accuracy. This ability has no effect on the one-hit KO moves (fissure, guillotine, horn drill, and sheer cold). Overworld: If the first Pokémon in the party has this ability, the chance of a wild Pokémon holding a particular item is raised from 50%, 5%, or 1% to 60%, 20%, or 5%, respectively.",
            },
            new PokemonAbilityEntity 
            {
                Id = 1013,
                AbilityName = "Insomnia",
                AbilityEffect = "This Pokémon cannot be asleep. This causes rest to fail altogether. If a Pokémon is asleep and acquires this ability, it will immediately wake up; this includes when regaining a lost ability upon leaving battle. This ability functions identically to vital spirit in battle.",
            },
            new PokemonAbilityEntity 
            {
                Id = 1014,
                AbilityName = "Color-Change",
                AbilityEffect = "Whenever this Pokémon takes damage from a move, the Pokémon's type changes to match the move. If the Pokémon has two types, both are overridden. The Pokémon must directly take damage; for example, moves blocked by a substitute will not trigger this ability, nor will moves that deal damage indirectly, such as spikes. This ability takes effect on only the last hit of a multiple-hit attack.",
            },
            new PokemonAbilityEntity 
            {
                Id = 1015,
                AbilityName = "Immunity",
                AbilityEffect = "This Pokémon cannot be poisoned. This includes bad poison. If a Pokémon is poisoned and acquires this ability, its poison is healed; this includes when regaining a lost ability upon leaving battle.",
            },
            new PokemonAbilityEntity 
            {
                Id = 1016,
                AbilityName = "Flash-Fire",
                AbilityEffect = "This Pokémon is immune to fire-type moves. Once this Pokémon has been hit by a Fire move, its own Fire moves will inflict 1.5× as much damage until it leaves battle. This ability has no effect while the Pokémon is frozen. The Fire damage bonus is retained even if the Pokémon is frozen and thawed or the ability is lost or disabled. Fire moves will ignore this Pokémon's substitute. This ability takes effect even on non-damaging moves, i.e. will o wisp.",
            },
            new PokemonAbilityEntity 
            {
                Id = 1017,
                AbilityName = "Own-Tempo",
                AbilityEffect = "This Pokémon cannot be confused. If a Pokémon is confused and acquires this ability, its confusion will immediately be healed.",
            },
            new PokemonAbilityEntity 
            {
                Id = 1018,
                AbilityName = "Intimidate",
                AbilityEffect = "When this Pokémon enters battle, the opponent's Attack is lowered by one stage. In a double battle, both opponents are affected. This ability also takes effect when acquired during a battle, but will not take effect again if lost and reobtained without leaving battle. This ability has no effect on an opponent that has a substitute. Overworld: If the first Pokémon in the party has this ability, any random encounter with a Pokémon five or more levels lower than it has a 50% chance of being skipped.",
            },
            new PokemonAbilityEntity 
            {
                Id = 1019,
                AbilityName = "Rough-Skin",
                AbilityEffect = "Whenever a move makes contact with this Pokémon, the move's user takes 1/8 of its maximum HP in damage. This ability functions identically to iron barbs.",
            },
            new PokemonAbilityEntity 
            {
                Id = 1020,
                AbilityName = "Levitate",
                AbilityEffect = "This Pokémon is immune to ground-type moves, spikes, toxic spikes, and arena trap. This ability is disabled during gravity or ingrain, or while holding an iron ball. This ability is not disabled during roost.",
            },
            new PokemonAbilityEntity 
            {
                Id = 1021,
                AbilityName = "Effect-Spore",
                AbilityEffect = "Whenever a move makes contact with this Pokémon, the move's user has a 30% chance of being paralyzed, poisoned, or put to sleep, chosen at random. Nothing is done to compensate if the move's user is immune to one of these ailments; there is simply a lower chance that the move's user will be affected.",
            },
            new PokemonAbilityEntity 
            {
                Id = 1022,
                AbilityName = "Synchronize",
                AbilityEffect = "Whenever this Pokémon is burned, paralyzed, or poisoned, the Pokémon who gave this Pokémon that ailment is also given the ailment. This ability passes back bad poison when this Pokémon is badly poisoned. This ability cannot pass on a status ailment that the Pokémon did not directly receive from another Pokémon, such as the poison from toxic spikes or the burn from a flame orb. Overworld: If the lead Pokémon has this ability, wild Pokémon have a 50% chance of having the lead Pokémon's nature, and a 50% chance of being given a random nature as usual, including the lead Pokémon's nature. This does not work on Pokémon received outside of battle or roaming legendaries.",
            },
            new PokemonAbilityEntity 
            {
                Id = 1023,
                AbilityName = "Natural-Cure",
                AbilityEffect = "This Pokémon is cured of any major status ailment when it is switched out for another Pokémon. If this ability is acquired during battle, the Pokémon is cured upon leaving battle before losing the temporary ability.",
            },
            new PokemonAbilityEntity 
            {
                Id = 1024,
                AbilityName = "Chlorophyll",
                AbilityEffect = "This Pokémon's Speed is doubled during strong sunlight. This bonus does not count as a stat modifier.",
            },
            new PokemonAbilityEntity 
            {
                Id = 1025,
                AbilityName = "Trace",
                AbilityEffect = "When this Pokémon enters battle, it copies a random opponent's ability. This ability cannot copy flower gift, forecast, illusion, imposter, multitype, trace, wonder guard, or zen mode.",
            },
            new PokemonAbilityEntity 
            {
                Id = 1026,
                AbilityName = "Huge-Power",
                AbilityEffect = "This Pokémon's Attack is doubled while in battle. This bonus does not count as a stat modifier. This ability functions identically to pure power.",
            },
            new PokemonAbilityEntity 
            {
                Id = 1027,
                AbilityName = "Poison-Point",
                AbilityEffect = "Whenever a move makes contact with this Pokémon, the move's user has a 30% chance of being poisoned.",
            },
            new PokemonAbilityEntity 
            {
                Id = 1028,
                AbilityName = "Inner-Focus",
                AbilityEffect = "This Pokémon cannot flinch.",
            },
            new PokemonAbilityEntity 
            {
                Id = 1029,
                AbilityName = "Magma-Armor",
                AbilityEffect = "This Pokémon cannot be frozen. If a Pokémon is frozen and acquires this ability, it will immediately thaw out; this includes when regaining a lost ability upon leaving battle. Overworld: If any Pokémon in the party has this ability, each egg in the party has its hatch counter decreased by 2 (rather than 1) each step cycle, making eggs hatch roughly twice as quickly. This effect does not stack if multiple Pokémon have this ability or flame body.",
            },
            new PokemonAbilityEntity 
            {
                Id = 1030,
                AbilityName = "Water-Veil",
                AbilityEffect = "This Pokémon cannot be burned. If a Pokémon is burned and acquires this ability, its burn is healed; this includes when regaining a lost ability upon leaving battle.",
            },
            new PokemonAbilityEntity 
            {
                Id = 1031,
                AbilityName = "Rain-Dish",
                AbilityEffect = "This Pokémon heals for 1/16 of its maximum HP after each turn during rain.",
            },
            new PokemonAbilityEntity 
            {
                Id = 1032,
                AbilityName = "Pressure",
                AbilityEffect = "Moves targetting this Pokémon use one extra PP. This ability stacks if multiple targets have it. This ability still affects moves that fail or miss. This ability does not affect ally moves that target either the entire field or just its side, nor this Pokémon's self-targetted moves; it does, however, affect single-targetted ally moves aimed at this Pokémon, ally moves that target all other Pokémon, and opponents' moves that target the entire field. If this ability raises a move's PP cost above its remaining PP, it will use all remaining PP. When this Pokémon enters battle, all participating trainers are notified that it has this ability. Overworld: If the lead Pokémon has this ability, higher-levelled Pokémon have their encounter rate increased.",
            },
            new PokemonAbilityEntity 
            {
                Id = 1033,
                AbilityName = "Flame-Body",
                AbilityEffect = "Whenever a move makes contact with this Pokémon, the move's user has a 30% chance of being burned. Overworld: If any Pokémon in the party has this ability, each egg in the party has its hatch counter decreased by 2 (rather than 1) each step cycle, making eggs hatch roughly twice as quickly. This effect does not stack if multiple Pokémon have this ability or magma armor.",
            },
            new PokemonAbilityEntity 
            {
                Id = 1034,
                AbilityName = "Keen-Eye",
                AbilityEffect = "This Pokémon cannot have its accuracy lowered. This ability does not prevent any accuracy losses other than stat modifiers, such as the accuracy cut from fog; nor does it prevent other Pokémon's evasion from making this Pokémon's moves less accurate. This Pokémon can still be passed negative accuracy modifiers through heart swap. Overworld: If the first Pokémon in the party has this ability, any random encounter with a Pokémon five or more levels lower than it has a 50% chance of being skipped.",
            },
            new PokemonAbilityEntity 
            {
                Id = 1035,
                AbilityName = "Truant",
                AbilityEffect = "Every second turn on which this Pokémon should attempt to use a move, it will instead do nothing (loaf around). Loafing around interrupts moves that take multiple turns the same way paralysis, flinching, etc do. Most such moves, for example bide or rollout, are simply cut off upon loafing around. Attacks with a recharge turn, such as hyper beam, do not have to recharge; attacks with a preparation turn, such as fly, do not end up being used. Moves that are forced over multiple turns and keep going through failure, such as outrage, uproar, or any move forced by encore, keep going as usual. If this Pokémon is confused, its confusion is not checked when loafing around; the Pokémon cannot hurt itself, and its confusion does not end or come closer to ending. If this Pokémon attempts to move but fails, e.g. because of paralysis or gravity, it still counts as having moved and will loaf around the next turn. If it does not attempt to move, e.g. because it is asleep or frozen, whatever it would have done will be postponed until its next attempt; that is, it will either loaf around or move as usual, depending on what it last did. This ability cannot be changed with worry seed, but it can be disabled with gastro acid, changed with role play, or traded away with skill swap.",
            },
            new PokemonAbilityEntity 
            {
                Id = 1036,
                AbilityName = "Shed-Skin",
                AbilityEffect = "After each turn, this Pokémon has a 33% of being cured of any major status ailment.",
            },
            new PokemonAbilityEntity 
            {
                Id = 1037,
                AbilityName = "Liquid-Ooze",
                AbilityEffect = "Whenever a Pokémon would heal after hitting this Pokémon with a leeching move like absorb, it instead loses as many HP as it would usually gain. dream eater is unaffected.",
            },
            new PokemonAbilityEntity 
            {
                Id = 1038,
                AbilityName = "Liquid-Ooze",
                AbilityEffect = "Whenever a Pokémon would heal after hitting this Pokémon with a leeching move like absorb, it instead loses as many HP as it would usually gain. dream eater is unaffected.",
            }
        );
        
    }

}
