using System.Text;
using System;
using System.Threading;


namespace StringMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 15;
            string name = "Eric";

            string a = "hello";
            string b = "world";

            string[] arr = new string[] { "a", "b", "c" };

            //-------------------------------String basics
            a = "hello";
            // string.Concat(); Combines multiple strings
            string A = string.Concat(a, " ", b);
            System.Console.WriteLine(A);//hello world

            //string.Join() Joins array elements with a separator
            string B = string.Join(", ", arr);
            System.Console.WriteLine(B);//"a, b, c"

            //.Split() Splits into an array based on a separator // " wont work, need seperator
            a = "h,e,l,l,o";
            string[] B1 = a.Split(",");// h
            System.Console.WriteLine(B1[0]);

            // ToCharArray() can split without seperator
            a = "hello";
            char[] B2 = a.ToCharArray();//[h,e,l,l,o]
            System.Console.WriteLine(B2);


            //string.Format() Formats strings with placeholders
            a = "hello";
            string C = string.Format("first: {0}, age: {1}", a, age);// can be number
            System.Console.WriteLine(C);

            //$"{}" (Interpolation) Inserts variables into strings
            string D = $"My Name is {name}";
            System.Console.WriteLine(D);

            //```````````````````````````````Checking string Content
            //string.IsNullOrEmpty() Checks if a string is null or empty
            bool E1 = string.IsNullOrEmpty(null); // true
            bool E2 = string.IsNullOrEmpty(""); // true
            bool E3 = string.IsNullOrEmpty("asd"); // false
            bool E8 = string.IsNullOrEmpty(" "); // false
            System.Console.WriteLine(E1);
            System.Console.WriteLine(E2);
            System.Console.WriteLine(E3);
            System.Console.WriteLine(E8);

            // string.IsNullOrWhiteSpace() Checks if a string is null, empty, or whitespace
            bool E4 = string.IsNullOrWhiteSpace(null); // true
            bool E5 = string.IsNullOrWhiteSpace(""); // true => return true for empty as well
            bool E6 = string.IsNullOrWhiteSpace("asd"); // false
            bool E7 = string.IsNullOrWhiteSpace(" "); // true
            System.Console.WriteLine(E4);
            System.Console.WriteLine(E5);
            System.Console.WriteLine(E6);
            System.Console.WriteLine(E7);

            // .Contains() Checks if a string contains a substring
            a = "hello";
            bool F = a.Contains("ll");// true
            System.Console.WriteLine(F);

            // .StartWith(); Checks if string starts with a value
            bool G = a.StartsWith("HE"); // false -> case sensitive
            System.Console.WriteLine(G);

            //.EndsWith() Checks if string ends with a value
            bool H = a.EndsWith("lo"); // true
            System.Console.WriteLine(H);

            // .IndexOf() find first index of substring
            a = "hello";
            int I1 = a.IndexOf("l"); // 2
            int I2 = a.IndexOf("lo"); // 3
            int I3 = a.IndexOf("asd"); // -1 -> nothing found
            System.Console.WriteLine(I1);
            System.Console.WriteLine(I2);
            System.Console.WriteLine(I3);

            //.LastIndexOf() Finds the last index of a substring
            int J = a.LastIndexOf("l"); //3
            System.Console.WriteLine(J);

            // .Equals() Compares two strings
            a = "hello";
            bool K1 = a.Equals("hello"); // true
            bool K2 = a.Equals("HELLO"); // false
            bool K3 = a.Equals("HELLO", StringComparison.OrdinalIgnoreCase); // true -> bounch of option in StringComparison class, check it out 
            System.Console.WriteLine(K1);
            System.Console.WriteLine(K2);
            System.Console.WriteLine(K3);


            //````````````````````String Modification( return new string)
            //.ToUpper() .ToLower() Converts to uppercase or lowercase
            a = "hello";
            string L1 = a.ToUpper();// HELLO
            string L2 = L1.ToLower();// hello
            System.Console.WriteLine(L1);
            System.Console.WriteLine(L2);

            // .Trim() .TrimStart() .TrimEnd() trim the string
            a = "  hello  ";
            string M1 = a.Trim();//"hello"
            string M2 = a.TrimStart();//"hello  "
            string M3 = a.TrimEnd();//"  hello"

            System.Console.WriteLine(M1);
            System.Console.WriteLine(M2);
            System.Console.WriteLine(M3);

            //.Replace() Replaces a substring for ***all*** match 
            a = "hello";
            string N1 = a.Replace("l", "y"); // heyyo
            string N2 = a.Replace("l", "ye"); //heyeyeo
            System.Console.WriteLine(N1);
            System.Console.WriteLine(N2);

            //.Remove()Removes characters from a position
            a = "hello";
            string O1 = a.Remove(1, 2);// hlo
                                       // string O2 = a.Remove(4,2); //ERROR: ArgumentOutOfRangeException
            System.Console.WriteLine(O1);

            // .Insert() Inserts a string at a position
            string P1 = a.Insert(0, "sad");// asdhello
            string P2 = a.Insert(4, "sad");// hellsado
            string P3 = a.Insert(5, "sad");// hellosad -> only can out of range by one
                                           // string P2 = a.Insert(6, "sad");// ArgumentOutOfRangeException
            System.Console.WriteLine(P1);
            System.Console.WriteLine(P2);
            System.Console.WriteLine(P3);

            //.PadLeft() .PadRight() Adds spaces to left or right
            a = "hello";
            //********pad with char not string
            string Q1 = a.PadLeft(8, 'X');//XXXhello
            string Q2 = a.PadRight(8, 'X');//helloXXX
            System.Console.WriteLine(Q1);
            System.Console.WriteLine(Q2);

        }
    }
}