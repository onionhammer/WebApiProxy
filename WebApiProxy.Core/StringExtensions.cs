using System;
using System.Text.RegularExpressions;

namespace WebApiProxy
{
    public static class StringExtensions
    {
        public static string DefaultIfEmpty(this string self, string value)
        {
            if (String.IsNullOrEmpty(self))
                return value;

            return self;
        }

        public static string StripAsync(this string self) =>
            Regex.Replace(self, "Async$", "");

        public static string ToTitle(this string self) =>
            self.Substring(0, 1).ToUpper() + 
            self.Substring(1, self.Length - 1).ToLower();

        public static string ToCamelCasing(this string self) =>
            self.Replace(self[0].ToString(), self[0].ToString().ToLower());

        /// <summary>
        /// Transform the string to the XML documentation expected format respecting the new lines.
        /// </summary>
        /// <param name="description">The description.</param>
        /// <returns>The xml documentation format.</returns>
        public static string ToSummary(this string description) =>
            Regex.Replace(description, "\n\\s*", "\n\t\t/// ")
                 .Replace("&", "&amp;").Replace("<", "&lt;")
                 .Replace(">", "&gt;").Replace("\"", "&quot;")
                 .Replace("'", "&apos;");

        /// <summary>
        /// Ensures common return types are made conrete
        /// </summary>
        public static string ToConcrete(this string returnType)
        {
            if (string.IsNullOrWhiteSpace(returnType))
                return returnType;

            string[] commonTypes = { 
                "IQueryable", 
                "IList", 
                "IEnumerable"
            };

            foreach (var type in commonTypes)
            {
                var replaced = Regex.Replace(returnType, type + @"\<(.+)\>", "List<$1>");

                if (replaced.Length != returnType.Length)
                    return replaced;
            }

            return returnType;
        }
    }
}
