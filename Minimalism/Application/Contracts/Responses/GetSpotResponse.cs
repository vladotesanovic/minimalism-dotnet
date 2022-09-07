using Minimalism.Domain.Entities;
using Minimalism.Domain.Enums;
using Minimalism.Domain.Objects;

namespace Minimalism.Application.Contracts.Responses;

public class GetSpotResponse
{
    public int SpotId { get; set; }
    public bool Available { get; set; }
    public SpotSize Size { get; set; }
    public Electrification Electrified { get; set; }
    public Parking Parking { get; set; }
}