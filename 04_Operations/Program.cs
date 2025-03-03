using System.Text;
using System.Threading.Tasks;

namespace Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 23;
            // + - * /
            // add 1
            age++;
            age = age + 1;
            age += 1;
            System.Console.WriteLine(age);// 26
            // minus 1
            age--;
            age = age - 1;
            age -= 1;
            System.Console.WriteLine(age);//23
            age = age * 2;
            age *= 2;
            // no ** or // avaliable in c#
            System.Console.WriteLine(age); // 92

            // inteerger division
            int age2 = 23;
            age2 /= 10;
            System.Console.WriteLine(age2);// 2.3 -> 2, truncate the decimal

            double age3 = 23;
            age3 /= 10;
            System.Console.WriteLine(age3); // 2.3 , use double or float or decimal to do division
            float age4 = 23;
            age4 /= 10;
            System.Console.WriteLine(age4); // 2.3 , use double or float or decimal to do division
            decimal age5 = 23;
            age5 /= 10;
            System.Console.WriteLine(age5); // 2.3 , use double or float or decimal to do division

            // ++
            int i = 0;
            Console.WriteLine(i++);// 0 :++ not excute when print
            Console.WriteLine(i);// 1 : i updated
            Console.WriteLine(++i);// 2!!! :++ excuted before print, i++ above excuted too just didnt print 


            // add on string 
            string name = "Eric";
            name += " programing";
            System.Console.WriteLine(name); // eric programing

            // add char -> add unit code
            char a = 'a';
            a+= 'b';
            System.Console.WriteLine(a);// line above a uni-code a + unicode b


            // remainder / modules %
            int first = 10;
            int second = 3;
            int result = first % second;
            System.Console.WriteLine(result); // 1

        }
    }
}