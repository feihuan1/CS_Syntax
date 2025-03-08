using System.Text;
using System.Threading.Tasks;


namespace StingOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            //   \t TAB   \n newline   \"escape
            //--------------------- escape
            string speech = "He said \"Somethin\"";//He said "Somethin"
            System.Console.WriteLine(speech);

            // escape
            string path = "C:\\Users\\CoffeeNCode\\Desktop\\C#\n new line test"; // C:\Users\CoffeeNCode\Desktop\C#
            System.Console.WriteLine(path);

            //----------------- @  Verbatim String Literals ignore escape slash
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
            // string concatenation
            System.Console.WriteLine("string1 " + "string2");

            // string interpolation
            string name = "Eric";
            System.Console.WriteLine($"my name is {name}");

            //---------------------- string formatting 
            int age = 36;
            System.Console.WriteLine("Name: " + name);
            System.Console.WriteLine("Age: " + age);
            System.Console.WriteLine("your name is {0}, age is {1}", name, age);
            System.Console.WriteLine($"your name is {name}, age is {age}");


            //``````````````````````````string interpolation
            System.Console.WriteLine($"your name is {name}, age is {age}");

            //----------concat

            string test = string.Concat("your name is ", name, " and your age is ", age);

            // concat array

            string[] names = new string[] {"eric", "ada", "alex"};
            System.Console.WriteLine(string.Concat(names));// no space
        }
    }
}