namespace BuberBreakfast.Models;

public class Breakfast
{
    public required Guid Id { get; init; }
    public required string Name { get; init; }
    public required string Description { get; init; }
    public required DateTime StartDateTime { get; init; }
    public required DateTime EndDateTime { get; init; }
    public required DateTime LastModifiedDateTime { get; init; }
    public required List<string> Savory { get; init; }
    public required List<string> Sweet { get; init; }
}