using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Entities;

public class PokemonAbilityEntity
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string AbilityName { get; set; } = string.Empty;

    [Required]
    public string AbilityEffect { get; set; } = string.Empty;
    

    
}
