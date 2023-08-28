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
                Console.WriteLine("\nEnter a Keyword to get its explanation (or 'exit' to quit):");
                string keyword = Console.ReadLine().ToLower();

                if (keyword == "exit")
                {
                    break;
                }

                KeywordInfo keywordInfo = KeywordDictionary.GetKeywordInfo(keyword);
                if (keywordInfo != null)
                {
                    Console.WriteLine($"Keyword: {keywordInfo.Keyword}");
                    Console.WriteLine($"Description: {keywordInfo.Description}");
                }
                else
                {
                    Console.WriteLine("Keyword not recognized.");
                }

            }
        }
    }
}
