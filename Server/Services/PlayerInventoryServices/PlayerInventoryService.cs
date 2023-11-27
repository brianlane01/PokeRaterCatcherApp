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
            NumberOfAntidotes = model.NumberOfAntidotes ?? 0,
            NumberOfGreatBalls = model.NumberOfGreatBalls ?? 0,
            NumberOfHyperPotions = model.NumberOfHyperPotions ?? 0,
            NumberOfIceHeals = model.NumberOfIceHeals ?? 0,
            NumberOfMaxPotions = model.NumberOfMaxPotions ?? 0,
            NumberOfMaxRevives = model.NumberOfMaxRevives ?? 0,
            NumberOfParalyzeHeals = model.NumberOfParalyzeHeals ?? 0,
            NumberOfPokeBalls = model.NumberOfPokeBalls ?? 0,
            NumberOfPotions = model.NumberOfPotions ?? 0,
            NumberOfRevives = model.NumberOfRevives ?? 0,
            NumberOfSuperPotions = model.NumberOfSuperPotions ?? 0,
            NumberOfUltraBalls = model.NumberOfUltraBalls ?? 0,
            NumberOfAwakening = model.NumberOfAwakening ?? 0,
            NumberOfBurnHeals = model.NumberOfBurnHeals ?? 0,
            NumberOfMasterBalls = model.NumberOfMasterBalls ?? 0,
            NumberOfBerryJuice = model.NumberOfBerryJuice ?? 0,
            NumberOfCasteliacone = model.NumberOfCasteliacone ?? 0,
            NumberOfCherishBall = model.NumberOfCherishBall ?? 0,
            NumberOfDiveBall = model.NumberOfDiveBall ?? 0,
            NumberOfDuskBall = model.NumberOfDuskBall ?? 0,
            NumberOfEnergyPowder = model.NumberOfEnergyPowder ?? 0,
            NumberOfEnergyRoot = model.NumberOfEnergyRoot ?? 0, 
            NumberOfFineRemendy = model.NumberOfFineRemendy ?? 0,
            NumberOfFullHeals = model.NumberOfFullHeals ?? 0,
            NumberOfFullRestore = model.NumberOfFullRestore ?? 0,
            NumberOfHealPowder = model.NumberOfHealPowder ?? 0,
            NumberOfHealBall = model.NumberOfHealBall ?? 0,
            NumberOfLavaCookie = model.NumberOfLavaCookie ?? 0,
            NumberOfLemonade = model.NumberOfLemonade ?? 0,
            NumberOfLumioseGalette = model.NumberOfLumioseGalette ?? 0,
            NumberOfLuxuryBall = model.NumberOfLuxuryBall ?? 0,
            NumberOfMoomooMilk = model.NumberOfMoomooMilk ?? 0,
            NumberOfNestBall = model.NumberOfNestBall ?? 0,
            NumberOfNetBall = model.NumberOfNetBall ?? 0,
            NumberOfOldGateau = model.NumberOfOldGateau ?? 0,
            NumberOfPremierBall = model.NumberOfPremierBall ?? 0,
            NumberOfQuickBall = model.NumberOfQuickBall ?? 0,
            NumberOfRepeatBall = model.NumberOfRepeatBall ?? 0,
            NumberOfRevivalHerb = model.NumberOfRevivalHerb ?? 0,
            NumberOfSafariBall = model.NumberOfSafariBall ?? 0,
            NumberOfShalourSable = model.NumberOfShalourSable ?? 0,
            NumberOfSacredAsh = model.NumberOfSacredAsh ?? 0,
            NumberOfSodaPop = model.NumberOfSodaPop ?? 0,
            NumberOfRageCandyBar = model.NumberOfRageCandyBar ?? 0,
            NumberOfTimerBall = model.NumberOfTimerBall ?? 0,
            NumberOfFreshWater = model.NumberOfFreshWater ?? 0,
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
            MoveDescriptions = entity.TMs.Select(c => c.MoveDescription).ToList(),
            NumberOfPotions = entity.NumberOfPotions,
            NumberOfSuperPotions = entity.NumberOfSuperPotions,
            NumberOfHyperPotions = entity.NumberOfHyperPotions,
            NumberOfMaxPotions = entity.NumberOfMaxPotions,
            NumberOfRevives = entity.NumberOfRevives,
            NumberOfMaxRevives = entity.NumberOfMaxRevives,
            NumberOfPokeBalls = entity.NumberOfPokeBalls,
            NumberOfGreatBalls = entity.NumberOfGreatBalls,
            NumberOfUltraBalls = entity.NumberOfUltraBalls,
            NumberOfMasterBalls = entity.NumberOfMasterBalls,
            NumberOfAntidotes = entity.NumberOfAntidotes,
            NumberOfParalyzeHeals = entity.NumberOfParalyzeHeals,
            NumberOfAwakening = entity.NumberOfAwakening,
            NumberOfBurnHeals = entity.NumberOfBurnHeals,
            NumberOfIceHeals = entity.NumberOfIceHeals,
            NumberOfFullHeals = entity.NumberOfFullHeals,
            NumberOfEnergyPowder = entity.NumberOfEnergyPowder,
            NumberOfEnergyRoot = entity.NumberOfEnergyRoot,
            NumberOfHealPowder = entity.NumberOfHealPowder,
            NumberOfRevivalHerb = entity.NumberOfRevivalHerb,
            NumberOfSodaPop = entity.NumberOfSodaPop,
            NumberOfLemonade = entity.NumberOfLemonade,
            NumberOfMoomooMilk = entity.NumberOfMoomooMilk,
            NumberOfBerryJuice = entity.NumberOfBerryJuice,
            NumberOfSacredAsh = entity.NumberOfSacredAsh,
            NumberOfRageCandyBar = entity.NumberOfRageCandyBar,
            NumberOfLavaCookie = entity.NumberOfLavaCookie,
            NumberOfCasteliacone = entity.NumberOfCasteliacone,
            NumberOfOldGateau = entity.NumberOfOldGateau,
            NumberOfShalourSable = entity.NumberOfShalourSable,
            NumberOfLumioseGalette = entity.NumberOfLumioseGalette,
            NumberOfFineRemendy = entity.NumberOfFineRemendy,
            NumberOfSafariBall = entity.NumberOfSafariBall,
            NumberOfPremierBall = entity.NumberOfPremierBall,
            NumberOfRepeatBall = entity.NumberOfRepeatBall,
            NumberOfTimerBall = entity.NumberOfTimerBall,
            NumberOfNestBall = entity.NumberOfNestBall,
            NumberOfNetBall = entity.NumberOfNetBall,
            NumberOfDiveBall = entity.NumberOfDiveBall,
            NumberOfLuxuryBall = entity.NumberOfLuxuryBall,
            NumberOfHealBall = entity.NumberOfHealBall,
            NumberOfQuickBall = entity.NumberOfQuickBall,
            NumberOfDuskBall = entity.NumberOfDuskBall,
            NumberOfCherishBall = entity.NumberOfCherishBall,
            NumberOfFullRestore = entity.NumberOfFullRestore,
            NumberOfFreshWater = entity.NumberOfFreshWater,
        };
    }

    public async Task<bool> UpdatePlayerInventoryAsync(PlayerInventoryEdit request)
    {
        var entity = await _dbContext.PlayerItemInventories.FindAsync(request.Id);

        if (entity is null)
            return false;

        entity.NameOfPlayer = request.NameOfPlayer;
        entity.NumberOfAntidotes = request.NumberOfAntidotes ?? 0;
        entity.NumberOfGreatBalls = request.NumberOfGreatBalls ?? 0;
        entity.NumberOfIceHeals = request.NumberOfIceHeals ?? 0;
        entity.NumberOfHyperPotions = request.NumberOfHyperPotions ?? 0;
        entity.NumberOfMaxPotions = request.NumberOfMaxPotions ?? 0;
        entity.NumberOfMaxRevives = request.NumberOfMaxRevives ?? 0;
        entity.NumberOfParalyzeHeals = request.NumberOfParalyzeHeals ?? 0;
        entity.NumberOfPokeBalls = request.NumberOfPokeBalls ?? 0;
        entity.NumberOfPotions = request.NumberOfPotions ?? 0;
        entity.NumberOfRevives = request.NumberOfRevives ?? 0;
        entity.NumberOfSuperPotions = request.NumberOfSuperPotions ?? 0;
        entity.NumberOfUltraBalls = request.NumberOfUltraBalls ?? 0;
        entity.NumberOfAwakening = request.NumberOfAwakening ?? 0;
        entity.NumberOfBurnHeals = request.NumberOfBurnHeals ?? 0;
        entity.NumberOfMasterBalls = request.NumberOfMasterBalls ?? 0;
        entity.NumberOfBerryJuice = request.NumberOfBerryJuice ?? 0;
        entity.NumberOfCasteliacone = request.NumberOfCasteliacone ?? 0;
        entity.NumberOfCherishBall = request.NumberOfCherishBall ?? 0;
        entity.NumberOfDiveBall = request.NumberOfDiveBall ?? 0;
        entity.NumberOfDuskBall = request.NumberOfDuskBall ?? 0;
        entity.NumberOfEnergyPowder = request.NumberOfEnergyPowder ?? 0;
        entity.NumberOfEnergyRoot = request.NumberOfEnergyRoot ?? 0; 
        entity.NumberOfFineRemendy = request.NumberOfFineRemendy ?? 0;
        entity.NumberOfFullHeals = request.NumberOfFullHeals ?? 0;
        entity.NumberOfFullRestore = request.NumberOfFullRestore ?? 0;
        entity.NumberOfHealPowder = request.NumberOfHealPowder ?? 0;
        entity.NumberOfHealBall = request.NumberOfHealBall ?? 0;
        entity.NumberOfLavaCookie = request.NumberOfLavaCookie ?? 0;
        entity.NumberOfLemonade = request.NumberOfLemonade ?? 0;
        entity.NumberOfLumioseGalette = request.NumberOfLumioseGalette ?? 0;
        entity.NumberOfLuxuryBall = request.NumberOfLuxuryBall ?? 0;
        entity.NumberOfMoomooMilk = request.NumberOfMoomooMilk ?? 0;
        entity.NumberOfNestBall = request.NumberOfNestBall ?? 0;
        entity.NumberOfNetBall = request.NumberOfNetBall ?? 0;
        entity.NumberOfOldGateau = request.NumberOfOldGateau ?? 0;
        entity.NumberOfPremierBall = request.NumberOfPremierBall ?? 0;
        entity.NumberOfQuickBall = request.NumberOfQuickBall ?? 0;
        entity.NumberOfRepeatBall = request.NumberOfRepeatBall ?? 0;
        entity.NumberOfRevivalHerb = request.NumberOfRevivalHerb ?? 0;
        entity.NumberOfSafariBall = request.NumberOfSafariBall ?? 0;
        entity.NumberOfShalourSable = request.NumberOfShalourSable ?? 0;
        entity.NumberOfSacredAsh = request.NumberOfSacredAsh ?? 0;
        entity.NumberOfSodaPop = request.NumberOfSodaPop ?? 0;
        entity.NumberOfRageCandyBar = request.NumberOfRageCandyBar ?? 0;
        entity.NumberOfTimerBall = request.NumberOfTimerBall ?? 0;
        entity.NumberOfFreshWater = request.NumberOfFreshWater ?? 0;
        
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
