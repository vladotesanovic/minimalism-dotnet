using Minimalism.Domain.Entities;

namespace Minimalism.Application.Repositories;

public interface IParkingSpotRepository : IDisposable
{
    Task<Spot> UpdateParkingSpot(Spot spot);
    Spot GetBySpotId(int spotId);
    Task Save();
}