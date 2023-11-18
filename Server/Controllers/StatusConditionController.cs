using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PokemonCatcherGame.Server.Services.StatusConditionServices;
using PokemonCatcherGame.Shared.Models.StatusConditionModels;

namespace Server.Controllers;

[ApiController]
[Route("api/[controller]")]
public class StatusConditionController : ControllerBase
{
    private readonly IStatusConditionService _statusConditonService;

    public StatusConditionController(IStatusConditionService statusConditionService)
    {
        _statusConditonService = statusConditionService; 
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

        _statusConditonService.SetUserId(userId);
        return true;
    }
    
    public async Task<IActionResult> Index()
    {
        var statusConditions = await _statusConditonService.GetAllStatusConditionsAsync();
        return Ok(statusConditions);
    }

    [HttpPost]
    public async Task<IActionResult> Create(StatusConditionCreate model)
    {
        if (model == null)
            return BadRequest();

        if (!SetUserIdInService())
            return Unauthorized();

        bool wasSuccessful = await _statusConditonService.CreateStatusConditionAsync(model);

        if (wasSuccessful)
            return Ok();

        return BadRequest();
    }

    [HttpGet("{id}")] 
    public async Task<IActionResult> StatusCondition(int id)
    {
        if (!SetUserIdInService())
            return Unauthorized();

        var statusCondition = await _statusConditonService.GetStatusConditionByIdAsync(id);

        if (statusCondition == null)
            return NotFound();

        return Ok(statusCondition);
    }

    [HttpPut("{id}")]  
    public async Task<IActionResult> Edit(int id, StatusConditionEdit model)
    {
        if (model == null)
            return BadRequest();

        if (!SetUserIdInService())
            return Unauthorized();

        if (id != model.Id)
            return BadRequest();

        bool wasSuccessful = await _statusConditonService.UpdateStatusConditionAsync(model);

        if (wasSuccessful)
            return Ok();

        return BadRequest();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        if (!SetUserIdInService())
            return Unauthorized();

        var statusCondition = await _statusConditonService.GetStatusConditionByIdAsync(id);

        if (statusCondition == null)
            return NotFound();

        bool wasSuccessful = await _statusConditonService.DeleteStatusConditionAsync(id);

        if (wasSuccessful)
            return Ok();

        return BadRequest();
    }
}
