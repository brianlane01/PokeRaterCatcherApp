using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokemonCatcherGame.Shared.Models.PokemonModels;

public class PokemonCreate
{
    [Required]
    public int PokedexNumber { get; set; }

    [Required]
    public string Name { get; set; } = string.Empty;

    [Required]
    public int Weight { get; set; }

    [Required]
    public int Height { get; set; }

    [Required, Range(1, 400)]
    public int Health { get; set; }

    [Required]
    public int BaseExperience { get; set; }

    [Required]
    public int PokeTypeIdOne { get; set; }

    public int? PokeTypeIdTwo { get; set; }

    [Required]
    public int MoveOneId { get; set; }

    [Required]
    public int MoveTwoId { get; set; }

    [Required]
    public int MoveThreeId { get; set; }

    public int? MoveFourId { get; set; }

    public List<int>? AbilitiesList { get; set; }
    public List<int>? TeachableMoves { get; set; }
}
