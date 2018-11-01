using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticingCSharp.ExtensionMethod
{
    public static class DictionaryExtension
    {
        // This is the dictionary spread method
        public static void Add<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, IDictionary<TKey, TValue> items)
        {
            foreach (var item in items)
            {
                dictionary[item.Key] = item.Value;
            }
        }


        public static void Add<TKey>(this IDictionary<TKey, int> dictionary, TKey key, params int[] values)
        {
            dictionary.Add(key, values.Aggregate(0, (s, v) => s * 1000 + v));
        }
    }
}
