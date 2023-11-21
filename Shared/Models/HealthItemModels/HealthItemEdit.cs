using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PokemonCatcherGame.Shared.Models.HealthItemModels;

public class HealthItemEdit
{
    public int Id { get; set; }

    [Required, MinLength(4), MaxLength(50)]
    public string HealthItemName { get; set; } = string.Empty;

    [Required, MinLength(4), MaxLength(500)]
    public string HealthItemDescription { get; set; } = string.Empty;
    
    [Required, Range(1, 400)]
    public double AmountOfHealthRestored { get; set; }
}
