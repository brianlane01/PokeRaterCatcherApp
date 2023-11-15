using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PokemonCatcherGame.Shared.Models.PokemonModels;

namespace PokemonCatcherGame.Server.Services.PokemonServices;

public interface IPokemonService
{
    Task<bool> CreatePokemonAsync(PokemonCreate model);
    Task<List<PokemonList>> GetAllPokemonAsync();
    Task<PokemonDetail?> GetPokemonByIdAsync(int noteId);
    Task<bool> UpdatePokemonAsync(PokemonEdit request);
    Task<bool> DeletePokemonAsync(int noteId);
    void SetUserId(string userId);
}
