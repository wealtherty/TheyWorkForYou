using Newtonsoft.Json;

namespace TheyWorkForYou.Model;

public class Person
{
    [JsonProperty("person_id")]
    public string Id { get; set; }
    
    [JsonProperty("full_name")]
    public string FullName { get; set; }
}