using System.Threading.Tasks;
using YoutubeExplode.Search;
using YoutubeExplode.Videos;

namespace SkillFactory.Task18
{
    public class YoutubeDownloader: YoutubeCommand
    {
        YoutubeReceiver youtubeReceiver;

        public YoutubeDownloader(YoutubeReceiver youtubeReceiver)
        {
            this.youtubeReceiver = youtubeReceiver;
        }
        public override async Task GetNameAndDescription(string url)
        {
            await youtubeReceiver.GetNameAndDescription(url);
        }
        public override async Task DownloadVideo(string url)
        {
           await youtubeReceiver.DownloadVideo(url);
        }
    }
}