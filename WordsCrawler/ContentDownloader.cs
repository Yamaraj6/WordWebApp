using System.Net;

namespace Crawler
{
    public class ContentDownloader : IContentDownloader
    {
        public string DownloadContent(string websiteUrl)
        {
            try
            {
                WebClient webClient = new WebClient();
                if (websiteUrl != null)
                {
                    var webContent = webClient.DownloadString(websiteUrl);
                    return webContent;
                }
                return null;
            }
            catch (WebException)
            {
                return null;
            }

        }
    }
}