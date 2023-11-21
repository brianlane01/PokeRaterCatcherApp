using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PokemonCatcherGame.Server.Data;
using PokemonCatcherGame.Shared.Models.StatusConditionItemModels;
using Server.Entities;

namespace Server.Services.StatusConditionItemServices;

public class StatusConditionItemService : IStatusConditionItemService
{
    private readonly ApplicationDbContext _dbContext;
    private string? _userId;

    public StatusConditionItemService(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<bool> CreateStatusConditionItemAsync(StatusConditionItemCreate model)
    {
        StatusConditionItemEntity entity = new()
        {
            StatusConditionItemName = model.StatusConditionItemName,
            StatusConditionItemDescription = model.StatusConditionItemDescription,
            RemovesBurn = model.RemovesBurn,
            RemovesConfusion = model.RemovesConfusion,
            RemovesFreeze = model.RemovesFreeze,
            RemovesPoison = model.RemovesPoison,
            RemovesParalysis = model.RemovesParalysis,
            RemovesSleep = model.RemovesSleep,
        };
        _dbContext.StatusConditionItems.Add(entity);
        var numberOfChanges = await _dbContext.SaveChangesAsync();

        return numberOfChanges == 1;
    }

    public async Task<bool> DeleteStatusConditionItemAsync(int id)
    {
        var entity = await _dbContext.StatusConditionItems.FindAsync(id);

        if(entity is null)
            return false;

        _dbContext.StatusConditionItems.Remove(entity);

        return await _dbContext.SaveChangesAsync() == 1;
    }

    public async Task<List<StatusConditionItemList>> GetAllStatusConditionItemsAsync(int page, int pageSize)
    {
        var statusConditionItemQuery = _dbContext.StatusConditionItems
            .Select(entity => new StatusConditionItemList
            {
                Id = entity.Id,
                StatusConditionItemName = entity.StatusConditionItemName,
                StatusConditionItemDescription = entity.StatusConditionItemDescription,
            });

        return await statusConditionItemQuery
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();
    }

    public async Task<List<StatusConditionItemList>> GetAllStatusConditionItemsForInventoryAsync()
    {
        var moveQuery = _dbContext.StatusConditionItems
            .Select(entity => 
                new StatusConditionItemList
                {
                    Id = entity.Id,
                    StatusConditionItemName = entity.StatusConditionItemName,
                    StatusConditionItemDescription = entity.StatusConditionItemDescription,
                });
        
        return await moveQuery
            .ToListAsync();
    }

    public async Task<StatusConditionItemDetail?> GetStatusConditionItemByIdAsync(int id)
    {
        var entity = await _dbContext.StatusConditionItems.FindAsync(id);
        if(entity is null)
            return null;

        return new StatusConditionItemDetail
        {
            Id = entity.Id,
            StatusConditionItemName = entity.StatusConditionItemName,
            StatusConditionItemDescription = entity.StatusConditionItemDescription,
            RemovesBurn = entity.RemovesBurn,
            RemovesConfusion = entity.RemovesConfusion,
            RemovesFreeze = entity.RemovesFreeze,
            RemovesPoison = entity.RemovesPoison,
            RemovesParalysis = entity.RemovesParalysis,
            RemovesSleep = entity.RemovesSleep,
        };
    }

    public void SetUserId(string userId) => _userId = userId;

    public async Task<bool> UpdateStatusConditionItem(StatusConditionItemEdit request)
    {
        var entity = await _dbContext.StatusConditionItems.FindAsync(request.Id);

        if(entity is null)
            return false;

        entity.StatusConditionItemName = request.StatusConditionItemName;
        entity.StatusConditionItemDescription = request.StatusConditionItemDescription;
        entity.RemovesBurn = request.RemovesBurn;
        entity.RemovesConfusion = request.RemovesConfusion;
        entity.RemovesSleep = request.RemovesSleep;
        entity.RemovesFreeze = request.RemovesFreeze;
        entity.RemovesParalysis = request.RemovesParalysis;
        entity.RemovesPoison = request.RemovesPoison;

        return await _dbContext.SaveChangesAsync() == 1;
    }
}
