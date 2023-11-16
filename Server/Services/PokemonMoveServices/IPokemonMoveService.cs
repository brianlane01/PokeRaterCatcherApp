using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PokemonCatcherGame.Shared.Models.PokemonMoveModels;
using Shared.Models.PokemonMoveModels;

namespace PokemonCatcherGame.Server.Services.PokemonMoveServices;

public interface IPokemonMoveService
{
    Task<bool> CreatePokemonMoveAsync(PokemonMoveCreate model);
    Task<List<PokemonMoveListItem>> GetAllPokemonMovesAsync();
    Task<PokemonMoveDetailDb?> GetPokemonMoveByIdAsync(int id);
    Task<bool> UpdatePokemonMoveAsync(PokemonMoveEdit request);
    Task<bool> DeletePokemonMoveAsync(int id);
    void SetUserId(string userId);
}
