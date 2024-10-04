using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using fitness.DTOS.Gyms;

namespace fitness.Models;

public class Gym
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }
    
    public string Name { get; set; } = string.Empty;
    
    [Required]
    [MaxLength(100)]
    public string Slug { get; set; } = string.Empty;
    
    public string Description { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    
    public string State { get; set; } = string.Empty;
    
    public string City { get; set; } = string.Empty;
    
    public string ZipCode { get; set; } = string.Empty;
    
    public string PhoneNumber { get; set; } = string.Empty;
    
    public string Website { get; set; } = string.Empty;

    //TODO: LEGGE TIL OPENINGSHOURS
}