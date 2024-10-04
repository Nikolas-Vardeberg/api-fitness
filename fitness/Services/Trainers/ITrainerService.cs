
using fitness.Models.Trainers;

namespace fitness.Services.Trainers;

public interface ITrainerService {
    Task<List<Trainer>> GetTrainerAsync();

    Task<bool> CreateTrainer(Trainer user);
}