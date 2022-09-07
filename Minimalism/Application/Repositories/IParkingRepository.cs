using Minimalism.Domain.Entities;

namespace Minimalism.Application.Repositories;

public interface IParkingRepository : IDisposable
{
    Parking CreateParking(Parking createParkingRequest);
    Task<List<Parking>> AllParking();
    Parking GetParking(int parkingId);
    Task Save();
}