using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _031_explicit_interface_implementation
{
    interface I1
    {
        void IMethod();
    }

    interface I2
    {
        void IMethod();
    }
    class Program : I1, I2
    {
        static void Main(string[] args)
        {
            Program P = new Program();
            /*use interface reference variable to invoke them (type cast)*/
            ((I1)P).IMethod();
            ((I2)P).IMethod();
            /*or*/
            I1 i1 = new Program();
            I2 i2 = new Program();
        }

        /*explicit interface implementation*/
        void I2.IMethod()
        {
            Console.WriteLine("I2");

        }
        /*default implementation -> void IMethod()*/
        void I1.IMethod()
        {
            Console.WriteLine("I1");
    
        }
    }
}
