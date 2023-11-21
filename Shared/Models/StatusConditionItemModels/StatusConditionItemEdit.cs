using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PokemonCatcherGame.Shared.Models.StatusConditionItemModels;

public class StatusConditionItemEdit
{
    public int Id { get; set; }

    [Required, MinLength(4), MaxLength(65)]
    public string StatusConditionItemName { get; set; } = string.Empty;

    [Required, MinLength(4), MaxLength(800)]
    public string StatusConditionItemDescription { get; set; } = string.Empty;

    [Required]
    public bool RemovesSleep { get; set; }

    [Required]
    public bool RemovesParalysis { get; set; }

    [Required]
    public bool RemovesFreeze { get; set; }

    [Required]
    public bool RemovesPoison { get; set; }

    [Required]
    public bool RemovesBurn { get; set; }

    [Required]
    public bool RemovesConfusion { get; set; }
}
