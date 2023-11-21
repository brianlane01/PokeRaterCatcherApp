using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokemonCatcherGame.Shared.Models.RejuvenationItemModels;

public class RejuvenationItemList
{
    public int Id {get; set;}

    public string RejuvenationItemName { get; set; } = string.Empty;

    public string RejuvenationItemDescription { get; set; } = string.Empty;
}
