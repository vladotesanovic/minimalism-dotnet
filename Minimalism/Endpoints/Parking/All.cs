using FastEndpoints;
using Microsoft.AspNetCore.Authorization;
using Minimalism.Application.Contracts.Responses;
using Minimalism.Application.Repositories;
using Minimalism.Domain.Mappers;

namespace Minimalism.Endpoints.Parking;

[HttpGet("/parking"), AllowAnonymous]
public class AllParking : Endpoint<EmptyRequest, GetParkingListResponse, ParkingMapper>
{
    private IParkingRepository ParkingRepository { get; }
    
    public AllParking(IParkingRepository parkingRepository)
    {
        ParkingRepository = parkingRepository;
    }
    
    public override async Task HandleAsync(EmptyRequest r,CancellationToken ct)
    {
        var listParking = await ParkingRepository.AllParking();
        
        await SendAsync(new GetParkingListResponse
        {
            ListParking = listParking.Select(p => Map.FromEntity(p)).ToList()
        }, cancellation: ct);
    }
}