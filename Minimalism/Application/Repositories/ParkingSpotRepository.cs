using Minimalism.Database;
using Minimalism.Domain.Entities;

namespace Minimalism.Application.Repositories;

public class ParkingSpotRepository : IParkingSpotRepository
{
    private readonly DatabaseContext _dbContext;

    public ParkingSpotRepository(DatabaseContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public async Task<Spot> UpdateParkingSpot(Spot spot)
    {
        var exists = GetBySpotId(spot.SpotId);

        if (exists == null!)
        {
            var newEntityEntry = _dbContext.Spots.Add(spot).Entity;
            await Save();
            
            return newEntityEntry;
        }

        exists.Available = spot.Available;
        var updateEntry = _dbContext.Spots.Update(exists).Entity;
        await Save();
            
        return updateEntry;
    }

    public Spot GetBySpotId(int spotId)
    {
        return _dbContext.Spots.SingleOrDefault(s => s.SpotId == spotId)!;
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