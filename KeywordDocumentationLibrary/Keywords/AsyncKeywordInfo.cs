using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeywordDocumentationLibrary.Keywords
{
    public class AsyncKeywordInfo : KeywordInfoBase
    {
        public AsyncKeywordInfo() : base("The 'async' keyword is used to indicate that a method contains asynchronous code and can use the 'await' keyword to pause execution without blocking the thread.")
        {
            Keyword = "async";
        }
    }
}
