using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeywordDocumentationLibrary
{
    public abstract class KeywordInfoBase
    {
        public string Keyword { get; protected set; }
        public string Description { get; protected set; }
        public KeywordInfoBase(string description)
        {
            Description = description;
        }
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Keyword: {Keyword}");
            Console.WriteLine($"Description: {Description}");
        }
    }
}
