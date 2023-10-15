namespace RecipeMate.Models
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

        public async Task<IEnumerable<string>> GetRecipesByIngredients(string ingredients)
        {
            var httpClient = _httpClientFactory.CreateClient();
            var apiKey = _configuration["ApiKey"];

            var url = $"https://api.spoonacular.com/recipes/findByIngredients?ingredients={ingredients}&number=10&apiKey={apiKey}";
            var response = await httpClient.GetAsync(url);

            response.EnsureSuccessStatusCode();
            var responseBody = await response.Content.ReadAsStringAsync();
            return responseBody.Split(',');
        }
    }
}
