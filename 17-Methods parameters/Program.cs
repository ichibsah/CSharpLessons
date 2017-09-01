using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Methods_parameters
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            
            /*passing by reference*/
            SimpleMethod(ref i);
            Console.WriteLine(i);

            /*method parameters - return multiple values*/
            int Total = 0;
            int Product = 0;
            Calculate(10, 20, out Total, out Product);

            Console.WriteLine("Sum = {0} & Product = {1}", Total, Product);

            /*parameters array*/
            int[] Numbers = new int[3];

            ParamsMethod();
            ParamsMethod(Numbers);
            ParamsMethod(1,2,3,4,5);
        }

        /*passing by reference*/
        public static void SimpleMethod (ref int j)
        {
            j = 101;
        }

        /*method parameters - return multiple values*/
        public static void Calculate(int FN, int SN, out int Sum, out int Product)
        {
            Sum = FN + SN;
            Product = FN * SN;
        }
        /*optional parameter must always the last one and the only one allowed*/
        public static void ParamsMethod(params int[] Numbers)
        {
            Console.WriteLine("there are {0} elements", Numbers.Length);
        }
    }
}
