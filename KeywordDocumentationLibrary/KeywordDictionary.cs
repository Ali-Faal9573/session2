//namespace KeywordDocumentationLibrary
//{
//    public static class KeywordDictionary
//    {
//        public static KeywordInfoBase GetKeywordInfo(string keyword)
//        {
//switch (keyword.ToLower())
//{
//    case "abstract":
//        return new AbstractKeywordInfo();
//    case "async":
//        return new AsyncKeywordInfo();
//    case "const":
//        return new ConstKeywordInfo();
//    case "event":
//        return new EventKeywordInfo();
//    case "extern":
//        return new ExternKeywordInfo();
//    case "new":
//        return new NewKeywordInfo();
//    case "override":
//        return new OverrideKeuwordInfo();
//    case "partial":
//        return new PartialKeywordInfo();
//    case "readonly":
//        return new ReadonlyKeywordInfo();
//    case "sealed":
//        return new SealedKeywordInfo();
//    case "static":
//        return new StaticKeywordInfo();
//    case "unsafe":
//        return new UnsafeKeywordInfo();
//    case "virtual":
//        return new VirtualKeywordInfo();
//    case "volatile":
//        return new VolatileKeywordInfo();
//    default:
//        return null;
//}
//        }
//    }
//}
using KeywordDocumentationLibrary.Keywords;

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
