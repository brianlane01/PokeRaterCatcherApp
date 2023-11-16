using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokemonCatcherGame.Shared.Models.StatusConditionModels;

public class StatusConditionList
{
    public int Id { get; set; }
    public string StatusConditionName { get; set; } = string.Empty;
    public string StatusConditionDescription { get; set; } = string.Empty;
}
