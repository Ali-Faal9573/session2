using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeywordDocumentationLibrary.Keywords
{
    public class ExternKeywordInfo : KeywordInfoBase
    {
        public ExternKeywordInfo() : base("The extern modifier is used to declare a method that is implemented externally. A common use of the extern modifier is with the DllImport attribute when you are using Interop services to call into unmanaged code. In this case, the method must also be declared as static")
        {
            Keyword = "extern";
        }
    }
}
