using Newtonsoft.Json;

namespace RecipeMate.Models.Information;

public class Ingredient
{
    [JsonProperty("id")] public int id { get; set; }

    [JsonProperty("name")] public string name { get; set; }

    [JsonProperty("localizedName")] public string localizedName { get; set; }

    [JsonProperty("image")] public string image { get; set; }
}