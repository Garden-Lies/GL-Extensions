using System.Linq;

namespace Codomaster.Extensions
{

    /// <summary>
    /// Etend les fonctionnalités de la classe string.
    /// </summary>
    public static class StringExtensions
    {

        /// <summary>
        /// Converti les chaînes de caractères en snake_case..
        /// https://gist.github.com/vkobel/d7302c0076c64c95ef4b
        /// </summary>
        /// <param name="str"></param>
        /// <returns>str</returns>
        static string ToSnakeCase(this string str) =>
        string.Concat(
            str.Select((x, i) =>
                i > 0 && char.IsUpper(x) && (char.IsLower(str[i - 1]) || i < str.Length - 1 && char.IsLower(str[i + 1]))
                    ? "_" + x
                    : x.ToString())).ToLowerInvariant();
    }
}