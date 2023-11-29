using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Entities;

public class PlayerItemInventoryEntity
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string NameOfPlayer { get; set; } = string.Empty;

    [Range(0, 999)]
    public int NumberOfPotions { get; set; } = 0;

    [Range(0, 999)]
    public int NumberOfSuperPotions { get; set; } = 0;

    [Range(0, 999)]
    public int NumberOfHyperPotions { get; set; } = 0;

    [Range(0, 999)]
    public int NumberOfMaxPotions { get; set; } = 0;

    [Range(0, 999)]
    public int NumberOfRevives { get; set; } = 0;

    [Range(0, 999)]
    public int NumberOfMaxRevives { get; set; } = 0;

    [Range(0, 999)]
    public int NumberOfPokeBalls { get; set; } = 0;
    
    [Range(0, 999)]
    public int NumberOfGreatBalls { get; set; } = 0;

    [Range(0, 999)]
    public int NumberOfUltraBalls { get; set; } = 0;

    [Range(0, 999)]
    public int NumberOfMasterBalls { get; set; } = 0;

    [Range(0, 999)]
    public int NumberOfAntidotes { get; set; } = 0;

    [Range(0, 999)]
    public int NumberOfParalyzeHeals { get; set; } = 0;

    [Range(0, 999)]
    public int NumberOfAwakening { get; set; } = 0;

    [Range(0, 999)] 
    public int NumberOfBurnHeals { get; set; } = 0;

    [Range(0, 999)]
    public int NumberOfIceHeals { get; set; } = 0;

    [Range(0, 999)]
    public int NumberOfFullHeals { get; set; } = 0;

    [Range(0, 999)]
    public int NumberOfEnergyPowder { get; set; } = 0;

    [Range(0, 999)]
    public int NumberOfEnergyRoot { get; set; } = 0;

    [Range(0, 999)]
    public int NumberOfHealPowder { get; set; } = 0;

    [Range(0, 999)]
    public int NumberOfRevivalHerb { get; set; } = 0;

    [Range(0, 999)]
    public int NumberOfSodaPop { get; set; } = 0;

    [Range(0, 999)]
    public int NumberOfLemonade { get; set; } = 0;

    [Range(0, 999)]
    public int NumberOfMoomooMilk { get; set; } = 0;

    [Range(0, 999)]
    public int NumberOfBerryJuice { get; set; } = 0;

    [Range(0, 999)]
    public int NumberOfSacredAsh { get; set; } = 0;

    [Range(0, 999)]
    public int NumberOfRageCandyBar { get; set; } = 0;

    [Range(0, 999)]
    public int NumberOfLavaCookie { get; set; } = 0;

    [Range(0, 999)]
    public int NumberOfCasteliacone { get; set; } = 0;

    [Range(0, 999)]
    public int NumberOfOldGateau { get; set; } = 0;

    [Range(0, 999)]
    public int NumberOfShalourSable { get; set; } = 0;

    [Range(0, 999)]
    public int NumberOfLumioseGalette { get; set; } = 0;

    [Range(0, 999)]
    public int NumberOfFineRemendy { get; set; } = 0;

    [Range(0, 999)]
    public int NumberOfSafariBall { get; set; } = 0;

    [Range(0, 999)]
    public int NumberOfPremierBall { get; set; } = 0;

    [Range(0, 999)]
    public int NumberOfRepeatBall { get; set; } = 0;

    [Range(0, 999)]
    public int NumberOfTimerBall { get; set; } = 0;

    [Range(0, 999)]
    public int NumberOfNestBall { get; set; } = 0;

    [Range(0, 999)]
    public int NumberOfNetBall { get; set; } = 0;

    [Range(0, 999)]
    public int NumberOfDiveBall { get; set; } = 0;

    [Range(0, 999)]
    public int NumberOfLuxuryBall { get; set; } = 0;

    [Range(0, 999)]
    public int NumberOfHealBall { get; set; } = 0;

    [Range(0, 999)]
    public int NumberOfQuickBall { get; set; } = 0;

    [Range(0, 999)]
    public int NumberOfDuskBall { get; set; } = 0;

    [Range(0, 999)]
    public int NumberOfCherishBall { get; set; } = 0;

    [Range(0, 999)]
    public int NumberOfFullRestore { get; set; } = 0;

    [Range(0, 999)]
    public int NumberOfFreshWater { get; set; } = 0;

    public virtual List<PlayerEntity> Players { get; set; } 
    
    //* Creates Many to Many relationships so that I can utilize the various items stored in these other tables as a player's Inventory....
    public ICollection<HealthItemEntity> HealthItems { get; set; } 
    public ICollection<RejuvenationItemEntity> ReviveItems { get; set; }
    public ICollection<PokeBallEntity> PokeBalls { get; set; }
    public ICollection<StatusConditionItemEntity> RemoveStatusConditionItems { get; set; }
    public ICollection<TechnicalMachineMoveEntity> TMs { get; set; }

    public PlayerItemInventoryEntity()
    {
        HealthItems = new HashSet<HealthItemEntity>();
        ReviveItems = new HashSet<RejuvenationItemEntity>();
        PokeBalls = new HashSet<PokeBallEntity>();
        RemoveStatusConditionItems = new HashSet<StatusConditionItemEntity>();
        TMs = new HashSet<TechnicalMachineMoveEntity>();
    }
}
