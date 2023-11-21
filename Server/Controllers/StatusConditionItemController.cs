using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PokemonCatcherGame.Shared.Models.StatusConditionItemModels;
using Server.Services.StatusConditionItemServices;

namespace Server.Controllers;

[ApiController]
[Route("api/[controller]")]
public class StatusConditionItemController : ControllerBase
{
    private readonly IStatusConditionItemService _statusConditionItemService;

    public StatusConditionItemController(IStatusConditionItemService statusConditionItemService)
    {
        _statusConditionItemService = statusConditionItemService;
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

        _statusConditionItemService.SetUserId(userId);
        return true;
    }
    
    public async Task<IActionResult> Index(int page = 1, int pageSize = 10)
    {
        if (!SetUserIdInService())
            return Unauthorized();

        var statusConditionItems = await _statusConditionItemService.GetAllStatusConditionItemsAsync(page, pageSize);

        return Ok(statusConditionItems);
    }

    [HttpGet("ForItemInventory")]
    public async Task<List<StatusConditionItemList>> GetAllStatusConditionItemsForInventory()
    {
        if (!SetUserIdInService())
            return new List<StatusConditionItemList>();

        var statusConditionItemList = await _statusConditionItemService.GetAllStatusConditionItemsForInventoryAsync();
            
        return statusConditionItemList.ToList();
    }

    [HttpPost]
    public async Task<IActionResult> Create(StatusConditionItemCreate model)
    {
        if (model == null)
            return BadRequest();

        if (!SetUserIdInService())
            return Unauthorized();

        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        bool wasSuccessful = await _statusConditionItemService.CreateStatusConditionItemAsync(model);
        
        if (wasSuccessful)
            return Ok();

        else
            return UnprocessableEntity();
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> StatusConditionItem(int id)
    {
        if (!SetUserIdInService())
            return Unauthorized();

        var statusConditionItem = await _statusConditionItemService.GetStatusConditionItemByIdAsync(id);

        if (statusConditionItem == null)
            return NotFound();

        return Ok(statusConditionItem);
    }

    [HttpPut("Edit/{id}")]
    public async Task<IActionResult> Edit(int id, StatusConditionItemEdit model)
    {
        if (!SetUserIdInService())
            return Unauthorized();

        if (model ==null || !ModelState.IsValid)
            return BadRequest(ModelState);

        if (id != model.Id)
            return BadRequest();

        bool wasSuccessful = await _statusConditionItemService.UpdateStatusConditionItem(model);

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
        
        var statusConditionItem = await _statusConditionItemService.GetStatusConditionItemByIdAsync(id);

        if(statusConditionItem == null)
            return NotFound();

        bool wasSuccessful = await _statusConditionItemService.DeleteStatusConditionItemAsync(id);

        if (wasSuccessful)
            return Ok();

        else
            return UnprocessableEntity();
    }
}
