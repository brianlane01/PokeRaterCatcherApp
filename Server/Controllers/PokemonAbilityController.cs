using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PokemonCatcherGame.Shared.Models.PokemonAbilityModels;
using Server.Services.PokemonAbilityServices;

namespace Server.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PokemonAbilityController : ControllerBase
{
    private readonly IPokemonAbilityService _pokemonAbilityService;

    public PokemonAbilityController(IPokemonAbilityService pokemonAbilityService)
    {
        _pokemonAbilityService = pokemonAbilityService;
    }

    private string? GetUserId()
    {
        string userIdClaim = User.Claims.First(i => i.Type == ClaimTypes.NameIdentifier).Value;

        if (userIdClaim == null)
            return null;

        return userIdClaim;
    }

    private bool SetUserIdInService()
    {
        var userId = GetUserId();
        if (userId == null)
            return false;

        _pokemonAbilityService.SetUserId(userId);
        return true;
    }

    [HttpGet]
    public async Task<List<PokemonAbilityList>> Index(int page = 1, int pageSize = 10)
    {
        if (!SetUserIdInService())
            return new List<PokemonAbilityList>();

        var abilities = await _pokemonAbilityService.GetAllPokemonAbilitiesAsync(page, pageSize);
            
        return abilities.ToList();
    }

    [HttpGet("ForPokemonCreate")]
    public async Task<List<PokemonAbilityList>> GetPokemonForPlayerStart()
    {

        var pokemon = await _pokemonAbilityService.GetAllPokemonAbilitiesForPokemomCreationAsync();

        return pokemon.ToList();
    }

    [HttpPost]
    public async Task<IActionResult> Create(PokemonAbilityCreate model)
    {
        if (model == null)
            return BadRequest();

        if (!SetUserIdInService())
            return Unauthorized();

        bool wasSuccessful = await _pokemonAbilityService.CreatePokemonAbilityAsync(model);

        if (wasSuccessful)
            return Ok();

        else
            return UnprocessableEntity();
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, PokemonAbilityEdit model)
    {
        if (model == null)
            return BadRequest();

        if (!SetUserIdInService())
            return Unauthorized();

        if (id != model.Id)
            return BadRequest();

        bool wasSuccessful = await _pokemonAbilityService.UpdatePokemonAbilityAsync(model);

        if (wasSuccessful)
            return Ok();

        else
            return UnprocessableEntity();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        if (!SetUserIdInService())
            return Unauthorized();

        bool wasSuccessful = await _pokemonAbilityService.DeletePokemonAbilityAsync(id);

        if (wasSuccessful)
            return Ok();

        else
            return UnprocessableEntity();
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> PokemonAbility(int id)
    {
        if (!SetUserIdInService())
            return Unauthorized();

        var pokeAbility = await _pokemonAbilityService.GetPokemonAbilityByIdAsync(id);

        if (pokeAbility == null)
            return NotFound();

        return Ok(pokeAbility);
    }
}
