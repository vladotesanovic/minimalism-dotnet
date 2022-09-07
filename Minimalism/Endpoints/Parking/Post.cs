using FastEndpoints;
using Microsoft.AspNetCore.Authorization;
using Minimalism.Application.Contracts.Requests;
using Minimalism.Application.Contracts.Responses;
using Minimalism.Application.Repositories;
using Minimalism.Domain.Mappers;

namespace Minimalism.Endpoints.Parking;

[HttpPost("/parking"), AllowAnonymous]
public class PostParking : Endpoint<PostParkingRequest, GetParkingResponse, ParkingMapper>
{
    private IParkingRepository ParkingRepository { get; }
    
    public PostParking(IParkingRepository parkingRepository)
    {
        ParkingRepository = parkingRepository;
    }

    public override async Task HandleAsync(PostParkingRequest r, CancellationToken c)
    {
        var parking = Map.ToEntity(r);
        var entity = ParkingRepository.CreateParking(parking);
        await ParkingRepository.Save();

        await SendAsync(Map.FromEntity(entity), cancellation: c);
    }
}