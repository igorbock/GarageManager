namespace GarageManagerRazorLib.Models;

public class GMJson : IGMActionResult
{
    public GMJson() => Content = null;

    public GMJson(object? content) => Content = JsonSerializer.Serialize(content);

    public GMJson(object? content, JsonSerializerOptions? options)
    {
        var memory = new MemoryStream();
        JsonSerializer.SerializeAsync(memory, content, options).Wait();
        Content = System.Text.Encoding.UTF8.GetString(memory.ToArray());
    }

    public int StatusCode { get; } = 200;
    public object? Content { get; set; }
}
