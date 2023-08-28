using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeywordDocumentationLibrary
{
    public class KeywordDictionary
    {
        private static readonly Dictionary<string, string> Keywords = new Dictionary<string, string>
        {
            { "abstract", "The 'abstract' keyword is used to define an abstract class or method. Abstract classes cannot be instantiated and are meant to be subclassed." },
            { "async", "The 'async' keyword is used to indicate that a method contains asynchronous code and can use the 'await' keyword to pause execution without blocking the thread." },
            { "const", "The 'const' keyword is used to declare a constant field that cannot be modified after it is assigned a value." },
            { "event", "The 'event' keyword is used to declare an event, which allows objects to communicate and react to actions or changes." },
        };

        public static KeywordInfo GetKeywordInfo(string keyword)
        {
            if (Keywords.ContainsKey(keyword))
            {
                return new KeywordInfo(keyword, Keywords[keyword]);
            }
            return null;
        }
    }
}
