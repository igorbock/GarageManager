namespace GarageManagerRazorLib.Models;

public class GMOk : IGMActionResult
{
    public GMOk() { }

    public GMOk(object? content) => Content = content;

    public int StatusCode { get; } = 200;
    public object? Content { get; set; }
}
