using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PokemonCatcherGame.Shared.Models.PokemonModels;

public class PokemonEdit
{
    public int Id { get; set; }

    [Required]
    public string PokeNickName { get; set; } = string.Empty;

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
    
    public int AbilityId { get; set; }
}
