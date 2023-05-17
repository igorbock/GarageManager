namespace GarageManagerRazorLib.Models;

public class GMBadRequest : IGMActionResult
{
    public GMBadRequest() { }

    public GMBadRequest(object? content) => Content = content;

    public int StatusCode { get; } = 400;
    public object? Content { get; set; }
}
