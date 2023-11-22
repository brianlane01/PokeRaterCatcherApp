using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PokemonCatcherGame.Shared.Models.PlayerModels;

public class PlayerCreate
{
    [Required, MinLength(4), MaxLength(50)]
    public string Name { get; set; } = string.Empty;

    public string UserId { get; set; } =string.Empty;

    public int? ItemInventoryId { get; set; }

    public List<int>? CaughtPokemon {get; set;}
}
