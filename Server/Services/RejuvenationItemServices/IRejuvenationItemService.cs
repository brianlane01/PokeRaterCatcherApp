using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PokemonCatcherGame.Shared.Models.RejuvenationItemModels;

namespace Server.Services.RejuvenationItemServices;

public interface IRejuvenationItemService
{
    Task<bool> CreateReviveItemAsync (RejuvenationItemCreate model);

    Task<List<RejuvenationItemList>> GetAllReviveItemsAsync(int page, int pageSize);

    Task<List<RejuvenationItemList>> GetAllReviveItemsForInventoryAsync();

    Task<RejuvenationItemDetail?> GetReviveItemByIdAsync(int id);

    Task<bool> UpdateReviveItemAsync (RejuvenationItemEdit request);

    Task<bool> DeleteReviveItemAsync(int id);
    
    void SetUserId(string userId);
}
