using Newtonsoft.Json;

namespace TheyWorkForYou.Model.Converters;

public class UrlConverter : JsonConverter<string>
{
    public override void WriteJson(JsonWriter writer, string? value, JsonSerializer serializer)
    {
        throw new NotImplementedException();
    }

    public override string ReadJson(JsonReader reader, Type objectType, string existingValue, bool hasExistingValue, JsonSerializer serializer)
    {
        return $"https://www.theyworkforyou.com{reader.Value}";
    }
}