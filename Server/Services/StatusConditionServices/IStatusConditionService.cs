using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PokemonCatcherGame.Shared.Models.StatusConditionModels;

namespace PokemonCatcherGame.Server.Services.StatusConditionServices;

public interface IStatusConditionService
{
    Task<bool> CreateStatusConditionAsync(StatusConditionCreate model);
    Task<List<StatusConditionList>> GetAllStatusConditionsAsync();
    Task<StatusConditionDetail?> GetStatusConditionByIdAsync(int id);
    Task<bool> UpdateStatusConditionAsync(StatusConditionEdit model);
    Task<bool> DeleteStatusConditionAsync(int id);
    void SetUserId(string userId);
}
