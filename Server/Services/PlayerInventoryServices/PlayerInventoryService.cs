using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PokemonCatcherGame.Server.Data;
using PokemonCatcherGame.Shared.Models.PlayerItemInventoryModels;
using Server.Entities;

namespace Server.Services.PlayerInventoryServices;

public class PlayerInventoryService : IPlayerInventoryService
{
    private readonly ApplicationDbContext _dbContext;

    private string? _userId;

    public PlayerInventoryService(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<bool> CreatePlayerInventoryAsync(PlayerInventoryCreate model)
    {
        PlayerItemInventoryEntity entity = new()
        {
            NameOfPlayer = model.NameOfPlayer,
        };

        _dbContext.PlayerItemInventories.Add(entity);

        var numberOfChanges = await _dbContext.SaveChangesAsync();

        if (model.HealthItems != null && model.HealthItems.Count > 0)
        {
            AddHealthItemsToInventory(model.HealthItems, entity.Id);
        }

        if (model.ReviveItems != null && model.ReviveItems.Count > 0)
        {
            AddReviveItemsToInventory(model.ReviveItems, entity.Id);
        }

        if (model.PokeBalls != null && model.PokeBalls.Count > 0)
        {
            AddPokeBallToInventory(model.PokeBalls, entity.Id);
        }

        if (model.StatusConditionItems != null && model.StatusConditionItems.Count > 0)
        {
            AddRemoveStatusConditionItemsToInventory(model.StatusConditionItems, entity.Id);
        }

        if (model.TMs != null)
        {
            AddTMsToInventory(model.TMs, entity.Id);
        }

        return numberOfChanges == 1;
    }

    public async Task<List<PlayerInventoryIndex>> GetAllPlayerInventoriesAsync(int page, int pageSize)
    {
        var playerInventoryQuery = _dbContext.PlayerItemInventories
            .Select(c => new PlayerInventoryIndex
            {
                Id = c.Id,
                NameOfPlayer = c.NameOfPlayer,
            });

        return await playerInventoryQuery
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();
    }

    public async Task<List<PlayerInventoryIndex>> GetAllPlayerInventoriesForPlayerAsync()
    {
        var playerInventoryQuery = _dbContext.PlayerItemInventories
            .Select(c => new PlayerInventoryIndex
            {
                Id = c.Id,
                NameOfPlayer = c.NameOfPlayer,
            });

        return await playerInventoryQuery.ToListAsync();
    }

    public async Task<PlayerInventoryDetail?> GetPlayerInventoryByIdAsync(int id)
    {
        var entity = await _dbContext.PlayerItemInventories
            .Include(c => c.HealthItems)
            .Include(c => c.ReviveItems)
            .Include(c => c.PokeBalls)
            .Include(c => c.RemoveStatusConditionItems)
            .Include(c => c.TMs)
            .SingleOrDefaultAsync(c => c.Id == id);

        if (entity is null)
            return null;

        return new PlayerInventoryDetail
        {
            Id = entity.Id,
            NameOfPlayer = entity.NameOfPlayer,
            HealthItemNames = entity.HealthItems.Select(c => c.HealthItemName).ToList(),
            HealthItemDescriptions = entity.HealthItems.Select(c => c.HealthItemDescription).ToList(),
            ReviveItemNames = entity.ReviveItems.Select(c => c.RejuvenationItemName).ToList(),
            ReviveItemDescriptions = entity.ReviveItems.Select(c => c.RejuvenationItemDescription).ToList(),   
            PokeBallNames = entity.PokeBalls.Select(c => c.NameOfBall).ToList(),
            PokeBallDescriptions = entity.PokeBalls.Select(c => c.DescriptionOfPokeBall).ToList(),
            StatusConditionItemNames = entity.RemoveStatusConditionItems.Select(c => c.StatusConditionItemName).ToList(),
            StatusConditionItemDescriptions = entity.RemoveStatusConditionItems.Select(c => c.StatusConditionItemDescription).ToList(),
            TMNumbers = entity.TMs.Select(c => c.TMNumber).ToList(),
            MoveNames = entity.TMs.Select(c => c.MoveName).ToList(),
        };
    }

    public async Task<bool> UpdatePlayerInventoryAsync(PlayerInventoryEdit request)
    {
        var entity = await _dbContext.PlayerItemInventories.FindAsync(request.Id);

        if (entity is null)
            return false;

        entity.NameOfPlayer = request.NameOfPlayer;

        _dbContext.PlayerItemInventories.Update(entity);

        var numberOfChanges = await _dbContext.SaveChangesAsync();

        if (request.HealthItems != null && request.HealthItems.Count > 0)
        {
            AddHealthItemsToInventory(request.HealthItems, entity.Id);
        }

        if (request.ReviveItems != null && request.ReviveItems.Count > 0)
        {
            AddReviveItemsToInventory(request.ReviveItems, entity.Id);
        }

        if (request.PokeBalls != null && request.PokeBalls.Count > 0)
        {
            AddPokeBallToInventory(request.PokeBalls, entity.Id);
        }

        if (request.StatusConditionItems != null && request.StatusConditionItems.Count > 0)
        {
            AddRemoveStatusConditionItemsToInventory(request.StatusConditionItems, entity.Id);
        }

        if (request.TMs != null)
        {
            AddTMsToInventory(request.TMs, entity.Id);
        }

        return numberOfChanges == 1;
    }

    public async Task<bool> DeletePlayerInventoryAsync(int id)
    {
        var entity = await _dbContext.PlayerItemInventories.FindAsync(id);

        if (entity is null)
            return false;

        _dbContext.PlayerItemInventories.Remove(entity);

        return await _dbContext.SaveChangesAsync() == 1;
    }

    public void AddHealthItemsToInventory(List<int> healthItemIds, int inventoryId)
    {
        var newInventory = _dbContext.PlayerItemInventories.Include(c => c.HealthItems).Single(c => c.Id == inventoryId);
        foreach (var healthItemId in healthItemIds)
        {
            var newHealthItem = _dbContext.HealthRestorationItems.Find(healthItemId);
            if (newHealthItem != null)
            {
                newInventory.HealthItems.Add(newHealthItem);
            }
        }

        _dbContext.SaveChanges();
    }

    public void AddReviveItemsToInventory(List<int> reviveItemIds, int inventoryId)
    {
        var newInventory = _dbContext.PlayerItemInventories.Include(c => c.ReviveItems).Single(c => c.Id == inventoryId);
        foreach (var reviveItemId in reviveItemIds)
        {
            var newReviveItem = _dbContext.ReviveItems.Find(reviveItemId);
            if (newReviveItem != null)
            {
                newInventory.ReviveItems.Add(newReviveItem);
            }
        }

        _dbContext.SaveChanges();
    }

    public void AddPokeBallToInventory(List<int> pokeBallIds, int inventoryId)
    {
        var newInventory = _dbContext.PlayerItemInventories.Include(c => c.PokeBalls).Single(c => c.Id == inventoryId);
        foreach (var pokeBallId in pokeBallIds)
        {
            var newPokeBall = _dbContext.PokeBalls.Find(pokeBallId);
            if (newPokeBall != null)
            {
                newInventory.PokeBalls.Add(newPokeBall);
            }
        }

        _dbContext.SaveChanges();
    }

    public void AddRemoveStatusConditionItemsToInventory(List<int> statusConditionItemIds, int inventoryId)
    {
        var newInventory = _dbContext.PlayerItemInventories.Include(c => c.RemoveStatusConditionItems).Single(c => c.Id == inventoryId);
        foreach (var statusConditionItemId in statusConditionItemIds)
        {
            var newStatusConditionItem = _dbContext.StatusConditionItems.Find(statusConditionItemId);
            if (newStatusConditionItem != null)
            {
                newInventory.RemoveStatusConditionItems.Add(newStatusConditionItem);
            }
        }

        _dbContext.SaveChanges();
    }

    public void AddTMsToInventory(List<int> tmIds, int inventoryId)
    {
        var newInventory = _dbContext.PlayerItemInventories.Include(c => c.TMs).Single(c => c.Id == inventoryId);
        foreach (var tmId in tmIds)
        {
            var newTM = _dbContext.TMs.Find(tmId);
            if (newTM != null)
            {
                newInventory.TMs.Add(newTM);
            }
        }

        _dbContext.SaveChanges();
    }
    
    public void SetUserId(string userId) => _userId = userId;
}
