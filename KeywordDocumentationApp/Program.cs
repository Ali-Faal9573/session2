using KeywordDocumentationLibrary;

namespace KeywordDocumentationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# Modifier Keyword Documentation");

            while (true)
            {
                Console.WriteLine(KeyWordList.showstartingtext());
                string keyword = Console.ReadLine().ToLower();
                if (keyword == "exit")
                {
                    break;
                }
                KeywordInfoBase keywordInfo = KeywordDictionary.GetKeywordInfo(keyword);
                if (keywordInfo != null)
                {
                    keywordInfo.DisplayInfo();
                }
                else
                {
                    Console.WriteLine("Keyword not recognized.");
                }

            }
        }
    }
}
