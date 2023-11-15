using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokemonCatcherGame.Shared.Models.StatusConditionModels;

public class StatusConditionDetail
{
    public int Id { get; set; }
    public string StatusConditionName { get; set; } = string.Empty;
    public string StatusConditionDescription { get; set; } = string.Empty;
    public bool ConditionDoesDamage { get; set; }
    public double DamageAmount { get; set; }
    public string DamageFrequency { get; set; } = string.Empty;
    public bool ParalysisEffect { get; set; }
    public bool BurnEffect { get; set; }
    public bool FreezeEffect { get; set; }
    public bool SleepEffect { get; set; }
    public string ConditionDuration { get; set; } = string.Empty;
}
