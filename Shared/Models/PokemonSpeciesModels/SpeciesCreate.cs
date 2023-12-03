using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PokemonCatcherGame.Shared.Models.PokemonSpeciesModels;

public class SpeciesCreate
{
    [JsonProperty("flavor_text_entries", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("flavor_text_entries")]
    public List<FlavorTextEntry> FlavorTextEntries { get; } = new List<FlavorTextEntry>();

    public class FlavorTextEntry
    {
        [JsonProperty("flavor_text", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("flavor_text")]
        public string? FlavorText { get; set; }

    }


}
