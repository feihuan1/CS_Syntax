using System.Text;
using System;
using System.Threading;


namespace StringCompair
{
    class Program
    {
        static void Main(string[] args)
        {
            //````````````````empty
            // initial empty string
            // string name = "";
            // string name2 = string.Empty;

            // System.Console.Write("Enter your name: ");
            // string name = Console.ReadLine()?? "";

            // if(name != string.Empty)// better look than "", bug if typo space " "!
            // {
            //     System.Console.WriteLine($"your name is {name}");
            // }
            // else
            // {
            //     System.Console.WriteLine("Name is Empty");
            // }

            //``````````````````Equals *** == compair value in memory reference, Equals compair value only 

            string message = "hello";
            string message2 = "hello";
            if (message == message2)
            {
                System.Console.WriteLine("same");
            }
            else
            {
                System.Console.WriteLine("diff");
            }

            if (message.Equals(message2))// less bug and beeter look
            {
                System.Console.WriteLine("same in fancy way");
            }
            else
            {
                System.Console.WriteLine("diff in fancy way");
            }

            //`````````````````````` looping
            string message3 = "C# is confusing";// this is a arry of char-> inmmutacle-> concat make a new string
            System.Console.WriteLine("char is " + message3[0]); // type char
            // System.Console.WriteLine("char is " + message3[100]); // IndexOutOfRangeException

            for (int i = 0; i < message3.Length; i++)
            {
                // System.Console.Write(message3[i]);
                // Thread.Sleep(500); // have to state using System.Threading
                System.Threading.Thread.Sleep(10); //dont have to state using System.Threading
            }
            System.Console.WriteLine();
            //`````````````Contains
            System.Console.WriteLine(message3.Contains("C# "));

            //`````````````````IsNullOrEmpty  !!! "" != null
            System.Console.WriteLine("".Equals(null)); //false
            // if user enter nother, it will return null, not ""
            System.Console.WriteLine("enter your name: ");
            string name = Console.ReadLine() ?? "";

            if(!name.Equals("")) // false if user click enter
            {
                System.Console.WriteLine("empty");
            }
            if(!name.Equals(null)) // true if user click enter
            {
                System.Console.WriteLine("empty");
            }

            if(string.IsNullOrEmpty(name))
            {
                System.Console.WriteLine("null or empty");
            }

            if(string.IsNullOrWhiteSpace(name))
            {
                System.Console.WriteLine("null or space");
            }

            // best practise
            if(!string.IsNullOrEmpty(name))
            {
                if(name.Equals("Eric"))
                {
                    System.Console.WriteLine("we got the same name");
                }
            }

        }
    }
}