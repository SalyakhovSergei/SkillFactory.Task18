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

            Console.WriteLine("Укажите ссылку на видео");
            string videoURL = Console.ReadLine();
            
            youtubeCommandSender.SetCommand(command);
            youtubeCommandSender.DownloadVideo(videoURL);
            youtubeCommandSender.GetNameAndDescription();
        }
    }
}
