using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RecipeMate.Models.Information;
using RecipeMate.Services;

namespace RecipeMate.Pages;

public class RecipeDetails : PageModel
{
    private readonly RecipeService _recipes;

    public RecipeDetails(RecipeService recipes)
    {
        _recipes = recipes;
    }

    public RecipeInfo? Information { get; set; }

    public async Task<IActionResult> OnGet(string slug)
    {
        // This regex will match a string like "123-recipe-name" and extract the recipe ID and name
        var regex = new Regex(@"(?<id>\d+)-(?<recipe>.+)");
        var matches = regex.Match(slug);
        // If the slug doesn't match the regex, return a 404
        if (!matches.Success)
        {
            return NotFound();
        }

        var id = int.Parse(matches.Groups["id"].Value);
        // Recipe is currently unused, but I've left it here as an example.
        var recipe = matches.Groups["recipe"].Value;

        Information = await _recipes.GetRecipeInformation(id);

        return Page();
    }
}