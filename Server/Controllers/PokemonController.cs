
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

    public async Task<List<PokemonList>> Index(int page = 1, int pageSize = 10)
    {

        var pokemon = await _pokemonService.GetAllPokemonAsync(page, pageSize);

        return pokemon.ToList();
    }

    [HttpGet("ForPlayerCreate")]
    public async Task<List<PokemonList>> GetPokemonForPlayerStart()
    {

        var pokemon = await _pokemonService.GetAllPokemonForPlayerStartAsync();

        return pokemon.ToList();
    }

    [HttpPost]
    public async Task<IActionResult> Create(PokemonCreate model)
    {
        if(model == null || !ModelState.IsValid)
            return BadRequest();

        bool wasSuccessful = await _pokemonService.CreatePokemonAsync(model);

        if (wasSuccessful)
            return Ok();

        else
            return BadRequest();
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Details(int id)
    {

        var pokemon = await _pokemonService.GetPokemonByIdAsync(id);

        if(pokemon == null)
            return NotFound();

        return Ok(pokemon);
    }

    [HttpPut("Edit/{id}")]
    public async Task<IActionResult> Edit(PokemonEdit model)
    {
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
            
        var pokemon = await _pokemonService.GetPokemonByIdAsync(id);
        
        if(pokemon == null)
            return NotFound();

        bool wasSuccessful = await _pokemonService.DeletePokemonAsync(id);

        if (wasSuccessful)
            return Ok();

        else
            return BadRequest();
    }

    [HttpGet("TotalCount")]
    public async Task<IActionResult> GetTotalCount()
    {
        var totalCount = await _pokemonService.GetPokemonTotalCountAsync();
        return Ok(totalCount);
    }
}
