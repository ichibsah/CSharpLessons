using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*while loop*/
            Console.WriteLine("please enter your target");
            int userTagert = int.Parse(Console.ReadLine());

            int start = 0;

            while (start <= userTagert)
            {
                Console.WriteLine(start);
                start = start + 2;
            }
            /* do while loop*/
            Console.WriteLine("please enter your target");
            userTagert = int.Parse(Console.ReadLine());

            start = 0;

            /*infinite loop*/
            while (start <= userTagert)
            {
                Console.WriteLine(start);
            }
        }

    }
}
