
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using PokemonCatcherGame.Server.Services.PokemonServices;
using PokemonCatcherGame.Shared.Models.PokemonModels;

namespace Server.Controllers;

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

    public async Task<List<PokemonList>> Index(int page = 1, int pageSize = 10)
    {
        if (!SetUserIdInService())
            return new List<PokemonList>();

        var pokemon = await _pokemonService.GetAllPokemonAsync(page, pageSize);

        return pokemon.ToList();
    }
    [HttpGet("ForPlayerCreate")]
    public async Task<List<PokemonList>> GetPokemonForPlayerStart()
    {
        if (!SetUserIdInService())
            return new List<PokemonList>();

        var pokemon = await _pokemonService.GetAllPokemonForPlayerStartAsync();

        return pokemon.ToList();
    }

    [HttpPost]
    public async Task<IActionResult> Create(PokemonCreate model)
    {
        if(model == null || !ModelState.IsValid)
            return BadRequest();

        if (!SetUserIdInService())
            return Unauthorized();

        bool wasSuccessful = await _pokemonService.CreatePokemonAsync(model);

        if (wasSuccessful)
            return Ok();

        else
            return BadRequest();
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Details(int id)
    {
        if (!SetUserIdInService())
            return Unauthorized();

        var pokemon = await _pokemonService.GetPokemonByIdAsync(id);

        if(pokemon == null)
            return NotFound();

        return Ok(pokemon);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, PokemonEdit model)
    {
        if (!SetUserIdInService())
            return Unauthorized();

        if (model == null)
            return BadRequest();

        bool wasSuccessful = await _pokemonService.UpdatePokemonAsync(model);

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
            
        var pokemon = await _pokemonService.GetPokemonByIdAsync(id);
        
        if(pokemon == null)
            return NotFound();

        bool wasSuccessful = await _pokemonService.DeletePokemonAsync(id);

        if (wasSuccessful)
            return Ok();

        else
            return BadRequest();
    }
}
