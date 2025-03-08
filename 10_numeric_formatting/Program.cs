using System.Text;
using System.Threading.Tasks;

// display diferent currency, give diferenct curreny by input country code
using System.Globalization;

namespace NumericFormatting
{
    class Program
    {
        static void Main(string[] args)
        {
            double value = 1000D / 12.34D;

            Console.WriteLine(value);//81.03727714748784 very ugly result

            // pass string paterm and value!! 0 is first value and 1 is second 1000;
            // 0 is first value, bihand : is format, only 2 decimal displayed
            // this wont effect the actual value of the variable, it is just display for user round up number
            System.Console.WriteLine(string.Format("{0} {1}", value, 1000)); // 81.03727714748784 1000
            System.Console.WriteLine(string.Format("{0:0}", value)); //81 -> round, Math.round()
            System.Console.WriteLine(string.Format("{0:0.0}", value)); //81.0 -> round, Math.round()
            System.Console.WriteLine(string.Format("{0:0.#}", value)); //# trim off trailing 0s
            System.Console.WriteLine(string.Format("{0:0.00}", value)); //81.04 -> round, Math.round()

            double money = 10D / 3D;// int dived int will auto truncate
            System.Console.WriteLine(string.Format("   ${0:0.0#}", money));// can add space or other char or symbol, imagin it's a string literal
            double money2 = -10D / 3D;
            System.Console.WriteLine(string.Format("-$10 - $3 = ${0:0.0#}", money2));// - will be after $ solution below
            System.Console.WriteLine(money2.ToString("C")); // C is currency/ currency depends on timezon location in OS!!! default is c2
            System.Console.WriteLine(money2.ToString("C0"));//($3) currency with no decimal , same logic below
            System.Console.WriteLine(money2.ToString("C1"));//($3.3)
            System.Console.WriteLine(money2.ToString("C2"));//($3.33)
            // -----------------display ($3.3) because in many country, negative mony is displayed in ()

            // display curernt culture money format
            System.Console.WriteLine(money2.ToString("c", CultureInfo.CurrentCulture));

            System.Console.WriteLine(money2.ToString("c", CultureInfo.CreateSpecificCulture("en-GB")));//-£3.33 this is UK culture, no () with negative money
            System.Console.WriteLine(money2.ToString("c", CultureInfo.CreateSpecificCulture("en-US")));//($3.33)
            System.Console.WriteLine(money2.ToString("c", CultureInfo.CreateSpecificCulture("zh-CN")));//-¥3.33
            System.Console.WriteLine(money2.ToString("c", CultureInfo.CreateSpecificCulture("en-AU")));//-$3.33  australia


        }
    }
}