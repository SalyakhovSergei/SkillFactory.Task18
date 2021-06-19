using System;
using System.Threading.Tasks;
using YoutubeExplode.Search;

namespace SkillFactory.Task18
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("link please");
            var youtubeCommandSender = new YoutubeCommandSender();
            var receiver = new YoutubeReceiver();

            var command = new YoutubeDownloader(receiver);

            
            string videoURL = Console.ReadLine();
            
            youtubeCommandSender.SetCommand(command);
            await youtubeCommandSender.DownloadVideo(videoURL);
            await youtubeCommandSender.GetNameAndDescription(videoURL);
        }
    }
}
