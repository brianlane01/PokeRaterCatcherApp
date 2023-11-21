using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PokemonCatcherGame.Shared.Models.PokeBallModels;

public class PokeBallCreate
{
    [Required, MinLength(4), MaxLength(55)]
    public string NameOfBall { get; set; } = string.Empty;

    [Required, MinLength(4), MaxLength(1000)]
    public string DescriptionOfPokeBall { get; set; } = string.Empty;

    [Required]
    public double CatchRate { get; set; }
}
