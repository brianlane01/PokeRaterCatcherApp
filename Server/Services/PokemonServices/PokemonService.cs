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
            MoveFourId = model.MoveFourId
        };
        _dbContext.Pokemon.Add(entity);
        var numberOfChanges = await _dbContext.SaveChangesAsync();

        AddAbilityToPokemon(model.AbilitiesList, entity.Id);

        return numberOfChanges == 1;

    }

    public async Task<bool> DeletePokemonAsync(int noteId)
    {
        throw new NotImplementedException();
    }

    public async Task<List<PokemonList>> GetAllPokemonAsync()
    {
        throw new NotImplementedException();
    }

    public async Task<PokemonDetail?> GetPokemonByIdAsync(int noteId)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> UpdatePokemonAsync(PokemonEdit request)
    {
        throw new NotImplementedException();
    }

    public void SetUserId(string userId) => _userId = userId;

    public void AddAbilityToPokemon(List<int> abilityIds, int pokeId)
    {
        var newPokemon = _dbContext.Pokemon.Include(c => c.AbilitiesList).Single(c => c.Id == pokeId);
        foreach (var abilityId in abilityIds)
        {
            var newAbility = _dbContext.PokemonAbilities.Find(abilityId);
            if (newAbility != null)
            {
                newPokemon.AbilitiesList.Add(newAbility);
            }
        }

        _dbContext.SaveChanges();
    }

}
