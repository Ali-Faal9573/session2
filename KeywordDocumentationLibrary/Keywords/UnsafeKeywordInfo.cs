using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeywordDocumentationLibrary.Keywords
{
    public class UnsafeKeywordInfo : KeywordInfoBase
    {
        public UnsafeKeywordInfo() : base("Most of the C# code you write is \"verifiably safe code.\" Verifiably safe code means .NET tools can verify that the code is safe. In general, safe code doesn't directly access memory using pointers. It also doesn't allocate raw memory. It creates managed objects instead.\r\n\r\nC# supports an unsafe context, in which you may write unverifiable code. In an unsafe context, code may use pointers, allocate and free blocks of memory, and call methods using function pointers. Unsafe code in C# isn't necessarily dangerous; it's just code whose safety cannot be verified.")
        {
            Keyword = "unsafe";
        }
    }
}
