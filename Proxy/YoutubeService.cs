/**
 * @(#) YoutubeService.cs
 */
using System;
namespace Proxy
{
    public class YoutubeService : IYouTubeService
    {
        public void GetVideos()
        {
            Console.WriteLine("Fetching videos");
        }

        public void OpenVideo(string id)
        {
            Console.WriteLine("Fetching video " + id);
        }
    }

}
