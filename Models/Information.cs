using Newtonsoft.Json;

namespace RecipeMate.Models;

public class Information
{
    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("title")]
    public string Title { get; set; }

    [JsonProperty("image")]
    public string ImageUrl { get; set; }
    
    [JsonProperty("servings")]
    public int Servings { get; set; }
    
    [JsonProperty("readyinminutes")]
    public int readyInMiunutes { get; set; }
    
    [JsonProperty("summary")]
    public string Summary { get; set; }
}