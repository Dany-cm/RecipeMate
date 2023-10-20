using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RecipeMate.Models;
using RecipeMate.Pages.Forms;
using RecipeMate.Repositories;

namespace RecipeMate.Pages
{
    public class IndexModel : PageModel
    {
        private readonly RecipeRepository _recipes;

        public IndexModel(RecipeRepository recipes)
        {
            _recipes = recipes;
        }

        [BindProperty] public IndexSearchForm SearchForm { get; set; }

        public List<RecipeModel>? Recipes { get; set; }
        
        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            
            Recipes = await _recipes.GetRecipesByIngredients(SearchForm.Ingredients!);

            return Page();
        }
    }
}