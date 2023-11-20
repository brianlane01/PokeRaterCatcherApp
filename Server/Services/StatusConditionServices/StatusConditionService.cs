using Microsoft.EntityFrameworkCore;
using PokemonCatcherGame.Server.Data;
using PokemonCatcherGame.Shared.Models.StatusConditionModels;
using Server.Entities;

namespace PokemonCatcherGame.Server.Services.StatusConditionServices;

public class StatusConditionService : IStatusConditionService
{
    private readonly ApplicationDbContext _dbContext;
    private string? _userId;

    public StatusConditionService(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task<bool> CreateStatusConditionAsync(StatusConditionCreate model)
    {
        StatusConditionEntity entity = new()
        {
            StatusConditionName = model.StatusConditionName,
            StatusConditionDescription = model.StatusConditionDescription,
            ConditionDoesDamage = model.ConditionDoesDamage,
            DamageAmount = model.DamageAmount,
            DamageFrequency = model.DamageFrequency,
            ParalysisEffect = model.ParalysisEffect,
            BurnEffect = model.BurnEffect,
            FreezeEffect = model.FreezeEffect,
            SleepEffect = model.SleepEffect,
            PoisonEffect = model.PoisonEffect,
            ConfusionEffect = model.ConfusionEffect,
            ConditionDuration = model.ConditionDuration
        };

        _dbContext.StatusConditions.Add(entity);
        var numberOfChanges = await _dbContext.SaveChangesAsync();

        return numberOfChanges == 1;
    }

    public async Task<bool> DeleteStatusConditionAsync(int id)
    {
        var entity = await _dbContext.StatusConditions.FindAsync(id);
        if(entity is null)
            return false;

        _dbContext.StatusConditions.Remove(entity);
        return await _dbContext.SaveChangesAsync() == 1;
    }

    public async Task<List<StatusConditionList>> GetAllStatusConditionsAsync()
    {
        var statusConditionQuery = _dbContext.StatusConditions
            .Select(entity => new StatusConditionList
            {
                Id = entity.Id,
                StatusConditionName = entity.StatusConditionName,
                StatusConditionDescription = entity.StatusConditionDescription,
            });
        
        return await statusConditionQuery.ToListAsync();
    }

    public async Task<StatusConditionDetail?> GetStatusConditionByIdAsync(int id)
    {
        StatusConditionEntity? entity = await _dbContext.StatusConditions
            .FirstOrDefaultAsync(entity => entity.Id == id);
        
        return entity is null ? null : new StatusConditionDetail
        {
            Id = entity.Id,
            StatusConditionName = entity.StatusConditionName,
            StatusConditionDescription = entity.StatusConditionDescription,
            ConditionDoesDamage = entity.ConditionDoesDamage,
            DamageAmount = entity.DamageAmount,
            DamageFrequency = entity.DamageFrequency,
            ParalysisEffect = entity.ParalysisEffect,
            BurnEffect = entity.BurnEffect,
            FreezeEffect = entity.FreezeEffect,
            SleepEffect = entity.SleepEffect,
            PoisonEffect = entity.PoisonEffect,
            ConfusionEffect = entity.ConfusionEffect,
            ConditionDuration = entity.ConditionDuration,
        };

    }

    public async Task<bool> UpdateStatusConditionAsync(StatusConditionEdit model)
    {
        if (model == null)
            return false;

        var entity = await _dbContext.StatusConditions.FindAsync(model.Id);

        if(entity  == null)
            return false;
        
        entity.Id = model.Id;
        entity.StatusConditionName = model.StatusConditionName;
        entity.StatusConditionDescription = model.StatusConditionDescription;
        entity.ConditionDoesDamage = model.ConditionDoesDamage;
        entity.DamageAmount = model.DamageAmount;
        entity.DamageFrequency = model.DamageFrequency;
        entity.ParalysisEffect = model.ParalysisEffect;
        entity.BurnEffect = model.BurnEffect;
        entity.FreezeEffect = model.FreezeEffect;
        entity.SleepEffect = model.SleepEffect;
        entity.PoisonEffect = model.PoisonEffect;
        entity.ConfusionEffect = model.ConfusionEffect;
        entity.ConditionDuration = model.ConditionDuration;

        return await _dbContext.SaveChangesAsync() == 1;
    }

    public void SetUserId(string userId) => _userId = userId;
}
