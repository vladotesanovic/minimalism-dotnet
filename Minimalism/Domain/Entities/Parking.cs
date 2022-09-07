using Minimalism.Domain.Primitives;

namespace Minimalism.Domain.Entities;

public class Parking : Entity
{
    public Parking(string name, int maximum)
    {
        Name = name;
        Maximum = maximum;
    }
    public string Name { get; set; }
    public int Maximum { get; set; }
    public List<Spot> Spots { get; } = new();

    public double OccupancyPercentage => (double) Spots.Count / Maximum * 100;
}