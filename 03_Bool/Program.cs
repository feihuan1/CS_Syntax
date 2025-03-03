using System.Text;
using System.Threading.Tasks;

namespace Bool
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool isMale = true;
            isMale = false;
            System.Console.WriteLine(isMale);

            // convert bool to str
            bool value = true;
            string textValue = value.ToString();
            System.Console.WriteLine(value);
            System.Console.WriteLine(textValue.GetType() == typeof(string));

            // convert str to bool
            string text = "TRUE"; // case in-sensitive
            bool boolText = bool.Parse(text);
            bool boolText2 = Convert.ToBoolean(text);
            System.Console.WriteLine(boolText);
            System.Console.WriteLine(boolText2);
        }
    }
}