using System.Collections.Generic;
using System.Linq;

namespace PracticingCSharp.ExtensionMethod
{
    public static class ListExtension
    {
        public static void Add<T>(this List<T> list, IEnumerable<T> items) => list.AddRange(items);

        public static void Add<T>(this List<T> list, params T[] items) => list.AddRange(items);
       
    }
}
