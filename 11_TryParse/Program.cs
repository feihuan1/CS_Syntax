using System.Text;
using System.Threading.Tasks;

// display diferent currency, give diferenct curreny by input country code
using System.Globalization;

namespace TryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            // System.Console.Write("Enter a Number: ");
            // string numInput = Console.ReadLine() ?? "";
            //    int num = Convert.ToInt32(numInput); // if user input a letter, it will throw runtime error FormatException
            // int num;

            // try parse numInput, output the value into num, if can't, it will be !!!0!!!
            // bool isValid = int.TryParse(numInput, out num);


            // // cant check falsy value using if(!num)
            // if (!isValid)
            // {
            //     System.Console.WriteLine("you entered a letter");
            // }
            // else
            // {
            //     System.Console.WriteLine(num);
            // }


            // tryParse return a boolean, but int cant use as implicit boolean like JS or PY
            // if (int.TryParse(numInput, out num))
            // {
            //     System.Console.WriteLine(num);
            // }
            // else
            // {
            //     System.Console.WriteLine("you entered a letter");
            // }


            bool success = true;

            while (success)
            {
                System.Console.Write("Enter a Number: ");
                string numInput = Console.ReadLine() ?? "";

                // create a variable in try parse
                if (int.TryParse(numInput, out int num2))
                {
                    success = false;
                    System.Console.WriteLine(num2);
                }
                else
                {
                    System.Console.WriteLine("you entered a letter");
                }
                // num2 is accessable out side the tryParse block but not outside while loop
                System.Console.WriteLine(num2);
            }

            // this works
            System.Console.WriteLine(Convert.ToBoolean(0));
            System.Console.WriteLine(Convert.ToBoolean(1));
        }
    }
}