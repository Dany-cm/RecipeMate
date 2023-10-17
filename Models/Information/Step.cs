using Newtonsoft.Json;

namespace RecipeMate.Models.Information;

public class Step
{
    [JsonProperty("number")] public int number { get; set; }

    [JsonProperty("step")] public string step { get; set; }

    [JsonProperty("ingredients")] public IList<Ingredient> ingredients { get; set; }

    [JsonProperty("equipment")] public IList<Equipment> equipment { get; set; }

    [JsonProperty("length")] public Length length { get; set; }
}