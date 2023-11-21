using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PokemonCatcherGame.Shared.Models.PokeBallModels;

namespace Server.Services.PokeBallServices;

public interface IPokeBallService
{
    Task<bool> CreatePokeBallAsync(PokeBallCreate model);
    Task<List<PokeBallListItem>> GetAllPokeBallsAsync(int page, int pageSize);  
    Task<List<PokeBallListItem>> GetAllPokeBallsForInventoryAsync();
    Task<PokeBallDetail?> GetPokeBallByIdAsync(int id);
    Task<bool> UpdatePokeBallAsync(PokeBallEdit request);
    Task<bool> DeletePokeBallAsync(int id);
    void SetUserId(string userId);
}
