using System.Text.RegularExpressions;

namespace CodeCleaner.HTMLCleaner
{
    public class RemoveNumbers : ICleaner
    {
        public string Clean(string text)
        {
            return Regex.Replace(text, @"\b(\d+)\b", "");
        }
    }
}
