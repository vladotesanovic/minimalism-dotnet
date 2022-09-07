using FastEndpoints;
using Microsoft.AspNetCore.Authorization;
using Minimalism.Application.Contracts.Requests;
using Minimalism.Application.Contracts.Responses;
using Minimalism.Application.Repositories;
using Minimalism.Domain.Mappers;

namespace Minimalism.Endpoints.Spot;

[HttpPut("/parking/{ParkingId}/spot/{SpotId}"), AllowAnonymous]
public class PutParkingSpot : Endpoint<PutParkingSpotRequest, GetSpotResponse, SpotMapper>
{
    private IParkingSpotRepository ParkingSpotRepository { get; }
    
    public PutParkingSpot(IParkingSpotRepository parkingSpotRepository)
    {
        ParkingSpotRepository = parkingSpotRepository;
    }

    public override async Task HandleAsync(PutParkingSpotRequest r, CancellationToken c)
    {
        var spot = Map.ToEntity(r);
        var update = await ParkingSpotRepository.UpdateParkingSpot(spot);

        await SendAsync(
            Map.FromEntity(update)
            , cancellation: c);
    }
}