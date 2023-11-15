using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokemonCatcherGame.Shared.Models.PokemonModels;

public class PokemonCreate
{
    [Required]
    public int PokedexNumber { get; set; }

    [Required]
    public string Name { get; set; } = string.Empty;

    [Required]
    public int Weight { get; set; }

    [Required]
    public int Height { get; set; }

    // [Required]
    // public int Health { get; set; }

    [Required]
    public int BaseExperience { get; set; }
}
