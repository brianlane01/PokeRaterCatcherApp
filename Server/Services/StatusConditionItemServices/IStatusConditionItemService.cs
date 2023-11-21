using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Storage;
using PokemonCatcherGame.Shared.Models.StatusConditionItemModels;

namespace Server.Services.StatusConditionItemServices;

public interface IStatusConditionItemService
{
    Task<bool> CreateStatusConditionItemAsync(StatusConditionItemCreate model);

    Task<List<StatusConditionItemList>> GetAllStatusConditionItemsAsync(int page, int pageSize);

    Task<List<StatusConditionItemList>> GetAllStatusConditionItemsForInventoryAsync();

    Task<StatusConditionItemDetail?> GetStatusConditionItemByIdAsync(int id);

    Task<bool> UpdateStatusConditionItem(StatusConditionItemEdit request);

    Task<bool> DeleteStatusConditionItemAsync(int id);

    void SetUserId(string userId);
    
}
