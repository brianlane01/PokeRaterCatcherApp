using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Entities;

public class TrainerOpponentEntity
{
    [Key]
    public int Id { get; set; }

    [Required, MinLength(4), MaxLength(100)]
    public string OpponentName { get; set; } = string.Empty;

    // public ICollection<PokemonEntity> UsablePokemon { get; set; }

    // public TrainerOpponentEntity()
    // {
    //     UsablePokemon = new HashSet<PokemonEntity>();
    // }
}
