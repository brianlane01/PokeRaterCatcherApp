using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PokemonCatcherGame.Server.Data;
using PokemonCatcherGame.Shared.Models.PokemonAbilityModels;
using Server.Entities;

namespace Server.Services.PokemonAbilityServices;

public class PokemonAbilityService : IPokemonAbilityService
{
    private readonly ApplicationDbContext _dbContext;
    private string? _userId;
    
    public PokemonAbilityService(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<bool> CreatePokemonAbilityAsync(PokemonAbilityCreate model)
    {
        PokemonAbilityEntity entity = new()
        {
            AbilityName = model.AbilityName,
            AbilityEffect = model.AbilityEffect,
        };

        _dbContext.PokemonAbilities.Add(entity);

        var numberOfChanges = await _dbContext.SaveChangesAsync();

        return numberOfChanges == 1;
    }

    public async Task<bool> DeletePokemonAbilityAsync(int id)
    {
        var entity = await _dbContext.PokemonAbilities.FindAsync(id);

        if (entity is null)
            return false;

        _dbContext.PokemonAbilities.Remove(entity);

        return await _dbContext.SaveChangesAsync() == 1;
    }

    public async Task<List<PokemonAbilityList>> GetAllPokemonAbilitiesAsync(int page, int pageSize)
    {
        var abilityQuery = _dbContext.PokemonAbilities
            .Select(n => 
            new PokemonAbilityList
            {
                Id = n.Id,
                AbilityName = n.AbilityName,
                AbilityEffect = n.AbilityEffect,
            });
        
        return await abilityQuery
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();
    }

    public async Task<PokemonAbilityDetail?> GetPokemonAbilityByIdAsync(int id)
    {
        PokemonAbilityEntity? entity = await _dbContext.PokemonAbilities.FindAsync(id);

        if (entity is null)
            return null;
        
        else
            return new PokemonAbilityDetail
            {
                Id = entity.Id,
                AbilityName = entity.AbilityName,
                AbilityEffect = entity.AbilityEffect,
            };
    }

    public async Task<bool> UpdatePokemonAbilityAsync(PokemonAbilityEdit request)
    {
        if (request is null)
            return false;

        var entity = await _dbContext.PokemonAbilities.FindAsync(request.Id);

        if (entity is null)
            return false;
        
        entity.Id = request.Id;
        entity.AbilityName = request.AbilityName;
        entity.AbilityEffect = request.AbilityEffect;

        return await _dbContext.SaveChangesAsync() == 1;
    }

    public void SetUserId(string userId) => _userId = userId;
}
