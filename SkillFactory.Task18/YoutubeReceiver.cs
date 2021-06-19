using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Converter;
using YoutubeExplode.Videos.Streams;

namespace SkillFactory.Task18
{
    public class YoutubeReceiver
    {
        private YoutubeClient _youtubeClient = new YoutubeClient();
        
        public async Task GetNameAndDescription(string url)
        {
            var video = await _youtubeClient.Videos.GetAsync(url);
            string title = video.Title;
            string description = video.Description;
            Console.WriteLine(title + description);
            Console.WriteLine("link please");
        }

        public async Task DownloadVideo(string url)
        {
           await _youtubeClient.Videos.DownloadAsync(url, "C:/Users/admin/Desktop/task18/video.mp4");
        }
    }
}