using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PokemonCatcherGame.Server.Data;
using PokemonCatcherGame.Shared.Models.RejuvenationItemModels;
using Server.Entities;

namespace Server.Services.RejuvenationItemServices;

public class RejuvenationItemService : IRejuvenationItemService
{
    private readonly ApplicationDbContext _dbContext;
    private string? _userId;

    public RejuvenationItemService(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<bool> CreateReviveItemAsync(RejuvenationItemCreate model)
    {
        RejuvenationItemEntity entity = new()
        {
            RejuvenationItemName = model.RejuvenationItemName,
            RejuvenationItemDescription = model.RejuvenationItemDescription,
            ReviveHealthAmount = model.ReviveHealthAmount,
            ReviveAllFaintedPokemon = model.ReviveAllFaintedPokemon,
        };
        
        _dbContext.ReviveItems.Add(entity);

        var numberOfChanges = await _dbContext.SaveChangesAsync();

        return numberOfChanges == 1;
    }

    public async Task<bool> DeleteReviveItemAsync(int id)
    {
        var entity = await _dbContext.ReviveItems.FindAsync(id);
        if(entity is null)
            return false;

        _dbContext.ReviveItems.Remove(entity);
        
        return await _dbContext.SaveChangesAsync() == 1;
    }

    public async Task<List<RejuvenationItemList>> GetAllReviveItemsAsync(int page, int pageSize)
    {
        var reviveItemQuery = _dbContext.ReviveItems
            .Select(entity => new RejuvenationItemList
            {
                Id = entity.Id,
                RejuvenationItemName = entity.RejuvenationItemName,
                RejuvenationItemDescription = entity.RejuvenationItemDescription,
            });

        return await reviveItemQuery
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();
    }

    public async Task<List<RejuvenationItemList>> GetAllReviveItemsForInventoryAsync()
    {
        var reviveItemQuery = _dbContext.ReviveItems
            .Select(entity => new RejuvenationItemList
            {
                Id = entity.Id,
                RejuvenationItemName = entity.RejuvenationItemName,
                RejuvenationItemDescription = entity.RejuvenationItemDescription,
            });

        return await reviveItemQuery
            .ToListAsync();
    }

    public async Task<RejuvenationItemDetail?> GetReviveItemByIdAsync(int id)
    {
        RejuvenationItemEntity? entity = await _dbContext.ReviveItems
            .FirstOrDefaultAsync(e => e.Id == id);

        return entity is null ? null : new RejuvenationItemDetail
        {
            Id =  entity.Id,
            RejuvenationItemDescription = entity.RejuvenationItemDescription,
            RejuvenationItemName = entity.RejuvenationItemName,
            ReviveHealthAmount = entity.ReviveHealthAmount,
            ReviveAllFaintedPokemon = entity.ReviveAllFaintedPokemon,
        };
    }

    public void SetUserId(string userId) => _userId = userId;

    public async Task<bool> UpdateReviveItemAsync(RejuvenationItemEdit request)
    {
        if (request == null)
            return false;
        
        var entity = await _dbContext.ReviveItems.FindAsync(request.Id);

        if(entity is null)
            return false;

        entity.RejuvenationItemName = request.RejuvenationItemName;
        entity.Id = request.Id;
        entity.RejuvenationItemDescription = request.RejuvenationItemDescription;
        entity.ReviveHealthAmount = request.ReviveHealthAmount;
        entity.ReviveAllFaintedPokemon = request.ReviveAllFaintedPokemon;

        return await _dbContext.SaveChangesAsync() == 1;
    }
}
