using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Server.Entities;

public class PokemonEntity
{
    [Key]
    public int Id { get; set; }

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

    [ForeignKey(nameof(PokeTypeOne))]
    public int PokeTypeIdOne { get; set; }
    public virtual PokemonTypeEntity PokeTypeOne { get; set; }

    [ForeignKey(nameof(PokeTypeTwo))]
    public int? PokeTypeIdTwo { get; set; }
    public virtual PokemonTypeEntity PokeTypeTwo { get; set; }

    [ForeignKey(nameof(MoveOne))]
    public int MoveOneId { get; set; }
    public virtual PokemonMoveEntity MoveOne { get; set; }

    [ForeignKey(nameof(MoveTwo))]
    public int MoveTwoId { get; set; }
    public virtual PokemonMoveEntity MoveTwo { get; set; }

    [ForeignKey(nameof(MoveThree))]
    public int MoveThreeId { get; set; }
    public virtual PokemonMoveEntity MoveThree { get; set; }

    [ForeignKey(nameof(MoveFour))]
    public int? MoveFourId { get; set; }
    public virtual PokemonMoveEntity MoveFour { get; set; }

    public virtual ICollection<PokemonAbilityEntity> AbilitiesList { get; set; }

    public PokemonEntity()
    {
        PokeTypeOne = new PokemonTypeEntity();
        PokeTypeTwo = new PokemonTypeEntity();
        MoveOne = new PokemonMoveEntity();
        MoveTwo = new PokemonMoveEntity();
        MoveThree = new PokemonMoveEntity();
        MoveFour = new PokemonMoveEntity();
        AbilitiesList = new HashSet<PokemonAbilityEntity>();
    }

}
