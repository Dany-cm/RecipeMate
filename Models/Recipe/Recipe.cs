using Newtonsoft.Json;

namespace RecipeMate.Models;

public class Recipe
{
    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("title")]
    public string Title { get; set; }

    [JsonProperty("image")]
    public string ImageUrl { get; set; }

    [JsonProperty("usedIngredientCount")]
    public int UsedIngredientCount { get; set; }

    [JsonProperty("missedIngredientCount")]
    public int MissedIngredientCount { get; set; }

    [JsonProperty("missedIngredients")]
    public List<Ingredient> MissedIngredients { get; set; }
    
    [JsonProperty("usedIngredients")]
    public List<Ingredient> UsedIngredients { get; set; }
    
    [JsonProperty("unusedIngredients")]
    public List<Ingredient> UnusedIngredients { get; set; }
    
    [JsonProperty("likes")]
    public int Likes { get; set; }
}