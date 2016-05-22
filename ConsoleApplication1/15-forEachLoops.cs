using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class forEachLoops
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3];

            numbers[0] = 101;
            numbers[1] = 102;
            numbers[2] = 103;

            foreach (int k in numbers)
            {
                Console.WriteLine(numbers[k]);
            }

            for (int j = 0; j < numbers.Length; j++)
            {
                if (j % 2 == 1)
                    continue;
                /*use break in place of continue*/
                //break;
                Console.WriteLine(numbers[j]);
            }

            int i = 0;
            while (i < numbers.Length)
            {
                Console.WriteLine(numbers[i]);
                i++;
            }
        }
    }
}
