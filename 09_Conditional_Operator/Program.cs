using System.Text;
using System.Threading.Tasks;

namespace ConditionalOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = -1;

            // if(age >= 0)
            // {
            //     System.Console.WriteLine("valid");
            // }
            // else{
            //     System.Console.WriteLine("Invalid");
            // }

            // condition ? true : false
            bool isValid = age >= 0 ? true : false;
            // bool isValid = age >= 0;

            string output = age < 18 ? "kids" : age < 26 ? "teen" : age < 65 ? "Adult" : "senior";
            // notice the () inside {}
            System.Console.WriteLine($"{(isValid ? output : "invalid")}");
        }
    }
}