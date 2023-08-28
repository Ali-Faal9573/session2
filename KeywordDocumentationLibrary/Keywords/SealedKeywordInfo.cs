using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeywordDocumentationLibrary.Keywords
{
    public class SealedKeywordInfo : KeywordInfoBase
    {
        public SealedKeywordInfo() : base("In c#, sealed is a keyword used to stop inheriting the particular class from other classes. We can also prevent overriding particular properties or methods based on our requirements.Generally, when we create a particular class we can inherit all the properties and methods in any class. If you want to restrict access to a defined class and its members, then by using a sealed keyword, we can prevent other classes from inheriting the defined class.")
        {
            Keyword = "sealed";
        }
    }
}
