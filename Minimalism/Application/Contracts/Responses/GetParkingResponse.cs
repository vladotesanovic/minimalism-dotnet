using Minimalism.Domain.Entities;

namespace Minimalism.Application.Contracts.Responses;

public class GetParkingResponse
{
    public long ParkingId { get; init; }
    public string Name { get; init; } = null!;
    public int NumberOfSlots { get; init; }
    public List<Spot> Spots { get; init; }
    public double OccupancyPercentage { get; set; }
}