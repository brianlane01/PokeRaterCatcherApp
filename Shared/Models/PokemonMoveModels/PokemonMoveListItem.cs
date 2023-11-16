using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokemonCatcherGame.Shared.Models.PokemonMoveModels;

public class PokemonMoveListItem
{
    public int Id { get; set; }
    public string MoveName { get; set; } = string.Empty;
    public string MoveDescription { get; set; } = string.Empty;    
}
