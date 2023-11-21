using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PokemonCatcherGame.Server.Data;
using PokemonCatcherGame.Shared.Models.HealthItemModels;
using Server.Entities;

namespace Server.Services.HealthItemServices;

public class HealthItemService : IHealthItemService
{
    private readonly ApplicationDbContext _dbContext;

    private string? _userId;

    public HealthItemService(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<bool> CreateHealthItemAsync(HealthItemCreate model)
    {
        var entity = new HealthItemEntity
        {
            HealthItemName = model.HealthItemName,
            HealthItemDescription = model.HealthItemDescription,
            AmountOfHealthRestored = model.AmountOfHealthRestored,
        };

        _dbContext.HealthRestorationItems.Add(entity);

        var numberOfChanges = await _dbContext.SaveChangesAsync();

        return numberOfChanges == 1;
    }

    public async Task<bool> DeleteHealthItemAsync(int id)
    {
        var entity = await _dbContext.HealthRestorationItems.FindAsync(id);
        if (entity is null)
            return false;

        _dbContext.HealthRestorationItems.Remove(entity);

        return await _dbContext.SaveChangesAsync() == 1;
    }

    public async Task<List<HealthItemList>> GetAllHealthItemsAsync(int page, int pageSize)
    {
        var healthItemQuery = _dbContext.HealthRestorationItems
            .Select(entity => new HealthItemList
            {
                Id = entity.Id,
                HealthItemName = entity.HealthItemName,
                HealthItemDescription = entity.HealthItemDescription,
            });

        return await healthItemQuery
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();
    }

    public async Task<List<HealthItemList>> GetAllHealthItemsForInventoryAsync()
    {
        var healthItemQuery = _dbContext.HealthRestorationItems
            .Select(entity => new HealthItemList
            {
                Id = entity.Id,
                HealthItemName = entity.HealthItemName,
                HealthItemDescription = entity.HealthItemDescription,
            });

        return await healthItemQuery.ToListAsync();
    }

    public async Task<HealthItemDetail?> GetHealthItemByIdAsync(int id)
    {
        HealthItemEntity? entity = await _dbContext.HealthRestorationItems
            .FirstOrDefaultAsync(e => e.Id == id);

        return entity is null ? null : new HealthItemDetail
        {
            Id = entity.Id,
            HealthItemName = entity.HealthItemName,
            HealthItemDescription = entity.HealthItemDescription,
            AmountOfHealthRestored = entity.AmountOfHealthRestored,
        };
    }

    public async Task<bool> UpdateHealthItemAsync(HealthItemEdit request)
    {
        if (request == null)
            return false;

        var entity = await _dbContext.HealthRestorationItems.FindAsync(request.Id);

        if (entity is null)
            return false;

        entity.HealthItemName = request.HealthItemName;
        entity.HealthItemDescription = request.HealthItemDescription;
        entity.AmountOfHealthRestored = request.AmountOfHealthRestored;

        return await _dbContext.SaveChangesAsync() == 1;
    }

    public void SetUserId(string userId) => _userId = userId;
}
