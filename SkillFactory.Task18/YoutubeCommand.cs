using System.Threading.Tasks;

namespace SkillFactory.Task18
{
    public abstract class YoutubeCommand
    {
        public abstract Task GetNameAndDescription(string url);
        public abstract Task DownloadVideo(string url);
    }
}