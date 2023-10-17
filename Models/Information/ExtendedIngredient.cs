using Newtonsoft.Json;

namespace RecipeMate.Models.Information;

public class ExtendedIngredient
{
    [JsonProperty("id")] public int id { get; set; }

    [JsonProperty("aisle")] public string aisle { get; set; }

    [JsonProperty("image")] public string image { get; set; }

    [JsonProperty("consistency")] public string consistency { get; set; }

    [JsonProperty("name")] public string name { get; set; }

    [JsonProperty("nameClean")] public string nameClean { get; set; }

    [JsonProperty("original")] public string original { get; set; }

    [JsonProperty("originalName")] public string originalName { get; set; }

    [JsonProperty("amount")] public int amount { get; set; }

    [JsonProperty("unit")] public string unit { get; set; }

    [JsonProperty("meta")] public IList<string> meta { get; set; }

    [JsonProperty("measures")] public Measures measures { get; set; }
}