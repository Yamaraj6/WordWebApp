using System.Collections.Generic;

namespace CodeCleaner.HTMLCleaner
{
    public class HTMLCodeCleaner : IHTMLCodeCleaner
    {
        public string ClearTextFromCode(string text, List<ICleaner> textCleaner)
        {
            foreach (var cleaner in textCleaner)
            {
                text = cleaner.Clean(text);
            }

            return text;
        }
    }
}
