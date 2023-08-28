using KeywordDocumentationLibrary.Keywords;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeywordDocumentationLibrary
{
    public static class KeywordDictionary
    {
        private static readonly Dictionary<string, Type> KeywordMappings = new Dictionary<string, Type>
        {
            { "abstract", typeof(AbstractKeywordInfo) },
            { "async", typeof(AsyncKeywordInfo) },
            { "const", typeof(ConstKeywordInfo) },
            { "event", typeof(EventKeywordInfo) },
            { "extern", typeof(ExternKeywordInfo) },
            { "new", typeof(NewKeywordInfo) },
            { "override", typeof(OverrideKeuwordInfo) },
            { "partial", typeof(PartialKeywordInfo) },
            { "readonly", typeof(ReadonlyKeywordInfo) },
            { "sealed", typeof(SealedKeywordInfo) },
            { "static", typeof(StaticKeywordInfo) },
            { "unsafe", typeof(UnsafeKeywordInfo) },
            { "virtual", typeof(VirtualKeywordInfo) },
            { "volatile", typeof(VolatileKeywordInfo) }
        };

        public static KeywordInfoBase GetKeywordInfo(string keyword)
        {
            if (KeywordMappings.TryGetValue(keyword.ToLower(), out Type keywordType))
            {
                return (KeywordInfoBase)Activator.CreateInstance(keywordType);
            }

            return null;
        }
    }
}
