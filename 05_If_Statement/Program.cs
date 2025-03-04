using System.Text;
using System.Threading.Tasks;

namespace IfStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            // #region check age
                
            // Console.Write("Enter Your Name: ");
            // string name = Console.ReadLine() ?? "";

            // Console.Write("Enter Your Name: ");
            // string ageInput = Console.ReadLine() ?? "";
            // int age = Convert.ToInt32(ageInput);


            // if (age < 0 || age > 150)
            // {
            //     System.Console.WriteLine("Invalid age");
            // }
            // else
            // {
            //     if (age >= 18 && age < 25)
            //     {
            //         System.Console.WriteLine("you are adult");
            //     }
            //     else if (age >= 25)
            //     {
            //         System.Console.WriteLine("you are 25 or older");
            //     }
            // }

            // Console.WriteLine();
            // Console.WriteLine($"Your name is {name} and your age is {age}");
            // #endregion

            #region Maths game
            System.Console.WriteLine("Enter first number");
            string firstInput = Console.ReadLine() ?? "0";
            int firstNum = Convert.ToInt32(firstInput);

            System.Console.WriteLine("Enter first number");
            string secondInput = Console.ReadLine() ?? "0";
            int secondNum = Convert.ToInt32(secondInput);

            int answer = firstNum * secondNum;
            
            System.Console.WriteLine($"Whats the answer of {firstNum} X {secondNum}");
            string userAnswerInput = Console.ReadLine() ?? "0";
            int userAnswer = Convert.ToInt32(userAnswerInput);

            if(userAnswer == answer)
            {
                System.Console.WriteLine("\n!!!Well done!!!");
            }
            else
            {
                System.Console.WriteLine("\nAlmost correct");
            }
            #endregion

            
        }
    }
}