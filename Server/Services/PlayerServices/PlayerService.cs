using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Azure.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using PokemonCatcherGame.Server.Data;
using PokemonCatcherGame.Shared.Models.PlayerModels;
using Server.Entities;

namespace Server.Services.PlayerServices;

public class PlayerService : IPlayerService
{
    private readonly ApplicationDbContext _dbContext;

    private string? _userId;

    public PlayerService(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public async Task<bool> CreatePlayerAsync(PlayerCreate model)
    {
        if (_userId == null)
        {
            throw new InvalidOperationException("UserId is not set.");
        }
        PlayerEntity entity = new()
        {
            Name = model.Name,
            UserId = _userId,
            ItemInventoryId = model.ItemInventoryId,
        };

        _dbContext.Players.Add(entity);

        var numberOfChanges = await _dbContext.SaveChangesAsync();

        if (model.CaughtPokemon != null)
        {
            AddPokemonToPlayer(model.CaughtPokemon, entity.Id);
        }

        if (model.ActivePokemon != null)
        {
            AddActivePokemonToPlayer(model.ActivePokemon, entity.Id);
        }

        return numberOfChanges == 1;
    }

    public async Task<List<PlayerIndex>> GetAllPlayersAsync(int page, int pageSize)
    {
        var playerQuery = _dbContext.Players
            .Where(c => c.UserId == _userId)
            .Select(c => new PlayerIndex
            {
                Id = c.Id,
                Name = c.Name,
                UserId = c.UserId,
                ItemInventoryId = c.ItemInventoryId ?? 0,
            });

        return await playerQuery
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();
    }

    public async Task<PlayerDetail?> GetPlayerByIdAsync(int id)
    {
        var entity = await _dbContext.Players
            .Include(c => c.CaughtPokemon)
            .Include(c => c.CaughtPokemon)
                .ThenInclude(p => p.PokeTypeOne)
            .Include(c => c.CaughtPokemon)
                .ThenInclude(p => p.PokeTypeTwo)   
            .Include(c => c.ItemInventory!)
                .ThenInclude(i => i.PokeBalls)
            .Include(c => c.ItemInventory!)
                .ThenInclude(i => i.HealthItems)
            .Include(c => c.ItemInventory!)
                .ThenInclude(i => i.ReviveItems)
            .Include(c => c.ItemInventory!)
                .ThenInclude(i => i.RemoveStatusConditionItems)
            .Include(c => c.ItemInventory!)
                .ThenInclude(i => i.TMs)
            .SingleOrDefaultAsync(c => c.Id == id && c.UserId == _userId);

        if (entity is null)
            return null;

        return new PlayerDetail
        {
            Id = entity.Id,
            Name = entity.Name,
            UserId = entity.UserId,
            ItemInventoryId = entity.ItemInventoryId ?? 0,
            PokemonNames = entity.CaughtPokemon.Select(c => c.Name).ToList(),
            PokemonIds = entity.CaughtPokemon.Select(c => c.Id).ToList(),
            PokemonTypeOne = entity.CaughtPokemon.Select(c => c.PokeTypeOne.PokeType).ToList(),
            PokemonTypeTwo = entity.CaughtPokemon.Select(c => c.PokeTypeTwo.PokeType).ToList(),
            HealthItems = entity.ItemInventory?.HealthItems.Select(c => c.HealthItemName).ToList(),
            PokeBalls = entity.ItemInventory?.PokeBalls.Select(c => c.NameOfBall).ToList(),
            ReviveItems = entity.ItemInventory?.ReviveItems.Select(c => c.RejuvenationItemName).ToList(),
            StatusConditionItems = entity.ItemInventory?.RemoveStatusConditionItems.Select(c => c.StatusConditionItemName).ToList(),
            TMs = entity.ItemInventory?.TMs.Select(c => c.MoveName).ToList(),
        };
    }

    public async Task<PlayerDetail?> GetPlayerByNameAsync(string name)
    {
        var entity = await _dbContext.Players
            .Include(c => c.CaughtPokemon)
            .Include(c => c.CaughtPokemon)
                .ThenInclude(p => p.PokeTypeOne)
            .Include(c => c.CaughtPokemon)
                .ThenInclude(p => p.PokeTypeTwo)   
            .Include(c => c.ItemInventory!)
                .ThenInclude(i => i.PokeBalls)
            .Include(c => c.ItemInventory!)
                .ThenInclude(i => i.HealthItems)
            .Include(c => c.ItemInventory!)
                .ThenInclude(i => i.ReviveItems)
            .Include(c => c.ItemInventory!)
                .ThenInclude(i => i.RemoveStatusConditionItems)
            .Include(c => c.ItemInventory!)
                .ThenInclude(i => i.TMs)
            .SingleOrDefaultAsync(c => c.Name == name && c.UserId == _userId);

        if (entity is null)
            return null;

        return new PlayerDetail
        {
            Id = entity.Id,
            Name = entity.Name,
            UserId = entity.UserId,
            ItemInventoryId = entity.ItemInventoryId ?? 0,
            PokemonNames = entity.CaughtPokemon.Select(c => c.Name).ToList(),
            PokemonIds = entity.CaughtPokemon.Select(c => c.Id).ToList(),
            PokemonTypeOne = entity.CaughtPokemon.Select(c => c.PokeTypeOne.PokeType).ToList(),
            PokemonTypeTwo = entity.CaughtPokemon.Select(c => c.PokeTypeTwo.PokeType).ToList(),
            HealthItems = entity.ItemInventory?.HealthItems.Select(c => c.HealthItemName).ToList(),
            PokeBalls = entity.ItemInventory?.PokeBalls.Select(c => c.NameOfBall).ToList(),
            ReviveItems = entity.ItemInventory?.ReviveItems.Select(c => c.RejuvenationItemName).ToList(),
            StatusConditionItems = entity.ItemInventory?.RemoveStatusConditionItems.Select(c => c.StatusConditionItemName).ToList(),
            TMs = entity.ItemInventory?.TMs.Select(c => c.MoveName).ToList(),
        };
    }

    public void AddPokemonToPlayer(List<int> pokemonIds, int playerId)
    {
        var newPlayer = _dbContext.Players.Include(c => c.CaughtPokemon).Single(c => c.Id == playerId);
        foreach (var pokemonId in pokemonIds)
        {
            var newPokemon = _dbContext.Pokemon.Find(pokemonId);
            if (newPokemon != null)
            {
                newPlayer.CaughtPokemon.Add(newPokemon);
            }
        }

        _dbContext.SaveChanges();
    }

    public void AddActivePokemonToPlayer(List<int> pokemonIds, int playerId)
    {
        var newPlayer = _dbContext.Players.Include(c => c.ActivePokemon).Single(c => c.Id == playerId);
        foreach (var pokemonId in pokemonIds)
        {
            var newPokemon = _dbContext.PlayerPokemon.Find(pokemonId);
            if (newPokemon != null)
            {
                newPlayer.ActivePokemon.Add(newPokemon);
            }
        }

        _dbContext.SaveChanges();
    }

    public async Task<bool> UpdatePlayerAsync(PlayerEdit request)
    {
        var entity = await _dbContext.Players.FindAsync(request.Id);

        if (entity is null)
            return false;

        entity.Id = request.Id;
        entity.Name = request.Name;
        if (_userId != null)
        {
            entity.UserId = _userId;
        }
        entity.ItemInventoryId = request.ItemInventoryId;

        var numberOfChanges = await _dbContext.SaveChangesAsync();

        if (request.CaughtPokemon != null)
        {
            AddPokemonToPlayer(request.CaughtPokemon, entity.Id);
        }

        return numberOfChanges == 1;
    }

    public async Task<bool> DeletePlayerAsync(int id)
    {
        var entity = await _dbContext.Players.FindAsync(id);

        if (entity is null)
            return false;
        
        _dbContext.Players.Remove(entity);

        return await _dbContext.SaveChangesAsync() == 1;
    }

    public void SetUserId(string userId) => _userId = userId;
}
