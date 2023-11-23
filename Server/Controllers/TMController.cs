using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PokemonCatcherGame.Shared.Models.TechnicalMachineMovesModels;
using Server.Services.TechnicalMahineMoveServices;

namespace Server.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TMController : ControllerBase
{
    private readonly ITMService _tmService; 

    public TMController(ITMService tmService)
    {
        _tmService = tmService;
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

        _tmService.SetUserId(userId);
        return true;
    }

    [HttpGet]
    public async Task<List<TMIndex>> Index(int page = 1, int pageSize = 10)
    {
        if (!SetUserIdInService())
            return new List<TMIndex>();

        var tms = await _tmService.GetAllTMsAsync(page, pageSize);
            
        return tms.ToList();
    }

    [HttpGet("ForInventory")]
    public async Task<List<TMIndex>> GetAllTMsForInventory()
    {
        if (!SetUserIdInService())
            return new List<TMIndex>();

        var tms = await _tmService.GetAllTMsForInventoryAsync();
            
        return tms.ToList();
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetTMById(int id)
    {
        if (!SetUserIdInService())
            return Unauthorized()   ;

        var tm = await _tmService.GetTMByIdAsync(id);

        if (tm is null)
            return NotFound();

        return Ok(tm);
    }

    [HttpPost]
    public async Task<IActionResult> Create(TMCreate model)
    {
        if (model == null)
            return BadRequest();

        if (!SetUserIdInService())
            return Unauthorized();

        bool wasSuccessful = await _tmService.CreateTMAsync(model);
        if (wasSuccessful)
            return Ok();

        else
            return UnprocessableEntity();
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateTM(int id, TMEdit model)
    {
        if (model == null || !ModelState.IsValid)
            return BadRequest();

        if (!SetUserIdInService())
            return Unauthorized();

        if (id != model.Id)
            return BadRequest();

        bool wasSuccessful = await _tmService.UpdateTMAsync(model);
        
        if (wasSuccessful)
            return Ok();

        else
            return BadRequest();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteTM(int id)
    {
        if (!SetUserIdInService())
            return Unauthorized();

        var tm = await _tmService.GetTMByIdAsync(id);

        if (tm is null)
            return NotFound();

        bool wasSuccessful = await _tmService.DeleteTMAsync(id);

        if(wasSuccessful)
            return Ok();

        else
            return BadRequest();
    }
}
