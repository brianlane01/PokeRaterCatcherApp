using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokemonCatcherGame.Shared.Models.PlayerItemInventoryModels;

public class PlayerInventoryDetail
{
    public int Id { get; set; }

    public string NameOfPlayer { get; set; } = string.Empty;

    public List<string>? HealthItemNames {get; set;}

    public List<string>? HealthItemDescriptions {get; set;}

    public List<string>? ReviveItemNames {get; set;}

    public List<string>? ReviveItemDescriptions {get; set;} 

    public List<string>? PokeBallNames {get; set;}

    public List<string>? PokeBallDescriptions {get; set;}

    public List<string>? StatusConditionItemNames {get; set;}

    public List<string>? StatusConditionItemDescriptions {get; set;}

    public List<string>? TMNumbers {get; set;}

    public List<string>? MoveNames {get; set;}
    
    public List<string>? MoveDescriptions {get; set;}

    public int NumberOfPotions { get; set; }
    public int NumberOfSuperPotions { get; set; }   
    public int NumberOfHyperPotions { get; set; }    
    public int NumberOfMaxPotions { get; set; }    
    public int NumberOfRevives { get; set; }    
    public int NumberOfMaxRevives { get; set; }    
    public int NumberOfPokeBalls { get; set; }        
    public int NumberOfGreatBalls { get; set; }
    public int NumberOfUltraBalls { get; set; }    
    public int NumberOfMasterBalls { get; set; }
    public int NumberOfAntidotes { get; set; }
    public int NumberOfParalyzeHeals { get; set; }
    public int NumberOfAwakening { get; set; }
    public int NumberOfBurnHeals { get; set; }
    public int NumberOfIceHeals { get; set; }
    public int NumberOfFullHeals { get; set; }
    public int NumberOfEnergyPowder { get; set; }
    public int NumberOfEnergyRoot { get; set; }
    public int NumberOfHealPowder { get; set; }
    public int NumberOfRevivalHerb { get; set; }
    public int NumberOfSodaPop { get; set; }
    public int NumberOfLemonade { get; set; }
    public int NumberOfMoomooMilk { get; set; }
    public int NumberOfBerryJuice { get; set; }
    public int NumberOfSacredAsh { get; set; }
    public int NumberOfRageCandyBar { get; set; }
    public int NumberOfLavaCookie { get; set; }
    public int NumberOfCasteliacone { get; set; }
    public int NumberOfOldGateau { get; set; }
    public int NumberOfShalourSable { get; set; }
    public int NumberOfLumioseGalette { get; set; }
    public int NumberOfFineRemendy { get; set; }
    public int NumberOfSafariBall { get; set; }
    public int NumberOfPremierBall { get; set; }
    public int NumberOfRepeatBall { get; set; }
    public int NumberOfTimerBall { get; set; }
    public int NumberOfNestBall { get; set; }
    public int NumberOfNetBall { get; set; }
    public int NumberOfDiveBall { get; set; }
    public int NumberOfLuxuryBall { get; set; }
    public int NumberOfHealBall { get; set; }
    public int NumberOfQuickBall { get; set; }
    public int NumberOfDuskBall { get; set; }
    public int NumberOfCherishBall { get; set; }    
    public int NumberOfFullRestore { get; set; }
    public int NumberOfFreshWater { get; set; } = 0;
}
