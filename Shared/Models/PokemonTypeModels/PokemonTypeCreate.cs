using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PokemonCatcherGame.Shared.Models.PokemonTypeModels;

public class PokemonTypeCreate
{
    [Required]
    public string PokeType { get; set; } = string.Empty;
}
