using Newtonsoft.Json;

namespace RecipeMate.Models.Information;

public class RecipeInfo
{
    [JsonProperty("vegetarian")] public bool vegetarian { get; set; }

    [JsonProperty("vegan")] public bool vegan { get; set; }

    [JsonProperty("glutenFree")] public bool glutenFree { get; set; }

    [JsonProperty("dairyFree")] public bool dairyFree { get; set; }

    [JsonProperty("veryHealthy")] public bool veryHealthy { get; set; }

    [JsonProperty("cheap")] public bool cheap { get; set; }

    [JsonProperty("veryPopular")] public bool veryPopular { get; set; }

    [JsonProperty("sustainable")] public bool sustainable { get; set; }

    [JsonProperty("lowFodmap")] public bool lowFodmap { get; set; }

    [JsonProperty("weightWatcherSmartPoints")]
    public int weightWatcherSmartPoints { get; set; }

    [JsonProperty("gaps")] public string gaps { get; set; }

    [JsonProperty("preparationMinutes")] public int preparationMinutes { get; set; }

    [JsonProperty("cookingMinutes")] public int cookingMinutes { get; set; }

    [JsonProperty("aggregateLikes")] public int aggregateLikes { get; set; }

    [JsonProperty("healthScore")] public int healthScore { get; set; }

    [JsonProperty("creditsText")] public string creditsText { get; set; }

    [JsonProperty("license")] public string license { get; set; }

    [JsonProperty("sourceName")] public string sourceName { get; set; }

    [JsonProperty("pricePerServing")] public double pricePerServing { get; set; }

    [JsonProperty("extendedIngredients")] public IList<ExtendedIngredient> extendedIngredients { get; set; }

    [JsonProperty("id")] public int id { get; set; }

    [JsonProperty("title")] public string title { get; set; }

    [JsonProperty("readyInMinutes")] public int readyInMinutes { get; set; }

    [JsonProperty("servings")] public int servings { get; set; }

    [JsonProperty("sourceUrl")] public string sourceUrl { get; set; }

    [JsonProperty("image")] public string image { get; set; }

    [JsonProperty("imageType")] public string imageType { get; set; }

    [JsonProperty("summary")] public string summary { get; set; }

    [JsonProperty("cuisines")] public IList<object> cuisines { get; set; }

    [JsonProperty("dishTypes")] public IList<string> dishTypes { get; set; }

    [JsonProperty("diets")] public IList<string> diets { get; set; }

    [JsonProperty("occasions")] public IList<object> occasions { get; set; }

    [JsonProperty("winePairing")] public WinePairing winePairing { get; set; }

    [JsonProperty("instructions")] public string instructions { get; set; }

    [JsonProperty("analyzedInstructions")] public IList<AnalyzedInstruction> analyzedInstructions { get; set; }

    [JsonProperty("originalId")] public object originalId { get; set; }

    [JsonProperty("spoonacularSourceUrl")] public string spoonacularSourceUrl { get; set; }
}