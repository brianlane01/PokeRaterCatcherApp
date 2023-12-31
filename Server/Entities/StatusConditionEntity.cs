using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Entities;

public class StatusConditionEntity
{
    [Key]
    public int Id { get; set; }

    [Required, MinLength(4), MaxLength(55)]
    public string StatusConditionName { get; set; } = string.Empty;

    [Required, MinLength(4), MaxLength(250)]
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
    public bool ConfusionEffect { get; set; }

    [Required]
    public string ConditionDuration { get; set; } = string.Empty;
}
