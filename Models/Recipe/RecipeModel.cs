using Newtonsoft.Json;

namespace RecipeMate.Models;

public class RecipeModel
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
    public List<IngredientModel> MissedIngredients { get; set; }
    
    [JsonProperty("usedIngredients")]
    public List<IngredientModel> UsedIngredients { get; set; }
    
    [JsonProperty("unusedIngredients")]
    public List<IngredientModel> UnusedIngredients { get; set; }
    
    [JsonProperty("likes")]
    public int Likes { get; set; }
}