//* Purpose: Model for Pokemon Ability List. This model will be used to create a list of abilities for a pokemon.

namespace PokemonCatcherGame.Shared.Models.PokemonAbilityModels;

public class PokemonAbilityList
{
    public int Id { get; set; }
    public string AbilityName { get; set; } = string.Empty;
    public string AbilityEffect { get; set; } = string.Empty;
}
