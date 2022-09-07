using Minimalism.Domain.Enums;
using Minimalism.Domain.Objects;
using Minimalism.Domain.Primitives;

namespace Minimalism.Domain.Entities;

public class Spot : Entity
{
    public Spot(long parkingId, int spotId, bool available, SpotSize size)
    {
        ParkingId = parkingId;
        SpotId = spotId;
        Available = available;
        Size = size;
    }
    
    public Spot(long parkingId, int spotId, bool available, SpotSize size, bool lockingMechanism, int powerRating)
    {
        ParkingId = parkingId;
        SpotId = spotId;
        Available = available;
        Size = size;
        Electrified = new Electrification()
        {
            LockingMechanism = lockingMechanism,
            PowerRating = powerRating
        };
    }

    public int SpotId { get; set; }
    public long ParkingId { get; set; }
    public bool Available { get; set; }
    public SpotSize Size { get; set; }
    public Electrification Electrified { get; set; }
}