using System;
using YoutubeExplode.Search;

namespace SkillFactory.Task18
{
    class Program
    {
        static void Main(string[] args)
        {
            var youtubeCommandSender = new YoutubeCommandSender();
            var receiver = new YoutubeReceiver();

            var command = new YoutubeDownloader(receiver);
            
            youtubeCommandSender.SetCommand(command);
            youtubeCommandSender.DownloadVideo();
            youtubeCommandSender.GetNameAndDescription();
        }
    }
}
