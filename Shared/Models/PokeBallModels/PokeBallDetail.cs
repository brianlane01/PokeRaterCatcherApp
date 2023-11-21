using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokemonCatcherGame.Shared.Models.PokeBallModels;

public class PokeBallDetail
{
    public int Id { get; set; }

    public string NameOfBall { get; set; } = string.Empty;

    public string DescriptionOfPokeBall { get; set; } = string.Empty;

    public double CatchRate { get; set; }
}
