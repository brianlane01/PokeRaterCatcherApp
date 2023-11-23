using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PokemonCatcherGame.Server.Data;
using PokemonCatcherGame.Shared.Models.PokeBallModels;
using Server.Entities;

namespace Server.Services.PokeBallServices;

public class PokeBallService : IPokeBallService
{
    private readonly ApplicationDbContext _dbContext;
    private string? _userId;

    public PokeBallService(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<bool> CreatePokeBallAsync(PokeBallCreate model)
    {
        PokeBallEntity entity = new()
        {
            NameOfBall = model.NameOfBall,
            DescriptionOfPokeBall = model.DescriptionOfPokeBall,
            CatchRate = model.CatchRate,
        };

        _dbContext.PokeBalls.Add(entity);

        var numberOfChanges = await _dbContext.SaveChangesAsync();

        return numberOfChanges == 1;
    }

    public async Task<bool> DeletePokeBallAsync(int id)
    {
        var entity = await _dbContext.PokeBalls.FindAsync(id);
        if(entity is null)
            return false;

        _dbContext.PokeBalls.Remove(entity);

        return await _dbContext.SaveChangesAsync() == 1;
    } 

    public async Task<List<PokeBallListItem>> GetAllPokeBallsAsync(int page, int pageSize)
    {
        var pokeBallQuery = _dbContext.PokeBalls
            .OrderBy(entity => entity.Id)
            .Select(entity => new PokeBallListItem
            {
                Id = entity.Id,
                NameOfBall = entity.NameOfBall,
                DescriptionOfPokeBall = entity.DescriptionOfPokeBall,
            });

        return await pokeBallQuery
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();
    }

    public async Task<List<PokeBallListItem>> GetAllPokeBallsForInventoryAsync()
    {
        var pokeBallQuery = _dbContext.PokeBalls
            .Select(entity => new PokeBallListItem
            {
                Id = entity.Id,
                NameOfBall = entity.NameOfBall,
                DescriptionOfPokeBall = entity.DescriptionOfPokeBall,
            });

        return await pokeBallQuery
            .ToListAsync();
    }

    public async Task<PokeBallDetail?> GetPokeBallByIdAsync(int id)
    {
        var entity = await _dbContext.PokeBalls.FindAsync(id);
        if(entity is null)
            return null;

        return new PokeBallDetail
        {
            Id = entity.Id,
            NameOfBall = entity.NameOfBall,
            DescriptionOfPokeBall = entity.DescriptionOfPokeBall,
            CatchRate = entity.CatchRate,
        };
    }

    public async Task<bool> UpdatePokeBallAsync(PokeBallEdit request)
    {
        var entity = await _dbContext.PokeBalls.FindAsync(request.Id);
        if(entity is null)
            return false;

        entity.NameOfBall = request.NameOfBall;
        entity.DescriptionOfPokeBall = request.DescriptionOfPokeBall;
        entity.CatchRate = request.CatchRate;

        return await _dbContext.SaveChangesAsync() == 1;
    }

    public void SetUserId(string userId) => _userId = userId;
}
