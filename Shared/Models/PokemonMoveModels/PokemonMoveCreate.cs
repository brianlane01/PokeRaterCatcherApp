using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PokemonCatcherGame.Shared.Models.PokemonMoveModels;

public class PokemonMoveCreate
{
    public int PokeApiMoveId { get; set; }
    public int Accuracy { get; set; }

    public string MoveName { get; set; } = string.Empty;

    [Required]
    [Range(0, int.MaxValue, ErrorMessage = "Power Must be Greater than or equal to zero.")]
    public int MovePower { get; set; }

    [Required]
    [Range(1, int.MaxValue, ErrorMessage = "PP Must be Greater than or equal to one.")]
    public int MoveBasePP { get; set; }

    public string MoveType { get; set; } = string.Empty;

    [Required, MinLength(3), MaxLength(200)]
    [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
    public string MoveDescription { get; set; } = string.Empty;

    [Required]
    public bool MoveRestoresHealth { get; set; }

    // [Range(1, 300)]
    public int HealthRestorationAmount { get; set; }

    [Required]
    public bool MoveAppliesAStatusCondition { get; set; }

    public int StatusConditionId { get; set; }


}
