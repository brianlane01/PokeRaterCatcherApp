//* Purpose: Model for editing a Pokemon Ability. This model will be used to edit an ability for a pokemon.

using System.ComponentModel.DataAnnotations;

namespace PokemonCatcherGame.Shared.Models.PokemonAbilityModels;

public class PokemonAbilityEdit
{
    public int Id { get; set; }

    [Required]
    public string AbilityName { get; set; } = string.Empty;

    [Required]
    public string AbilityEffect { get; set; } = string.Empty;
    
}
