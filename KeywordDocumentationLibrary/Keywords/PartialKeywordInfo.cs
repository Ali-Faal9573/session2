using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeywordDocumentationLibrary.Keywords
{
    public class PartialKeywordInfo : KeywordInfoBase
    {
        public PartialKeywordInfo() : base("In C#, you can split the implementation of a class, a struct, a method, or an interface in multiple .cs files using the partial keyword. The compiler will combine all the implementation from multiple .cs files when the program is compiled.")
        {
            Keyword = "partial";
        }
    }
}
