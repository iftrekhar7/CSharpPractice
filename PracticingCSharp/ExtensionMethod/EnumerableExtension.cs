using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace PracticingCSharp.ExtensionMethod
{
    public static class EnumerableExtension
    {
        public static TaskAwaiter<T[]> GetAwaiter<T>(this IEnumerable<Task<T>> manyTasks)=> Task.WhenAll(manyTasks).GetAwaiter();
    }
}
