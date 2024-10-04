using fitness.Models;

namespace fitness.Interfaces;

public interface IGymService
{
    Task<Gym?> GetGymByIdAsync(Guid id);

    Task<Gym?> GetGymBySlugAsync(string slug);
    
    Task<List<Gym>> GetGymsAsync();
    
    Task<bool> CreateGymAsync(Gym gym);
    
    Task<bool> UpdateGymAsync(Gym gym);
}