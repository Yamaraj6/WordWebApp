using System;
using System.Collections.Generic;
using System.Linq;

namespace Crawler
{
    public static class ExtensionMethods
    {
        public static Dictionary<string, int> Sort(this Dictionary<string, int> dictionary)
        {
            return dictionary.OrderBy(x => -x.Value).ToDictionary(x => x.Key, x => x.Value);
        }
        
        public static Dictionary<string, int> CreateWordsDictionary(this string text)
        {
            Dictionary<string, int> wordsDictionary = new Dictionary<string, int>();
            List<string> list = text.DivideTextIntoWords();

            foreach (var word in list)
            {
                if (wordsDictionary.ContainsKey(word))
                {
                    wordsDictionary[word]++;
                }
                else
                {
                    wordsDictionary.Add(word, 1);
                }
            }
            return wordsDictionary;
        }
        
        public static List<string> DivideTextIntoWords(this string text)
        {
            return new List<string>(text.Split(new[] { " ", "\n" }, StringSplitOptions.RemoveEmptyEntries));
        }
    }
}
