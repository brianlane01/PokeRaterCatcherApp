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

    public string? Description { get; set; }

    [ForeignKey(nameof(PokeTypeOne))]
    public int PokeTypeIdOne { get; set; }
    public virtual PokemonTypeEntity PokeTypeOne { get; set; }

    [ForeignKey(nameof(PokeTypeTwo))]
    public int? PokeTypeIdTwo { get; set; }
    public virtual PokemonTypeEntity? PokeTypeTwo { get; set; }

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

    [ForeignKey(nameof(Ability))]
    public int AbilityId { get; set; }
    public virtual PokemonAbilityEntity Ability { get; set; }

    public virtual ICollection<PlayerEntity> Player { get; set; }
    public virtual ICollection<TrainerOpponentEntity> Opponents { get; set; }

    public PokemonEntity()
    {
        Player = new HashSet<PlayerEntity>();
        Opponents = new HashSet<TrainerOpponentEntity>();

        
    }

}
