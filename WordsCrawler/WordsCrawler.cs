using CodeCleaner.HTMLCleaner;
using System.Collections.Generic;

namespace Crawler
{
    public class WordsCrawler : IWordsCrawler
    {
        private IContentDownloader contentDownloader;
        private IHTMLCodeCleaner hTMLCodeCleaner;
        private List<ICleaner> textCleaner;

        public WordsCrawler(IContentDownloader contetDownloader, IHTMLCodeCleaner hTMLCodeCleaner)
        {
            this.contentDownloader = contetDownloader;
            this.hTMLCodeCleaner = hTMLCodeCleaner;
        }

        public Dictionary<string, int> GetWordsStatistics(string websiteUrl)
        {
            string websiteText = contentDownloader.DownloadContent(websiteUrl);

            if (websiteText == null)
            {
                return null;
            }
            MakeCleanerList();

            websiteText = hTMLCodeCleaner.ClearTextFromCode(websiteText, textCleaner);
            var wordsStats = websiteText.CreateWordsDictionary();
            return wordsStats.Sort();
        }

        public void MakeCleanerList()
        {
            textCleaner = new List<ICleaner>();
            textCleaner.Add(new RemoveJavaScriptCode());
            textCleaner.Add(new RemoveHtmlTags());
            textCleaner.Add(new RemovePunctuationCharacters());
            textCleaner.Add(new RemoveNumbers());
        }
    }
}