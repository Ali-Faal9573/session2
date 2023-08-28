using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeywordDocumentationLibrary.Keywords
{
    public class OverrideKeuwordInfo : KeywordInfoBase
    {
        public OverrideKeuwordInfo() : base("The override modifier is required to extend or modify the abstract or virtual implementation of an inherited method, property, indexer, or event.")
        {
            Keyword = "override";
        }
    }
}
