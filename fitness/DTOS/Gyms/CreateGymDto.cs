using fitness.Models;
using System.ComponentModel.DataAnnotations;

namespace fitness.DTOS.Gyms;

public class CreateGymDto
{
    public string Name { get; set; } = String.Empty;
    
    [Required]
    [MaxLength(100)]
    public string Slug { get; set; } = String.Empty;
    
    public string Description { get; set; } = String.Empty;
    public string Address { get; set; } = String.Empty;
    public string State { get; set; } = String.Empty;
    
    public string City { get; set; } = String.Empty;
    
    public string ZipCode { get; set; } = String.Empty;
    
    public string PhoneNumber { get; set; } = String.Empty;
    
    public string Website { get; set; } = String.Empty;

    public OpeningHours OpeningHours { get; set; } = null!;
}