/**
 * @(#) ProxyYouTubeService.cs
 */
using System;
namespace Proxy
{
    public class ProxyYouTubeService : IYouTubeService
    {
        YoutubeService service;

        bool videos;
        string activeVideo;

        public ProxyYouTubeService(YoutubeService service)
        {
            this.service = service;
            videos = false;
            activeVideo = "";
        }
        public void GetVideos()
        {

            if (!videos)
            {
                service.GetVideos();
                videos = true;
                Console.WriteLine("Returing fetched videos");
            }
            else
            {
                Console.WriteLine("Returing cached videos");
            }
        }

        public void OpenVideo(string id)
        {
            if (activeVideo.Length == 0 || !activeVideo.Equals(id))
            {
                service.OpenVideo(id);
                activeVideo = id;
                Console.WriteLine("Opening fetched video " + activeVideo);
            }
            else
            {
                Console.WriteLine("Opening cached video " + activeVideo);
            }
        }
    }

}
