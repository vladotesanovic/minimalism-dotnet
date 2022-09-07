using Minimalism.Domain.Primitives;

namespace Minimalism.Domain.Objects;

public class Electrification : ValueObject
{
    public int PowerRating { get; set; }
    public bool LockingMechanism { get; set; }
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return PowerRating;
        yield return LockingMechanism;
    }
}