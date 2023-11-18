using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PokemonCatcherGame.Server.Data;
using PokemonCatcherGame.Shared.Models.PokemonTypeModels;

namespace PokemonCatcherGame.Server.Services.PokemonTypeServices;

public class PokemonTypeService : IPokemonTypeService
{
    private readonly ApplicationDbContext _dbContext;
    private string? _userId;

    public PokemonTypeService(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<bool> CreatePokemonTypeAsync(PokemonTypeCreate model)
    {
        PokemonTypeEntity entity = new()
        {
            PokeType = model.PokeType,
        };

        _dbContext.PokemonTypes.Add(entity);
        var numberOfChanges = await _dbContext.SaveChangesAsync();

        return numberOfChanges == 1;
    }

    public async Task<bool> DeletePokemonTypeAsync(int id)
    {
        var entity = await _dbContext.PokemonTypes.FindAsync(id);
        if(entity is null)
            return false;

        _dbContext.PokemonTypes.Remove(entity);

        return await _dbContext.SaveChangesAsync() == 1;
    }

    public async Task<List<PokemonTypeList>> GetAllPokemonTypesAsync()
    {
        var pokemonTypeQuery = _dbContext.PokemonTypes
            .Select(entity => new PokemonTypeList
            {
                Id = entity.Id,
                PokeType = entity.PokeType,
            });
        
        return await pokemonTypeQuery.ToListAsync();
    }

    public async Task<PokemonTypeDetail?> GetPokemonTypeByIdAsync(int id)
    {
        var entity = await _dbContext.PokemonTypes.FindAsync(id);
        if(entity is null)
            return null;

        return new PokemonTypeDetail
        {
            Id = entity.Id,
            PokeType = entity.PokeType,
        };
    }

    public async Task<bool> UpdatePokemonTypeAsync(PokemonTypeEdit request)
    {
        var entity = await _dbContext.PokemonTypes.FindAsync(request.Id);
        if(entity is null)
            return false;

        entity.PokeType = request.PokeType;

        return await _dbContext.SaveChangesAsync() == 1;
    }

    public void SetUserId(string userId) => _userId = userId;
}
