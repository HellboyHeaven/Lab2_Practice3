using System.Text.RegularExpressions;

namespace Utilities;

public static class StringExtensions
{
    public static string ToSnakeCase(this string text)
    {
        return Regex.Replace(text.Trim(), @"\W+", " ")  // Replace non-word characters with space
                    .ToLower()                           // Convert to lowercase
                    .Trim()                              // Trim again in case of leading/trailing spaces
                    .Replace(" ", "_"); ;
    }
}