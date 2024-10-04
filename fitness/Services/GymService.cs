using fitness.Data;
using fitness.Interfaces;
using fitness.Models;
using Microsoft.EntityFrameworkCore;

namespace fitness.Services;

public class GymService : IGymService
{
    private readonly DataContext _dbContext;

    public GymService(DataContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Gym?> GetGymByIdAsync(Guid id)
    {
        return await _dbContext.Gyms.FindAsync(id);
    }

    public async Task<Gym?> GetGymBySlugAsync(string slug)
    {
        return await _dbContext.Gyms.FirstOrDefaultAsync(x => x.Slug == slug);
    }

    public async Task<List<Gym>> GetGymsAsync()
    {
        return await _dbContext.Gyms.ToListAsync();
    }

    public async Task<bool> CreateGymAsync(Gym gym)
    {
        await _dbContext.Gyms.AddAsync(gym);
        return await _dbContext.SaveChangesAsync() > 0;
    }

    public async Task<bool> UpdateGymAsync(Gym gym)
    {
        _dbContext.Gyms.Update(gym);
        return await _dbContext.SaveChangesAsync() > 0;
    }
}