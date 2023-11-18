using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using PokemonCatcherGame.Server.Services.PokemonServices;
using PokemonCatcherGame.Shared.Models.PokemonModels;

namespace PokemonCatcherGame.Server.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PokemonController : ControllerBase
{
    private readonly IPokemonService _pokemonService;
    public PokemonController(IPokemonService pokemonService)
    {
        _pokemonService = pokemonService;
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

        _pokemonService.SetUserId(userId);
        return true;
    }

    [HttpPost]
    public async Task<IActionResult> Create(PokemonCreate model)
    {
        if (model == null)
            return BadRequest();

        if (!SetUserIdInService())
            return Unauthorized();

        bool wasSuccessful = await _pokemonService.CreatePokemonAsync(model);

        if (wasSuccessful)
            return Ok();

        else
            return UnprocessableEntity();
    }
}
