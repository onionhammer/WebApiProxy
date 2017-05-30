using System;
using System.Linq;

namespace WebApiProxy
{
    public static class TypeExtensions
    {
        public static bool IsExcluded(this Type self) =>
            self.GetCustomAttributes(true).OfType<ExcludeProxy>().Any();
    }
}
