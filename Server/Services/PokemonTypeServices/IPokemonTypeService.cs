using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PokemonCatcherGame.Shared.Models.PokemonTypeModels;

namespace PokemonCatcherGame.Server.Services.PokemonTypeServices;

public interface IPokemonTypeService
{
    Task<List<PokemonTypeList>> GetAllPokemonTypesAsync();
    void SetUserId(string userId);
}
