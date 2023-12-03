using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.EntityFrameworkCore;
using PokemonCatcherGame.Server.Data;
using PokemonCatcherGame.Shared.Models.PokemonModels;
using Server.Entities;

namespace PokemonCatcherGame.Server.Services.PokemonServices;

public class PokemonService : IPokemonService
{
    private readonly ApplicationDbContext _dbContext;
    private string? _userId;

    public PokemonService(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<bool> CreatePokemonAsync(PokemonCreate model)
    {
        PokemonEntity entity = new()
        {
            PokedexNumber = model.PokedexNumber,
            Name = model.Name,
            Height = model.Height,
            Weight = model.Weight,
            BaseExperience = model.BaseExperience,
            Health = model.Health,
            PokeTypeIdOne = model.PokeTypeIdOne,
            PokeTypeIdTwo = model.PokeTypeIdTwo,
            MoveOneId = model.MoveOneId,
            MoveTwoId = model.MoveTwoId,
            MoveThreeId = model.MoveThreeId,
            MoveFourId = model.MoveFourId,
            AbilityId = model.AbilityId,
            PokeNickName = model.PokeNickName,
            Description = model.Description,
        };
        _dbContext.Pokemon.Add(entity);
        var numberOfChanges = await _dbContext.SaveChangesAsync();

        return numberOfChanges == 1;

    }

    public async Task<bool> DeletePokemonAsync(int noteId)
    {
        var entity = await _dbContext.Pokemon.FindAsync(noteId);

        if (entity is null)
            return false;

        _dbContext.Pokemon.Remove(entity);

        return await _dbContext.SaveChangesAsync() == 1;
    }

    public async Task<List<PokemonList>> GetAllPokemonAsync(int page, int pageSize)
    {
        var pokemonQuery = _dbContext.Pokemon
            .Include(c => c.PokeTypeOne)
            .Include(c => c.PokeTypeTwo)
            .OrderBy(c => c.PokedexNumber)
            .Select(n =>
                new PokemonList
                {
                    Id = n.Id,
                    PokedexNumber = n.PokedexNumber,
                    Name = n.Name,
                    PokeNickName = n.PokeNickName,
                    PokeTypeNameOne = n.PokeTypeOne.PokeType,
                    PokeTypeNameTwo = n.PokeTypeTwo.PokeType,
                });

        return await pokemonQuery
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();
    }

    public async Task<List<PokemonList>> GetAllPokemonForPlayerStartAsync()
    {
        var pokemonQuery = _dbContext.Pokemon
            .Include(c => c.PokeTypeOne)
            .Include(c => c.PokeTypeTwo)
            .OrderBy(c => c.PokedexNumber)
            .Select(n =>
                new PokemonList
                {
                    Id = n.Id,
                    PokedexNumber = n.PokedexNumber,
                    Name = n.Name,
                    PokeNickName = n.PokeNickName,
                    PokeTypeNameOne = n.PokeTypeOne.PokeType,
                    PokeTypeNameTwo = n.PokeTypeTwo.PokeType,
                });

        return await pokemonQuery
            .ToListAsync();
    }

    public async Task<PokemonDetail?> GetPokemonByIdAsync(int id)
    {
        PokemonEntity? entity = await _dbContext.Pokemon
            .Include(c => c.Ability)
            .Include(c => c.MoveOne)
            .Include(c => c.MoveTwo)
            .Include(c => c.MoveThree)
            .Include(c => c.MoveFour)
            .Include(c => c.PokeTypeOne)
            .Include(c => c.PokeTypeTwo)
            .FirstOrDefaultAsync(c => c.Id == id);

        if(entity is null)
            return null;

        else
            return new PokemonDetail
            {
                Id = entity.Id,
                PokedexNumber = entity.PokedexNumber,
                Name = entity.Name,
                PokeNickName = entity.PokeNickName,
                Height = entity.Height,
                Weight = entity.Weight,
                BaseExperience = entity.BaseExperience,
                Description = entity.Description,
                Health = entity.Health,
                PokeTypeIdOne = entity.PokeTypeIdOne,
                PokeTypeNameOne = entity.PokeTypeOne.PokeType,
                PokeTypeNameTwo = entity.PokeTypeTwo.PokeType,
                PokeTypeIdTwo = entity.PokeTypeIdTwo,
                MoveOneId = entity.MoveOneId,
                MoveOneName = entity.MoveOne.MoveName,
                MoveOneDescription = entity.MoveOne.MoveDescription,
                MoveTwoId = entity.MoveTwoId,
                MoveTwoName = entity.MoveTwo.MoveName,
                MoveTwoDescription = entity.MoveTwo.MoveDescription,
                MoveThreeId = entity.MoveThreeId,
                MoveThreeName = entity.MoveThree.MoveName,
                MoveThreeDescription = entity.MoveThree.MoveDescription,
                MoveFourId = entity.MoveFourId,
                MoveFourName = entity.MoveFour.MoveName,
                MoveFourDescription = entity.MoveFour.MoveDescription,
                AbilityId = entity.AbilityId,
                AbilityName = entity.Ability.AbilityName,
                AbilityDescription = entity.Ability.AbilityEffect
            };
    }

    public async Task<bool> UpdatePokemonAsync(PokemonEdit request)
    {
        if (request is null)
            return false;

        var entity = await _dbContext.Pokemon.FindAsync(request.Id);

        if (entity is null)
            return false;

        entity.Id = request.Id;
        entity.Name = request.Name;
        entity.PokeNickName = request.PokeNickName;
        entity.MoveOneId = request.MoveOneId;
        entity.MoveTwoId = request.MoveTwoId;
        entity.MoveThreeId = request.MoveThreeId;
        entity.MoveFourId = request.MoveFourId;
        entity.AbilityId = request.AbilityId;
        
        var numberOfChanges = await _dbContext.SaveChangesAsync();

        return numberOfChanges == 1;
    }

    public async Task<int> GetPokemonTotalCountAsync()
    {
        return await _dbContext.Pokemon.CountAsync();
    }

    public void SetUserId(string userId) => _userId = userId;
}
