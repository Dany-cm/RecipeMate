using Newtonsoft.Json;

namespace RecipeMate.Models.Information;

public class ProductMatch
{
    [JsonProperty("id")] public int id { get; set; }

    [JsonProperty("title")] public string title { get; set; }

    [JsonProperty("description")] public string description { get; set; }

    [JsonProperty("price")] public string price { get; set; }

    [JsonProperty("imageUrl")] public string imageUrl { get; set; }

    [JsonProperty("averageRating")] public double averageRating { get; set; }

    [JsonProperty("ratingCount")] public int ratingCount { get; set; }

    [JsonProperty("score")] public double score { get; set; }

    [JsonProperty("link")] public string link { get; set; }
}