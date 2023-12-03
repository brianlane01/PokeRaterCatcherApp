using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PokemonCatcherGame.Shared.Models.PlayerPokemonModels;

namespace Server.Services.PlayerPokemonServices;

public interface IPlayerPokemonService
{
    Task<PlayerPokeDetail?> CreatePokemonForPlayerAsync(PlayerPokeCreate model);
    Task<List<PlayerPokeCreate>> GetAllPokemonForPlayerAsync(int page, int pageSize);
    Task<PlayerPokeDetail?> GetPokemonForPlayerByIdAsync(int id);
    Task<bool> UpdatePokemonForPlayerAsync(PlayerPokeCreate request);
    Task<bool> DeletePokemonPlayerAsync(int id);
}
