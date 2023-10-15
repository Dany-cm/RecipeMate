using System.ComponentModel.DataAnnotations;

namespace RecipeMate.Pages.Forms;

public class IndexSearchForm
{
    [Required] public string? Ingredients { get; set; }
}