using System.Threading.Tasks;

namespace SkillFactory.Task18
{
    public class YoutubeCommandSender
    {
        private YoutubeCommand _youtubeCommand;

        public void SetCommand(YoutubeCommand youtubeCommand)
        {
            _youtubeCommand = youtubeCommand;
        }

        public async Task GetNameAndDescription(string url)
        {
            await _youtubeCommand.GetNameAndDescription(url);
        }
        public async Task DownloadVideo(string url)
        {
            await _youtubeCommand.DownloadVideo(url);
        }
    }
}