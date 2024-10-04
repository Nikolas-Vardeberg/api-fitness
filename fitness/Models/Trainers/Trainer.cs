using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace fitness.Models.Trainers;

public class Trainer {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id {get;set;}

    public string Email { get; set; }
    public string Firstname {get; set; }
    public string Lastname {get; set;}
}

public abstract class TrainerService {
    public static List<Trainer> GetTrainers() {
        return new List<Trainer>() {
        };
    }
}