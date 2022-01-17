/**
 * @(#) YouTubeServiceClient.cs
 */

namespace Proxy
{
	public class YouTubeServiceClient
	{
		private IYouTubeService proxy;

		public YouTubeServiceClient(YoutubeService service)
        {
			proxy = new ProxyYouTubeService(service);
        }
		
		public IYouTubeService GetInstance()
        {
			return proxy;
        }
	}
	
}
