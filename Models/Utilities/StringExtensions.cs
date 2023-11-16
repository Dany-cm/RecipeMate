using Slugify;

namespace RecipeMate.Models.Utilities;

public static class StringExtensions
{
    public static string ToSlug(this string title)
    {
        SlugHelper helper = new SlugHelper();
        return helper.GenerateSlug(title);
    }

    public static string ToUserFriendlyString(this bool value)
    {
        return value ? "yes" : "no";
    }
    
}