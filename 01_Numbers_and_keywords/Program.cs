using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // declear multiple
            int x,y,z;
            int a = 1, b = 2, c = 3;// or put in new line

            // iterger
            int age = 23; // initialization
            age = 24;// assign a value 
            Console.WriteLine(age);//23    
            Console.WriteLine(int.MaxValue);//2147483647
            Console.WriteLine(int.MinValue);//-2147483648

            // int16 short
            short smallNum = 32; // initialization
            Console.WriteLine(smallNum);//32  
            Console.WriteLine(short.MaxValue);//32767
            Console.WriteLine(short.MinValue);//-32768

            // int 64 , long number
            long bignumber = 9000000L;
            Console.WriteLine(bignumber);//9000000
            Console.WriteLine(long.MaxValue);//9223372036854775807
            Console.WriteLine(long.MinValue);//-9223372036854775808

            // need f : 6-7 digit
            float precision = 5.000001f;
            Console.WriteLine(precision);//5.000001
            Console.WriteLine(float.MaxValue);//3.4028235E+38
            Console.WriteLine(float.MinValue);//-3.4028235E+38

            //default decimal type, dont need D: ~15-16 digits
            double negative = -55.2D;
            Console.WriteLine(negative);//-55.2
            Console.WriteLine(double.MaxValue);//1.7976931348623157E+308
            Console.WriteLine(double.MinValue);//-1.7976931348623157E+308

            // need capital M,(for money) : 28-29 digits
            decimal money = 14.99M;
            Console.WriteLine(money);//14.9911
            Console.WriteLine(decimal.MaxValue);//79228162514264337593543950335
            Console.WriteLine(decimal.MinValue);//-79228162514264337593543950335

//++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            // var keyword
            var age3 = 3; // implicit type
            var age4 = 9000000L; // this makes it implicit a Long
            var age5 = 1.1; // double
            var age6 = 1.1f; // float
            var age7 = 1.1M; // decimal
            var age8 = (short)3; // still int32!!!!!!!!!!!!!!!!!!!!!!!!!!
            var name = "eric"; // string
            var letter = 'a'; // char
            // var age4; error, complier wont know the type if didnt assign at initialization
            System.Console.WriteLine(age3.GetType());//System.Int32

            //const key word
            const int vat = 10;
            const double percentVat = vat / 100D;

            int balance = 1000;
            System.Console.WriteLine(balance * (vat / 90D)); // 100D will keep the decimal
            System.Console.WriteLine(balance * percentVat); // better practise, change one place can change entire app like updating version number 
            // vat = 1; error, cant change 
        }
    }
}