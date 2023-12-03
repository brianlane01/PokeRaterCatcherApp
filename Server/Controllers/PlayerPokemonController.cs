using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PokemonCatcherGame.Shared.Models.PlayerPokemonModels;
using Server.Services.PlayerPokemonServices;

namespace Server.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PlayerPokemonController : ControllerBase
{
    private readonly IPlayerPokemonService _playerPokemonService;

    public PlayerPokemonController(IPlayerPokemonService playerPokemonService)
    {
        _playerPokemonService = playerPokemonService;
    } 

    [HttpGet("{id}")]
    public async Task<IActionResult> Details(int id)
    {

        var playerPokemon = await _playerPokemonService.GetPokemonForPlayerByIdAsync(id);

        if (playerPokemon == null)
            return NotFound();

        return Ok(playerPokemon);
    }

    [HttpPost]
    public async Task<IActionResult> Create(PlayerPokeCreate playerPokeCreate)
    {
        if (playerPokeCreate == null || !ModelState.IsValid)
            return BadRequest();

        var playerPokemon = await _playerPokemonService.CreatePokemonForPlayerAsync(playerPokeCreate);

        if (playerPokemon == null)
            return BadRequest();

        return Ok(playerPokemon);
    }
}
