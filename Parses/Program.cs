using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parses
{
    class Program
    {
        static void Main(string[] args)
        {
            // Convert string to number.
            string text = "500";
            int num = int.Parse(text);
            Console.WriteLine(num);

            string input = "carrot";
            // ... This will throw an exception.
            int carrots = int.Parse(input);
            Console.WriteLine(carrots);

            // See if we can parse the 'text' string.
            // If we can't, TryParse will return false.
            // Note the "out" keyword in TryParse.
            string text1 = "x";
            int num1;
            bool res = int.TryParse(text1, out num1);
            if (res == false)
            {
                // String is not a number.
            }

            // Use int.TryParse on a valid numeric string.
            string text2 = "10000";
            int num2;
            if (int.TryParse(text2, out num2))
            {
                // It was assigned.
            }

            // Display both results.
            Console.WriteLine(num1);
            Console.WriteLine(num2);

            string error = "Welcome";
            // This will leave the result variable with a value of 0.
            int result;
            int.TryParse(error, out result);
            Console.WriteLine(result);
        }
    }
}
