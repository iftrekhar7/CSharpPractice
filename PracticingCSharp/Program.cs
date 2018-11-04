using PracticingCSharp.EventDelegate;
using PracticingCSharp.ExtensionMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PracticingCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictator = "Hello world, i am admiral general ALADIN";
            Console.WriteLine(dictator.Shorten(4));

            var video = new Video() { Title = "Testing" };
            var videoEncoder = new VideoEncoder();// Publisher
            var mailService = new MailService();// subscriber
            var messageService = new MessageService();

            videoEncoder.VideoEncoded += mailService.OnVedioEncoded;
            videoEncoder.VideoEncoded += messageService.OnVedioEncoded;

            videoEncoder.Encode(video);

            Console.ReadLine();
        }

       
    }
}
