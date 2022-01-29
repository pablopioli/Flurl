using Flurl.Http.Configuration;
using Jil;

namespace JilSample;

internal class JilSerializer : ISerializer
{
    private readonly Options _options;

    public JilSerializer()
    {
        // Use any options you prefer
        _options = new Options(excludeNulls: true);
    }

    public T Deserialize<T>(string json)
    {
        return JSON.Deserialize<T>(json, _options);
    }

    public T Deserialize<T>(Stream stream)
    {
        return JSON.Deserialize<T>(new StreamReader(stream), _options);
    }

    public string Serialize(object obj)
    {
        return JSON.Serialize(obj, _options);
    }
}
