﻿using Microsoft.AspNetCore.Mvc;
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

        public List<Recipe>? Recipes { get; set; }
        public List<Information>? Informations { get; set; }

        // retrieve the user input
        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            
            // pass the information to GetRecipesByIngredients
            // GetRecipesByIngredients return a list of recipe
            Recipes = await _recipes.GetRecipesByIngredients(SearchForm.Ingredients!);

            // Informations = await _recipes.GetRecipeInformation();
            
            return Page();
        }
    }
}