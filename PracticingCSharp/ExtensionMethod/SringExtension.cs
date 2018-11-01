using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PracticingCSharp.ExtensionMethod
{
    public static class SringExtension
    {
        public static TaskAwaiter<string> GetAwaiter(this string str) => Task.FromResult(str).GetAwaiter();

        public static string Shorten(this string str, int numberOfWords)
        {
            if(numberOfWords < 0)
                throw new ArgumentOutOfRangeException("number of words should be greater than or equal to zero");
            if (numberOfWords == 0)
                return "";

            var words = str.Split(' ');

            if (words.Length <= numberOfWords)
                return str;

            return string.Join(" ", words.Take(numberOfWords)) + "......";
        }
    }
}
