using Microsoft.EntityFrameworkCore;
using Minimalism.Database;
using Minimalism.Domain.Entities;

namespace Minimalism.Application.Repositories;

public class ParkingRepository : IParkingRepository
{
    private readonly DatabaseContext _dbContext;

    public ParkingRepository(DatabaseContext dbContext)
    {
        _dbContext = dbContext;
    }

    public Parking CreateParking(Parking parking)
    {
        return _dbContext.Parkings.Add(new Parking(parking.Name, parking.Maximum)).Entity;
    }

    public Task<List<Parking>> AllParking()
    {
        return _dbContext.Parkings
            .Include(p => p.Spots)
            .ToListAsync();
    }

    public Parking GetParking(int parkingId)
    {
        return _dbContext.Parkings.Find(parkingId)!;
    }

    public async Task Save()
    {
        await _dbContext.SaveChangesAsync();
    }

    public void Dispose()
    {
        GC.SuppressFinalize(this);
    }
}