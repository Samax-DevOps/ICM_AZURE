using System.Text.RegularExpressions;

namespace ICM.WebSites.Extensions;

public static partial class StringExtensions
{
    public static string? RemoveSpaces(this string? value)
    {
        return value != null ? WhiteSpaceRegex().Replace(value, "") : null;
    }

    [GeneratedRegex("\\s+")]
    private static partial Regex WhiteSpaceRegex();
}