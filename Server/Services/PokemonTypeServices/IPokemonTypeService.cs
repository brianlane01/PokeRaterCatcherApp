using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PokemonCatcherGame.Shared.Models.PokemonTypeModels;

namespace PokemonCatcherGame.Server.Services.PokemonTypeServices;

public interface IPokemonTypeService
{
    Task<bool> CreatePokemonTypeAsync(PokemonTypeCreate model);
    Task<List<PokemonTypeList>> GetAllPokemonTypesAsync();
    Task<PokemonTypeDetail?> GetPokemonTypeByIdAsync(int id);
    Task<bool> UpdatePokemonTypeAsync(PokemonTypeEdit request);
    Task<bool> DeletePokemonTypeAsync(int id);
    void SetUserId(string userId);

}
