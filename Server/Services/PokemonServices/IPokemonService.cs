using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PokemonCatcherGame.Shared.Models.PokemonModels;

namespace PokemonCatcherGame.Server.Services.PokemonServices;

public interface IPokemonService
{
    Task<bool> CreatePokemonAsync(PokemonCreate model);
    Task<List<PokemonList>> GetAllPokemonAsync(int page, int pageSize);
    Task<List<PokemonList>> GetAllPokemonForPlayerStartAsync();
    Task<PokemonDetail?> GetPokemonByIdAsync(int id);
    Task<bool> UpdatePokemonAsync(PokemonEdit request);
    Task<bool> DeletePokemonAsync(int id);
    void SetUserId(string userId);
}
