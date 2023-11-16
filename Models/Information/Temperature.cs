using Newtonsoft.Json;

namespace RecipeMate.Models.Information;

public class Temperature
{
    [JsonProperty("number")] public decimal number { get; set; }

    [JsonProperty("unit")] public string unit { get; set; }
}