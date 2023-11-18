//* Purpose: Model for Pokemon Ability Detail. This model will be used to create a detail view of an ability for a pokemon.

namespace PokemonCatcherGame.Shared.Models.PokemonAbilityModels;

public class PokemonAbilityDetail
{
    public int Id { get; set; }
    public string AbilityName { get; set; } = string.Empty;
    public string AbilityEffect { get; set; } = string.Empty;
}

