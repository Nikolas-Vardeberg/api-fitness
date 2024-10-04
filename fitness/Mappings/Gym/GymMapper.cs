using fitness.DTOS.Gyms;
using Riok.Mapperly.Abstractions;

namespace fitness.Mappings.Gyms;

[Mapper]
public static partial class GymMapper
{
    public static partial GymDto ToDto(this Models.Gym gym);
    
    public static partial List<GymDto> ToDtos(this List<Models.Gym> gym);
}