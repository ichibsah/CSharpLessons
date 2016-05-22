using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Program.EvenNumbers(30);

            Program P = new Program();
            int Sum = P.Add(10, 20);

            Console.WriteLine("sum = {0}", Sum);
        }

        public int Add(int FN, int SN)
        {
            return FN + SN;
        }

        public static void EvenNumbers(int Target)
        {
            int Start = 0;

            while (Start <= Target)
            {
                Console.WriteLine(Start);
                Start = Start + 2;
            }
        }
    }
}
