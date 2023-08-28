using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeywordDocumentationLibrary.Keywords
{
    public class AbstractKeywordInfo : KeywordInfoBase
    {
        public AbstractKeywordInfo() : base("The 'abstract' keyword is used to define an abstract class or method. Abstract classes cannot be instantiated and are meant to be subclassed.")
        {
            Keyword = "abstract";
        }
    }
}
