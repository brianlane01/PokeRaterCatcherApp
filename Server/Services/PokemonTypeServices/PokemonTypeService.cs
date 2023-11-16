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

    public void SetUserId(string userId) => _userId = userId;
}
