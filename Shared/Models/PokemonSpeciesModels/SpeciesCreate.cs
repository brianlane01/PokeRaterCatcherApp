using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PokemonCatcherGame.Shared.Models.PokemonSpeciesModels;

public class SpeciesCreate
{
    
    [JsonProperty("base_happiness", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("base_happiness")]
    public int BaseHappiness { get; set; }

    [JsonProperty("capture_rate", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("capture_rate")]
    public int CaptureRate { get; set; }

    [JsonProperty("color", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("color")]
    public Color? Colors { get; set; }

    [JsonProperty("egg_groups", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("egg_groups")]
    public List<EggGroup> EggGroups { get; } = new List<EggGroup>();

    [JsonProperty("evolution_chain", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("evolution_chain")]
    public EvolutionChain? EvolutionChains { get; set; }

    [JsonProperty("evolves_from_species", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("evolves_from_species")]
    public EvolvesFromSpecies? EvolveFromSpecies { get; set; }

    [JsonProperty("flavor_text_entries", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("flavor_text_entries")]
    public List<FlavorTextEntry> FlavorTextEntries { get; } = new List<FlavorTextEntry>();

    [JsonProperty("form_descriptions", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("form_descriptions")]
    public List<FormDescription> FormDescriptions { get; } = new List<FormDescription>();

    [JsonProperty("forms_switchable", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("forms_switchable")]
    public bool FormsSwitchable { get; set; }

    [JsonProperty("gender_rate", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("gender_rate")]
    public int GenderRate { get; set; }

    [JsonProperty("genera", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("genera")]
    public List<Genera> Generas { get; } = new List<Genera>();

    [JsonProperty("generation", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("generation")]
    public Generation? Generations { get; set; }

    [JsonProperty("growth_rate", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("growth_rate")]
    public GrowthRate? GrowthRates { get; set; }

    [JsonProperty("habitat", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("habitat")]
    public object? Habitat { get; set; }

    [JsonProperty("has_gender_differences", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("has_gender_differences")]
    public bool HasGenderDifferences { get; set; }

    [JsonProperty("hatch_counter", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("hatch_counter")]
    public int HatchCounter { get; set; }

    [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonProperty("is_baby", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("is_baby")]
    public bool IsBaby { get; set; }

    [JsonProperty("is_legendary", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("is_legendary")]
    public bool IsLegendary { get; set; }

    [JsonProperty("is_mythical", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("is_mythical")]
    public bool IsMythical { get; set; }

    [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("name")]
    public string? NameOf { get; set; }

    [JsonProperty("names", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("names")]
    public List<Name> Names { get; } = new List<Name>();

    [JsonProperty("order", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("order")]
    public int Order { get; set; }

    [JsonProperty("pal_park_encounters", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("pal_park_encounters")]
    public List<object> PalParkEncounters { get; } = new List<object>();

    [JsonProperty("pokedex_numbers", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("pokedex_numbers")]
    public List<PokedexNumber> PokedexNumbers { get; } = new List<PokedexNumber>();

    [JsonProperty("shape", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("shape")]
    public Shape? Shapes { get; set; }

    [JsonProperty("varieties", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("varieties")]
    public List<Variety> Varieties { get; } = new List<Variety>();



    public class Color
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("url")]
        public string? Url { get; set; }
    }

    public class EggGroup
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("url")]
        public string? Url { get; set; }
    }

    public class EvolutionChain
    {
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("url")]
        public string? Url { get; set; }
    }

    public class EvolvesFromSpecies
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("url")]
        public string? Url { get; set; }
    }

    public class FlavorTextEntry
    {
        [JsonProperty("flavor_text", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("flavor_text")]
        public string? FlavorText { get; set; }

        [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("language")]
        public Language? Language { get; set; }

        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("version")]
        public Version? Version { get; set; }
    }

    public class FormDescription
    {
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("language")]
        public Language? Language { get; set; }
    }

    public class Genera
    {
        [JsonProperty("genus", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("genus")]
        public string? Genus { get; set; }

        [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("language")]
        public Language? Language { get; set; }
    }

    public class Generation
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("url")]
        public string? Url { get; set; }
    }

    public class GrowthRate
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("url")]
        public string? Url { get; set; }
    }

    public class Language
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("url")]
        public string? Url { get; set; }
    }

    public class Name
    {
        [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("language")]
        public Language? Language { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("name")]
        public string? PokeName { get; set; }
    }

    public class Pokedex
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("url")]
        public string? Url { get; set; }
    }

    public class PokedexNumber
    {
        [JsonProperty("entry_number", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("entry_number")]
        public int EntryNumber { get; set; }

        [JsonProperty("pokedex", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("pokedex")]
        public Pokedex? Pokedex { get; set; }
    }

    public class Pokemon
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("url")]
        public string? Url { get; set; }
    }

    public class Shape
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("url")]
        public string? Url { get; set; }
    }

    public class Variety
    {
        [JsonProperty("is_default", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("is_default")]
        public bool IsDefault { get; set; }

        [JsonProperty("pokemon", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("pokemon")]
        public Pokemon? Pokemon { get; set; }
    }

    public class Version
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("url")]
        public string? Url { get; set; }
    }
}

