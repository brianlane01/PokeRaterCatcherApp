using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokemonCatcherGame.Shared.Models.StatusConditionModels;

public class StatusConditionEdit
{
    public int Id { get; set; }

    [Required, MinLength(4, ErrorMessage = "{0} must be at least {4} characters long."), MaxLength(55)]
    public string StatusConditionName { get; set; } = string.Empty;

    [Required, MinLength(4, ErrorMessage = "{0} must be at least {4} characters long."), MaxLength(250)]
    public string StatusConditionDescription { get; set; } = string.Empty;

    [Required]
    public bool ConditionDoesDamage { get; set; }
    public double DamageAmount { get; set; }
    public string DamageFrequency { get; set; } = string.Empty;

    [Required]
    public bool ParalysisEffect { get; set; }

    [Required]
    public bool BurnEffect { get; set; }

    [Required]
    public bool FreezeEffect { get; set; }

    [Required]
    public bool SleepEffect { get; set; }

    [Required]
    public bool PoisonEffect { get; set; }

    [Required]
    public string ConditionDuration { get; set; } = string.Empty;
}
