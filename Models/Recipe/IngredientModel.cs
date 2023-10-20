using Newtonsoft.Json;

namespace RecipeMate.Models;

public class IngredientModel
{
    [JsonProperty("id")] public int Id { get; set; }

    [JsonProperty("amount")] public double Amount { get; set; }

    [JsonProperty("unit")] public string Unit { get; set; }

    [JsonProperty("unitLong")] public string UnitLong { get; set; }

    [JsonProperty("unitShort")] public string UnitShort { get; set; }

    [JsonProperty("aisle")] public string Aisle { get; set; }

    [JsonProperty("name")] public string Name { get; set; }

    [JsonProperty("original")] public string Original { get; set; }

    [JsonProperty("originalName")] public string OriginalName { get; set; }

    [JsonProperty("meta")] public List<string> Meta { get; set; }

    [JsonProperty("image")] public string Image { get; set; }
}