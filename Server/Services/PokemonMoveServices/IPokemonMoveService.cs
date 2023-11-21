using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PokemonCatcherGame.Shared.Models.PokemonMoveModels;


namespace PokemonCatcherGame.Server.Services.PokemonMoveServices;

public interface IPokemonMoveService
{
    Task<bool> CreatePokemonMoveAsync(PokemonMoveCreate model);
    Task<List<PokemonMoveListItem>> GetAllPokemonMovesAsync(int page, int pageSize);
    Task<PokemonMoveDetailDb?> GetPokemonMoveByIdAsync(int id);
    Task<bool> UpdatePokemonMoveAsync(PokemonMoveEdit request);
    Task<bool> DeletePokemonMoveAsync(int id);
    Task<List<PokemonMoveListItem>> GetAllPokemonMovesForPokemonCreateAsync();
    void SetUserId(string userId);
}
