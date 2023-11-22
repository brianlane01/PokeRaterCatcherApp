using System;
using System.Collections.Generic;
using System.ComponentModel;
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
}
