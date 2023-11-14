using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Server.Entities;

public class PokemonEntity
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    [JsonPropertyName("weight")]
    public int Weight { get; set; }

    [JsonPropertyName("base_experience")]
    public long BaseExperience { get; set; }

    public virtual ICollection<PokemonAbilityEntity> AbilitiesList { get; set; }
    public List<PokemonTypeEntity> PokeTypes { get; set; } = new List<PokemonTypeEntity>();

    public PokemonEntity ()
    {
        AbilitiesList = new HashSet<PokemonAbilityEntity>();
    }

}
