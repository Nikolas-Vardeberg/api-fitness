using fitness.DTOS.Gyms;
using fitness.Interfaces;
using fitness.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using fitness.Mappings.Gyms;

namespace fitness.Controllers;

[Route("/api/gyms")]
[ApiController]

public class GymsController
{
    private readonly IGymService _gymService;

    public GymsController(IGymService gymService)
    {
        _gymService = gymService;
    }

    [HttpPost]
    [AllowAnonymous]
    public async Task<GymDto> Create([FromBody] CreateGymDto dto)
    {
        var gym = new Gym()
        {
            Name = dto.Name,
            Slug = dto.Slug,
            Description = dto.Description,
            Address = dto.Address,
            State = dto.State,
            City = dto.City,
            ZipCode = dto.ZipCode,
            PhoneNumber = dto.PhoneNumber,
            Website = dto.Website,
        };

        var success = await _gymService.CreateGymAsync(gym);
        if (!success)
            throw new Exception("Failed to create restaurant");

        return gym.ToDto();
    }
}
