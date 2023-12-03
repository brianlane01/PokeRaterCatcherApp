using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PokemonCatcherGame.Shared.Models.PlayerPokemonModels;

public class PlayerPokeCreate
{
    [Required]
    public int PokedexNumber { get; set; }

    [Required]
    public string Name { get; set; } = string.Empty;

    [Required]
    public string PokeNickName { get; set; } = string.Empty;

    [Required]
    public int Weight { get; set; }

    [Required]
    public int Height { get; set; }

    [Required]
    public int Health { get; set; }

    [Required]
    public int BaseExperience { get; set; }

    [Required]
    public string? Description { get; set; }

    [Required]
    public int PokeTypeIdOne { get; set; }

    [Required]
    public int? PokeTypeIdTwo { get; set; }
    
    [Required]
    public int MoveOneId { get; set; }

    [Required]
    public int MoveTwoId { get; set; }

    [Required]
    public int MoveThreeId { get; set; }

    [Required]
    public int? MoveFourId { get; set; }

    [Required]
    public int AbilityId { get; set; }
}
