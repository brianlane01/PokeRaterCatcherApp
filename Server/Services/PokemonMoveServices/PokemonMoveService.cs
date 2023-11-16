using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PokemonCatcherGame.Server.Data;
using PokemonCatcherGame.Server.Entities;
using PokemonCatcherGame.Shared.Models.PokemonMoveModels;
using Server.Entities;
using Shared.Models.PokemonMoveModels;

namespace PokemonCatcherGame.Server.Services.PokemonMoveServices;

public class PokemonMoveService : IPokemonMoveService
{
    private readonly ApplicationDbContext _dbContext;
    private string? _userId;

    public PokemonMoveService(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task<bool> CreatePokemonMoveAsync(PokemonMoveCreate model)
    {
        PokemonMoveEntity entity = new()
        {
            PokeApiMoveId = model.PokeApiMoveId,
            Accuracy = model.Accuracy,
            MoveName = model.MoveName,
            MovePower = model.MovePower,
            MoveBasePP = model.MoveBasePP,
            MoveType = model.MoveType,
            MoveDescription = model.MoveDescription,
            MoveRestoresHealth = model.MoveRestoresHealth,
            HealthRestorationAmount = model.HealthRestorationAmount,
            MoveAppliesAStatusCondition = model.MoveAppliesAStatusCondition,
            StatusConditionId = model.StatusConditionId,
        };

        _dbContext.PokemonMoves.Add(entity);
        var numberOfChanges = await _dbContext.SaveChangesAsync();

        return numberOfChanges == 1;
    }

    public async Task<bool> DeletePokemonMoveAsync(int id)
    {
        var entity = await _dbContext.PokemonMoves.FindAsync(id);
        if(entity is null)
            return false;

        _dbContext.PokemonMoves.Remove(entity);

        return await _dbContext.SaveChangesAsync() == 1;
    }

    public async Task<List<PokemonMoveListItem>> GetAllPokemonMovesAsync()
    {
        var moveQuery = _dbContext.PokemonMoves
            .Select(n => 
                new PokemonMoveListItem
                {
                    Id = n.Id,
                    MoveName = n.MoveName,
                    MoveDescription = n.MoveDescription,
                });
        
        return await moveQuery.ToListAsync();
    }

    public async Task<PokemonMoveDetailDb?> GetPokemonMoveByIdAsync(int id)
    {
        PokemonMoveEntity? entity = await _dbContext.PokemonMoves
            .Include(nameof(StatusConditionEntity))
            .FirstOrDefaultAsync(e => e.Id == id);
        
        return entity is null ? null : new PokemonMoveDetailDb
        {
            Id = entity.Id,
            PokeApiMoveId = entity.PokeApiMoveId,
            MoveName = entity.MoveName,
            MoveDescription = entity.MoveDescription,
            Accuracy = entity.Accuracy,
            MoveBasePP = entity.MoveBasePP,
            MovePower = entity.MovePower,
            MoveType = entity.MoveType,
            MoveRestoresHealth = entity.MoveRestoresHealth,
            HealthRestorationAmount = entity.HealthRestorationAmount,
            MoveAppliesAStatusCondition = entity.MoveAppliesAStatusCondition,
            StatusConditionId = entity.StatusConditionId,
            StatusConditionName = entity.StatusCondition!.StatusConditionName,
            StatusConditionDescription = entity.StatusCondition.StatusConditionDescription,
        };
    }

    public async Task<bool> UpdatePokemonMoveAsync(PokemonMoveEdit request)
    {
        if (request == null)
            return false;
        
        var entity = await _dbContext.PokemonMoves.FindAsync(request.Id);

        if(entity is null)
            return false;

        entity.Id = request.Id;
        entity.MoveName = request.MoveName;
        entity.MoveDescription = request.MoveDescription;
        entity.Accuracy = request.Accuracy;
        entity.MoveBasePP = request.MoveBasePP;
        entity.MovePower = request.MovePower;
        entity.MoveType = request.MoveType;
        entity.MoveRestoresHealth = request.MoveRestoresHealth;
        entity.HealthRestorationAmount = request.HealthRestorationAmount;
        entity.MoveAppliesAStatusCondition = request.MoveAppliesAStatusCondition;
        entity.StatusConditionId = request.StatusConditionId;
        
        return await _dbContext.SaveChangesAsync() == 1;
    }

    public void SetUserId(string userId) => _userId = userId;
}
