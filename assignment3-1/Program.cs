using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

               string input;

                // Using TryParse for integer conversion
                Console.Write("Enter an integer: ");
                input = Console.ReadLine();
                if (int.TryParse(input, out int intResult))
                {
                    Console.WriteLine("TryParse - Integer Conversion Successful. Result: " + intResult);
                }
                else
                {
                    Console.WriteLine("TryParse - Integer Conversion Failed. Invalid input.");
                }

                // Using Convert for double conversion
                Console.Write("Enter a double: ");
                input = Console.ReadLine();
                try
                {
                    double doubleResult = Convert.ToDouble(input);
                    Console.WriteLine("Convert - Double Conversion Successful. Result: " + doubleResult);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Convert - Double Conversion Failed. Format error.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Convert - Double Conversion Failed. Overflow error.");
                }

                // Using Parse for decimal conversion
                Console.Write("Enter a decimal: ");
                input = Console.ReadLine();
                try
                {
                    decimal decimalResult = decimal.Parse(input);
                    Console.WriteLine("Parse - Decimal Conversion Successful. Result: " + decimalResult);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Parse - Decimal Conversion Failed. Format error.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Parse - Decimal Conversion Failed. Overflow error.");
                }
            
        }
    }
}
