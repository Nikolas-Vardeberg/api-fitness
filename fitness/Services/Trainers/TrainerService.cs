using fitness.Data;
using fitness.Models.Trainers;
using Microsoft.EntityFrameworkCore;

namespace fitness.Services.Trainers;

public class TrainerService : ITrainerService
{
    private readonly DataContext _dbContext;

    public TrainerService(DataContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<bool> CreateTrainer(Trainer trainer)
    {
        await _dbContext.Trainers.AddAsync(trainer);
        return await _dbContext.SaveChangesAsync() > 0;
    }

    public async Task<List<Trainer>> GetTrainerAsync()
    {
        return await _dbContext.Trainers.ToListAsync();
    }
}