using Newtonsoft.Json;

namespace TheyWorkForYou.Model.Converters;

public class NullableDateTimeConverter : JsonConverter<DateTime?>
{
    private static readonly DateTime NullDateTime = new DateTime(9999, 12, 31);
    
    public override void WriteJson(JsonWriter writer, DateTime? value, JsonSerializer serializer)
    {
        throw new NotImplementedException();
    }

    public override DateTime? ReadJson(JsonReader reader, Type objectType, DateTime? existingValue, bool hasExistingValue,
        JsonSerializer serializer)
    {
        if (!existingValue.HasValue) return existingValue;
        
        return existingValue.Value.Equals(NullDateTime) ? null : existingValue;
    }
}