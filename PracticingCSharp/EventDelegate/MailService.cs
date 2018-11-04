using System;

namespace PracticingCSharp.EventDelegate
{
    public class MailService
    {
        public void OnVedioEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine($"MailService: Sending an email...{e.Video.Title}");
        }
    }
}
