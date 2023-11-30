using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokemonCatcherGame.Shared.Models.PlayerModels;

public class PlayerIndex
{
    public int Id {get; set;}

    public string Name {get; set; } = string.Empty;

    public string UserId {get; set;} = string.Empty;
    public int ItemInventoryId { get; set; }
}
