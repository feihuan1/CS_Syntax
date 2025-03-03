using System;


namespace String_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            //"" is must!!!, '' is for Char
            string name = "Eric"; // can be empty
            char letter = 'a';  // can not be empty
            // console write dont make a new line
            System.Console.Write("My name is ");
            System.Console.Write(name);// my name is Eric
            // add a gap to next line
            System.Console.WriteLine();
            System.Console.WriteLine(name);// Eric
            System.Console.WriteLine(letter);// a

            // convert a string to int
            string textAge = "23";
            int age = Convert.ToInt32(textAge);
            System.Console.WriteLine(age); //(int) 23
            System.Console.WriteLine(age.GetType()); // System.Int32
            System.Console.WriteLine(age.GetType() == typeof(int)); //true typeof(int)return a type object for int

            //// convert a string to long
            string textBigNumber = "-9000000000000";
            long bigNumber = Convert.ToInt64(textBigNumber);
            System.Console.WriteLine(bigNumber);//-9000000000000

            //conver str to double
            string textNegativeNumber = "-55.2";
            double negativeNumber = Convert.ToDouble(textNegativeNumber);
            System.Console.WriteLine(negativeNumber);//-55.2

            
            //conver str to float, it is ToSingle not float
            // use float.tryParse to be safe
            string textPrecision = "5.000001";
            double precision = Convert.ToSingle(textPrecision);
            System.Console.WriteLine(precision);//5.000001


        }
    }
}