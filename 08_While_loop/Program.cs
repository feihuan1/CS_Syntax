using System.Text;
using System.Threading.Tasks;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            #region basic

            // int i = 0;

            // while (i < 10)
            // {
            //     System.Console.WriteLine(i);
            //     i++;
            // }
            #endregion

            #region while    
            // System.Console.Write("whats 2 X 2: ");
            // string answer = "4";
            // string userInput = Console.ReadLine()?? "";
            // while(userInput != answer)
            // {
            //     System.Console.Write("\nAlmost correct, guess again: ");
            //     userInput = Console.ReadLine()?? "";
            // }
            // System.Console.WriteLine("\nyou are almost a genius");
            #endregion

            #region do while
            string answer;
            do
            {
                System.Console.Write("whats 2 x 2: ");
                answer = Console.ReadLine() ?? "";

                if(answer != "4")
                {
                    System.Console.WriteLine("Almost correct, guess again!\n");
                }

            } while (answer != "4");
            System.Console.WriteLine("\n Can't belive you got this right");
            #endregion
        }
    }
}