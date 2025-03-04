using System.Text;
using System.Threading.Tasks;

namespace SwitchStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Enter the day of the week: ");
            string dayinput = Console.ReadLine()?? "1";
            int day = Convert.ToInt32(dayinput);

            switch(day)
            {
                case 1: System.Console.WriteLine("Monday!");// same line is fine
                    break;
                case 2:// this is like 2 or 3
                case 3:
                    System.Console.WriteLine("Tuesday or Wendsday!");
                    break;
                case 4:
                    System.Console.WriteLine("Thursday!");
                    break;
                case 5:
                    System.Console.WriteLine("Friday!");
                    break;
                case 6:
                    System.Console.WriteLine("Saturday!");
                    break;
                case 7:
                    System.Console.WriteLine("Sunday!");
                    break;
                default:
                    System.Console.WriteLine("Invalid day!!!");
                    break;
            }
        }
    }
}