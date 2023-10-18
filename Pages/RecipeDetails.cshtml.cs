using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RecipeMate.Models.Information;
using RecipeMate.Repositories;

namespace RecipeMate.Pages;

public class RecipeDetails : PageModel
{
    private readonly RecipeRepository _recipes;

    public RecipeDetails(RecipeRepository recipes)
    {
        _recipes = recipes;
    }
    
    public List<RecipeInfo>? Informations { get; set; }
        
    public async Task<IActionResult> OnGet()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }
        
        int recipeId = int.Parse(HttpContext.Request.Query["id"]);
    
        Informations = await _recipes.GetRecipeInformation(recipeId)!;
        
        return Page();
    }
}