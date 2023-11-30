using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PokemonCatcherGame.Shared.Models.PlayerItemInventoryModels;

namespace Server.Services.PlayerInventoryServices;

public interface IPlayerInventoryService
{
    Task<PlayerInventoryDetail?> CreatePlayerInventoryAsync(PlayerInventoryCreate model);
    Task<List<PlayerInventoryIndex>> GetAllPlayerInventoriesAsync(int page, int pageSize);
    Task<List<PlayerInventoryIndex>> GetAllPlayerInventoriesForPlayerAsync();
    Task<PlayerInventoryDetail?> GetPlayerInventoryByIdAsync(int id);
    Task<bool> UpdatePlayerInventoryAsync(PlayerInventoryEdit request);
    Task<bool> DeletePlayerInventoryAsync(int id);
    void SetUserId(string userId);


}
