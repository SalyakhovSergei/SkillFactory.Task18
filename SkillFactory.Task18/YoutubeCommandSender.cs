namespace SkillFactory.Task18
{
    public class YoutubeCommandSender
    {
        private YoutubeCommand _youtubeCommand;

        public void SetCommand(YoutubeCommand youtubeCommand)
        {
            _youtubeCommand = youtubeCommand;
        }

        public void GetNameAndDescription()
        {
            _youtubeCommand.GetNameAndDescription();
        }
        public void DownloadVideo()
        {
            _youtubeCommand.DownloadVideo();
        }
    }
}