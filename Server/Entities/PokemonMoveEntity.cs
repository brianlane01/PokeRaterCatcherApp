using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Entities;

public class PokemonMoveEntity
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string MoveName { get; set; } = string.Empty;

    [Required, MinLength(3), MaxLength(200)]
    [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
    public string MoveDescription { get; set; } = string.Empty;

    [Required]
    [Range(1, int.MaxValue, ErrorMessage = "PP Must be Greater than or equal to one.")]
    public int MoveBasePP { get; set; }

    [Required]
    [Range(0, int.MaxValue, ErrorMessage = "Power Must be Greater than or equal to zero.")]
    public int MovePower { get; set; }

    [Required, MinLength(3), MaxLength(55)]
    public string MoveType { get; set; } = string.Empty;

    [Required]
    public bool MoveRestoresHealth { get; set; }

    [Range(1, 300)]
    public int HealthRestorationAmount { get; set; }

    [Required]
    public bool MoveAppliesAStatusCondition { get; set; }

    [ForeignKey(nameof(StatusCondition))]
    public int StatusConditionId { get; set; }
    public StatusConditionEntity? StatusCondition { get; set; }
}
