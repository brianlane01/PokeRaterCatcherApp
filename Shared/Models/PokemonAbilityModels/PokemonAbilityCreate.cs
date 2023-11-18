//* Purpose: Model for creating a new Pokemon Ability. This model will be used to create a new ability for a pokemon.
using System.ComponentModel.DataAnnotations;

namespace PokemonCatcherGame.Shared.Models.PokemonAbilityModels;

public class PokemonAbilityCreate
{
    [Required]
    public string AbilityName { get; set; } = string.Empty;

    [Required]
    public string AbilityEffect { get; set; } = string.Empty;
    
}
