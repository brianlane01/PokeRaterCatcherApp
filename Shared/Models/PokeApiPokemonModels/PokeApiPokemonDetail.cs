using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace PokemonCatcherGame.Shared.Models.PokeApiPokemonModels;

public class PokeApiPokemonDetail
{
    [JsonPropertyName("id")]
    public int PokedexNumber { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    [JsonPropertyName("weight")]
    public int Weight { get; set; }

    [JsonPropertyName("height")]
    public int Height { get; set; }

    [JsonPropertyName("base_experience")]
    [JsonProperty("base_experience")]
    public int BaseExperience { get; set; }

    [JsonPropertyName("types")]
    public List<string>? Type { get; set; }
}
