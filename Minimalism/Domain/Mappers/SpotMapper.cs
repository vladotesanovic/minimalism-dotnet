using FastEndpoints;
using Minimalism.Application.Contracts.Requests;
using Minimalism.Application.Contracts.Responses;
using Minimalism.Domain.Entities;

namespace Minimalism.Domain.Mappers;

public class SpotMapper : Mapper<PutParkingSpotRequest, GetSpotResponse, Spot>
{
    public override Spot ToEntity(PutParkingSpotRequest r) => new(r.ParkingId, r.SpotId, r.Available, r.Size, r.ElectrifiedLockingMechanism, r.ElectrifiedPowerRating);

    public override GetSpotResponse FromEntity(Spot s) => new()
    {
        Available = s.Available,
        Electrified = s.Electrified,
        Size = s.Size,
        SpotId = s.SpotId,
    };
}