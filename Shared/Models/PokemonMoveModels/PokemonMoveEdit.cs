using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PokemonCatcherGame.Shared.Models.PokemonMoveModels;

public class PokemonMoveEdit
{
    public int Id { get; set; }

    [Required]
    public string MoveName { get; set; } = string.Empty;

    [Required, MinLength(3), MaxLength(200)]
    public string MoveDescription { get; set; } = string.Empty;

    public int? Accuracy { get; set; }

    [Required]
    [Range(1, int.MaxValue, ErrorMessage = "PP Must be Greater than or equal to one.")]
    public int MoveBasePP { get; set; }

    [Range(0, int.MaxValue, ErrorMessage = "Power Must be Greater than or equal to zero.")]
    public int? MovePower { get; set; }

    [Required, MinLength(3), MaxLength(55)]
    public string MoveType { get; set; } = string.Empty;

    [Required]
    public bool MoveRestoresHealth { get; set; }

    [Range(0, 300)]
    public int HealthRestorationAmount { get; set; }

    [Required]
    public bool MoveAppliesAStatusCondition { get; set; }
    
    public int? StatusConditionId { get; set; }

}
