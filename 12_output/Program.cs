using System.Text;
using System.Threading.Tasks;


namespace Output
{
    class Program
    {
        static void Main(string[] args)
        {
            //   \t TAB   \n newline   \"escape
            // escape
            string speech = "He said \"Somethin\"";//He said "Somethin"
            System.Console.WriteLine(speech);

            // escape
            string path = "C:\\Users\\CoffeeNCode\\Desktop\\C#\n new line test"; // C:\Users\CoffeeNCode\Desktop\C#
            System.Console.WriteLine(path);

            // @  Verbatim String Literals ignore escape slash
            //The @ symbol allows you to write multi-line strings and include special characters (like backslashes \) without escaping them.
            path = @"C:\\Users\\CoffeeNCode\\Desktop\\C#"; //C:\\Users\\CoffeeNCode\\Desktop\\C#
            System.Console.WriteLine(path);

            string multiLine = @"This is line 1
This is line 2
This is line 3";
            Console.WriteLine(multiLine);
            
            // escape " in Verbatim String
            string quote = @"he said ""Hello""";
            System.Console.WriteLine(quote);

            // @ can also escaping reserved keyword identifier
            // without @, class is a class creator
            int @class = 10;
            System.Console.WriteLine(@class);

            // $ +
            // string concatination
            System.Console.WriteLine("string1 " + "string2");

            // string Literals
            string name = "Eric";
            System.Console.WriteLine($"my name is {name}");
        }
    }
}