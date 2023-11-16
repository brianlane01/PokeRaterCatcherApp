using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shared.Models.PokemonMoveModels;

//* This is the detail coming back from the Database for this project
public class PokemonMoveDetailDb
{
    public int Id { get; set; }
    public int PokeApiMoveId { get; set; }
    public string MoveName { get; set; } = string.Empty;
    public string MoveDescription { get; set; } = string.Empty;
    public int? Accuracy { get; set; }
    public int MoveBasePP { get; set; }
    public int? MovePower { get; set; }
    public string MoveType { get; set; } = string.Empty;
    public bool MoveRestoresHealth { get; set; }
    public int HealthRestorationAmount { get; set; }
    public bool MoveAppliesAStatusCondition { get; set; }
    public int? StatusConditionId { get; set; }
    public string StatusConditionName { get; set; } = string.Empty;
    public string StatusConditionDescription { get; set; } = string.Empty;
}
