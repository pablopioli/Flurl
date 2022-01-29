using Flurl.Http.Configuration;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace TextJson;

public class TextJsonSerializer : ISerializer
{
    private readonly JsonSerializerOptions _options;

    public TextJsonSerializer()
    {
        // Use any options you prefer
        _options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
            PropertyNamingPolicy = null,
            NumberHandling = JsonNumberHandling.AllowReadingFromString,
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };
    }

    public string Serialize(object obj)
    {
        return JsonSerializer.Serialize(obj, _options);
    }

    public T Deserialize<T>(string s)
    {
        return JsonSerializer.Deserialize<T>(s, _options)!;
    }
    public T Deserialize<T>(Stream stream)
    {
        using var reader = new StreamReader(stream);
        return (T)JsonSerializer.Deserialize(stream, typeof(T), _options);
    }
}
