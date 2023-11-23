using PokemonCatcherGame.Shared.Models.TechnicalMachineMovesModels;


namespace Server.Services.TechnicalMahineMoveServices;

public interface ITMService
{
    Task<bool> CreateTMAsync(TMCreate model);

    Task<List<TMIndex>> GetAllTMsAsync(int page, int pageSize);

    Task<List<TMIndex>> GetAllTMsForInventoryAsync();

    Task<TMDetail?> GetTMByIdAsync(int id);

    Task<bool> UpdateTMAsync(TMEdit request);

    Task<bool> DeleteTMAsync(int id);

    void SetUserId(string userId);
}
