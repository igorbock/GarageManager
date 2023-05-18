namespace GarageManagerRazorLib.Interfaces;

public interface IGMActionResult
{
    int StatusCode { get; }
    object? Content { get; set; }
}
