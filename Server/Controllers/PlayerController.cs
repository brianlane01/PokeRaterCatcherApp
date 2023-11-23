using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using PokemonCatcherGame.Shared.Models.PlayerModels;
using Server.Services.PlayerServices;

namespace Server.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PlayerController : ControllerBase
{
    private readonly IPlayerService _playerService;

    public PlayerController(IPlayerService playerService)
    {
        _playerService = playerService;
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

        _playerService.SetUserId(userId);
        return true;
    }

    [HttpGet]
    public async Task<List<PlayerIndex>> Index(int page = 1, int pageSize = 10)
    {
        if (!SetUserIdInService())
            return new List<PlayerIndex>();

        var players = await _playerService.GetAllPlayersAsync(page, pageSize);

        return players.ToList();
    }

    [HttpPost]
    public async Task<IActionResult> Create(PlayerCreate model)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        if (!SetUserIdInService())
            return Unauthorized();

        bool wasSuccessful = await _playerService.CreatePlayerAsync(model);

        if (!wasSuccessful)
            return Ok();
        else 
            return UnprocessableEntity();
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Details(int id)
    {
        if (!SetUserIdInService())
            return Unauthorized();

        var player = await _playerService.GetPlayerByIdAsync(id);

        if (player == null)
            return NotFound();

        return Ok(player);
    }

    [HttpPut("Edit/{id}")]
    public async Task<IActionResult> Edit(int id, PlayerEdit model)
    {
        if (model == null || !ModelState.IsValid || id != model.Id)
            return BadRequest();

        if (!SetUserIdInService())
            return Unauthorized();

        bool wasSuccessful = await _playerService.UpdatePlayerAsync(model);

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

        var player = await _playerService.GetPlayerByIdAsync(id);

        if (player == null)
            return NotFound();

        bool wasSuccessful = await _playerService.DeletePlayerAsync(id);

        if (wasSuccessful)
            return Ok();

        else
            return BadRequest();
    }
}
