using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PokemonCatcherGame.Shared.Models.HealthItemModels;

namespace Server.Services.HealthItemServices;

public interface IHealthItemService
{
    Task<bool> CreateHealthItemAsync(HealthItemCreate model);

    Task<List<HealthItemList>> GetAllHealthItemsAsync(int page, int pageSize);

    Task<List<HealthItemList>> GetAllHealthItemsForInventoryAsync();

    Task<HealthItemDetail?> GetHealthItemByIdAsync(int id);

    Task<bool> UpdateHealthItemAsync (HealthItemEdit request);

    Task<bool> DeleteHealthItemAsync(int id);
    
    void SetUserId(string userId);
}
