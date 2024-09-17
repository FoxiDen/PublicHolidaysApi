namespace PublicHolidaysApi.Models;

public record DateBaseDto
{
    public required int Day { get; init; }
    public required int Month { get; init; }
    public required int Year { get; init; }
}

