using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PokemonCatcherGame.Server.Services.PokemonTypeServices;
using PokemonCatcherGame.Shared.Models.PokemonTypeModels;

namespace Server.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PokemonTypeController : ControllerBase
{
    private readonly IPokemonTypeService _pokemonTypeService;

    public PokemonTypeController(IPokemonTypeService pokemonTypeService)
    {
        _pokemonTypeService = pokemonTypeService;
    }

    public async Task<IActionResult> Index()
    {
        var pokeTypes = await _pokemonTypeService.GetAllPokemonTypesAsync();
        return Ok(pokeTypes);
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

        _pokemonTypeService.SetUserId(userId);
        return true;
    }

    [HttpPost]
    public async Task<IActionResult> Create(PokemonTypeCreate model)
    {
        if (model == null)
            return BadRequest();

        if (!SetUserIdInService())
            return Unauthorized();

        bool wasSuccessful = await _pokemonTypeService.CreatePokemonTypeAsync(model);

        if (wasSuccessful)
            return Ok();
        else
            return UnprocessableEntity();
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> PokemonType(int id)
    {
        if (!SetUserIdInService())
            return Unauthorized();

        var pokemonType = await _pokemonTypeService.GetPokemonTypeByIdAsync(id);

        if (pokemonType is null)
            return NotFound();

        return Ok(pokemonType);
    }

    [HttpPut("Edit/{id}")]
    public async Task<IActionResult> Edit(PokemonTypeEdit model)
    {
        if (!SetUserIdInService())
            return Unauthorized();

        if (model == null || !ModelState.IsValid)
            return BadRequest();

        bool wasSuccessful = await _pokemonTypeService.UpdatePokemonTypeAsync(model);

        if (wasSuccessful)
            return Ok();
            
        else
            return BadRequest();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        if (!SetUserIdInService())
            return Unauthorized();

        var pokemonType = await _pokemonTypeService.GetPokemonTypeByIdAsync(id);
        
        if (pokemonType is null)
            return NotFound();

        bool wasSuccessful = await _pokemonTypeService.DeletePokemonTypeAsync(id);

        if (wasSuccessful)
            return Ok();
        else
            return BadRequest();
    }
}
