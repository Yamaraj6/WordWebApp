using System.Collections.Generic;

namespace Crawler
{
    public interface IWordsCrawler
    {
        Dictionary<string, int> GetWordsStatistics(string websiteUrl);
    }
}