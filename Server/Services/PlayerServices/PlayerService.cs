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

    private string _userId;

    public PlayerService(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public async Task<bool> CreatePlayerAsync(PlayerCreate model)
    {
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

        return numberOfChanges == 1;
    }

    public async Task<List<PlayerIndex>> GetAllPlayersAsync()
    {
        var playerQuery = _dbContext.Players
            .Where(c => c.UserId == _userId)
            .Select(c => new PlayerIndex
            {
                Id = c.Id,
                Name = c.Name,
                UserId = c.UserId,
            });

        return await playerQuery.ToListAsync();
    }

    public async Task<PlayerDetail?> GetPlayerByIdAsync(int id)
    {
        var entity = await _dbContext.Players
            .Include(c => c.CaughtPokemon)
            .Include(c => c.ItemInventory)
            .SingleOrDefaultAsync(c => c.Id == id && c.UserId == _userId);

        if (entity is null)
            return null;

        return new PlayerDetail
        {
            Id = entity.Id,
            Name = entity.Name,
            UserId = entity.UserId,
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

    public Task<bool> UpdatePlayerAsync(PlayerEdit request)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeletePlayerAsync(int id)
    {
        throw new NotImplementedException();
    }

    public void SetUserId(string userId)
    {
        throw new NotImplementedException();
    }
}
