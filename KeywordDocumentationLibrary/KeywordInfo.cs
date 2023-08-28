using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeywordDocumentationLibrary
{
    public class KeywordInfo
    {
        public string Keyword { get; set; }
        public string Description { get; set; }

        public KeywordInfo(string keyword, string description)
        {
            Keyword = keyword;
            Description = description;
        }
    }
}
