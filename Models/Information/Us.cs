using Newtonsoft.Json;

namespace RecipeMate.Models.Information;

public class Us
{
    [JsonProperty("amount")] public int amount { get; set; }

    [JsonProperty("unitShort")] public string unitShort { get; set; }

    [JsonProperty("unitLong")] public string unitLong { get; set; }
}