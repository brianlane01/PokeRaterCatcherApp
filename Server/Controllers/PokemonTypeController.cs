using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PokemonCatcherGame.Server.Services.PokemonTypeServices;

namespace Server.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PokemonTypeController : ControllerBase
{
    private readonly IPokemonTypeService _pokemonTypeService;

    public PokemonTypeController(IPokemonTypeService pokemonTypeService)
    {
        _pokemonTypeService = pokemonTypeService;
    }
    
    public async Task<IActionResult> Index()
    {
        var pokeTypes = await _pokemonTypeService.GetAllPokemonTypesAsync();
        return Ok(pokeTypes);
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
            if(userId == null)
                return false;

            _pokemonTypeService.SetUserId(userId);
            return true;
        }
}
