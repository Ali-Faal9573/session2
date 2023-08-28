
namespace KeywordDocumentationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# Modifier Keyword Documentation");

            while (true)
            {
                Console.WriteLine("\nEnter a keyword to get its explanation (or 'exit' to quit):");
                string keyword = Console.ReadLine().ToLower();

                if (keyword == "exit")
                    break;

                switch (keyword)
                {
                    case "abstract":
                        Console.WriteLine("he 'abstract' keyword is used to define an abstract class or method. Abstract classes cannot be instantiated and are meant to be subclassed.");
                        break;
                    case "async":
                        Console.WriteLine("The 'async' keyword is used to indicate that a method contains asynchronous code and can use the 'await' keyword to pause execution without blocking the thread.");
                        break;
                    case "const":
                        Console.WriteLine("You use the const keyword to declare a constant field or a local constant. Constant fields and locals aren't variables and may not be modified. Constants can be numbers, Boolean values, strings, or a null reference. Don’t create a constant to represent information that you expect to change at any time. For example, don’t use a constant field to store the price of a service, a product version number, or the brand name of a company. These values can change over time, and because compilers propagate constants, other code compiled with your libraries will have to be recompiled to see the changes.");
                        break;
                    case "event":
                        Console.WriteLine("The 'event' keyword is used to declare an event, which allows objects to communicate and react to actions or changes.");
                        break;
                    default:
                        Console.WriteLine("Keyword not recognized.");
                        break;
                }
            }
        }
    }
}
