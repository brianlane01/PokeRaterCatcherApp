using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PokemonCatcherGame.Shared.Models.PlayerItemInventoryModels;

public class PlayerInventoryCreate
{
    public string NameOfPlayer { get; set; } = string.Empty;

    public List<int>? HealthItems {get; set;}

    public List<int>? ReviveItems {get; set;}

    public List<int>? PokeBalls {get; set;}

    public List<int>? StatusConditionItems {get; set;}

    public List<int>? TMs {get; set;}

    [Range(0, 20, ErrorMessage= "You can only have 20 Potions at the start of your adventure.")]
    public int? NumberOfPotions { get; set; } = 0;

    [Range(0, 10, ErrorMessage= "You can only have 10 Super Potions at the start of your adventure.")]
    public int? NumberOfSuperPotions { get; set; } = 0;

    [Range(0, 6, ErrorMessage= "You can only have 6 Hyper Potions at the start of your adventure.")]
    public int? NumberOfHyperPotions { get; set; } = 0;

    [Range(0, 2, ErrorMessage = "You can only have 2 Max Potions at the start of your adventure.")]
    public int? NumberOfMaxPotions { get; set; } = 0;

    [Range(0, 20, ErrorMessage = "You can only have 20 Revives at the start of your adventure.")]
    public int? NumberOfRevives { get; set; } = 0;

    [Range(0, 4, ErrorMessage = "You can only have 4 Max Revives at the start of your adventure.")]
    public int? NumberOfMaxRevives { get; set; } = 0;

    [Range(0, 20, ErrorMessage = "You can only have 20 Poke Balls at the start of your adventure.")]
    public int? NumberOfPokeBalls { get; set; } = 0;
    
    [Range(0, 10, ErrorMessage = "You can only have 10 Great Balls at the start of your adventure.")]
    public int? NumberOfGreatBalls { get; set; } = 0;

    [Range(0, 5, ErrorMessage = "You can only have 5 Ultra Balls at the start of your adventure.")]
    public int? NumberOfUltraBalls { get; set; } = 0;

    [Range(0, 0, ErrorMessage = "Master Balls are not available at the start of your adventure.")]
    public int? NumberOfMasterBalls { get; set; } = 0;

    [Range(0, 5, ErrorMessage = "You can only have 5 Antidotes at the start of your adventure.")]
    public int? NumberOfAntidotes { get; set; } = 0;

    [Range(0, 5, ErrorMessage = "You can only have 5 Paralyze Heals at the start of your adventure.")]
    public int? NumberOfParalyzeHeals { get; set; } = 0;

    [Range(0, 5, ErrorMessage = "You can only have 5 Awakening at the start of your adventure.")]
    public int? NumberOfAwakening { get; set; } = 0;

    [Range(0, 5, ErrorMessage = "You can only have 5 Burn Heals at the start of your adventure.")] 
    public int? NumberOfBurnHeals { get; set; } = 0;

    [Range(0, 5, ErrorMessage = "You can only have 5 Ice Heals at the start of your adventure.")]
    public int? NumberOfIceHeals { get; set; } = 0;

    [Range(0, 1, ErrorMessage = "You can only have 1 Full Heals at the start of your adventure.")]  
    public int? NumberOfFullHeals { get; set; } = 0;

    [Range(0, 1, ErrorMessage = "You can only have 1 Energy Powder at the start of your adventure.")]
    public int? NumberOfEnergyPowder { get; set; } = 0;

    [Range(0, 1, ErrorMessage = "You can only have 1 Energy Root at the start of your adventure.")]
    public int? NumberOfEnergyRoot { get; set; } = 0;

    [Range(0, 1, ErrorMessage = "You can only have 1 Heal Powder at the start of your adventure.")]
    public int? NumberOfHealPowder { get; set; } = 0;

    [Range(0, 1, ErrorMessage = "You can only have 1 Revival Herb at the start of your adventure.")]
    public int? NumberOfRevivalHerb { get; set; } = 0;

    [Range(0, 1, ErrorMessage = "You can only have 1 Soda Pop at the start of your adventure.")]
    public int? NumberOfSodaPop { get; set; } = 0;

    [Range(0, 1, ErrorMessage = "You can only have 1 Lemonade at the start of your adventure.")]
    public int? NumberOfLemonade { get; set; } = 0;

