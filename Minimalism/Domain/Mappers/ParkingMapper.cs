using FastEndpoints;
using Minimalism.Application.Contracts.Requests;
using Minimalism.Application.Contracts.Responses;
using Minimalism.Domain.Entities;

namespace Minimalism.Domain.Mappers;

public class ParkingMapper : Mapper<PostParkingRequest, GetParkingResponse, Parking>
{
    public override Parking ToEntity(PostParkingRequest r) => new(r.Name, r.NumberOfSlots);

    public override GetParkingResponse FromEntity(Parking p) => new()
    {
        ParkingId = p.Id,
        Name = p.Name,
        NumberOfSlots = p.Maximum,
        Spots = p.Spots,
        OccupancyPercentage = p.OccupancyPercentage
    };
}