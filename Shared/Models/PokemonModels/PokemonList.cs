using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokemonCatcherGame.Shared.Models.PokemonModels;

public class PokemonList
{
    public int Id { get; set; }
    public int PokedexNumber { get; set; }
    public string Name { get; set; } = string.Empty;
    public string PokeNickName { get; set; } = string.Empty;

    //* These are the names and descriptions of the Types that the pokemon has.
    //* They are not stored in the Pokemon Table, but are instead stored in the PokemonType table.
    public string PokeTypeNameOne { get; set; } = string.Empty;
    public string? PokeTypeNameTwo { get; set; } = string.Empty;
}
