using Newtonsoft.Json;
using RecipeMate.Models;
using RecipeMate.Models.Information;

namespace RecipeMate.Repositories
{
    public class RecipeRepository
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public RecipeRepository(IHttpClientFactory httpClientFactory, IConfiguration configuration)
        {
            _httpClientFactory = httpClientFactory ?? throw new ArgumentNullException(nameof(httpClientFactory));
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }

        public async Task<List<RecipeModel>?> GetRecipesByIngredients(string ingredients)
        {
            var httpClient = _httpClientFactory.CreateClient();
            var apiKey = _configuration["ApiKey"];

            var url = $"https://api.spoonacular.com/recipes/findByIngredients?ingredients={ingredients}&number=12&apiKey={apiKey}";
            var response = await httpClient.GetAsync(url);

            response.EnsureSuccessStatusCode();
            var responseBody = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<RecipeModel>>(responseBody);
        }
        
        public async Task<RecipeInfo?> GetRecipeInformation(int id)
        {
            var httpClient = _httpClientFactory.CreateClient();
            var apiKey = _configuration["ApiKey"];

            var url = $"https://api.spoonacular.com/recipes/{id}/information?includeNutrition=false&apiKey={apiKey}";
            var response = await httpClient.GetAsync(url);

            response.EnsureSuccessStatusCode();
            var responseBody = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<RecipeInfo?>(responseBody);
        }
    }
}
