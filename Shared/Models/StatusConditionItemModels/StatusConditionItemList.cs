using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PokemonCatcherGame.Shared.Models.StatusConditionItemModels;

public class StatusConditionItemList
{
    public int Id { get; set; }

    [Required, MinLength(4), MaxLength(65)]
    public string StatusConditionItemName { get; set; } = string.Empty;

    [Required, MinLength(4), MaxLength(800)]
    public string StatusConditionItemDescription { get; set; } = string.Empty;
}
