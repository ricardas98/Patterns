using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            YoutubeService service = new YoutubeService();
            YouTubeServiceClient client = new YouTubeServiceClient(service);

            client.GetInstance().GetVideos();
            client.GetInstance().GetVideos();

            client.GetInstance().OpenVideo("123");
            client.GetInstance().OpenVideo("123");
            client.GetInstance().OpenVideo("153");
            client.GetInstance().OpenVideo("123");
        }
    }
}
