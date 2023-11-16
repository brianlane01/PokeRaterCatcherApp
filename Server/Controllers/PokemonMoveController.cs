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
    public async Task<List<PokemonMoveListItem>> Index()
    {
        if (!SetUserIdInService())
            return new List<PokemonMoveListItem>();

        var notes = await _pokemonMoveService.GetAllPokemonMovesAsync();

        return notes.ToList();
    }

    [HttpPost]
        public async Task<IActionResult>  Create(PokemonMoveCreate model)
        {
            if(model == null)
                return BadRequest();

            if(!SetUserIdInService())
                return Unauthorized();

            bool wasSuccessful = await _pokemonMoveService.CreatePokemonMoveAsync(model);

            if(wasSuccessful)
                return Ok ();

            else    
                return UnprocessableEntity();
        }
}
