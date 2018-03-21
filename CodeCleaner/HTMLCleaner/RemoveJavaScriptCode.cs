using HtmlAgilityPack;

namespace CodeCleaner.HTMLCleaner
{
    public class RemoveJavaScriptCode : ICleaner
    {
        public string Clean(string text)
        {
            HtmlDocument htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(text);
            var htmlNodes = htmlDoc.DocumentNode.SelectNodes("//script|//style");

            foreach (var node in htmlNodes)
            {
                node.ParentNode.RemoveChild(node);
            }

            return htmlDoc.DocumentNode.OuterHtml;
        }
    }
}
