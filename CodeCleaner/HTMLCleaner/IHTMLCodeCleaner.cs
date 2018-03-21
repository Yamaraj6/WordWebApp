using System.Collections.Generic;

namespace CodeCleaner.HTMLCleaner
{
    public interface IHTMLCodeCleaner
    {
        string ClearTextFromCode(string text, List<ICleaner> textCleaner);
    }
}
