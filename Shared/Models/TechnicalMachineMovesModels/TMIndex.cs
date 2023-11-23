using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokemonCatcherGame.Shared.Models.TechnicalMachineMovesModels;

public class TMIndex
{
    public int Id { get; set; }

    public string TMNumber { get; set; } = string.Empty;
    
    public string MoveName { get; set; } = string.Empty;

    public string MoveDescription { get; set; } = string.Empty;
}
