using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeywordDocumentationLibrary.Keywords
{
    public class NewKeywordInfo : KeywordInfoBase
    {
        public NewKeywordInfo() : base("When used as a declaration modifier, the new keyword explicitly hides a member that is inherited from a base class. When you hide an inherited member, the derived version of the member replaces the base class version. This assumes that the base class version of the member is visible, as it would already be hidden if it were marked as private or, in some cases, internal. Although you can hide public or protected members without using the new modifier, you get a compiler warning. If you use new to explicitly hide a member, it suppresses this warning.\r\n\r\nYou can also use the new keyword to create an instance of a type or as a generic type constraint.\r\n\r\nTo hide an inherited member, declare it in the derived class by using the same member name, and modify it with the new keyword.")
        {
            Keyword = "new";
        }
    }
}
