using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PokemonCatcherGame.Shared.Models.HealthItemModels;
using Server.Services.HealthItemServices;

namespace Server.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HealthItemController : ControllerBase
{
    private readonly IHealthItemService _healthItemService;

    public HealthItemController(IHealthItemService healthItemService)
    {
        _healthItemService = healthItemService;
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

        _healthItemService.SetUserId(userId);
        return true;
    }

    [HttpGet]
    public async Task<List<HealthItemList>> Index(int page = 1, int pageSize = 10)
    {
        if (!SetUserIdInService())
            return new List<HealthItemList>();

        var healthItems = await _healthItemService.GetAllHealthItemsAsync(page, pageSize);

        return healthItems.ToList();
    }

    [HttpGet("ForInventory")]
    public async Task<List<HealthItemList>> GetAllHealthItemsForInventory()
    {
        if (!SetUserIdInService())
            return new List<HealthItemList>();

        var healthItems = await _healthItemService.GetAllHealthItemsForInventoryAsync();

        return healthItems.ToList();
    }

    [HttpPost]
    public async Task<IActionResult> Create(HealthItemCreate model)
    {
        if (model == null)
            return BadRequest();

        if (!SetUserIdInService())
            return Unauthorized();

        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        bool wasSuccessful = await _healthItemService.CreateHealthItemAsync(model);

        if (wasSuccessful)
            return Ok();

        return UnprocessableEntity();
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> HealthItem(int id)
    {
        if (!SetUserIdInService())
            return Unauthorized();

        var healthItem = await _healthItemService.GetHealthItemByIdAsync(id);

        if (healthItem == null)
            return NotFound();

        return Ok(healthItem);
    }

    [HttpPut("Edit/{id}")]
    public async Task<IActionResult> Edit(HealthItemEdit model)
    {
        if (!SetUserIdInService())
            return Unauthorized();

        if (model == null || !ModelState.IsValid)
            return BadRequest(ModelState);

        bool wasSuccessful = await _healthItemService.UpdateHealthItemAsync(model);

        if (wasSuccessful)
            return Ok();

        return BadRequest();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        if (!SetUserIdInService())
            return Unauthorized();

        var healthItem = await _healthItemService.GetHealthItemByIdAsync(id);

        if (healthItem == null)
            return NotFound();

        bool wasSuccessful = await _healthItemService.DeleteHealthItemAsync(id);

        if (wasSuccessful)
            return Ok();

        return BadRequest();
    }
}
