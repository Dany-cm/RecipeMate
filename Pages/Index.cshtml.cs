using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RecipeMate.Pages.Forms;

namespace RecipeMate.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        [BindProperty] public IndexSearchForm SearchForm { get; set; }

        // retrieve the user input
        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            // pass the information to GetRecipesByIngredients
            
            // GetRecipesByIngredients return a list of recipe
            await Task.Yield();
            return Page();
        }
    }
}