using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokemonCatcherGame.Shared.Models.HealthItemModels;

public class HealthItemDetail
{
    public int Id { get; set; }

    public string HealthItemName { get; set; } = string.Empty;

    public string HealthItemDescription { get; set; } = string.Empty;

    public double AmountOfHealthRestored { get; set; }
}
