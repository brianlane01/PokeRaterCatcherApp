using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PokemonCatcherGame.Shared.Models.PokeBallModels;
using Server.Services.PokeBallServices;

namespace Server.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PokeBallController : ControllerBase
{
    private readonly IPokeBallService _pokeBallService;

    public PokeBallController(IPokeBallService pokeBallService)
    {
        _pokeBallService = pokeBallService;
    }

    private string? GetUserId()
    {
        string userIdClaim = User.Claims.First(i => i.Type == ClaimTypes.NameIdentifier).Value;

        if(userIdClaim == null)
            return null;

        return userIdClaim;
    }

    private bool SetUserIdInService()
    {
        var userId = GetUserId();
        if (userId == null)
            return false;

        _pokeBallService.SetUserId(userId);
        return true;
    }

    [HttpGet]
    public async Task<List<PokeBallListItem>> Index(int page = 1, int pageSize = 10)
    {
        if (!SetUserIdInService())
            return new List<PokeBallListItem>();

        var pokeBalls = await _pokeBallService.GetAllPokeBallsAsync(page, pageSize);

        return pokeBalls.ToList();
    }

    [HttpGet("ForInventory")]
    public async Task<List<PokeBallListItem>> GetAllPokeBallsForInventory()
    {
        if (!SetUserIdInService())
            return new List<PokeBallListItem>();

        var pokeBalls = await _pokeBallService.GetAllPokeBallsForInventoryAsync();

        return pokeBalls.ToList();
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Details(int id)
    {
        if (!SetUserIdInService())
            return Unauthorized();

        var pokeBall = await _pokeBallService.GetPokeBallByIdAsync(id);

        if (pokeBall is null)
            return NotFound();

        return Ok(pokeBall);
    }

    [HttpPost]
    public async Task<IActionResult> Create(PokeBallCreate model)
    {
        if (model == null)
            return BadRequest();

        if (!SetUserIdInService())
            return Unauthorized();

        bool wasSuccessful = await _pokeBallService.CreatePokeBallAsync(model);

        if (wasSuccessful)
            return Ok();

        return UnprocessableEntity();
    }

    [HttpPut("Edit/{id}")]
    public async Task<IActionResult> Edit(int id, PokeBallEdit model)
    {
        if (model == null)
            return BadRequest();

        if (!SetUserIdInService())
            return Unauthorized();

        if (id != model.Id)
            return BadRequest();

        bool wasSuccessful = await _pokeBallService.UpdatePokeBallAsync(model);

        if (wasSuccessful)
            return Ok();

        return UnprocessableEntity();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        if (!SetUserIdInService())
            return Unauthorized();
            
        var pokeBall = await _pokeBallService.GetPokeBallByIdAsync(id);

        bool wasSuccessful = await _pokeBallService.DeletePokeBallAsync(id);

        if(pokeBall is null)
            return NotFound();

        if (wasSuccessful)
            return Ok();

        return BadRequest();
    }
}
