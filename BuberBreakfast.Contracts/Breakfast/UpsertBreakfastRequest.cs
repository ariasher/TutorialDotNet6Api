namespace BuberBreakfast.Contracts.Breakfast;

public record UpsertBreakfstRequest 
(
    string Name,
    string Description,
    DateTime StartDateTime,
    DateTime EndDateTime,
    List<string> Savory,
    List<string> Sweet
);