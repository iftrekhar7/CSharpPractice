using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticingCSharp.EventDelegate
{
    public class MessageService
    {
        public void OnVedioEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine($"MessageService: Sending a Message...{e.Video.Title}");

            Func<int, IEnumerable<int>> PrimeNumbers = max =>
                from i in Enumerable.Range(2, max - 1).AsParallel()
                where Enumerable.Range(2, i - 2).All(j => i % j != 0)
                select i;


        }
    }
}
