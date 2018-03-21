using System.Text.RegularExpressions;

namespace CodeCleaner.HTMLCleaner
{
    public class RemovePunctuationCharacters : ICleaner
    {
        public string Clean(string text)
        {
            return Regex.Replace(text, @"[^\w\s]", " ");
        }
    }
}
