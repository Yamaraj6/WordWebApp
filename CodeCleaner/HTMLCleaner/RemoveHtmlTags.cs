using HtmlAgilityPack;

namespace CodeCleaner.HTMLCleaner
{ 
    public class RemoveHtmlTags:ICleaner
    {
        public string Clean(string text)
        {
            HtmlDocument htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(text);
            return htmlDoc.DocumentNode.InnerText;
        }
    }
}
