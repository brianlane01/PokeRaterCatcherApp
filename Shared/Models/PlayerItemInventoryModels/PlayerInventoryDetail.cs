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

}
