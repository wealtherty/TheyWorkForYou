using Newtonsoft.Json;

namespace TheyWorkForYou.Model;

public class Person
{
    [JsonProperty("person_id")]
    public string Id { get; set; }
    
    [JsonProperty("member_id")]
    public string MemberId { get; set; }
    
    public string House { get; set; }
    
    public string Constituency { get; set; }
    
    public string Party { get; set; }
    
    [JsonProperty("full_name")]
    public string FullName { get; set; }
    
    
}