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
        
        public async Task GetVideoInfo()
        {
            var video = await _youtubeClient.Videos.GetAsync("www");
            string title = video.Title;
            string description = video.Description;
            Console.WriteLine(title + description);
        }

        public async Task DownloadVideo(string url, string filePath)
        {
            await _youtubeClient.Videos.DownloadAsync(url, filePath);
        }
    }
}