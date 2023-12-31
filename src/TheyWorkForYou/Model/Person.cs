﻿using Newtonsoft.Json;
using TheyWorkForYou.Model.Converters;

namespace TheyWorkForYou.Model;

public class Person
{
    [JsonProperty("person_id")]
    public string Id { get; set; }
    
    [JsonProperty("member_id")]
    public string MemberId { get; set; }
    
    public House House { get; set; }
    
    public string Constituency { get; set; }
    
    public string Party { get; set; }
    
    public string Title { get; set; }

    [JsonProperty("given_name")]
    public string GivenName { get; set; }

    [JsonProperty("family_name")]
    public string FamilyName { get; set; }
    
    [JsonProperty("full_name")]
    public string FullName { get; set; }
    
    [JsonProperty("entered_house")]
    public DateTime EnteredHouse { get; set; }
    
    [JsonProperty("entered_reason")]
    public string EnteredReason { get; set; }
    
    [JsonProperty("left_house")]
    [JsonConverter(typeof(NullableDateTimeConverter))]
    public DateTime? LeftHouse { get; set; }
    
    [JsonProperty("left_reason")]
    public string LeftReason { get; set; }
    
 
    [JsonConverter(typeof(UrlConverter))]
    public string Url { get; set; }

    [JsonConverter(typeof(UrlConverter))]
    public string Image { get; set; }
}