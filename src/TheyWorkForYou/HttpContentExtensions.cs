using Newtonsoft.Json;

namespace TheyWorkForYou;

public static class HttpContentExtensions
{
    public static async Task<T> ReadAsJsonAsync<T>(this HttpContent content)
    {
        await using var s = await content.ReadAsStreamAsync()
            .ConfigureAwait(false);
        using var sr = new StreamReader(s);
        await using var reader = new JsonTextReader(sr);
        var serializer = new JsonSerializer();

        return serializer.Deserialize<T>(reader);
    }
}