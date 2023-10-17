using Newtonsoft.Json;

namespace RecipeMate.Models.Information;

public class AnalyzedInstruction
{
    [JsonProperty("name")] public string name { get; set; }

    [JsonProperty("steps")] public IList<Step> steps { get; set; }
}