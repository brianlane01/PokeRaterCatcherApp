using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokemonCatcherGame.Shared.Models.PokemonModels;

public class PokemonDetail
{
    public int Id { get; set; }
    public int PokedexNumber { get; set; }
    public string Name { get; set; } = string.Empty;
    public int Weight { get; set; }
    public int Height { get; set; }
    public int Health { get; set; }
    public int BaseExperience { get; set; }
    public int PokeTypeIdOne { get; set; }
    public int? PokeTypeIdTwo { get; set; }
    public int MoveOneId { get; set; }
    public int MoveTwoId { get; set; }
    public int MoveThreeId { get; set; }
    public int? MoveFourId { get; set; }

    //* These are the names and descriptions of the abilities and teachable moves
    //* that the pokemon has. They are not stored in the Pokemon Table, but are
    //* instead stored in the PokemonAbility and PokemonMove tables.
    public List<string>? AbilityName { get; set; }
    public List<string>? AbilityDescription { get; set; }
    public List<string>? TeachableMoveName { get; set; }
    public List<string>? TeachableMoveDescription { get; set; }
}
