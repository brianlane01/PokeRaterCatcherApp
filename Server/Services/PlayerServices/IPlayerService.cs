using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PokemonCatcherGame.Shared.Models.PlayerModels;

namespace Server.Services.PlayerServices;

public interface IPlayerService
{
    Task<bool> CreatePlayerAsync(PlayerCreate model);
    Task<List<PlayerIndex>> GetAllPlayersAsync(int page, int pageSize);
    Task<PlayerDetail?> GetPlayerByIdAsync(int id);
    Task<PlayerDetail?> GetPlayerByNameAsync(string name);
    Task<bool> UpdatePlayerAsync (PlayerEdit request);
    Task<bool> DeletePlayerAsync(int id);
    void SetUserId(string userId);
}
