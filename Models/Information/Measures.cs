using Newtonsoft.Json;

namespace RecipeMate.Models.Information;

public class Measures
{
    [JsonProperty("us")] public Us us { get; set; }

    [JsonProperty("metric")] public Metric metric { get; set; }
}