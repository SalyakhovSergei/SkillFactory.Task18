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
        public override void GetNameAndDescription()
        {
            youtubeReceiver.GetVideoInfo();
        }
        public override void DownloadVideo(string url)
        {
            youtubeReceiver.DownloadVideo(url);
        }
    }
}