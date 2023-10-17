using Newtonsoft.Json;

namespace RecipeMate.Models.Information;

public class Length
{
    [JsonProperty("number")] public int number { get; set; }

    [JsonProperty("unit")] public string unit { get; set; }
}