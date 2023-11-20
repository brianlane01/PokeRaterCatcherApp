using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PokemonCatcherGame.Server.Services.PokemonMoveServices;
using PokemonCatcherGame.Shared.Models.PokemonMoveModels;

namespace Server.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PokemonMoveController : ControllerBase
{
    private readonly IPokemonMoveService _pokemonMoveService;

    public PokemonMoveController(IPokemonMoveService pokemonMoveService)
    {
        _pokemonMoveService = pokemonMoveService;
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

        _pokemonMoveService.SetUserId(userId);
        return true;
    }

    [HttpGet]
    public async Task<List<PokemonMoveListItem>> Index(int page = 1, int pageSize = 10)
    {
        if (!SetUserIdInService())
            return new List<PokemonMoveListItem>();

        var moves = await _pokemonMoveService.GetAllPokemonMovesAsync(page, pageSize);
            
        return moves.ToList();
    }

    [HttpPost]
    public async Task<IActionResult> Create(PokemonMoveCreate model)
    {
        if (model == null)
            return BadRequest();

        if (!SetUserIdInService())
            return Unauthorized();

        bool wasSuccessful = await _pokemonMoveService.CreatePokemonMoveAsync(model);
        if (wasSuccessful)
            return Ok();

        else
            return UnprocessableEntity();
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> PokemonMove(int id)
    {
        if(!SetUserIdInService())
            return Unauthorized();

        var pokeMove = await _pokemonMoveService.GetPokemonMoveByIdAsync(id);

        if(pokeMove == null)
            return NotFound();

        return Ok(pokeMove);
    }

    [HttpPut("Edit/{id}")]
    public async Task<IActionResult> Edit(PokemonMoveEdit model)
    {
        if(!SetUserIdInService())
            return Unauthorized();

        if(model == null || !ModelState.IsValid)
            return BadRequest();

        bool wasSuccessful = await _pokemonMoveService.UpdatePokemonMoveAsync(model);

        if(wasSuccessful)
            return Ok();

        return BadRequest();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        if(!SetUserIdInService())
            return Unauthorized();

        var pokeMove = await _pokemonMoveService.GetPokemonMoveByIdAsync(id);

        if(pokeMove == null)
            return NotFound();
        
        bool wasSuccessful = await _pokemonMoveService.DeletePokemonMoveAsync(id);

        if(!wasSuccessful)
            return BadRequest();

        return Ok();
    }
}
