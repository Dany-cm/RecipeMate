using Newtonsoft.Json;

namespace RecipeMate.Models.Information;

public class WinePairing
{
    [JsonProperty("pairedWines")] public IList<string> pairedWines { get; set; }

    [JsonProperty("pairingText")] public string pairingText { get; set; }

    [JsonProperty("productMatches")] public IList<ProductMatch> productMatches { get; set; }
}