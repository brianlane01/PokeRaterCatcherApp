using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PokemonCatcherGame.Server.Data;
using PokemonCatcherGame.Shared.Models.TechnicalMachineMovesModels;
using Server.Entities;

namespace Server.Services.TechnicalMahineMoveServices;

public class TMService : ITMService
{
    private readonly ApplicationDbContext _dbContext; 

    private string? _userId;

    public TMService(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<bool> CreateTMAsync(TMCreate model)
    {
        TechnicalMachineMoveEntity entity = new()
        {
            TMNumber = model.TMNumber,
            MoveName = model.MoveName,
            MoveDescription = model.MoveDescription,
            MoveType = model.MoveType,
            MovePower = model.MovePower,
            MoveBasePP = model.MoveBasePP,
            MoveAccuracy = model.MoveAccuracy,
            MoveRestoresHealth = model.MoveRestoresHealth,
            HealthRestorationAmount = model.HealthRestorationAmount,
            MoveAppliesAStatusCondition = model.MoveAppliesAStatusCondition,
            StatusConditionId = model.StatusConditionId,
            PsychicCanLearn = model.PsychicCanLearn,
            FireCanLearn = model.FireCanLearn,
            GhostCanLearn = model.GhostCanLearn,
            GrassCanLearn = model.GrassCanLearn,
            ElectricCanLearn = model.ElectricCanLearn,
            FightingCanLearn = model.FightingCanLearn,
            FairyCanLearn = model.FairyCanLearn,
            DragonCanLearn = model.DragonCanLearn,
            PoisonCanLearn = model.PoisonCanLearn,
            BugCanLearn = model.BugCanLearn,
            WaterCanLearn = model.WaterCanLearn,
            NormalCanLearn = model.NormalCanLearn,
            FlyingCanLearn = model.FlyingCanLearn,
            GroundCanLearn = model.GroundCanLearn,
            RockCanLearn = model.RockCanLearn,
            DarkCanLearn = model.DarkCanLearn,
            SteelCanLearn = model.SteelCanLearn,
            IceCanLearn = model.IceCanLearn,
        };

        _dbContext.TMs.Add(entity);

        var numberOfChanges = await _dbContext.SaveChangesAsync();

        return numberOfChanges == 1;
    }

    public async Task<List<TMIndex>> GetAllTMsAsync(int page, int pageSize)
    {
        var query = _dbContext.TMs.AsQueryable();

        var entities = await query
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();

        return entities.Select(i => new TMIndex
        {
            Id = i.Id,
            TMNumber = i.TMNumber,
            MoveName = i.MoveName,
            MoveDescription = i.MoveDescription,
            
        }).ToList();
    }

    public async Task<List<TMIndex>> GetAllTMsForInventoryAsync()
    {
        var query = _dbContext.TMs.AsQueryable();

        var entities = await query.ToListAsync();

        return entities.Select(i => new TMIndex
        {
            Id = i.Id,
            TMNumber = i.TMNumber,
            MoveName = i.MoveName,
            MoveDescription = i.MoveDescription,
            
        }).ToList();
    }

    public async Task<TMDetail?> GetTMByIdAsync(int id)
    {
        var entity = await _dbContext.TMs
            .Include("StatusCondition")
            .FirstOrDefaultAsync(e => e.Id == id);

        if (entity is null)
            return null;

        return new TMDetail
        {
            Id = entity.Id,
            TMNumber = entity.TMNumber,
            MoveName = entity.MoveName,
            MoveDescription = entity.MoveDescription,
            MoveType = entity.MoveType,
            MovePower = entity.MovePower,
            MoveBasePP = entity.MoveBasePP,
            MoveAccuracy = entity.MoveAccuracy,
            MoveRestoresHealth = entity.MoveRestoresHealth,
            HealthRestorationAmount = entity.HealthRestorationAmount,
            MoveAppliesAStatusCondition = entity.MoveAppliesAStatusCondition,
            StatusConditionId = entity.StatusConditionId,
            StatusConditionName = entity.StatusCondition!.StatusConditionName,
            StatusConditionDescription = entity.StatusCondition.StatusConditionDescription,
            PsychicCanLearn = entity.PsychicCanLearn,
            FireCanLearn = entity.FireCanLearn,
            GhostCanLearn = entity.GhostCanLearn,
            GrassCanLearn = entity.GrassCanLearn,
            ElectricCanLearn = entity.ElectricCanLearn,
            FightingCanLearn = entity.FightingCanLearn,
            FairyCanLearn = entity.FairyCanLearn,
            DragonCanLearn = entity.DragonCanLearn,
            PoisonCanLearn = entity.PoisonCanLearn,
            BugCanLearn = entity.BugCanLearn,
            WaterCanLearn = entity.WaterCanLearn,
            NormalCanLearn = entity.NormalCanLearn,
            FlyingCanLearn = entity.FlyingCanLearn,
            GroundCanLearn = entity.GroundCanLearn,
            RockCanLearn = entity.RockCanLearn,
            DarkCanLearn = entity.DarkCanLearn,
            SteelCanLearn = entity.SteelCanLearn,
            IceCanLearn = entity.IceCanLearn,
        };
    }

    public async Task<bool> UpdateTMAsync(TMEdit request)
    {
        if (request is null)
            return false;

        var entity = await _dbContext.TMs.FindAsync(request.Id);

        if (entity is null)
            return false;

        entity.Id = request.Id;
        entity.TMNumber = request.TMNumber;
        entity.MoveName = request.MoveName;
        entity.MoveDescription = request.MoveDescription;
        entity.MoveType = request.MoveType;
        entity.MovePower = request.MovePower;
        entity.MoveBasePP = request.MoveBasePP;
        entity.MoveAccuracy = request.MoveAccuracy;
        entity.MoveRestoresHealth = request.MoveRestoresHealth;
        entity.HealthRestorationAmount = request.HealthRestorationAmount;
        entity.MoveAppliesAStatusCondition = request.MoveAppliesAStatusCondition;
        entity.StatusConditionId = request.StatusConditionId;
        entity.PsychicCanLearn = request.PsychicCanLearn;
        entity.FireCanLearn = request.FireCanLearn;
        entity.GhostCanLearn = request.GhostCanLearn;
        entity.GrassCanLearn = request.GrassCanLearn;
        entity.ElectricCanLearn = request.ElectricCanLearn;
        entity.FightingCanLearn = request.FightingCanLearn;
        entity.FairyCanLearn = request.FairyCanLearn;
        entity.DragonCanLearn = request.DragonCanLearn;
        entity.PoisonCanLearn = request.PoisonCanLearn;
        entity.BugCanLearn = request.BugCanLearn;
        entity.WaterCanLearn = request.WaterCanLearn;
        entity.NormalCanLearn = request.NormalCanLearn;
        entity.FlyingCanLearn = request.FlyingCanLearn;
        entity.GroundCanLearn = request.GroundCanLearn;
        entity.RockCanLearn = request.RockCanLearn;
        entity.DarkCanLearn = request.DarkCanLearn;
        entity.SteelCanLearn = request.SteelCanLearn;
        entity.IceCanLearn = request.IceCanLearn;

        var numberOfChanges = await _dbContext.SaveChangesAsync();

        return numberOfChanges == 1;
    }

    public async Task<bool> DeleteTMAsync(int id)
    {
        var entity = await _dbContext.TMs.FindAsync(id);
        
        if(entity is null)
            return false;

        _dbContext.TMs.Remove(entity);

        return await _dbContext.SaveChangesAsync() == 1;
    }

    public void SetUserId(string userId) => _userId = userId;
    
}
