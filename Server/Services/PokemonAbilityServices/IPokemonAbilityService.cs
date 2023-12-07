using PokemonCatcherGame.Shared.Models.PokemonAbilityModels;

//* Purpose: Interface for Pokemon Ability Service. This interface will be used for full CRUD application of abilities for a pokemon.

namespace Server.Services.PokemonAbilityServices;

public interface IPokemonAbilityService
{
    Task<bool> CreatePokemonAbilityAsync(PokemonAbilityCreate model);
    Task<List<PokemonAbilityList>> GetAllPokemonAbilitiesAsync(int page, int pageSize);
    Task<List<PokemonAbilityList>> GetAllPokemonAbilitiesForPokemomCreationAsync();
    Task<PokemonAbilityDetail?> GetPokemonAbilityByIdAsync(int id);
    Task<bool> UpdatePokemonAbilityAsync(PokemonAbilityEdit request);
    Task<bool> DeletePokemonAbilityAsync(int id);
    void SetUserId(string userId);
}
