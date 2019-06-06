using System;
using System.Globalization;

namespace Strings_Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            double result = FormatNumber(54.23D);

            Console.WriteLine(" The percentage is : {0}.", result.ToString("P", CultureInfo.InvariantCulture));
        }

        //Write a method that formats a number with a percentage

        public static double FormatNumber(double num)
        {
            double percentage = num / 100;

            return percentage;
        }

    }
}
