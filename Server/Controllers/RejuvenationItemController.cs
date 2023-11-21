using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PokemonCatcherGame.Shared.Models.RejuvenationItemModels;
using Server.Services.RejuvenationItemServices;

namespace Server.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RejuvenationItemController : ControllerBase
{
    private readonly IRejuvenationItemService _rejuvenationItemService;

    public RejuvenationItemController(IRejuvenationItemService rejuvenationItemService)
    {
        _rejuvenationItemService = rejuvenationItemService;
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

        _rejuvenationItemService.SetUserId(userId);
        return true;
    }

    [HttpGet]
    public async Task<List<RejuvenationItemList>> Index(int page = 1, int pageSize = 10)
    {
        if (!SetUserIdInService())
            return new List<RejuvenationItemList>();

        var reviveItems = await _rejuvenationItemService.GetAllReviveItemsAsync(page, pageSize);

        return reviveItems.ToList();
    }

    [HttpGet("ForInventory")]
    public async Task<List<RejuvenationItemList>> GetAllReviveItemsForInventory()
    {
        if (!SetUserIdInService())
            return new List<RejuvenationItemList>();

        var reviveItems = await _rejuvenationItemService.GetAllReviveItemsForInventoryAsync();

        return reviveItems.ToList();
    }

    [HttpPost]
    public async Task<IActionResult> Create(RejuvenationItemCreate model)
    {
        if (model == null)
            return BadRequest();

        if (!SetUserIdInService())
            return Unauthorized();

        bool wasSuccessful = await _rejuvenationItemService.CreateReviveItemAsync(model);

        if (wasSuccessful)
            return Ok();

        return UnprocessableEntity();
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> ReviveItem(int id)
    {
        if(!SetUserIdInService())
            return Unauthorized();

        var reviveItem = await _rejuvenationItemService.GetReviveItemByIdAsync(id);

        if(reviveItem is null)
            return NotFound();

        return Ok(reviveItem);
    }

    [HttpPut("Edit/{id}")]
    public async Task<IActionResult> Edit(int id, RejuvenationItemEdit model)
    {
        if (model == null)
            return BadRequest();

        if(!SetUserIdInService())
            return Unauthorized();

        if (id != model.Id)
            return BadRequest();

        bool wasSuccessful = await _rejuvenationItemService.UpdateReviveItemAsync(model);

        if (wasSuccessful)
            return Ok();

        return BadRequest();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        if(!SetUserIdInService())
            return Unauthorized();

        var reviveItem = await _rejuvenationItemService.GetReviveItemByIdAsync(id);

        if(reviveItem is null)
            return NotFound();  

        bool wasSuccessful = await _rejuvenationItemService.DeleteReviveItemAsync(id);

        if(!wasSuccessful)
            return BadRequest();

        return Ok();
    }
}
