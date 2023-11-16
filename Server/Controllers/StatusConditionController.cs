using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PokemonCatcherGame.Server.Services.StatusConditionServices;

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

    public async Task<IActionResult> Index()
    {
        var statusConditions = await _statusConditonService.GetAllStatusConditionsAsync();
        return Ok(statusConditions);
    }
}
