using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokemonCatcherGame.Shared.Models.PlayerModels;

public class PlayerDetail
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string UserId { get; set; } =string.Empty;

    public List<string>? PokemonNames {get; set;}

    public List<string>? PokemonTypeOne {get; set;}

    public List<string>? PokemonTypeTwo {get; set;}
    
    public List<int>? PokemonIds {get; set;}

    public List<string>? HealthItems {get; set;}

    public List<string>? PokeBalls {get; set;}

    public List<string>? ReviveItems {get; set;}

    public List<string>? StatusConditionItems {get; set;}

    public List<string>? TMs {get; set;}
}