    [Range(0, 1, ErrorMessage = "You can only have 1 MooMoo Milk at the start of your adventure.")]
    public int? NumberOfMoomooMilk { get; set; } = 0;

    [Range(0, 1, ErrorMessage = "You can only have 1 Berry Juice at the start of your adventure.")]
    public int? NumberOfBerryJuice { get; set; } = 0;

    [Range(0, 1, ErrorMessage = "You can only have 1 Sacred Ash at the start of your adventure.")]
    public int? NumberOfSacredAsh { get; set; } = 0;

    [Range(0, 1, ErrorMessage = "You can only have 1 Rage Candy Bar at the start of your adventure.")]
    public int? NumberOfRageCandyBar { get; set; } = 0;

    [Range(0, 1, ErrorMessage = "You can only have 1 Lava Cookie at the start of your adventure.")]
    public int? NumberOfLavaCookie { get; set; } = 0;

    [Range(0, 1, ErrorMessage = "You can only have 1 Casteliacone at the start of your adventure.")]
    public int? NumberOfCasteliacone { get; set; } = 0;

    [Range(0, 1, ErrorMessage = "You can only have 1 Old Gateau at the start of your adventure.")]
    public int? NumberOfOldGateau { get; set; } = 0;

    [Range(0, 1, ErrorMessage = "You can only have 1 Shalour Sable at the start of your adventure.")] 
    public int? NumberOfShalourSable { get; set; } = 0;

    [Range(0, 1, ErrorMessage = "You can only have 1 Lumiose Galette at the start of your adventure.")]
    public int? NumberOfLumioseGalette { get; set; } = 0;

    [Range(0, 1, ErrorMessage = "You can only have 1 Fine Remedy at the start of your adventure.")]
    public int? NumberOfFineRemendy { get; set; } = 0;

    [Range(0, 1, ErrorMessage = "You can only have 1 Safari Ball at the start of your adventure.")]
    public int? NumberOfSafariBall { get; set; } = 0;

    [Range(0, 1, ErrorMessage = "You can only have 1 Premier Ball at the start of your adventure.")]
    public int? NumberOfPremierBall { get; set; } = 0;

    [Range(0, 1, ErrorMessage = "You can only have 1 Repeat Ball at the start of your adventure.")]
    public int? NumberOfRepeatBall { get; set; } = 0;

    [Range(0, 1, ErrorMessage = "You can only have 1 Timer Ball at the start of your adventure.")]
    public int? NumberOfTimerBall { get; set; } = 0;

    [Range(0, 1, ErrorMessage = "You can only have 1 Nest Ball at the start of your adventure.")]
    public int? NumberOfNestBall { get; set; } = 0;

    [Range(0, 1, ErrorMessage = "You can only have 1 Net Ball at the start of your adventure.")]
    public int? NumberOfNetBall { get; set; } = 0;

    [Range(0, 1, ErrorMessage = "You can only have 1 Dive Ball at the start of your adventure.")]
    public int? NumberOfDiveBall { get; set; } = 0;

    [Range(0, 1, ErrorMessage = "You can only have 1 Luxury Ball at the start of your adventure.")]
    public int? NumberOfLuxuryBall { get; set; } = 0;

    [Range(0, 1, ErrorMessage = "You can only have 1 Heal Ball at the start of your adventure.")]
    public int? NumberOfHealBall { get; set; } = 0;

    [Range(0, 1, ErrorMessage = "You can only have 1 Quick Ball at the start of your adventure.")]
    public int? NumberOfQuickBall { get; set; } = 0;

    [Range(0, 1, ErrorMessage = "You can only have 1 Dusk Ball at the start of your adventure.")]
    public int? NumberOfDuskBall { get; set; } = 0;

    [Range(0, 1, ErrorMessage = "You can only have 1 Cherish Ball at the start of your adventure.")]
    public int? NumberOfCherishBall { get; set; } = 0;


    [Range(0, 1, ErrorMessage = "You can only have 1 Park Ball at the start of your adventure.")]
    public int? NumberOfFullRestore { get; set; } = 0;


    [Range(0, 1, ErrorMessage = "You can only have 1 Full Restore at the start of your adventure.")]
    public int? NumberOfFreshWater { get; set; } = 0;
}
