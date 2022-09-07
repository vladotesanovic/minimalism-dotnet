using Minimalism.Domain.Enums;

namespace Minimalism.Application.Contracts.Requests;

public class PutParkingSpotRequest
{
    public int ParkingId { get; set; }
    public int SpotId { get; set; }
    public bool Available { get; set; }
    public int ElectrifiedPowerRating { get; set; }
    public bool ElectrifiedLockingMechanism { get; set; }
    public SpotSize Size { get; set; }
}