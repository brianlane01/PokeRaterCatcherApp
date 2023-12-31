using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using PokemonCatcherGame.Shared.Models.PlayerItemInventoryModels;
using Server.Services.PlayerInventoryServices;

namespace Server.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PlayerInventoryController : ControllerBase
{
    private readonly IPlayerInventoryService _playerInventoryService;  

    public PlayerInventoryController(IPlayerInventoryService playerInventoryService)
    {
        _playerInventoryService = playerInventoryService;
    }

    [HttpGet]
    public async Task<List<PlayerInventoryIndex>> Index(int page = 1, int pageSize = 10)
    {
        var playerItemInventory = await _playerInventoryService.GetAllPlayerInventoriesAsync(page, pageSize);

        return playerItemInventory.ToList();
    }

    [HttpGet("ForPlayer")]
    public async Task<List<PlayerInventoryIndex>> GetAllPlayerInventoriesForPlayer()
    {
        var playerItemInventory = await _playerInventoryService.GetAllPlayerInventoriesForPlayerAsync();

        return playerItemInventory.ToList();
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Details(int id)
    {
        var playerItemInventory = await _playerInventoryService.GetPlayerInventoryByIdAsync(id);

        if (playerItemInventory == null)
            return NotFound();

        return Ok(playerItemInventory);
    }

    [HttpPost]
    public async Task<IActionResult> Create(PlayerInventoryCreate model)
    {
        if (model == null || !ModelState.IsValid)
            return BadRequest();

        var response = await _playerInventoryService.CreatePlayerInventoryAsync(model);

        if (response != null)
            return Ok(response);

        else
            return UnprocessableEntity();
    }

    [HttpPut("Edit/{id}")]
    public async Task<IActionResult> Update(PlayerInventoryEdit model)
    {

        if (model == null || !ModelState.IsValid)
            return BadRequest();

        var response = await _playerInventoryService.UpdatePlayerInventoryAsync(model);

        if (response != null)
            return Ok(response);

        return UnprocessableEntity();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var playerItemInventory = await _playerInventoryService.GetPlayerInventoryByIdAsync(id);

        if (playerItemInventory == null)
            return NotFound();

        bool wasSuccessful = await _playerInventoryService.DeletePlayerInventoryAsync(id);

        if (wasSuccessful)
            return Ok();

        return BadRequest();
    }
}
