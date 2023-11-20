using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokemonCatcherGame.Shared.Models.PokemonModels;

public class PokemonDetail
{
    //* This is the information that is stored in the Pokemon Table
    public int Id { get; set; }
    public int PokedexNumber { get; set; }
    public string Name { get; set; } = string.Empty;
    public string PokeNickName { get; set; } = string.Empty;
    public int Weight { get; set; }
    public int Height { get; set; }
    public int Health { get; set; }
    public int BaseExperience { get; set; }

    //? These are the names and descriptions of the Types that the pokemon has.
    //? They are not stored in the Pokemon Table, but are instead stored in the PokemonType table.
    //? The PokeTypeIdOne is the primary type of the pokemon and the PokeTypeIdTwo is the secondary type of the pokemon.
    //? The PokeTypeIdTwo is nullable because a pokemon may not have a secondary type.
    //? The PokeTypeIdOne and PokeTypeIdTwo are the foriegn keys to the PokemonType table.
    public int PokeTypeIdOne { get; set; }
    public string PokeTypeNameOne { get; set; } = string.Empty;

    public int? PokeTypeIdTwo { get; set; }
    public string? PokeTypeNameTwo { get; set; } = string.Empty;


    //* These are the names and descriptions of the Moves that the pokemon has.
    //* They are not stored in the Pokemon Table, but are instead stored in the PokemonMove table.
    public int MoveOneId { get; set; } //* This is the id of the move and the foriegn key to the PokemonMove table
    public string MoveOneName { get; set; } = string.Empty; //* This is the name of the move
    public string MoveOneDescription { get; set; } = string.Empty; //* This is the description of the move

    public int MoveTwoId { get; set; } //* This is the id of the  second move a pokemon can have and the foriegn key to the PokemonMove table
    public string MoveTwoName { get; set; } = string.Empty; //* This is the name of the second move a pokemon can have
    public string MoveTwoDescription { get; set; } = string.Empty; //* This is the description of the second move a pokemon can have.

    public int MoveThreeId { get; set; } //* This is the id of the third move a pokemon can have and the foriegn key to the PokemonMove table
    public string MoveThreeName { get; set; } = string.Empty; //* This is the name of the third move a pokemon can have
    public string? MoveThreeDescription { get; set; } = string.Empty; //* This is the description of the third move a pokemon can have.

    public int? MoveFourId { get; set; } //* This is the id of the fourth move a pokemon can have and the foriegn key to the PokemonMove table. It is nullable because a pokemon may not have a fourth move.
    public string? MoveFourName { get; set; } = string.Empty; //* This is the name of the fourth move a pokemon can have. It is nullable because a pokemon may not have a fourth move.
    public string? MoveFourDescription { get; set; } = string.Empty; //* This is the description of the fourth move a pokemon can have. It is nullable because a pokemon may not have a fourth move.


    //* These are the names and descriptions of the abilities and teachable moves
    //* that the pokemon has. They are not stored in the Pokemon Table, but are
    //* instead stored in the PokemonAbility and PokemonMove tables.
    public string AbilityName { get; set; } = string.Empty; //* This is the name of the ability that the pokemon has.
    public string AbilityDescription { get; set; } = string.Empty; //* This is the description of the ability that the pokemon has.

}
