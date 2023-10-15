using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RecipeMate.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        /* retrieve the user input
        public void OnGet()
        {
            // pass the information to GetRecipesByIngredients
            
            // GetRecipesByIngredients return a list of recipe

        }
        */
    }
}