using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeywordDocumentationLibrary.Keywords
{
    public class VirtualKeywordInfo : KeywordInfoBase
    {
        public VirtualKeywordInfo() :base("The virtual keyword is used to modify a method, property, indexer, or event declaration and allow for it to be overridden in a derived class.")
        {
            Keyword = "virtual";
        }
    }
}
