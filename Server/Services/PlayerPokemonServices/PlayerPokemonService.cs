using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PokemonCatcherGame.Server.Data;
using PokemonCatcherGame.Shared.Models.PlayerPokemonModels;
using Server.Entities;

namespace Server.Services.PlayerPokemonServices;

public class PlayerPokemonService : IPlayerPokemonService
{
    private readonly ApplicationDbContext _dbContext;

    public PlayerPokemonService(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<PlayerPokeDetail?> CreatePokemonForPlayerAsync(PlayerPokeCreate model)
    {
        PlayerPokemonEntity entity = new()
        {
            PokedexNumber = model.PokedexNumber,
            Name = model.Name,
            PokeNickName = model.PokeNickName,
            Weight = model.Weight,
            Height = model.Height,
            Health = model.Health,
            BaseExperience = model.BaseExperience,
            Description = model.Description,
            PokeTypeIdOne = model.PokeTypeIdOne,
            PokeTypeIdTwo = model.PokeTypeIdTwo,
            MoveOneId = model.MoveOneId,
            MoveTwoId = model.MoveTwoId,
            MoveThreeId = model.MoveThreeId,
            MoveFourId = model.MoveFourId,
            AbilityId = model.AbilityId,
        };

        _dbContext.PlayerPokemonEntity.Add(entity);

        var pokemonAdded = await _dbContext.SaveChangesAsync();

        PlayerPokeDetail? response = await GetPokemonForPlayerByIdAsync(entity.Id);

        return response;
    }

    public Task<bool> DeletePokemonPlayerAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<PlayerPokeCreate>> GetAllPokemonForPlayerAsync(int page, int pageSize)
    {
        throw new NotImplementedException();
    }

    public async Task<PlayerPokeDetail?> GetPokemonForPlayerByIdAsync(int id)
    {
        PlayerPokemonEntity? entity = await _dbContext.PlayerPokemonEntity
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
            return new PlayerPokeDetail
            {
                Id = entity.Id,
                PokedexNumber = entity.PokedexNumber,
                Name = entity.Name,
                PokeNickName = entity.PokeNickName,
                Height = entity.Height,
                Weight = entity.Weight,
                BaseExperience = entity.BaseExperience,
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
                AbilityName = entity.Ability.AbilityName,
                AbilityDescription = entity.Ability.AbilityEffect
            };
    }

    public Task<bool> UpdatePokemonForPlayerAsync(PlayerPokeCreate request)
    {
        throw new NotImplementedException();
    }
}
